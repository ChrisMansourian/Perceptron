using System;
using System.Collections.Generic;
using System.Text;

namespace PerceptronLibrary
{
    public class Normalizer
    {
        public double UnNormalizedMin { get; private set; }

        public double UnNormalizedMax { get; private set; }

        public double NormalizedMax { get; private set; }

        public double NormalizedMin { get; private set; }

        public Normalizer(double UnNormalizedMin, double UnNormalizedMax, double NormalizedMax, double NormalizedMin)
        {
            this.UnNormalizedMax = UnNormalizedMax;
            this.UnNormalizedMin = UnNormalizedMin;
            this.NormalizedMax = NormalizedMax;
            this.NormalizedMin = NormalizedMin;
        }

        public double[] Normalize(double[] dataToNormalize)
        {
            double[] normalizedData = new double[dataToNormalize.Length];

            for (int i = 0; i < dataToNormalize.Length; i++)
            {
                normalizedData[i] = Normalize(dataToNormalize[i]);
            }
            return normalizedData;
        }

        public double Normalize(double dataToNormalize)
        {

            return ((dataToNormalize - UnNormalizedMin) / (UnNormalizedMax - UnNormalizedMin)) * (NormalizedMax - NormalizedMin) + NormalizedMin;

        }



        public double[] UnNormalize(double[] dataToUnNormalize)
        {
            double[] unNormalizedData = new double[dataToUnNormalize.Length];

            for (int i = 0; i < dataToUnNormalize.Length; i++)
            {
                unNormalizedData[i] = UnNormalize(dataToUnNormalize[i]);
            }
            return unNormalizedData;

        }

        public double UnNormalize(double dataToUnNormalize)
        {
            return ((dataToUnNormalize - NormalizedMin) / (NormalizedMax - NormalizedMin)) * (UnNormalizedMax - UnNormalizedMin) + UnNormalizedMin;

        }

    }
}
