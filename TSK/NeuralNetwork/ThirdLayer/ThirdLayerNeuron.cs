using System;
using System.Collections.Generic;

namespace TSK.NeuralNetwork.ThirdLayer
{
    class ThirdLayerNeuron
    {
        internal List<double> linearWeights;
        private int N;
    
        private static Random random = new Random();

        public ThirdLayerNeuron(int N)
        {
            this.N = N;

            linearWeights = new List<double>();
            for(int i = 0; i < N + 1; i++)
            {
                linearWeights.Add(random.NextDouble());
            }
        }

        private double Multiply(List<double> x)
        {
            double result = linearWeights[0];

            for(int i = 1; i < N; i++)
            {
                result += linearWeights[i] * x[i - 1];
            }

            return result;
        }

        public double Calculate(double w, List<double> x)
        {
            return w * Multiply(x);
        }

        public void SetP(List<double> list)
        {
            linearWeights = list;
        }
    }
}