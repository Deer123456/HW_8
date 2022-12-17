using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcilator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            // input
            int num1 = int.Parse(textBoxNum1.Text);
            int num2 = int.Parse(textBoxNum2.Text);

            // action
            int res = num1 + num2;

            // output
            labelResult.Text = res.ToString();
            labelResultInfo.Text = num1.ToString() + " + " + num2.ToString() + " = " + res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // input
            int num1 = int.Parse(textBoxNum1.Text);
            int num2 = int.Parse(textBoxNum2.Text);

            // action
            int res = num1 - num2;

            // output
            labelResult.Text = res.ToString();
            labelResultInfo.Text = num1.ToString() + " - " + num2.ToString() + " = " + res.ToString();
        }

        private void buttonDif_Click(object sender, EventArgs e)
        {
            // input
            int num1 = int.Parse(textBoxNum1.Text);
            int num2 = int.Parse(textBoxNum2.Text);

            // action
            int res = num1 / num2;

            // output
            labelResult.Text = res.ToString();
            labelResultInfo.Text = num1.ToString() + " / " + num2.ToString() + " = " + res.ToString();
        }

        private void buttonUmn_Click(object sender, EventArgs e)
        {
            // input
            int num1 = int.Parse(textBoxNum1.Text);
            int num2 = int.Parse(textBoxNum2.Text);

            // action
            int res = num1 * num2;

            // output
            labelResult.Text = res.ToString();
            labelResultInfo.Text = num1.ToString() + " * " + num2.ToString() + " = " + res.ToString();
        }
    }
}
