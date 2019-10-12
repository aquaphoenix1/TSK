using System.Collections.Generic;

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

      
        //public List<double> Calculate(List<List<double>> list, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        //{
        //    List<double> result = new List<double>();

        //    for (int i = 0; i < M; i++)
        //    {
        //        //List<double> l = new List<double>();

        //        //for (int j = 0; j < list.Count; j++)
        //        //{
        //        //    l.Add(list[j][i]);
        //        //}

        //        result.Add(neurons[i].Calculate(l, cList[i], sigmaList[i], bList[i]));
        //    }

        //    return result;
        //}
    }
}
