using System;
using System.Collections.Generic;
using System.Text;

namespace PerceptronLibrary
{
    public class HillClimberPerceptron : Perceptron
    {
        Random random;
        double mutationAmount;

        public HillClimberPerceptron(double[] initialWeights, double initialBias, Random random, double mutationAmount, Func<double, double, double> errorFunc)
            : base(initialWeights, initialBias, errorFunc)
        {
            this.random = random;
            this.mutationAmount = mutationAmount;
        }

        public HillClimberPerceptron(int amountOfValues, Random random, double mutationAmount, Func<double, double, double> errorFunc)
            : base(amountOfValues, errorFunc)
        {
            this.random = random;
            this.mutationAmount = mutationAmount;
        }

        public double Mutate(double[][] inputs, double[] desiredOutputs, double startingError)
        {

            double amount = GenRandomDouble(random, -mutationAmount, mutationAmount);
            if (random.Next(0, 2) == 0)
            {
                int index = random.Next(0, weights.Length);
                weights[index] += amount;
                double newError = GetError(inputs, desiredOutputs);
                if (newError < startingError)
                {
                    return newError;
                }
                weights[index] -= amount;
                return startingError;
            }
            else
            {
                bias += amount;
                double newError = GetError(inputs, desiredOutputs);
                if (newError < startingError)
                {
                    return newError;
                }
                bias -= amount;
                return startingError;
            }


        }

        public override double TrainingIteration(double[][] inputs, double[] desiredOutputs, int iterationCount)
        {
            double currentError = GetError(inputs, desiredOutputs);

            for (int i = 0; i < iterationCount; i++)
            {
                currentError = Mutate(inputs, desiredOutputs, currentError);
            }
            return currentError;
        }
    }
}
