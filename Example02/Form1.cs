using System.Xml.Serialization;

namespace Example02
{
    public partial class Form1 : Form
    {
        string path = @"D:\form.xml";
        Windows iw = new InfoWindows();
        public Form1()
        {
            InitializeComponent();
        }
       
        public void Write(InfoWindows iw)
        {
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }
        
        public InfoWindows Read()
        {
            XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
            StreamReader file = new StreamReader(path);
            InfoWindows iw = (InfoWindows)reader.Deserialize(file);
            file.Close();
            return iw;
        }

        void Form1_ResizeEnd(object sender, System.EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }
        void Form1_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw = Read();
            this.Width = iw.Width;
            this.Height = iw.Height;
            this.Location = iw.Location;
            Write(iw);
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Size.Location;
            Write(iw);
        }

    }
}
