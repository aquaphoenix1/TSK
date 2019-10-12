namespace TSK.NeuralNetwork.FifthLayer
{
    class FifthLayerNeuron
    {
        public double Calculate(double input, double weightSum)
        {
            return input / weightSum;
        }
    }
}
