namespace PictureBox_Move
{
    public partial class Form1 : Form
    {
        PictureBox pb = new PictureBox();
        int x = 0;
        int y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(150, 150);
            pb.Location = new Point(x, y); 
            pb.BorderStyle = BorderStyle.FixedSingle; 

            if (!this.Controls.Contains(pb))
            {
                this.Controls.Add(pb);
            }

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chọn ảnh từ máy tính";
            dlg.Filter = "Image Files(*.jpg; *.png)|*.jpg; *.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Gán đường dẫn file vào đối tượng 'pb'
                pb.ImageLocation = dlg.FileName;
            }
        }
        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10;
            pb.Location = new Point(x, y);
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10;
            pb.Location = new Point(x, y);
        }
    }
}
