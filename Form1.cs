using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    public partial class Form1 : Form
    {
        double value;
        string Operators;
        bool Check;
        public Form1()
        {
            InitializeComponent();
        }
        private void pNumber (object sender , EventArgs e)
        {
            if (Operators =="+" || Operators=="-" || Operators == "*" || Operators == "/")
            {
                if (Check)
                {
                    Check = false;
                    txtResult.Text = "0";
                }
            }
            Button b = sender as Button;
            if (txtResult.Text =="0")
            {
                txtResult.Text = b.Text;
            }
            else
            {
                    txtResult.Text +=b.Text;
            }
        }

        private void neoOperator(object sender, EventArgs e)
        {
            Button b = sender as Button;
            value = double.Parse(txtResult.Text);
            Operators = b.Text;
            txtResult.Text += b.Text;
            Check = true;

        }
        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Operators)
                {
                    case "+":txtResult.Text = (value + double.Parse(txtResult.Text)).ToString();
                        break;
                    case "-": txtResult.Text = (value - double.Parse(txtResult.Text)).ToString();
                        break;
                    case "*":
                        txtResult.Text = (value * double.Parse(txtResult.Text)).ToString();
                        break;
                    case "/":
                        txtResult.Text = (value / double.Parse(txtResult.Text)).ToString();
                        break;

                }
            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
        }
    }
}
