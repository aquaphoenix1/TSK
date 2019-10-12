using System;
using System.Collections.Generic;

namespace TSK.NeuralNetwork.ThirdLayer
{
    class ThirdLayer
    {
        private int M;

        public ThirdLayer(int M, int N)
        {
            this.M = M;

            Neurons = new ThirdLayerNeuron[M];

            for (int i = 0; i < M; i++)
            {
                Neurons[i] = new ThirdLayerNeuron(N);
            }
        }

        internal ThirdLayerNeuron[] Neurons { get; set; }

        public List<double> Calculate(List<double> x, List<double> secondLayerResult)
        {
            List<double> result = new List<double>();

            for (int i = 0; i < M; i++)
            {
                result.Add(Neurons[i].Calculate(secondLayerResult[i], x));
            }

            return result;
        }

        public void SetNewP(List<List<double>> newP)
        {
            for (int i = 0; i < M; i++)
            {
                Neurons[i].SetP(newP[i++]);
            }
        }
    }
}
