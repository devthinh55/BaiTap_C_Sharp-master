namespace QLSV_2
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
            dtpNgaySinh = new DateTimePicker();
            tbHoTen = new TextBox();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            cbKhoa = new ComboBox();
            tbTrangThai = new TextBox();
            btThem = new Button();
            btThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(128, 79);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 0;
            // 
            // tbHoTen
            // 
            tbHoTen.Location = new Point(128, 29);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(250, 27);
            tbHoTen.TabIndex = 1;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Location = new Point(176, 152);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(62, 24);
            rbNam.TabIndex = 2;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(285, 152);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(50, 24);
            rbNu.TabIndex = 3;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Items.AddRange(new object[] { "Công nghệ thông tin", "Kế toán", "Cơ khí" });
            cbKhoa.Location = new Point(128, 198);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(250, 28);
            cbKhoa.TabIndex = 4;
            // 
            // tbTrangThai
            // 
            tbTrangThai.Location = new Point(128, 248);
            tbTrangThai.Multiline = true;
            tbTrangThai.Name = "tbTrangThai";
            tbTrangThai.ReadOnly = true;
            tbTrangThai.ScrollBars = ScrollBars.Vertical;
            tbTrangThai.Size = new Size(250, 150);
            tbTrangThai.TabIndex = 5;
            // 
            // btThem
            // 
            btThem.Location = new Point(144, 418);
            btThem.Name = "btThem";
            btThem.Size = new Size(94, 29);
            btThem.TabIndex = 6;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(265, 418);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 7;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 8;
            label1.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 86);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 9;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 129);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 10;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 201);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 11;
            label4.Text = "Khoa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 248);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 12;
            label5.Text = "Trạng thái";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 569);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btThoat);
            Controls.Add(btThem);
            Controls.Add(tbTrangThai);
            Controls.Add(cbKhoa);
            Controls.Add(rbNu);
            Controls.Add(rbNam);
            Controls.Add(tbHoTen);
            Controls.Add(dtpNgaySinh);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgaySinh;
        private TextBox tbHoTen;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private ComboBox cbKhoa;
        private TextBox tbTrangThai;
        private Button btThem;
        private Button btThoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
