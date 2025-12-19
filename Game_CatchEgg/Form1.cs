using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_CatchEgg
{
    public partial class Form1 : Form
    {
        PictureBox pbBasket = new PictureBox();
        PictureBox pbEgg = new PictureBox();
        PictureBox pbChicken = new PictureBox();
        Label lblScore = new Label();
        Button btnReset = new Button(); // Nút chơi lại

        // Timer điều khiển gà (Timer tmEgg lấy từ Toolbox Designer)
        System.Windows.Forms.Timer tmChicken = new System.Windows.Forms.Timer();

        // Tọa độ và tốc độ chuẩns
        int xBasket = 250, yBasket, xDeltaBasket = 25; 
        int xChicken = 300, yChicken = 10, xDeltaChicken = 5;
        int xEgg = 300, yEgg = 10, yDeltaEgg = 5;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.KeyDown += Form1_KeyDown;

            tmChicken.Interval = 10;
            tmChicken.Tick += tmChiken_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(600, 650);
            this.Text = "Catch Egg Game";
            this.KeyPreview = true;

            lblScore.Text = "Score: 0";
            lblScore.Font = new Font("Arial", 16, FontStyle.Bold);
            lblScore.AutoSize = true;
            lblScore.Location = new Point(10, 10);
            this.Controls.Add(lblScore);
            lblScore.BringToFront();

            yBasket = this.ClientSize.Height - 120;

            SetupGameObject(pbBasket, new Size(120, 120),
                new Point(xBasket, yBasket),
                "../../../Images/basket.png");

            SetupGameObject(pbChicken, new Size(100, 100),
                new Point(xChicken, yChicken),
                "../../../Images/chicken.png");

            SetupGameObject(pbEgg, new Size(40, 40),
                new Point(xEgg, yEgg),
                "../../../Images/egg_gold.png");

            btnReset.Text = "Chơi lại";
            btnReset.Size = new Size(100, 40);
            btnReset.Location = new Point(this.ClientSize.Width - 110, 10);
            btnReset.Font = new Font("Arial", 10, FontStyle.Bold);
            btnReset.BackColor = Color.LightGray;
            btnReset.TabStop = false;
            btnReset.Click += BtnReset_Click;
            this.Controls.Add(btnReset);
            btnReset.BringToFront();

            btnReset.PreviewKeyDown += (s, ev) => {
                if (ev.KeyCode == Keys.Left || ev.KeyCode == Keys.Right ||
                    ev.KeyCode == Keys.Up || ev.KeyCode == Keys.Down)
                {
                    ev.IsInputKey = true; // Cho phép các phím mũi tên truyền tín hiệu đến Form
                }
            };

            pbBasket.BringToFront();

            tmEgg.Interval = 10;
            tmEgg.Start();
            tmChicken.Start();

            this.ActiveControl = null;
            this.Focus();              
        }

        private void SetupGameObject(PictureBox pb, Size size, Point loc, string imgPath)
        {
            pb.Size = size;
            pb.Location = loc;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.BackColor = Color.Transparent;

            try { pb.Image = Image.FromFile(imgPath); }
            catch { }

            this.Controls.Add(pb);
        }

        private void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDeltaEgg;

            if (pbEgg.Bounds.IntersectsWith(pbBasket.Bounds))
            {
                score += 10;
                lblScore.Text = "Score: " + score;
                ResetEgg();
            }

            if(yEgg > this.ClientSize.Height - pbEgg.Height)
{
                tmEgg.Stop();
                tmChicken.Stop();

            
                try
                {
                    pbEgg.Image = Image.FromFile("../../../Images/egg_gold_broken.png");
                }
                catch
                {
                    try
                    {
                        pbEgg.Image = Image.FromFile("Images/egg_gold_broken.png");
                    }
                    catch { }
                }

                MessageBox.Show("Game Over! Điểm của bạn: " + score);
            }


            pbEgg.Location = new Point(xEgg, yEgg);
        }

        private void tmChiken_Tick(object sender, EventArgs e)
        {
            xChicken += xDeltaChicken;

            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
                xDeltaChicken = -xDeltaChicken;

            pbChicken.Location = new Point(xChicken, yChicken);
        }

        private void ResetEgg()
        {
            xEgg = xChicken + 30;
            yEgg = yChicken + 40;
            pbEgg.Location = new Point(xEgg, yEgg);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 && xBasket < this.ClientSize.Width - pbBasket.Width)
                xBasket += xDeltaBasket;

            if (e.KeyValue == 37 && xBasket > 0)
                xBasket -= xDeltaBasket;

            pbBasket.Location = new Point(xBasket, yBasket);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            score = 0;
            lblScore.Text = "Score: 0";
            xChicken = 300;
            yChicken = 10;
            xBasket = 250;

            try { pbEgg.Image = Image.FromFile("../../../Images/egg_gold.png"); } catch { }

            ResetEgg();

            tmEgg.Start();
            tmChicken.Start();

            // Ép Form nhận lại quyền điều khiển bàn phím
            this.ActiveControl = null;
            this.Focus();
        }
    }
}
