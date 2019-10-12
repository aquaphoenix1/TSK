using System.Collections.Generic;
using System.Linq;

namespace TSK.NeuralNetwork.FourthLayer
{
    class FourthLayerNeuron
    {
        public double Calculate(List<double> input)
        {
            return input.Sum();
        }
    }
}
