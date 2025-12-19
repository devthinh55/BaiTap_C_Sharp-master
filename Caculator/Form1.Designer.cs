namespace Caculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            btLuu = new Button();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(60, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Số X";
            // 
            // label2
            // 
            label2.Location = new Point(60, 90);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Số Y";
            // 
            // label3
            // 
            label3.Location = new Point(60, 160);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(160, 30);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(150, 27);
            tbSoX.TabIndex = 3;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(160, 90);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(150, 27);
            tbSoY.TabIndex = 4;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(160, 160);
            tbKetQua.Multiline = true;
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(450, 150);
            tbKetQua.TabIndex = 5;
            // 
            // btLuu
            // 
            btLuu.Location = new Point(60, 340);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(75, 23);
            btLuu.TabIndex = 6;
            btLuu.Text = "Lưu";
            btLuu.Click += btLuu_Click;
            // 
            // btCong
            // 
            btCong.Location = new Point(260, 340);
            btCong.Name = "btCong";
            btCong.Size = new Size(75, 23);
            btCong.TabIndex = 7;
            btCong.Text = "Cộng";
            btCong.Click += btCong_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(360, 340);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(75, 23);
            btNhan.TabIndex = 8;
            btNhan.Text = "Nhân";
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(460, 340);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(75, 23);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.Click += btThoat_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(700, 420);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(tbSoX);
            Controls.Add(tbSoY);
            Controls.Add(tbKetQua);
            Controls.Add(btLuu);
            Controls.Add(btCong);
            Controls.Add(btNhan);
            Controls.Add(btThoat);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caculator";
         
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1, label2, label3;
        private TextBox tbSoX, tbSoY, tbKetQua;
        private Button btLuu, btCong, btNhan, btThoat;
    }
}
