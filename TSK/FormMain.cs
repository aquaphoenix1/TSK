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

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                fileDialog.Filter = "data files (*.data)|*.data|All files (*.*)|*.*";
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    dict = Tools.DownloadSet(fileDialog.FileName);
                }
            }

            if (dict != null)
            {
                var res = dict.GroupBy(x => x.Key).Select(g => g.ToList()).ToList();

                List<List<double>> initCenters = Network.GetInitCenters(res);
                List<List<double>> initRadiuses = Network.GetInitRadiuses(res, initCenters);

                var minCount = res.Min(x => x.Count());
                int learningPercents = (int)(minCount * 70 / 100);
                int checkPercents = minCount - learningPercents;

                List<KeyValuePair<double, List<double>>> learningSet1 = Tools.GetRandomArray(res[0], learningPercents);
                List<KeyValuePair<double, List<double>>> checkSet1 = Tools.GetRandomArray(res[0], checkPercents);

                List<KeyValuePair<double, List<double>>> learningSet2 = Tools.GetRandomArray(res[1], learningPercents);
                List<KeyValuePair<double, List<double>>> checkSet2 = Tools.GetRandomArray(res[1], checkPercents);

                List<KeyValuePair<double, List<double>>> totalLearningSet = new List<KeyValuePair<double, List<double>>>();
                totalLearningSet.AddRange(learningSet1);
                totalLearningSet.AddRange(learningSet2);

                List<KeyValuePair<double, List<double>>> totalChectSet = new List<KeyValuePair<double, List<double>>>();
                totalChectSet.AddRange(checkSet1);
                totalChectSet.AddRange(checkSet2);

                totalLearningSet.Shuffle();

                Network.InitNetwork(dict[0].Value.Count, 3, (double)numericUpDownCoefficient.Value, totalLearningSet, this, totalChectSet);
                Network.InitCenters(initCenters);
                Network.InitRadiuses(initRadiuses);

                buttonTest.Enabled = true;
                buttonStartLearning.Enabled = true;

                Network.Epoch = 0;

                ClearLogs();
            }
        }
        
        private void ClearLogs()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RichTextBox)
                        (control as RichTextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(tableLayoutPanelNeuronsLogs.Controls);

            chartLearning.Series["Ошибка эпохи"].Points.Clear();
        }

        internal void ShowCheckError(int count, int error)
        {
            textBoxError.Invoke((MethodInvoker)delegate { textBoxError.Text = $"{error} из {count}"; });
        }

        internal bool IsShowNeuronsLog()
        {
            return checkBoxShowNeuronsLog.Checked;
        }

        private void PrintNeuronResult(RichTextBox richTextBox, int index, double result)
        {
            richTextBox.Invoke((MethodInvoker)delegate { richTextBox.AppendText(index + ": " + String.Format("{0:0.00000}", result) + "\r\n"); });
        }

        internal void LogResults(List<double> secondLayerResult, List<double> thirdLayerResult, List<double> fourthLayerResult, double fifthLayerResult, int index)
        {
            PrintNeuronResult(richTextBoxFirstLayerFirstNeuron, index, secondLayerResult[0]);
            PrintNeuronResult(richTextBoxFirstLayerSecondNeuron, index, secondLayerResult[1]);
            PrintNeuronResult(richTextBoxFirstLayerThirdNeuron, index, secondLayerResult[2]);

            PrintNeuronResult(richTextBoxSecondLayerFirstNeuron, index, thirdLayerResult[0]);
            PrintNeuronResult(richTextBoxSecondLayerSecondNeuron, index, thirdLayerResult[1]);
            PrintNeuronResult(richTextBoxSecondLayerThirdNeuron, index, thirdLayerResult[2]);

            PrintNeuronResult(richTextBoxThirdLayerFirstNeuron, index, fourthLayerResult[0]);
            PrintNeuronResult(richTextBoxThirdLayerSecondNeuron, index, fourthLayerResult[1]);

            PrintNeuronResult(richTextBoxFourthLayerFirstNeuron, index, fifthLayerResult);
        }

        internal void PrintLinearWeights(List<List<double>> listWeights, int epoch)
        {
            richTextBoxLinearWeights.Invoke((MethodInvoker)delegate {
                string weights = "Эпоха " + epoch.ToString() + ":\r\n";
                for (var i = 0; i < listWeights.Count; i++)
                {
                    weights += "\tНейрон: " + i + "\r\n";
                    for (var j = 0; j < listWeights[i].Count; j++)
                    {
                        weights += "\t\t" + listWeights[i][j] + "\r\n";
                    }
                }
                richTextBoxLinearWeights.AppendText(weights + "\r\n");
            });
        }

        internal void PaintCurrentEpoch(int epoch)
        {
            textBoxCurrentEpoch.Invoke((MethodInvoker)delegate { textBoxCurrentEpoch.Text = epoch.ToString(); });

        }

        internal void PaintIterationError(int iteration, double error)
        {
            BeginInvoke(new MethodInvoker(() => chartLearning.Series["Ошибка итерации"].Points.AddXY(iteration, error)));
        }

        internal void PaintEpochError(int iteration, double error)
        {
            BeginInvoke(new MethodInvoker(() => chartLearning.Series["Ошибка эпохи"].Points.AddXY(iteration, error)));
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

        internal void PrintOutputLog(int epoch, int k, double val, double output)
        {
            richTextBoxOutputNeuronsLog.Invoke((MethodInvoker)delegate { richTextBoxOutputNeuronsLog.AppendText($"Эпоха: {epoch}; Итерация: {k}; Значение: {val}; Выход: {output};\r\n"); });
        }
    }
}
