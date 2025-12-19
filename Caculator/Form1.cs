using System;
using System.IO;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;

            tbKetQua.AppendText($"{x} + {y} = {kq}\r\n");
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;

            tbKetQua.AppendText($"{x} * {y} = {kq}\r\n");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            File.AppendAllText("Caculator.txt", tbKetQua.Text);
        }

        
    }
}
