namespace QLSV_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int stt = 1;

        private void btThem_Click(object sender, EventArgs e)
        {
         
            string hoTen = tbHoTen.Text;
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy"); 
            string gioiTinh = "";
            string khoa = cbKhoa.Text; 

          
            if (rbNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rbNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                gioiTinh = "Chưa xác định";
            }

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(khoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ và Tên, và chọn Khoa.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sinhVienMoi = stt.ToString() + "." + hoTen + "\r\n" +
                                 "-Giới tính: " + gioiTinh + "\r\n" +
                                 "-Ngày Sinh: " + ngaySinh + "\r\n" +
                                 "-Khoa: " + khoa + "\r\n";

            tbTrangThai.Text += sinhVienMoi;
            stt++; 

            tbHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now; 
            cbKhoa.SelectedIndex = -1;       // Bỏ chọn mục trong ComboBox
            rbNam.Checked = false;
            rbNu.Checked = false;
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
