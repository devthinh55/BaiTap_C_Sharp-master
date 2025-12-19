using System.Collections;
using System.Windows.Forms;
using System;

namespace Faculty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            lst.Add(new Faculty { Id = "K01", Name = "Công nghệ thông tin", Quantity = 1200 });
            lst.Add(new Faculty { Id = "K02", Name = "Quản trị kinh doanh", Quantity = 4200 });
            lst.Add(new Faculty { Id = "K03", Name = "Kế toán tài chính", Quantity = 5200 });
            return lst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty!.DataSource = lst;
            cb_Faculty.DisplayMember = "Name";
        }

        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            Faculty? selectedFaculty = cb_Faculty!.SelectedItem as Faculty;

            if (selectedFaculty != null)
            {
                tbDisplay!.Text = "Bạn đã chọn khoa có mã : " + selectedFaculty.Id;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Faculty? selectedFaculty = cb_Faculty!.SelectedItem as Faculty;

            if (selectedFaculty != null)
            {
                tbDisplay!.Text = "Bạn đã chọn khoa có tên : " + selectedFaculty.Name;
            }
            else
            {
                tbDisplay!.Text = "Vui lòng chọn một khoa.";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            tbDisplay!.Clear();
        }
    }
}