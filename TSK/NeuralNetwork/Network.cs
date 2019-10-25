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
        private static List<KeyValuePair<double, List<double>>> checkSet;

        private static FirstLayer.FirstLayer firstLayer;
        private static SecondLayer.SecondLayer secondLayer;
        private static ThirdLayer.ThirdLayer thirdLayer;
        private static FourthLayer.FourthLayer fourthLayer;
        private static FifthLayer.FifthLayer fifthLayer;

        private static Task learningTask;
        private static CancellationTokenSource learningTokenSource;
        private static CancellationToken cancellationLearningToken;

        public static int Epoch { get; set; } = 0;

        public static void InitNetwork(int N, int M, double learningCoefficient, List<KeyValuePair<double, List<double>>> learningSets, FormMain mainForm, List<KeyValuePair<double, List<double>>> checkSet)
        {
            Network.N = N;
            Network.M = M;
            Network.learningCoefficient = learningCoefficient;
            Network.learningSets = learningSets;
            Network.checkSet = checkSet;
            Network.mainForm = mainForm;

            firstLayer = new FirstLayer.FirstLayer(M, N);
            secondLayer = new SecondLayer.SecondLayer(M);
            thirdLayer = new ThirdLayer.ThirdLayer(M, N);
            fourthLayer = new FourthLayer.FourthLayer();
            fifthLayer = new FifthLayer.FifthLayer();
        }

        public static double Output(List<double> list, out List<double> secondLayerResult, int iteration = -1)
        {
            var firstLayerResult = firstLayer.Calculate(list);
            secondLayerResult = secondLayer.Calculate(firstLayerResult);

            List<double> thirdLayerResult = thirdLayer.Calculate(list, secondLayerResult);

            List<double> fourthLayerResult = fourthLayer.Calculate(secondLayerResult, thirdLayerResult);

            double fifthLayerResult = fifthLayer.Calculate(fourthLayerResult);

            if(mainForm.IsShowNeuronsLog() && iteration != -1)
            {
                mainForm.LogResults(secondLayerResult, thirdLayerResult, fourthLayerResult, fifthLayerResult, iteration);
            }

            return fifthLayerResult;
        }

        public static void StopLearning()
        {
            learningTokenSource.Cancel();
            learningTokenSource.Dispose();
        }

        private static void CheckNetwork()
        {
            int error = 0;

            for(var j = 0; j < checkSet.Count; j++)
            {
                if(Math.Abs(Output(checkSet[j].Value, out _) - checkSet[j].Key) > 0.5)
                {
                    error++;
                }
            }

            mainForm.ShowCheckError(checkSet.Count, error);
        }

        public static void Learning()
        {
            learningTokenSource = new CancellationTokenSource();
            cancellationLearningToken = learningTokenSource.Token;

            learningTask = Task.Run(() =>
                {
                    while (true)
                    {
                        if (cancellationLearningToken.IsCancellationRequested)
                        {
                            try
                            {
                                cancellationLearningToken.ThrowIfCancellationRequested();
                            }
                            catch
                            {
                                CheckNetwork();
                                return;
                            }
                            finally
                            {
                                learningTokenSource.Dispose();
                            }
                        }

                        mainForm.PaintCurrentEpoch(Epoch);
                        double[,] A = new double[learningSets.Count, (N + 1) * M];

                        for (int k = 0; k < learningSets.Count; k++)
                        {
                            KeyValuePair<double, List<double>> pair = learningSets[k];
                            List<double> l = pair.Value;

                            Output(l, out List<double> secondLayerResult);

                            double wSum = secondLayerResult.Sum();
                            var _w = secondLayerResult.Select(o => o / wSum).ToList();

                            int p = 0;
                            bool flag = true;

                            for (int j = 0; j < (N + 1) * M; j++)
                            {
                                if (flag)
                                {
                                    A[k, j] = _w[p];
                                    flag = false;
                                }
                                else
                                {
                                    for (int d = 0; d < l.Count; d++)
                                    {
                                        A[k, j] = _w[p] * l[d];
                                        j++;
                                    }

                                    j--;
                                    p++;
                                    flag = true;
                                }
                            }
                        }

                        double[,] Aplus = A.PseudoInverse();

                        double[] outputReal = new double[learningSets.Count];

                        for (int j = 0; j < learningSets.Count; j++)
                        {
                            outputReal[j] = learningSets[j].Key;
                        }

                        List<List<double>> newP = new List<List<double>>();
                        double[] result = Matrix.Dot(Aplus, outputReal);
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
                        if (mainForm.IsShowNeuronsLog())
                        {
                            mainForm.PrintLinearWeights(newP, Epoch);
                        }

                        double error = 0;

                        var allP = new List<double>();
                        foreach (var itemP in newP)
                        {
                            allP.AddRange(itemP);
                        }

                        double[] y = Matrix.Dot(A,allP.ToArray());

                        for (int k = 0; k < learningSets.Count; k++)
                        {
                            KeyValuePair<double, List<double>> pair = learningSets[k];
                            List<double> learningSetExample = pair.Value;

                            double val = pair.Key;
                            double output = y[k];

                            if (mainForm.IsShowNeuronsLog())
                            {
                                mainForm.PrintOutputLog(Epoch, k, val, Output(learningSets[k].Value, out _, k));
                            }

                            //mainForm.PaintIterationError(iteration++, output - val);

                            error += (Math.Abs(output - val) > 0.45) ? 1 : 0;

                            Output(learningSetExample, out List<double> w);

                            List<List<double>> newC = firstLayer.GetRecalculatedC(learningCoefficient, output, val, newP, learningSetExample, w);
                            List<List<double>> newSigma = firstLayer.GetRecalculatedSigma(learningCoefficient, output, val, newP, learningSetExample, w);
                            //List<List<double>> newB = firstLayer.GetRecalculatedB(learningCoefficient, output, val, newP, learningSetExample);

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

                        mainForm.PaintEpochError(Epoch, error);

                        Epoch++;

                        if(Epoch % 10 == 0)
                        {
                            CheckNetwork();
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
                var averageParams = new List<double>(Enumerable.Repeat(0.0, learningSets[j][0].Value.Count));

                learningSets[j].Select(x => x.Value).ToList().ForEach(x => x.Select((y, i) => new { val = y, index = i }).ToList().ForEach(z => averageParams[z.index] += z.val));

                averageParams = averageParams.Select(x => x /= learningSets[j].Count).ToList();

                initCenters.Add(averageParams);
            }

            List<double> totalAverageParams = new List<double>(Enumerable.Repeat(0.0, learningSets[0][0].Value.Count));
            initCenters.ForEach(x => x.Select((v, i) => totalAverageParams[i] += v).ToList());
            totalAverageParams = totalAverageParams.Select(x => x /= 2).ToList();

            List<List<double>> newInitCenters = new List<List<double>>
            {
                initCenters[0],
                totalAverageParams,
                initCenters[1]
            };

            return newInitCenters;
        }

        public static List<List<double>> GetInitRadiuses(List<List<KeyValuePair<double, List<double>>>> learningSets, List<List<double>> centers)
        {
            List<List<double>> initRadiuses = new List<List<double>>();

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
