using System;
using System.Collections.Generic;

namespace TSK.NeuralNetwork.SecondLayer
{
    class SecondLayerNeuron
    {
        public double Calculate(List<double> x, List<double> cList, List<double> sigmaList, List<double> bList)
        {
            double result = 1;

            for (int i = 0; i < x.Count; i++)
            {
                double a = (x[i] - cList[i]);
                double b = a / sigmaList[i];
                double c = 2 * bList[i];
                double d = Math.Pow(b, c);
                double e = 1 + d;
                double k = 1 / e;
                result *= k;
            }

            return result;
        }
    }
}
