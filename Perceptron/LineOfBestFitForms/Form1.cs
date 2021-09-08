using PerceptronLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LineOfBestFitForms
{
    public partial class Form1 : Form
    {
        List<PointF> points = new List<PointF>();
        Random random = new Random();
        Normalizer inputNormalizer = new Normalizer(0,0,0,0);
        Normalizer outputNormalizer = new Normalizer(0, 0, 0, 0);
        Perceptron perceptron;
        double[][] inputs;
        double[] desiredOutputs;
        double[][] normalizedInputs = new double[0][];
        double[] normalizedOutputs = new double[0];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            perceptron = new Perceptron(0, ErrorTypes.MeanAbsoluteError);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(XTextBox.Text, out float x) && float.TryParse(YTextBox.Text, out float y))
            {
                points.Add(new PointF(x, y));
                XTextBox.Clear();
                YTextBox.Clear();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            points.Clear();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            //If hill climber selected
            if (points.Count > 0)
            {
                perceptron = new HillClimberPerceptron(1, random, .1, ErrorTypes.MeanSquaredError);
                inputs = new double[points.Count][];
                desiredOutputs = new double[points.Count];
                double inputMax = points[0].X; 
                double inputMin = points[0].X; 
                double outputMax = points[0].Y; 
                double outputMin = points[0].Y;
                for (int i = 0; i < points.Count; i++)
                {
                    inputs[i] = new double[] { points[i].X };
                    desiredOutputs[i] = points[i].Y;

                    if (points[i].X < inputMin)
                    {
                        inputMin = points[i].X;
                    }
                    if (points[i].X > inputMax)
                    {
                        inputMax = points[i].X;
                    }
                    if (points[i].Y < outputMin)
                    {
                        outputMin = points[i].Y;
                    }
                    if (points[i].Y > outputMax)
                    {
                        outputMax = points[i].Y;
                    }
                }
                perceptron.Randomize(random, -1, 1);
                inputNormalizer = new Normalizer(inputMin, inputMax, 0,1);
                outputNormalizer = new Normalizer(outputMin, outputMax, 0, 1);

                normalizedInputs = new double[inputs.Length][];
                for (int i = 0; i < inputs.Length; i++)
                {
                    normalizedInputs[i] = inputNormalizer.Normalize(inputs[i]);
                }
                normalizedOutputs = outputNormalizer.Normalize(desiredOutputs);
            }
            
        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TrainTextBox.Text, out int result) && inputs != null)
            {

                //perceptron.TrainingIteration(normalizedInputs, normalizedOutputs, result);
                perceptron.TrainingIteration(inputs, desiredOutputs, result);

                EquationLabel.Text = $"Equation: y={perceptron.weights[0]}x + {perceptron.bias}";
            }
        }
    }
}
