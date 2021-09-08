using PerceptronLibrary;
using System;

namespace Perceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            HillClimberPerceptron perceptron = new HillClimberPerceptron(2, random, .1, ErrorTypes.MeanSquaredError);
            Console.WriteLine("How many Points would you like to add?");
            int amount;
            while( !int.TryParse(Console.ReadLine(), out amount) || amount < 0)
            {

            }

            double[][] inputs = new double[amount][];
            double[] expectedOutput = new double[amount];

            for (int i = 0; i < amount; i++)
            {
                inputs[i] = new double[2];
                Console.WriteLine("Enter the x-coordinate");
                while(!double.TryParse(Console.ReadLine(), out inputs[i][0]))
                {
                    Console.WriteLine("Enter the x-coordinate");
                }
                Console.WriteLine("Enter the y-coordinate");
                while (!double.TryParse(Console.ReadLine(), out inputs[i][1]))
                {
                    Console.WriteLine("Enter the y-coordinate");
                }

                Console.WriteLine("Enter the expected group");
                while(!double.TryParse(Console.ReadLine(), out expectedOutput[i]))
                {
                    Console.WriteLine("Enter the expected group");
                }

            }

            Console.WriteLine("Enter the char s to stop training");
            while (true)
            {
                string s = Console.ReadLine();
                if(s.Length > 0 && s[0]=='s')
                {
                    break;
                }
                perceptron.TrainingIteration(inputs, expectedOutput, 1000000);
                Console.WriteLine($"weights: {perceptron.weights[0]}, {perceptron.weights[1]} bias: {perceptron.bias}");
            }


            bool repeat = true;
            while(repeat)
            {
                Console.WriteLine("Do you want to check a point for its group or exit? Type check or exit.");
                string result = Console.ReadLine();
                while(result.ToLower() != "exit" && result.ToLower() != "check")
                {
                    result = Console.ReadLine();
                }

                if(result == "check")
                {
                    double[] userInputs = new double[2];
                    Console.WriteLine("Enter the x-coordinate");
                    while (!double.TryParse(Console.ReadLine(), out userInputs[0]))
                    {
                        Console.WriteLine("Enter the x-coordinate");
                    }
                    Console.WriteLine("Enter the y-coordinate");
                    while (!double.TryParse(Console.ReadLine(), out userInputs[1]))
                    {
                        Console.WriteLine("Enter the y-coordinate");
                    }
                    double group = perceptron.Compute(userInputs);
                    if(group > perceptron.bias)
                    {
                        group = 1;
                    }
                    else
                    {
                        group = 0;
                    }
                    Console.WriteLine($"The group of that point is {group}");
                }
                else
                {
                    repeat = false;
                }
            }



            //double[] initialWeights = new double[] { .75, -1.25 };
            //double initialBias = .5;
            //Perceptron perceptron = new Perceptron(initialWeights, initialBias);

            //double[][] inputs = new double[][]
            //{
            //    new double[]{0,0},
            //    new double[]{0.3,-0.7},
            //    new double[]{1,1},
            //    new double[]{-1,-1},
            //    new double[]{-0.5,0.5}
            //};

            //var result = perceptron.Compute(inputs); 
            //;

            /*Console.WriteLine("Choose between AND, OR, or MULTI");
            string answer = "";
            while (answer != "and" && answer != "or" && answer != "multi")
            {
                answer = Console.ReadLine().ToLower();
            }

            (double[][] inputs, double[] outputs) result;

            if (answer == "and")
            {
                result = ANDGate();
            }
            else if (answer == "or")
            {
                result = ORGate();
            }
            else
            {
                result = MULTIGate();
            }

            Random random = new Random();
            HillClimberPerceptron perceptron = new HillClimberPerceptron(result.inputs.Length, random, .1, ErrorTypes.MeanSquaredError);

            perceptron.Randomize(random, .1, .1);
            double currentError = perceptron.GetError(result.inputs, result.outputs);

            while (currentError != 0)
            {
                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < result.inputs.Length; i++)
                {
                    Console.Write("Inputs: ");
                    for (int j = 0; j < result.inputs[i].Length; j++)
                    {
                        if (j != 0)
                        {
                            Console.Write(", ");
                        }
                        Console.Write(result.inputs[i][j]);
                    }

                    Console.Write(" Output Filtered: " + Math.Round(perceptron.Compute(result.inputs[i]), 0));
                    Console.WriteLine();
                }
                Console.WriteLine("Error: " + Math.Round(currentError, 3));
                currentError = perceptron.TrainingIteration(result.inputs, result.outputs, 100000);
            }

            Console.WriteLine("Hello World!");*/
        }

        static (double[][] inputs, double[] outputs) ANDGate()
        {
            double[][] inputs = new double[][] { new double[] { 0, 0 }, new double[] { 1, 0 }, new double[] { 0, 1 }, new double[] { 1, 1 } };
            double[] outputs = new double[] { 0, 0, 0, 1 };
            return (inputs, outputs);
        }

        static (double[][] inputs, double[] outputs) ORGate()
        {
            double[][] inputs = new double[][] { new double[] { 0, 0 }, new double[] { 1, 0 }, new double[] { 0, 1 }, new double[] { 1, 1 } };
            double[] outputs = new double[] { 0, 1, 1, 1 };
            return (inputs, outputs);
        }

        static (double[][] inputs, double[] outputs) MULTIGate()
        {
            double[][] inputs = new double[][] { new double[] { 0, 0, 0}, new double[] { 1, 0, 0 }, new double[] { 0, 1, 0}, new double[] { 1, 1, 0 },
                                                 new double[] { 0, 0, 1}, new double[] { 1, 0, 1 }, new double[] { 0, 1, 1}, new double[] { 1, 1, 1 }};
            double[] outputs = new double[] { 0, 1, 1, 1, 0, 0, 0, 1 };
            return (inputs, outputs);
        }

    }
}
