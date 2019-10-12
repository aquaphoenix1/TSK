using System;
using System.Collections.Generic;

namespace TSK.NeuralNetwork.FirstLayer
{
    class FirstLayer
    {
        private int M;
        private int N;

        public FirstLayer(int M, int N)
        {
            this.M = M;
            this.N = N;

            Neurons = new FirstLayerNeuron[M];

            int k = 0;
            while (k < M)
            {
                Neurons[k++] = new FirstLayerNeuron(N);
            }
        }

        internal FirstLayerNeuron[] Neurons { get; set; }

        public List<double> Calculate(List<double> x)
        {
            List<double> result = new List<double>();

            for (int i = 0; i < Neurons.Length; i++)
            {
                result.Add(Neurons[i].Calculate(x));
            }

            return result;
        }

        private List<List<List<double>>> GetAllLists()
        {
            List<List<List<double>>> list = new List<List<List<double>>>();

            List<List<double>> cList = new List<List<double>>();
            List<List<double>> sigmaList = new List<List<double>>();
            List<List<double>> bList = new List<List<double>>();

            for (int i = 0; i < Neurons.Length; i++)
            {
                cList.Add(Neurons[i].C);
                sigmaList.Add(Neurons[i].Sigma);
                bList.Add(Neurons[i].B);
            }

            list.Add(cList);
            list.Add(sigmaList);
            list.Add(bList);

            return list;
        }

        public List<List<double>> GetRecalculatedC(double coefficient, double y, double d, List<List<double>> p, List<double> x)
        {
            List<List<List<double>>> allParams = GetAllLists();
            List<List<double>> newC = new List<List<double>>();
            for (int i = 0; i < Neurons.Length; i++)
            {
                List<double> c = new List<double>();
                for (int j = 0; j < Neurons[i].C.Count; j++)
                {
                    c.Add(RecalculatedC(coefficient, i, j, y, d, p, x, allParams[0], allParams[1], allParams[2]));
                }

                newC.Add(c);
            }

            return newC;
        }

        private double RecalculatedC(double coefficient, int i, int j, double y, double d, List<List<double>> p, List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            return coefficient * DerivativeEC(i, j, y, d, p, x, cList, sigmaList, bList);
        }

        private double DerivativeEC(int i, int j, double y, double d, List<List<double>> p, List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            double result = y - d;

            for (int k = 0; k < M; k++)
            {
                result += p[k][0];

                for (int j1 = 1; j1 < N; j1++)
                {
                    result += p[k][j1] * x[j1 - 1];
                }

                result *= DerivativeC(x, cList, sigmaList, bList, k, i, j);
            }

            return result;
        }

        private double DerivativeC(List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList, int k, int i, int j)
        {
            double result = Tools.DerivativeCoefficient(x, cList, sigmaList, bList, k, i, j);

            result *= 2 * Neurons[i].B[j] / Neurons[i].Sigma[j] * Tools.GaussPowMinusOne(x[j], Neurons[i].C[j], Neurons[i].Sigma[j], Neurons[i].B[j]);

            result /= Math.Pow(1 + Tools.GaussPow(x[j], Neurons[i].C[j], Neurons[i].Sigma[j], Neurons[i].B[j]), 2);

            return result;
        }

        public List<List<double>> GetRecalculatedSigma(double coefficient, double y, double d, List<List<double>> p, List<double> x)
        {
            List<List<List<double>>> allParams = GetAllLists();
            List<List<double>> newC = new List<List<double>>();
            for (int i = 0; i < Neurons.Length; i++)
            {
                List<double> c = new List<double>();
                for (int j = 0; j < Neurons[i].C.Count; j++)
                {
                    c.Add(RecalculatedSigma(coefficient, i, j, y, d, p, x, allParams[0], allParams[1], allParams[2]));
                }

                newC.Add(c);
            }

            return newC;
        }

        private double RecalculatedSigma(double coefficient, int i, int j, double y, double d, List<List<double>> p, List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            return coefficient * DerivativeESigma(i, j, y, d, p, x, cList, sigmaList, bList);
        }

        private double DerivativeESigma(int i, int j, double y, double d, List<List<double>> p, List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            double result = y - d;

            for (int k = 0; k < M; k++)
            {
                result += p[k][0];

                for (int j1 = 1; j1 < N; j1++)
                {
                    result += p[k][j1] * x[j1 - 1];
                }

                result *= DerivativeSigma(x, cList, sigmaList, bList, k, i, j);
            }

            return result;
        }

        private double DerivativeSigma(List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList, int k, int i, int j)
        {
            double result = Tools.DerivativeCoefficient(x, cList, sigmaList, bList, k, i, j);

            var gauss = Tools.GaussPow(x[j], Neurons[i].C[j], Neurons[i].Sigma[j], Neurons[i].B[j]);

            result *= 2 * Neurons[i].B[j] / Neurons[i].Sigma[j] * gauss;

            result /= Math.Pow(1 + gauss, 2);

            return result;
        }

        public List<List<double>> GetRecalculatedD(double coefficient, double y, double d, List<List<double>> p, List<double> x)
        {
            List<List<List<double>>> allParams = GetAllLists();
            List<List<double>> newC = new List<List<double>>();
            for (int i = 0; i < Neurons.Length; i++)
            {
                List<double> c = new List<double>();
                for (int j = 0; j < Neurons[i].C.Count; j++)
                {
                    c.Add(RecalculatedD(coefficient, i, j, y, d, p, x, allParams[0], allParams[1], allParams[2]));
                }

                newC.Add(c);
            }

            return newC;
        }

        private double RecalculatedD(double coefficient, int i, int j, double y, double d, List<List<double>> p, List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            return coefficient * DerivativeED(i, j, y, d, p, x, cList, sigmaList, bList);
        }

        private double DerivativeED(int i, int j, double y, double d, List<List<double>> p, List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            double result = y - d;

            for (int k = 0; k < M; k++)
            {
                result += p[k][0];

                for (int j1 = 1; j1 < N; j1++)
                {
                    result += p[k][j1] * x[j1 - 1];
                }

                result *= DerivativeD(x, cList, sigmaList, bList, k, i, j);
            }

            return result;
        }

        private double DerivativeD(List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList, int k, int i, int j)
        {
            double result = Tools.DerivativeCoefficient(x, cList, sigmaList, bList, k, i, j);

            var gauss = Tools.GaussPow(x[j], Neurons[i].C[j], Neurons[i].Sigma[j], Neurons[i].B[j]);

            result *= -2 * gauss * Math.Log(gauss);

            result /= Math.Pow(1 + gauss, 2);

            return result;
        }
    }
}
