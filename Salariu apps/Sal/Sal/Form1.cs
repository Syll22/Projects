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
        double net_old = 0;
        double brut_old = 0;
        double net_new = 0;
        double brut_new = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void CalculeazaButton_old(object sender, EventArgs e)
        {
            if (radioButtonScutit_old.Checked && textBoxNet_old.Text != "")
            {
                net_old = Double.Parse(textBoxNet_old.Text);
                //brut = net > 11193 ? (net + 1408) / 0.94 : net / 0.835; Calcul vechi cu palfonarea CAS
                brut_old = net_old / 0.835 ;
                textBoxBrut_old.Text = Convert.ToString(brut_old);
            }
            else if (radioButtonScutit_old.Checked && textBoxBrut_old.Text != "")
            {
                brut_old = Double.Parse(textBoxBrut_old.Text);
                //net = brut > 13405 ? (brut * 0.94) - 1408 : brut * 0.835; Calcul vechi cu palfonarea CAS
                net_old = brut_old * 0.835 ;
                textBoxNet_old.Text = Convert.ToString(net_old);
            }
            else if (radioButtonNescutit_old.Checked && textBoxNet_old.Text != "")
            {
                net_old = Double.Parse(textBoxNet_old.Text);
                //brut = net > 9402 ? (net + 1183) / 0.7896 : net / 0.835 / 0.84; Calcul vechi cu palfonarea CAS
                brut_old = net_old / 0.835 / 0.84;
                textBoxBrut_old.Text = Convert.ToString(brut_old);
            }
            else if (radioButtonNescutit_old.Checked && textBoxBrut_old.Text != "")
            {
                brut_old = Double.Parse(textBoxBrut_old.Text);
                //net = brut > 13405 ? (brut * 0.7896) - 1183 : brut * 0.7014; Calcul vechi cu palfonarea CAS
                net_old = brut_old * 0.835 * 0.84;
                textBoxNet_old.Text = Convert.ToString(net_old);
            }
        }

        private void ResetButton_old(object sender, EventArgs e)
        {
            net_old = 0;
            brut_old = 0;
            textBoxBrut_old.Text = "";
            textBoxNet_old.Text = "";
        }

        private void button_calcul_new_Click(object sender, EventArgs e)
        {
            if (radioButtonScutit_new.Checked && textBoxNet_new.Text != "")
            {
                net_new = Double.Parse(textBoxNet_new.Text);
                brut_new = net_new / 0.65;
                textBoxBrut_new.Text = Convert.ToString(brut_new);
            }
            else if (radioButtonScutit_new.Checked && textBoxBrut_new.Text != "")
            {
                brut_new = Double.Parse(textBoxBrut_new.Text);
                net_new = brut_new * 0.65;
                textBoxNet_new.Text = Convert.ToString(net_new);
            }
            else if (radioButtonNescutit_new.Checked && textBoxNet_new.Text != "")
            {
                net_new = Double.Parse(textBoxNet_new.Text);
                brut_new = net_new / 0.65 / 0.9;
                textBoxBrut_new.Text = Convert.ToString(brut_new);
            }
            else if (radioButtonNescutit_new.Checked && textBoxBrut_new.Text != "")
            {
                brut_new = Double.Parse(textBoxBrut_new.Text);
                net_new = brut_new * 0.65 * 0.9;
                textBoxNet_new.Text = Convert.ToString(net_new);
            }
        }

        private void button_reset_new_Click(object sender, EventArgs e)
        {
            net_new = 0;
            brut_new = 0;
            textBoxBrut_new.Text = "";
            textBoxNet_new.Text = "";
        }
    }
}
