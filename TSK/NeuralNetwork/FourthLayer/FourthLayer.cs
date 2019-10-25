using System.Collections.Generic;
using System.Linq;

namespace TSK.NeuralNetwork.FourthLayer
{
    class FourthLayer
    {
        private FourthLayerNeuron[] neurons;

        public FourthLayer()
        {
            int count = 1;

            neurons = new FourthLayerNeuron[count];

            for(int i = 0; i < count; i++)
            {
                neurons[i] = new FourthLayerNeuron();
            }
        }

        public List<double> Calculate(List<double> secondLayerResults, List<double> thirdLayerResults)
        {
            
            List<double> result = new List<double>();

            for(int i = 0; i < neurons.Length; i++)
            {
                result.Add(neurons[i].Calculate(thirdLayerResults));
            }

            result.Add(secondLayerResults.Sum());

            return result;
        }
    }
}
