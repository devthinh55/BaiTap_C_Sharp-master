using System.Windows.Forms;

namespace Example03
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btThoat;
        // Thêm nút Lưu nếu bạn dùng chức năng này
        // private System.Windows.Forms.Button btLuu; 
        // ... Khai báo các Label khác nếu cần ...
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.Text = "Name";

            // textBox1
            this.textBox1.Location = new System.Drawing.Point(163, 68);
            this.textBox1.Size = new System.Drawing.Size(145, 22);

            // numericUpDown1
            this.numericUpDown1.Location = new System.Drawing.Point(325, 68);
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);

            // checkBox1
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(80, 143);
            this.checkBox1.Text = "checkBox1";

            // radioButton1
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(205, 143);
            this.radioButton1.Text = "radioButton1";

            // comboBox1
            this.comboBox1.Location = new System.Drawing.Point(80, 183);
            this.comboBox1.Size = new System.Drawing.Size(200, 24);

            // dateTimePicker1
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 213);
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);

            // listBox1
            this.listBox1.Location = new System.Drawing.Point(80, 266);
            this.listBox1.Size = new System.Drawing.Size(120, 84);

            // bt_OK
            this.bt_OK.Location = new System.Drawing.Point(205, 397);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(75, 23);
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);

            // button2
            this.button2.Location = new System.Drawing.Point(305, 397);
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.Text = "Cancel";

            // Form1
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Caculator";
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button button2;
    }
}
