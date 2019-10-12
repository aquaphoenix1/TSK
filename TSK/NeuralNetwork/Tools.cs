using System;
using System.Collections.Generic;

namespace TSK.NeuralNetwork
{
    class Tools
    {
        public static double DeltaKroneker(int i, int j)
        {
            return (i == j) ? 1.0 : 0.0;
        }

        internal static double GaussPow(double x, double c, double sigma, double b)
        {
            return Math.Pow(Gauss(x, c, sigma), 2 * b);
        }

        internal static double GaussPowMinusOne(double x, double c, double sigma, double b)
        {
            return Math.Pow(Gauss(x, c, sigma), 2 * b - 1);
        }

        private static double Gauss(double x, double c, double sigma)
        {
            return (x - c) / sigma;
        }

        public static double nu(List<double> x, List<double> c, List<double> sigma, List<double> b)
        {
            double result = 1.0;

            for (int j = 0; j < x.Count; j++)
            {
                result *= (1.0 / (1.0 + GaussPow(x[j], c[j], sigma[j], b[j])));
            }

            return result;
        }

        public static double l(List<double> x, List<double> c, List<double> sigma, List<double> b)
        {
            double result = 1.0;

            for (int s = 0; s < x.Count; s++)
            {
                result *= GaussPow(x[s], c[s], sigma[s], b[s]);
            }

            return result;
        }

        public static double m(List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList)
        {
            double result = 0.0;

            for (int i = 0; i < cList.Count; i++)
            {
                result += l(x, cList[i], sigmaList[i], bList[i]);
            }

            return result;
        }

        public static double ThirdLayerRes(List<double> p, List<double> x)
        {
            double multiply = p[0];
            for (int i = 1; i < p.Count; i++)
            {
                multiply += p[i] * x[i - 1];
            }

            return multiply;
        }

        public static double DerivativeCoefficient(List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList, int k, int i, int j)
        {
            var m = Tools.m(x, cList, sigmaList, bList);
            var coeff = (DeltaKroneker(i, k) * m - l(x, cList[i], sigmaList[i], bList[i])) / Math.Pow(m, 2);

            for (int s = 0; s < x.Count; s++)
            {
                if (s != j)
                {
                    coeff *= l(x, cList[s], sigmaList[s], bList[s]);
                }
            }

            return coeff;
        }
    }
}
