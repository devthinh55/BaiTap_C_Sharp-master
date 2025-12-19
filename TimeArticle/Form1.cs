namespace TimeArticle
{
    public partial class Form1 : Form
    {
        int second = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            // Thiết lập khoảng thời gian lặp lại là 1000ms (1 giây)
            tmStopwatch.Interval = 1000;
            tmStopwatch.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }
        
        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++;
            lblDisplay.Text = second.ToString();
        }
    }
}
