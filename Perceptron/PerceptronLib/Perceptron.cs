using System;
using System.Collections.Generic;
using System.Text;

namespace PerceptronLibrary
{
    public class Perceptron
    {
        public double[] weights { get; protected set; }
        public double bias { get; protected set; }
        Func<double, double, double> errorFunc;

        public Perceptron(double[] initialWeights, double initialBias, Func<double, double, double> errorFunc)
        {
            this.weights = initialWeights;
            this.bias = initialBias;
            this.errorFunc = errorFunc;
        }

        public Perceptron(int amountOfValues, Func<double, double, double> errorFunc)
        {
            this.weights = new double[amountOfValues];
            this.errorFunc = errorFunc;
        }

        public void Randomize(Random random, double min, double max)
        {
            bias = GenRandomDouble(random, min, max);
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = GenRandomDouble(random, min, max);
            }
        }

        public double GenRandomDouble(Random random, double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }

        public double Compute(double[] inputs)
        {
            double output = bias;
            for (int i = 0; i < inputs.Length; i++)
            {
                output += inputs[i] * weights[i];
            }
            return output;
        }

        public double[] Compute(double[][] inputs)
        {
            double[] outputs = new double[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                outputs[i] = Compute(inputs[i]);
            }
            return outputs;
        }

        public double GetError(double[][] inputs, double[] desiredOutput)
        {
            double error = 0;

            for (int i = 0; i < desiredOutput.Length; i++)
            {
                error += errorFunc(Compute(inputs[i]), desiredOutput[i]);
            }
            error /= desiredOutput.Length;

            return error;
        }

        public virtual double TrainingIteration(double[][] inputs, double[] desiredOutputs, int iterationCount)
        {
            return GetError(inputs, desiredOutputs);
        }
    }
}
