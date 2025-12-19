using static System.Net.Mime.MediaTypeNames;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //cách 1: gán trực tiếp đường dẫn cố định(dùng để test nhanh)

        //private void btfile_click(object sender, eventargs e)
        //{
        //    // thiết lập chế độ hiển thị ảnh vừa khít với picturebox
        //    pbimage.sizemode = pictureboxsizemode.stretchimage;

        //    // gán đường dẫn trực tiếp (lưu ý: file d:\abc.jpg phải tồn tại)
        //    pbimage.imagelocation = @"d:\abc.jpg";
        //}


        //Cách 2: Dùng OpenFileDialog
        private void btFile_Click(object sender, EventArgs e)
        {
            // Thiết lập chế độ hiển thị ảnh co giãn theo khung
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";

            dlg.Filter = "JPEG files (*.jpg)|*.jpg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Gán đường dẫn file đã chọn vào PictureBox
                pbImage.ImageLocation = dlg.FileName;
            }
        }
    }
}
