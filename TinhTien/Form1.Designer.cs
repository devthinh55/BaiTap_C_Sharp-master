namespace TinhTien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbName = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            ckDiscount = new CheckBox();
            tbDiscount = new TextBox();
            tbResult = new TextBox();
            btRun = new Button();
            btThoat = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(36, 36);
            tbName.Name = "tbName";
            tbName.Size = new Size(357, 27);
            tbName.TabIndex = 0;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(118, 117);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 1;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(205, 117);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(50, 24);
            rbFemale.TabIndex = 2;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // ckDiscount
            // 
            ckDiscount.AutoSize = true;
            ckDiscount.Location = new Point(36, 190);
            ckDiscount.Name = "ckDiscount";
            ckDiscount.Size = new Size(91, 24);
            ckDiscount.TabIndex = 3;
            ckDiscount.Text = "Giảm giá";
            ckDiscount.UseVisualStyleBackColor = true;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(147, 187);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(246, 27);
            tbDiscount.TabIndex = 4;
            tbDiscount.Click += ckDiscount_CheckedChanged;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(36, 250);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(357, 27);
            tbResult.TabIndex = 5;
            // 
            // btRun
            // 
            btRun.Location = new Point(175, 348);
            btRun.Name = "btRun";
            btRun.Size = new Size(94, 46);
            btRun.TabIndex = 7;
            btRun.Text = "Tính tiền";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(288, 348);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 46);
            btThoat.TabIndex = 8;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 94);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 9;
            label1.Text = "Giới tính";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(label1);
            Controls.Add(btThoat);
            Controls.Add(btRun);
            Controls.Add(tbResult);
            Controls.Add(tbDiscount);
            Controls.Add(ckDiscount);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(tbName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private CheckBox ckDiscount;
        private TextBox tbDiscount;
        private TextBox tbResult;
        private Button btRun;
        private Button btThoat;
        private Label label1;
    }
}
