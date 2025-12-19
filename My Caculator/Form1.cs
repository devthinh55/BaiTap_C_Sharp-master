using System;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        double memory = 0;
        string operation = "";
        bool isNewNumber = true;

        public Form1()
        {
            InitializeComponent();
            txtDisplay.Text = "0";
            lblHistory.Text = "";
        }

        // ===== NUMBER =====
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            if (btn.Text == "." && txtDisplay.Text.Contains(".")) return;

            txtDisplay.Text += btn.Text;
        }

        // ===== OPERATOR =====
        private void BtnOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            result = double.Parse(txtDisplay.Text);
            operation = btn.Text;

            lblHistory.Text = result + " " + operation;
            isNewNumber = true;
        }

        // ===== EQUAL =====
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtDisplay.Text);

            lblHistory.Text += " " + x + " =";

            switch (operation)
            {
                case "+": result += x; break;
                case "-": result -= x; break;
                case "*": result *= x; break;
                case "/":
                    if (x == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0");
                        return;
                    }
                    result /= x;
                    break;
            }

            txtDisplay.Text = result.ToString();
            operation = "";
            isNewNumber = true;
        }

        // ===== CLEAR =====
        private void BtnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblHistory.Text = "";
            result = 0;
            operation = "";
            isNewNumber = true;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            isNewNumber = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (!isNewNumber && txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text[..^1];
            else
                txtDisplay.Text = "0";
        }

        // ===== EXTRA =====
        private void BtnSign_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (-x).ToString();
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Sqrt(x).ToString();
            isNewNumber = true;
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (x / 100).ToString();
            isNewNumber = true;
        }

        private void BtnInvert_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtDisplay.Text);
            if (x == 0)
            {
                MessageBox.Show("Không thể chia cho 0");
                return;
            }
            txtDisplay.Text = (1 / x).ToString();
            isNewNumber = true;
        }

        // ===== MEMORY =====
        private void BtnMC_Click(object sender, EventArgs e) => memory = 0;

        private void BtnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memory.ToString();
            isNewNumber = true;
        }

        private void BtnMS_Click(object sender, EventArgs e)
        {
            memory = double.Parse(txtDisplay.Text);
            isNewNumber = true;
        }

        private void BtnMPlus_Click(object sender, EventArgs e)
        {
            memory += double.Parse(txtDisplay.Text);
            isNewNumber = true;
        }

        private void BtnMMinus_Click(object sender, EventArgs e)
        {
            memory -= double.Parse(txtDisplay.Text);
            isNewNumber = true;
        }
    }
}
