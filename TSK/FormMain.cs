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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInitialize_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<double, List<double>>> dict = null;
            var maxValues = new List<double>();

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                fileDialog.Filter = "data files (*.data)|*.data|All files (*.*)|*.*";
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var tuple = Tools.DownloadSet(fileDialog.FileName);
                    dict = tuple.Item1;
                    maxValues = tuple.Item2;
                }
            }

            if (dict != null)
            {
                var res = dict.GroupBy(x => x.Key).Select(g => g.ToList()).ToList();

                var minCount = res.Min(x => x.Count());
                int learningPercents = (int)(minCount * 70 / 100);
                int controlPercents = minCount * 15 / 100;
                int checkPercents = minCount - learningPercents - controlPercents;

                List<KeyValuePair<double, List<double>>> learningSet1 = Tools.GetRandomArray(res[0], learningPercents);
                List<KeyValuePair<double, List<double>>> controlSet1 = Tools.GetRandomArray(res[0], controlPercents);
                List<KeyValuePair<double, List<double>>> checkSet1 = res[0];

                List<KeyValuePair<double, List<double>>> learningSet2 = Tools.GetRandomArray(res[1], learningPercents);
                List<KeyValuePair<double, List<double>>> controlSet2 = Tools.GetRandomArray(res[1], controlPercents);
                List<KeyValuePair<double, List<double>>> checkSet2 = res[1];

                List<KeyValuePair<double, List<double>>> totalLearningSet = new List<KeyValuePair<double, List<double>>>();
                totalLearningSet.AddRange(learningSet1);
                totalLearningSet.AddRange(learningSet2);

                List<List<KeyValuePair<double, List<double>>>> learningSets = new List<List<KeyValuePair<double, List<double>>>>(new List<KeyValuePair<double, List<double>>>[] { learningSet1, learningSet2 });

                List<List<double>> initCenters = Network.GetInitCenters(learningSets);
                List<List<double>> initRadiuses = Network.GetInitRadiuses(learningSets, initCenters);

                Network.InitNetwork(dict[0].Value.Count, 3, (double)numericUpDownCoefficient.Value, totalLearningSet, this, maxValues);
                Network.InitCenters(initCenters);
                Network.InitRadiuses(initRadiuses);

                buttonTest.Enabled = true;
                buttonStartLearning.Enabled = true;
            }
        }

        internal void PaintResultsLearning(int i)
        {
            BeginInvoke(new MethodInvoker(() => textBoxLearningError.Text = i.ToString()));
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            List<double> AAAA = new List<double>();
            List<double> parameters = new List<double>();
            parameters.AddRange(new double[] {
                (double)numericUpDownFirstParameter.Value,
                (double)numericUpDownSecondParameter.Value,
                (double)numericUpDownThirdParameter.Value,
                (double)numericUpDownFourthParameter.Value,
                (double)numericUpDownFifthParameter.Value,
                (double)numericUpDownSixthParameter.Value
            });

            textBoxTestResult.Text = Network.Output(parameters, out AAAA).ToString();
        }

        private void buttonStartLearning_Click(object sender, EventArgs e)
        {
            buttonInitialize.Enabled = false;
            buttonStartLearning.Enabled = false;
            buttonStopLearning.Enabled = true;
            buttonTest.Enabled = false;

            Network.Learning();
        }

        private void buttonStopLearning_Click(object sender, EventArgs e)
        {
            buttonInitialize.Enabled = true;
            buttonStartLearning.Enabled = true;
            buttonStopLearning.Enabled = false;
            buttonTest.Enabled = true;

            Network.StopLearning();
        }
    }
}
