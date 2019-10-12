﻿using System;
using System.Collections.Generic;

namespace TSK.NeuralNetwork.FirstLayer
{
    class FirstLayerNeuron
    {
        private static readonly Random random = new Random();

        internal List<double> C { get; set; }
        public List<double> Sigma { get; set; }
        public List<double> B { get; set; }

        public FirstLayerNeuron(int N)
        {
            C = new List<double>();
            B = new List<double>();
            Sigma = new List<double>();

            for (int i = 0; i < N; i++)
            {
                C.Add(random.NextDouble());
                B.Add(1);
                Sigma.Add(random.NextDouble());
            }
        }

        public double Calculate(List<double> x)
        {
            double result = 1.0;

            for (int j = 0; j < x.Count; j++)
            {
                result *= Tools.GaussPow(x[j], C[j], Sigma[j], B[j]);
            }

            return result;
        }

        /*public double RecalculatedB(double coefficient, double error, List<double> p, List<double> x, int i, int j, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            return coefficient * DerivativeEB(error, i, j, x, p, cList, sigmaList, bList);
        }

        private double DerivativeEB(double error, int i, int j, List<double> x, List<double> p, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            double result = error;

            double multiply = Tools.ThirdLayerRes(p, x);

            result *= multiply;

            result *= DerivativeB(i, j, x, cList, sigmaList, bList);

            return result;
        }

        private double DerivativeB(int i, int j, List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            double result = Tools.DerivativeCoefficient(i, j, x, cList, sigmaList, bList);

            result *= -2 * Tools.GaussPow(x[j], cList[i][j], sigmaList[i][j], bList[i][j]) * Math.Log(Tools.GaussPow(x[j], cList[i][j], sigmaList[i][j], bList[i][j]));

            result /= Math.Pow((1 + Tools.GaussPow(x[j], cList[i][j], sigmaList[i][j], bList[i][j])), 2);

            return result;

        }

        public double RecalculatedSigma(double coefficient, double error, List<double> p, List<double> x, int i, int j, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            return coefficient * DerivativeESigma(error, i, j, x, p, cList, sigmaList, bList);
        }

        private double DerivativeESigma(double error, int i, int j, List<double> x, List<double> p, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            double result = error;

            double multiply = Tools.ThirdLayerRes(p, x);

            result *= multiply;

            result *= DerivativeSigma(i, j, x, cList, sigmaList, bList);

            return result;
        }

        private double DerivativeSigma(int i, int j, List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            double result = Tools.DerivativeCoefficient(i, j, x, cList, sigmaList, bList);

            result *= 2 * bList[i][j] / sigmaList[i][j] * Tools.GaussPow(x[j], cList[i][j], sigmaList[i][j], bList[i][j]);

            result /= Math.Pow((1 + Tools.GaussPow(x[j], cList[i][j], sigmaList[i][j], bList[i][j])), 2);

            return result;

        }*/
    }
}