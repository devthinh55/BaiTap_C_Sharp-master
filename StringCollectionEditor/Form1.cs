using System.Windows.Forms;
using System;

namespace StringCollectionEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                string song = lbSong.SelectedItem.ToString()!;
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }
        }

        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                string song = lbSong.SelectedItem.ToString()!;
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }
        }

        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                string song = lbFavorite.SelectedItem.ToString()!;
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        private void lbFavorite_MouseDoubleCick(object sender, MouseEventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                string song = lbFavorite.SelectedItem.ToString()!;
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            // dếm ngược để tránh lỗi index khi xóa
            for (int i = lbSong.Items.Count - 1; i >= 0; i--)
            {
                string song = lbSong.Items[i].ToString()!;
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(i);
            }
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            // Đếm ngược để tránh lỗi index khi xóa
            for (int i = lbFavorite.Items.Count - 1; i >= 0; i--)
            {
                string song = lbFavorite.Items[i].ToString()!;
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(i);
            }
        }
    }
}