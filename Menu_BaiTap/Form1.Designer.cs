namespace Menu_BaiTap
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
        //
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(235, 57);
            button2.Name = "button2";
            button2.Size = new Size(115, 71);
            button2.TabIndex = 1;
            button2.Text = "Caculator";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCaculator_Click;
            // 
            // button5
            // 
            button5.Location = new Point(235, 175);
            button5.Name = "button5";
            button5.Size = new Size(115, 71);
            button5.TabIndex = 5;
            button5.Text = "PictureBox";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnPictureBox_Click;
            // 
            // button6
            // 
            button6.Location = new Point(84, 57);
            button6.Name = "button6";
            button6.Size = new Size(115, 71);
            button6.TabIndex = 4;
            button6.Text = "MyCaculator";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnMyCalculator_Click;
            // 
            // button7
            // 
            button7.Location = new Point(399, 166);
            button7.Name = "button7";
            button7.Size = new Size(115, 71);
            button7.TabIndex = 7;
            button7.Text = "QLSV_2";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnQLSV_2_Click;
            // 
            // button8
            // 
            button8.Location = new Point(399, 57);
            button8.Name = "button8";
            button8.Size = new Size(115, 71);
            button8.TabIndex = 6;
            button8.Text = "PictureBox_Move";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnPictureBox_Move_Click;
            // 
            // button9
            // 
            button9.Location = new Point(93, 279);
            button9.Name = "button9";
            button9.Size = new Size(115, 71);
            button9.TabIndex = 9;
            button9.Text = "TimeArticle";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnTimeArticle_Click;
            // 
            // button10
            // 
            button10.Location = new Point(93, 175);
            button10.Name = "button10";
            button10.Size = new Size(115, 71);
            button10.TabIndex = 8;
            button10.Text = "StringCollectionEditor";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnStringCollectionEditor_Click;
            // 
            // button11
            // 
            button11.Location = new Point(235, 279);
            button11.Name = "button11";
            button11.Size = new Size(115, 71);
            button11.TabIndex = 11;
            button11.Text = "TinhTien";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnTinhTien_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(button11);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}
