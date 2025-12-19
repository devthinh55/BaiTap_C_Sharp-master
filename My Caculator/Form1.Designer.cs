using System.Drawing;
using System.Windows.Forms;

namespace MyCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtDisplay;
        private Button btnMC, btnMR, btnMS, btnMPlus, btnMMinus;
        private Button btnBackspace, btnCE, btnC;
        private Button btnPlusMinus, btnSqrt, btnPercent, btnReciprocal;
        private Button btnDivide, btnMultiply, btnMinus, btnPlus, btnEquals;
        private Button btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnDecimal;
        private Label lblHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            txtDisplay = new TextBox
            {
                Font = new Font("Segoe UI", 24F),
                Location = new Point(12, 12),
                Size = new Size(416, 53),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right,
                Text = "0"
            };

            lblHistory = new Label();
            lblHistory.Font = new Font("Segoe UI", 12F);
            lblHistory.ForeColor = Color.Gray;
            lblHistory.TextAlign = ContentAlignment.MiddleRight;
            lblHistory.Location = new Point(12, 5);
            lblHistory.Size = new Size(416, 25);
            lblHistory.Text = "";

            Controls.Add(lblHistory);


            btnMC = CreateBtn("MC", 24, 94, BtnMC_Click);
            btnMR = CreateBtn("MR", 106, 94, BtnMR_Click);
            btnMS = CreateBtn("MS", 188, 94, BtnMS_Click);
            btnMPlus = CreateBtn("M+", 270, 94, BtnMPlus_Click);
            btnMMinus = CreateBtn("M-", 352, 94, BtnMMinus_Click);

            btnBackspace = CreateBtn("←", 24, 150, BtnBack_Click);
            btnCE = CreateBtn("CE", 106, 150, BtnCE_Click);
            btnC = CreateBtn("C", 188, 150, BtnC_Click);
            btnPlusMinus = CreateBtn("±", 270, 150, BtnSign_Click);
            btnSqrt = CreateBtn("√", 352, 150, BtnSqrt_Click);

            btn7 = CreateBtn("7", 24, 206, BtnNumber_Click);
            btn8 = CreateBtn("8", 106, 206, BtnNumber_Click);
            btn9 = CreateBtn("9", 188, 206, BtnNumber_Click);
            btnDivide = CreateBtn("/", 270, 206, BtnOperator_Click);
            btnPercent = CreateBtn("%", 352, 206, BtnPercent_Click);

            btn4 = CreateBtn("4", 24, 262, BtnNumber_Click);
            btn5 = CreateBtn("5", 106, 262, BtnNumber_Click);
            btn6 = CreateBtn("6", 188, 262, BtnNumber_Click);
            btnMultiply = CreateBtn("*", 270, 262, BtnOperator_Click);
            btnReciprocal = CreateBtn("1/x", 352, 262, BtnInvert_Click);

            btn1 = CreateBtn("1", 24, 318, BtnNumber_Click);
            btn2 = CreateBtn("2", 106, 318, BtnNumber_Click);
            btn3 = CreateBtn("3", 188, 318, BtnNumber_Click);
            btnMinus = CreateBtn("-", 270, 318, BtnOperator_Click);

            btn0 = CreateBtn("0", 24, 374, BtnNumber_Click);
            btn0.Size = new Size(158, 50);
            btnDecimal = CreateBtn(".", 188, 374, BtnNumber_Click);
            btnPlus = CreateBtn("+", 270, 374, BtnOperator_Click);
            btnEquals = CreateBtn("=", 352, 318, BtnEqual_Click);
            btnEquals.Size = new Size(76, 106);

            Controls.AddRange(new Control[]
            {
                txtDisplay,
                btnMC, btnMR, btnMS, btnMPlus, btnMMinus,
                btnBackspace, btnCE, btnC, btnPlusMinus, btnSqrt,
                btn7, btn8, btn9, btnDivide, btnPercent,
                btn4, btn5, btn6, btnMultiply, btnReciprocal,
                btn1, btn2, btn3, btnMinus,
                btn0, btnDecimal, btnPlus, btnEquals
            });

            ClientSize = new Size(452, 441);
            Text = "My Calculator";
            ResumeLayout(false);
        }

        private Button CreateBtn(string text, int x, int y, EventHandler click)
        {
            Button b = new Button();
            b.Text = text;
            b.Size = new Size(76, 50);
            b.Location = new Point(x, y);
            b.Click += click;
            return b;
        }


    }
}
