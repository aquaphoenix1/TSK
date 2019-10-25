using System;
using System.Collections.Generic;
using System.Linq;

namespace TSK.NeuralNetwork.SecondLayer
{
    class SecondLayer
    {
        private SecondLayerNeuron[] neurons;
        private int M;

        public SecondLayer(int M)
        {
            this.M = M;

            neurons = new SecondLayerNeuron[M];

            int k = 0;
            while (k < M)
            {
                neurons[k++] = new SecondLayerNeuron();
            }
        }

        internal List<double> Calculate(List<List<double>> firstLayerResult)
        {
            return firstLayerResult.Select(o => o.Aggregate((t, p) => t *= p)).ToList();
        }
    }
}
