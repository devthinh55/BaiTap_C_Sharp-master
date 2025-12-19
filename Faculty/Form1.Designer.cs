namespace Faculty
{
    partial class Form1
    {
        // Khai báo Controls
        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button buttonClear; // Đổi tên button1 thành buttonClear cho rõ ràng
        private System.Windows.Forms.Button btOK; // Đổi tên btOK_Click thành btOK

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button(); // Khởi tạo nút OK
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Ngoại ngữ", "Quản trị kinh doanh", "Cơ khí", "Điện", "Cơ khí động lực" });
            this.cb_Faculty.Location = new System.Drawing.Point(76, 44);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(494, 28);
            this.cb_Faculty.TabIndex = 0;
            this.cb_Faculty.SelectedValueChanged += new System.EventHandler(this.cb_Faculty_SelectedValueChanged); // Gán sự kiện

            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(76, 93);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(494, 27);
            this.tbDisplay.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(189, 221);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 29);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click); // Gán sự kiện Clear

            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(335, 221);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(94, 29);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click); // Gán sự kiện Click

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "Form1";
            this.Text = "ComboBox Article"; // Đổi tên Form theo ảnh
            this.Load += new System.EventHandler(this.Form1_Load); // Gán sự kiện Form Load
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}