using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSK.NeuralNetwork;

namespace TSK
{
    public partial class Form1 : Form
    {
        private static Random random = new Random();

        private static int GetRandom(int maxValue)
        {
            return random.Next(0, maxValue);
        }

        public Form1()
        {
            InitializeComponent();

            List<KeyValuePair<double, List<double>>> dict = null;

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                fileDialog.Filter = "data files (*.data)|*.data|All files (*.*)|*.*";
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    dict = Tools.downloadSet(fileDialog.FileName);
                }
            }

            if (dict != null)
            {
                var res = dict.GroupBy(x => x.Key).Select(g => g.ToList()).ToList();
                var minCount = res.Min(x=>x.Count());
                int learningPercents = (int)(minCount * 70 / 100);
                int controlPercents = minCount * 15 / 100;
                int checkPercents = minCount - learningPercents - controlPercents;

                /*res[0] = new List<KeyValuePair<double, List<double>>>();
                res[0].Add(new KeyValuePair<double, List<double>>(0, new List<double>(new double[] { 1, 1, 1, 1, 1, 2})));
                res[0].Add(new KeyValuePair<double, List<double>>(0, new List<double>(new double[] { 1, 1, 1, 1, 1, 2 })));*/

                List<KeyValuePair<double, List<double>>> learningSet1 = GetRandomArray(res[0], learningPercents);
                List<KeyValuePair<double, List<double>>> controlSet1 = GetRandomArray(res[0], controlPercents);
                List<KeyValuePair<double, List<double>>> checkSet1 = res[0];

                List<KeyValuePair<double, List<double>>> learningSet2 = GetRandomArray(res[1], learningPercents);
                List<KeyValuePair<double, List<double>>> controlSet2 = GetRandomArray(res[1], controlPercents);
                List<KeyValuePair<double, List<double>>> checkSet2 = res[1];

                List<KeyValuePair<double, List<double>>> totalLearningSet = new List<KeyValuePair<double, List<double>>>();
                totalLearningSet.AddRange(learningSet1);
                totalLearningSet.AddRange(learningSet2);

                List<List<KeyValuePair<double, List<double>>>> learningSets = new List<List<KeyValuePair<double, List<double>>>>(new List<KeyValuePair<double, List<double>>>[] { learningSet1, learningSet2 });

                List<List<double>> initCenters = GetInitCenters(learningSets);
                List<List<double>> initRadiuses = GetInitRadiuses(learningSets, initCenters);

                Network network = new Network(dict[0].Value.Count, 2);
                network.InitCenters(initCenters);

                network.Learning(totalLearningSet, 0.2);
            }
        }

        private List<List<double>> GetInitCenters(List<List<KeyValuePair<double, List<double>>>> learningSets)
        {
            List<List<double>> initCenters = new List<List<double>>();

            for(int j = 0; j < learningSets.Count; j++)
            {
                List<double> averageParams = new List<double>(Enumerable.Repeat(0.0, learningSets[j][0].Value.Count));

                learningSets[j].Select(x => x.Value).ToList().ForEach(x => x.Select((y, i) => new { val = y, index = i }).ToList().ForEach(z=>averageParams[z.index] += z.val));

                averageParams = averageParams.Select(x => x /= learningSets[j].Count).ToList();

                initCenters.Add(averageParams);
            }

            return initCenters;
        }

        private List<List<double>> GetInitRadiuses(List<List<KeyValuePair<double, List<double>>>> learningSets, List<List<double>> centers)
        {
            List<List<double>> initRadiuses = new List<List<double>>();

            for (int j = 0; j < learningSets.Count; j++)
            {
                List<double> averageParams = new List<double>(Enumerable.Repeat(0.0, learningSets[j][0].Value.Count));

                learningSets[j].Select(x => x.Value).ToList().ForEach(x => x.Select((y, i) => new { val = y, index = i }).ToList().ForEach(z => averageParams[z.index] += z.val));

                averageParams = averageParams.Select(x => x /= learningSets[j].Count).ToList();

                initRadiuses.Add(averageParams);
            }

            return initRadiuses;
        }

        private static List<KeyValuePair<double, List<double>>> GetRandomArray(List<KeyValuePair<double, List<double>>> list, int learningPercents)
        {
            List<KeyValuePair<double, List<double>>> res = new List<KeyValuePair<double, List<double>>>();

            for (int i = 0; i < learningPercents; i++)
            {
                int randomVal = GetRandom(list.Count);
                res.Add(list[randomVal]);
                list.RemoveAt(randomVal);
            }

            return res;
        }
    }
}
