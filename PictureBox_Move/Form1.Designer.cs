namespace PictureBox_Move
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
            btLeft = new Button();
            btRight = new Button();
            btFile = new Button();
            SuspendLayout();
            // 
            // btLeft
            // 
            btLeft.Location = new Point(128, 262);
            btLeft.Name = "btLeft";
            btLeft.Size = new Size(64, 51);
            btLeft.TabIndex = 1;
            btLeft.Text = "<-";
            btLeft.UseVisualStyleBackColor = true;
            btLeft.Click += btLeft_Click;
            // 
            // btRight
            // 
            btRight.Location = new Point(207, 262);
            btRight.Name = "btRight";
            btRight.Size = new Size(64, 51);
            btRight.TabIndex = 2;
            btRight.Text = "->";
            btRight.UseVisualStyleBackColor = true;
            btRight.Click += btRight_Click;
            // 
            // btFile
            // 
            btFile.Location = new Point(327, 269);
            btFile.Name = "btFile";
            btFile.Size = new Size(77, 36);
            btFile.TabIndex = 3;
            btFile.Text = "File . . . ";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(btFile);
            Controls.Add(btRight);
            Controls.Add(btLeft);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btLeft;
        private Button btRight;
        private Button btFile;
    }
}
