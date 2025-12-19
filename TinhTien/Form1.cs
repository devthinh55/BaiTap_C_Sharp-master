namespace TinhTien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
            {
                tbDiscount.Enabled = true;
            }
            else
            {
                tbDiscount.Enabled = false;
                // Có thể thêm tbDiscount.Text = "0"; nếu muốn xóa giá trị giảm giá
            }
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            

            string msg = null;
            int disc = 0; 

          
            if (rbMale.Checked == true)
            {
                msg = "Ông ";
            }

            
            else if (rbFemale.Checked == true)
            {
                msg = "Bà ";
            }

          

            // Xác định Giảm giá 
            if (ckDiscount.Checked == true)
            {
                // Lấy giá trị giảm giá từ TextBox. Cần xử lý lỗi nếu người dùng nhập chữ.
                // Dùng int.TryParse() để an toàn hơn so với int.Parse()
                if (int.TryParse(tbDiscount.Text, out int parsedDisc))
                {
                    disc = parsedDisc;
                }
                else
                {
                    disc = 0;
                }
            }
            else
            {
                // Nếu CheckBox không được chọn, giảm giá là 0 (hoặc giữ nguyên giá trị disc=0)
                disc = 0;
            }

            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
