using Caculator;
using MyCalculator;
using PictureBox;
using PictureBox_Move;
using QLSV_2;
using StringCollectionEditor;
using TimeArticle;
using TinhTien;

namespace Menu_BaiTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCaculator_Click(object sender, EventArgs e)
        {
           Caculator.Form1 ca = new Caculator.Form1();
            ca.ShowDialog();
        }

       
        private void btnMyCalculator_Click(object sender, EventArgs e)
        {
            MyCalculator.Form1 mc = new MyCalculator.Form1();
            mc.ShowDialog();
        }

        private void btnPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox.Form1 pb = new PictureBox.Form1();
            pb.ShowDialog();
        }

     
        private void btnPictureBox_Move_Click(object sender, EventArgs e)
        {
            PictureBox_Move.Form1 pbm = new PictureBox_Move.Form1();
            pbm.ShowDialog();
        }

        private void btnQLSV_2_Click(object sender, EventArgs e)
        {
            QLSV_2.Form1 qlsv = new QLSV_2.Form1();
            qlsv.ShowDialog();
        }

        private void btnStringCollectionEditor_Click(object sender, EventArgs e)
        {
            StringCollectionEditor.Form1 sce = new StringCollectionEditor.Form1();
            sce.ShowDialog();
        }

        private void btnTimeArticle_Click(object sender, EventArgs e)
        {
            TimeArticle.Form1 ta = new TimeArticle.Form1();
            ta.ShowDialog();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            TinhTien.Form1 tt = new TinhTien.Form1();
            tt.ShowDialog();
        }
        // Cap nhat menu daaddass
    }
}
