using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TSK.NeuralNetwork
{
    static class Tools
    {
        public static Random random = new Random();

        public static int GetRandom(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }

        public static int GetRandom(int maxValue)
        {
            return random.Next(maxValue);
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = GetRandom(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static List<KeyValuePair<double, List<double>>> DownloadSet(string path)
        {
            var result = new List<KeyValuePair<double, List<double>>>();
            using (TextReader reader = File.OpenText(path))
            {
                string text;
                while ((text = reader.ReadLine()) != null)
                {
                    var arr = text.Split(new char[] { ',' });
                    var x = new List<double>();
                    arr.Where((e, i) => i != arr.Length - 1).ToList().ForEach(e => x.Add(double.Parse(e.Replace('.', ','))));
                    result.Add(new KeyValuePair<double, List<double>>(double.Parse(arr[arr.Length - 1].Replace('.', ',')), x));
                }
            }

            return new List<KeyValuePair<double, List<double>>>(result);
        }

        public static List<KeyValuePair<double, List<double>>> GetRandomArray(List<KeyValuePair<double, List<double>>> list, int learningPercents)
        {
            List<KeyValuePair<double, List<double>>> res = new List<KeyValuePair<double, List<double>>>();

            for (int i = 0; i < learningPercents; i++)
            {
                int randomVal = Tools.GetRandom(list.Count);
                res.Add(list[randomVal]);
                list.RemoveAt(randomVal);
            }

            return res;
        }

        public static double DeltaKroneker(int i, int j)
        {
            return (i == j) ? 1.0 : 0.0;
        }

        internal static double GaussPow(double x, double c, double sigma, double b)
        {
            return Math.Pow(Gauss(x, c, sigma), 2.0 * b);
        }

        internal static double GaussPowMinusOne(double x, double c, double sigma, double b)
        {
            return Math.Pow(Gauss(x, c, sigma), 2.0 * b - 1.0);
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

        public static double l(List<double> x, List<double> c, List<double> sigma, List<double> b, int i = -1)
        {
            double result = 1.0;

            for (int s = 0; s < x.Count; s++)
            {
                if (s != i)
                {
                    result *= 1.0 / (1.0 + GaussPow(x[s], c[s], sigma[s], b[s]));
                }
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

        public static double DerivativeCoefficient(List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList, int k, int i, int j, List<double> w)
        {

            var m = w.Sum();
            var l = w[i];

            var coef = ((k == i ? 1 : 0) * m - l) /  Math.Pow(m, 2);

            coef *= Mu(x.ToArray(), cList[i].ToArray(), sigmaList[i].ToArray(), bList[i].ToArray(), j);


            ////var m = Tools.m(x, cList, sigmaList, bList);
            //var coeff = (DeltaKroneker(i, k) * m - l(x, cList[i], sigmaList[i], bList[i])) / Math.Pow(m, 2);

            ////for (int s = 0; s < x.Count; s++)
            //{
            //    coeff *= l(x, cList[i], sigmaList[i], bList[i], j);
            //}

            return coef;
        }


        private static double Mu(double[] x, double[] c, double[] s, double[] b, int sInd)
        {
            double result = 1;

            for (int i = 0; i < x.Length; i++)
            {
                if (i == sInd) continue;
                result *= 1.0 / (1.0 + Math.Pow((x[i] - c[i]) / s[i], 2 * b[i]));
            }
            return result;
        }
    }
}
