using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sal
{
    public partial class Form1 : Form
    {
        double net = 0;
        double brut = 0;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonScutit.Checked && textBoxNet.Text != "")
            {
                net = Double.Parse(textBoxNet.Text);
                brut = net > 11193 ? (net + 1408) / 0.94 : net / 0.835;
                textBoxBrut.Text = Convert.ToString(brut);
            }
            else if (radioButtonScutit.Checked && textBoxBrut.Text != "")
            {
                brut = Double.Parse(textBoxBrut.Text);
                net = brut > 13405 ? (brut * 0.94) - 1408 : brut * 0.835;
                textBoxNet.Text = Convert.ToString(net);
            }
            else if (radioButtonNescutit.Checked && textBoxNet.Text != "")
            {
                net = Double.Parse(textBoxNet.Text);
                brut = net > 9402 ? (net + 1183) / 0.7896 : net / 0.835 / 0.84;
                textBoxBrut.Text = Convert.ToString(brut);
            }
            else if (radioButtonNescutit.Checked && textBoxBrut.Text != "")
            {
                brut = Double.Parse(textBoxBrut.Text);
                net = brut > 13405 ? (brut * 0.7896) - 1183 : brut * 0.7014;
                textBoxNet.Text = Convert.ToString(net);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            net = 0;
            brut = 0;
            textBoxBrut.Text = "";
            textBoxNet.Text = "";

        }
    }
}
