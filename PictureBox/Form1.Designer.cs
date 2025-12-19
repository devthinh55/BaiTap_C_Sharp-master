namespace PictureBox
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            pbImage = new System.Windows.Forms.PictureBox();
            btFile = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 46);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 136);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Ảnh 3x4";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(150, 46);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(140, 27);
            txtMaNV.TabIndex = 3;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(150, 86);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(256, 27);
            txtTenNV.TabIndex = 4;
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Location = new Point(150, 136);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(132, 167);
            pbImage.TabIndex = 5;
            pbImage.TabStop = false;
            // 
            // btFile
            // 
            btFile.Location = new Point(301, 136);
            btFile.Name = "btFile";
            btFile.Size = new Size(105, 36);
            btFile.TabIndex = 6;
            btFile.Text = "Chọn ảnh . . . ";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 450);
            Controls.Add(btFile);
            Controls.Add(pbImage);
            Controls.Add(txtTenNV);
            Controls.Add(txtMaNV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private System.Windows.Forms.PictureBox pbImage;
        private Button btFile;
    }
}
