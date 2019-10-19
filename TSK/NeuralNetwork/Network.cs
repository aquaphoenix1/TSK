using Accord.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TSK.NeuralNetwork
{
    static class Network
    {
        private static FormMain mainForm;
        private static int N;
        private static int M;
        private static double learningCoefficient;
        private static List<KeyValuePair<double, List<double>>> learningSets;
        private static List<double> maxValues;

        private static FirstLayer.FirstLayer firstLayer;
        private static SecondLayer.SecondLayer secondLayer;
        private static ThirdLayer.ThirdLayer thirdLayer;
        private static FourthLayer.FourthLayer fourthLayer;
        private static FifthLayer.FifthLayer fifthLayer;

        private static Task learningTask;
        private static CancellationTokenSource learningTokenSource;
        private static CancellationToken cancellationLearningToken;

        public static void InitNetwork(int N, int M, double learningCoefficient, List<KeyValuePair<double, List<double>>> learningSets, FormMain mainForm, List<double> maxValues)
        {
            Network.N = N;
            Network.M = M;
            Network.learningCoefficient = learningCoefficient;
            Network.learningSets = learningSets;
            Network.mainForm = mainForm;
            Network.maxValues = maxValues;

            firstLayer = new FirstLayer.FirstLayer(M, N);
            secondLayer = new SecondLayer.SecondLayer(M);
            thirdLayer = new ThirdLayer.ThirdLayer(M, N);
            fourthLayer = new FourthLayer.FourthLayer();
            fifthLayer = new FifthLayer.FifthLayer();
        }

        public static double Output(List<double> list, out List<double> secondLayerResult)
        {
            List<double> firstLayerResult = firstLayer.Calculate(list);

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

        public static void StopLearning()
        {
            learningTokenSource.Cancel();
            learningTokenSource.Dispose();
        }

        public static void Learning()
        {
            int iteration = 0;

            learningTokenSource = new CancellationTokenSource();
            cancellationLearningToken = learningTokenSource.Token;

            learningTask = Task.Run(() =>
                {
                    while (true)
                    {
                        if (cancellationLearningToken.IsCancellationRequested)
                        {
                            cancellationLearningToken.ThrowIfCancellationRequested();
                        }

                        iteration++;
                        mainForm.PaintResultsLearning(iteration);
                        double[,] A = new double[learningSets.Count, (N + 1) * M];

                        for (int k = 0; k < learningSets.Count; k++)
                        {
                            KeyValuePair<double, List<double>> pair = learningSets[k];
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

                        double[] outputReal = new double[learningSets.Count];

                        for (int j = 0; j < learningSets.Count; j++)
                        {
                            outputReal[j] = learningSets[j].Key;
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

                        for (int k = 0; k < learningSets.Count; k++)
                        {
                            KeyValuePair<double, List<double>> pair = learningSets[k];
                            List<double> learningSetExample = pair.Value;
                            double output = Output(learningSetExample, out AAAAAAAAAAAAAAA);
                            double val = pair.Key;

                            List<List<double>> newC = firstLayer.GetRecalculatedC(learningCoefficient, output, val, newP, learningSetExample);
                            List<List<double>> newSigma = firstLayer.GetRecalculatedSigma(learningCoefficient, output, val, newP, learningSetExample);
                            //List<List<double>> newB = firstLayer.GetRecalculatedD(learningCoefficient, output, val, newP, learningSetExample);

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
                    }
                }, learningTokenSource.Token);
        }

        public static void InitRadiuses(List<List<double>> initRadiuses)
        {
            firstLayer.InitRadiuses(initRadiuses);
        }

        public static void InitCenters(List<List<double>> initCenters)
        {
            firstLayer.InitCenters(initCenters);
        }

        public static List<List<double>> GetInitCenters(List<List<KeyValuePair<double, List<double>>>> learningSets)
        {
            List<List<double>> initCenters = new List<List<double>>();

            for (int j = 0; j < learningSets.Count; j++)
            {
                List<double> maxValues = new List<double>(Enumerable.Repeat(double.MinValue, learningSets[j][0].Value.Count));
                List<double> minValues = new List<double>(Enumerable.Repeat(double.MaxValue, learningSets[j][0].Value.Count));

                /*learningSets[j].Select(x => x.Value).ToList().ForEach(x => x.Select((y, i) => new { val = y, index = i }).ToList().ForEach(z => averageParams[z.index] += z.val));

                averageParams = averageParams.Select(x => x /= learningSets[j].Count).ToList();*/

                learningSets[j].Select(x => x.Value).ToList().ForEach(x => x.Select((y, i) => new { val = y, index = i }).ToList().ForEach(z =>
                {
                    if (z.val > maxValues[z.index])
                    {
                        maxValues[z.index] = z.val;
                    }
                    if (z.val < minValues[z.index])
                    {
                        minValues[z.index] = z.val;
                    }
                }));

                var result = new List<double>(Enumerable.Repeat(0.0, learningSets[j][0].Value.Count));
                maxValues.Select((v, i) => result[i] = maxValues[i] - minValues[i]).ToList();

                initCenters.Add(result);
            }

            List<double> totalAverageParams = new List<double>(Enumerable.Repeat(0.0, learningSets[0][0].Value.Count));
            initCenters.ForEach(x => x.Select((v, i) => totalAverageParams[i] += v).ToList());
            totalAverageParams = totalAverageParams.Select(x => x /= 2).ToList();

            List<List<double>> newInitCenters = new List<List<double>>();
            newInitCenters.Add(initCenters[0]);
            newInitCenters.Add(totalAverageParams);
            newInitCenters.Add(initCenters[1]);

            return newInitCenters;
        }

        public static List<List<double>> GetInitRadiuses(List<List<KeyValuePair<double, List<double>>>> learningSets, List<List<double>> centers)
        {
            List<List<double>> initRadiuses = new List<List<double>>();

            /*for (int j = 0; j < learningSets.Count; j++)
            {
                List<double> averageParams = new List<double>(Enumerable.Repeat(0.0, learningSets[j][0].Value.Count));

                learningSets[j].Select(x => x.Value).ToList().ForEach(x => x.Select((y, i) => new { val = y, index = i }).ToList().ForEach(z =>
                {
                    var newVal = Math.Abs(z.val - centers[j][z.index]);
                    averageParams[z.index] = newVal > averageParams[z.index] ? newVal : averageParams[z.index];
                }));

                initRadiuses.Add(averageParams);
            }*/

            List<double> averageParams = new List<double>(Enumerable.Repeat(0.0, learningSets[0][0].Value.Count));
            for (var i = 0; i < centers[0].Count; i++)
            {
                averageParams[i] += centers[0][i] - centers[1][i];
            }

            averageParams = averageParams.Select(x => Math.Abs(x)).ToList();
            initRadiuses.AddRange(new List<double>[] { averageParams, averageParams, averageParams });

            return initRadiuses;
        }
    }
}
