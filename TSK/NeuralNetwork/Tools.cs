using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TSK.NeuralNetwork
{
    class Tools
    {
        public static Random random = new Random();

        public static int GetRandom(int maxValue)
        {
            return random.Next(0, maxValue);
        }

        public static Tuple<List<KeyValuePair<double, List<double>>>, List<double>> DownloadSet(string path)
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

            var maxValues = NormalizeData(ref result);

            return new Tuple<List<KeyValuePair<double, List<double>>>, List<double>>(result, maxValues);
        }

        public static List<double> NormalizeData(ref List<KeyValuePair<double, List<double>>> list)
        {
            var maxValues = new List<double>();
            for (int i = 0; i < list[0].Value.Count; i++)
            {
                var max = list.Select(o => o.Value[i]).Max();
                maxValues.Add(max);
                list.ForEach(o => o.Value[i] /= max);
            }

            return maxValues;
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
                    result *= GaussPow(x[s], c[s], sigma[s], b[s]);
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

        public static double DerivativeCoefficient(List<double> x, List<List<double>> cList, List<List<double>> sigmaList, List<List<double>> bList, int k, int i, int j)
        {
            var m = Tools.m(x, cList, sigmaList, bList);
            var coeff = (DeltaKroneker(i, k) * m - l(x, cList[i], sigmaList[i], bList[i])) / Math.Pow(m, 2);

            for (int s = 0; s < x.Count; s++)
            {
                coeff *= l(x, cList[i], sigmaList[i], bList[i], s);
            }

            return coeff;
        }
    }
}
