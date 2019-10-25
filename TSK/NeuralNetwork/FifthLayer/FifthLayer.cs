using System.Collections.Generic;

namespace TSK.NeuralNetwork.FifthLayer
{
    class FifthLayer
    {
        private FifthLayerNeuron[] neurons;

        public FifthLayer()
        {
            int count = 1;

            neurons = new FifthLayerNeuron[count];

            for (int i = 0; i < count; i++)
            {
                neurons[i] = new FifthLayerNeuron();
            }
        }

        public double Calculate(List<double> fourthLayerResult)
        {
            return fourthLayerResult[0] / fourthLayerResult[1];
        }
    }
}
