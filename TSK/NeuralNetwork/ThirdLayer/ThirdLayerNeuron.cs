using System;
using System.Collections.Generic;

namespace TSK.NeuralNetwork.ThirdLayer
{
    class ThirdLayerNeuron
    {
        internal List<double> linearWeights;
        private int N;

        private static Random random = new Random();

        public ThirdLayerNeuron(int N, List<double> weights = null)
        {
            this.N = N;

            if (weights != null)
            {
                linearWeights = weights;
            }
            else
            {
                linearWeights = new List<double>();
                for (int i = 0; i < N + 1; i++)
                {
                    linearWeights.Add(random.NextDouble());
                }
            }
        }

        private double Multiply(List<double> x)
        {
            double result = linearWeights[0];

            for (int i = 0; i < N; i++)
            {
                result += linearWeights[i + 1] * x[i];
            }

            return result;
        }

        public double Calculate(double w, List<double> x)
        {
            var g = Multiply(x);
            return w * g;
        }

        public void SetP(List<double> list)
        {
            linearWeights = list;
        }
    }
}