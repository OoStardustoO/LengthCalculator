using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM;
            if (double.TryParse(txtCM.Text, out douCM))
            {
                txtM.Text = string.Format("{0:0.##########}", douCM / 100);
                txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
            }
            else
            {
                // Handle invalid input, e.g., clear the output text boxes or show an error message
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
                txtInfo.Text = "你輸入錯了拉";
                txtCM.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM;
            if (double.TryParse(txtM.Text, out douM))
            {
                txtCM.Text = string.Format("{0:0.##########}", douM * 100);
                txtKM.Text = string.Format("{0:0.##########}", douM / 1000);
                txtIn.Text = string.Format("{0:0.##########}", douM * 39.3701);
                txtFt.Text = string.Format("{0:0.##########}", douM * 3.28084);
                txtYard.Text = string.Format("{0:0.##########}", douM * 1.09361);
            }
            else
            {
                // Handle invalid input, e.g., clear the output text boxes or show an error message
                txtCM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
                txtInfo.Text = "你輸入錯了拉";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM;
            if (double.TryParse(txtKM.Text, out douKM))
            {
                txtCM.Text = string.Format("{0:0.##########}", douKM * 100000);
                txtM.Text = string.Format("{0:0.##########}", douKM * 1000);
                txtIn.Text = string.Format("{0:0.##########}", douKM * 39370.1);
                txtFt.Text = string.Format("{0:0.##########}", douKM * 3280.84);
                txtYard.Text = string.Format("{0:0.##########}", douKM * 1093.61);
            }
            else
            {
                // Handle invalid input, e.g., clear the output text boxes or show an error message
                txtCM.Text = "";
                txtM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
                txtInfo.Text = "你輸入錯了拉";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn;
            if (double.TryParse(txtIn.Text, out douIn))
            {
                txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);
                txtM.Text = string.Format("{0:0.##########}", douIn * 0.0254);
                txtKM.Text = string.Format("{0:0.##########}", douIn * 0.0000254);
                txtFt.Text = string.Format("{0:0.##########}", douIn * 0.0833333);
                txtYard.Text = string.Format("{0:0.##########}", douIn * 0.0277778);
            }
            else
            {
                // Handle invalid input, e.g., clear the output text boxes or show an error message
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtFt.Text = "";
                txtYard.Text = "";
                txtInfo.Text = "你輸入錯了拉";
                txtIn.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt;
            if (double.TryParse(txtFt.Text, out douFt))
            {
                txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48);
                txtM.Text = string.Format("{0:0.##########}", douFt * 0.3048);
                txtKM.Text = string.Format("{0:0.##########}", douFt * 0.0003048);
                txtIn.Text = string.Format("{0:0.##########}", douFt * 12);
                txtYard.Text = string.Format("{0:0.##########}", douFt * 0.333333);
            }
            else
            {
                // Handle invalid input, e.g., clear the output text boxes or show an error message
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtYard.Text = "";
                txtInfo.Text = "你輸入錯了拉";
                txtFt.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard;
            if (double.TryParse(txtYard.Text, out douYard))
            {
                txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44);
                txtM.Text = string.Format("{0:0.##########}", douYard * 0.9144);
                txtKM.Text = string.Format("{0:0.##########}", douYard * 0.0009144);
                txtIn.Text = string.Format("{0:0.##########}", douYard * 36);
                txtFt.Text = string.Format("{0:0.##########}", douYard * 3);
            }
            else
            {
                // Handle invalid input, e.g., clear the output text boxes or show an error message
                txtCM.Text = "";
                txtM.Text = "";
                txtKM.Text = "";
                txtIn.Text = "";
                txtFt.Text = "";
                txtInfo.Text = "你輸入錯了拉";
                txtYard.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
            txtInfo.Text = "";
        }
    }
}
