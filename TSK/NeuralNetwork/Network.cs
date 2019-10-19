using Accord.Math;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TSK.NeuralNetwork
{
    class Network
    {
        private int N;
        private int M;

        private FirstLayer.FirstLayer firstLayer;
        private SecondLayer.SecondLayer secondLayer;
        private ThirdLayer.ThirdLayer thirdLayer;
        private FourthLayer.FourthLayer fourthLayer;
        private FifthLayer.FifthLayer fifthLayer;

        public Network(int N, int M)
        {
            this.N = N;
            this.M = M;

            firstLayer = new FirstLayer.FirstLayer(M, N);
            secondLayer = new SecondLayer.SecondLayer(M);
            thirdLayer = new ThirdLayer.ThirdLayer(M, N);
            fourthLayer = new FourthLayer.FourthLayer();
            fifthLayer = new FifthLayer.FifthLayer();
        }

        public double Output(List<double> list, out List<double> secondLayerResult)
        {
            List<double> firstLayerResult = firstLayer.Calculate(list);// new List<List<double>>();

            //for (int i = 0; i < list.Count; i++)
            //{
            //    firstLayerResult.Add(firstLayer.Calculate(list));
            //}

            //List<List<double>> cList = new List<List<double>>();
            //List<List<double>> sigmaList = new List<List<double>>();
            //List<List<double>> bList = new List<List<double>>();

            //for (int i = 0; i < firstLayer.Neurons.Length; i++)
            //{
            //    cList.Add(firstLayer.Neurons[i].C);
            //    sigmaList.Add(firstLayer.Neurons[i].Sigma);
            //    bList.Add(firstLayer.Neurons[i].B);
            //}

            //secondLayerResult = secondLayer.Calculate(firstLayerResult, cList, sigmaList, bList);

            secondLayerResult = firstLayerResult;

            List<double> thirdLayerResult = thirdLayer.Calculate(list, firstLayerResult);

            List<double> fourthLayerResult = fourthLayer.Calculate(firstLayerResult, thirdLayerResult);

            double fifthLayerResult = fifthLayer.Calculate(fourthLayerResult);

            return fifthLayerResult;
        }

        public void Learning(List<KeyValuePair<double, List<double>>> learningSet, double coefficient)
        {
            while (true)
            {
                double[,] A = new double[learningSet.Count, (N + 1) * M];

                for (int k = 0; k < learningSet.Count; k++)
                {
                    KeyValuePair<double, List<double>> pair = learningSet[k];
                    List<double> l = pair.Value;
                    List<double> secondLayerResult;
                    Output(l, out secondLayerResult);

                    int p = 0;
                    bool flag = true;

                    for (int j = 0; j < (N + 1) * M; j++)
                    {
                        if (flag)
                        {
                            A[k, j] = secondLayerResult[p];
                            flag = false;
                        }
                        else
                        {
                            for (int d = 0; d < l.Count; d++)
                            {
                                A[k, j] = secondLayerResult[p] * l[d];
                                j++;
                            }

                            j--;
                            p++;
                            flag = true;
                        }
                    }
                }

                A = A.PseudoInverse();

                double[] outputReal = new double[learningSet.Count];

                for (int j = 0; j < learningSet.Count; j++)
                {
                    outputReal[j] = learningSet[j].Key;
                }

                List<List<double>> newP = new List<List<double>>();
                double[] result = Matrix.Dot(A, outputReal);
                int index = 0;
                for (int k = 0; k < M; k++)
                {
                    List<double> calculatedP = new List<double>();
                    for (int d = 0; d < N + 1; d++)
                    {
                        calculatedP.Add(result[index++]);
                    }

                    newP.Add(calculatedP);
                }

                thirdLayer.SetNewP(newP);

                List<double> AAAAAAAAAAAAAAA = new List<double>();

                for (int k = 0; k < learningSet.Count; k++)
                {
                    KeyValuePair<double, List<double>> pair = learningSet[k];
                    List<double> learningSetExample = pair.Value;
                    double output = Output(learningSetExample, out AAAAAAAAAAAAAAA);
                    double val = pair.Key;

                    List<List<double>> newC = firstLayer.GetRecalculatedC(0.2, output, val, newP, learningSetExample);
                    List<List<double>> newSigma = firstLayer.GetRecalculatedSigma(0.2, output, val, newP, learningSetExample);
                    //List<List<double>> newB = firstLayer.GetRecalculatedD(0.2, output, val, newP, learningSetExample);

                    for (int i = 0; i < newC.Count; i++)
                    {
                        for (int j = 0; j < newC[i].Count; j++)
                        {
                            firstLayer.Neurons[i].C[j] -= newC[i][j];
                            firstLayer.Neurons[i].Sigma[j] -= newSigma[i][j];
                            //firstLayer.Neurons[i].B[j] -= newB[i][j];
                        }
                    }
                }

                double o = Output(new List<double>(new double[] { 85, 92, 45, 27, 31, 0.0 }), out AAAAAAAAAAAAAAA);
            }
        }

        internal void InitRadiuses(List<List<double>> initRadiuses)
        {
            firstLayer.InitRadiuses(initRadiuses);
        }

        internal void InitCenters(List<List<double>> initCenters)
        {
            firstLayer.InitCenters(initCenters);
        }
    }
}
