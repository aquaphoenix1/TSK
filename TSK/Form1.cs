using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSK.NeuralNetwork;

namespace TSK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<KeyValuePair<double, List<double>>> dict = new List<KeyValuePair<double, List<double>>>();
            dict.Add(new KeyValuePair<double, List<double>>(0.38, new List<double>(new double[] { 0.2, 0.2 })));
            //dict.Add(new KeyValuePair<double, List<double>>(0.76, new List<double>(new double[] { 0.7, 0.7 })));

            Network network = new Network(2, 3);

            network.Learning(dict, 0.2);
        }
    }
}
