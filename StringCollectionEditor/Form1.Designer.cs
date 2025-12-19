using System;
using System.Windows.Forms;

namespace StringCollectionEditor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lbSong = new ListBox();
            lbFavorite = new ListBox();
            btSelect = new Button();
            btDeselect = new Button();
            btSelectAll = new Button();
            btDeselectAll = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbSong
            // 
            lbSong.FormattingEnabled = true;
            lbSong.Items.AddRange(new object[] { "Giấc mơ Chapi", "Đôi Mắt Pleiku", "Em Muốn Sống Bên Anh Trọn Đời", "H'Zen Lên Rẫy", "Còn Thương Nhau Thì Về Buôn Mê Thuột", "Ly Cà Phê Ban Mê", "Đi tìm lời ru mặt trời" });
            lbSong.Location = new Point(12, 34);
            lbSong.Name = "lbSong";
            lbSong.Size = new Size(330, 424);
            lbSong.TabIndex = 1;
            lbSong.MouseDoubleClick += lbSong_MouseDoubleClick;
            // 
            // lbFavorite
            // 
            lbFavorite.FormattingEnabled = true;
            lbFavorite.Location = new Point(438, 34);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(330, 424);
            lbFavorite.TabIndex = 2;
            lbFavorite.MouseDoubleClick += lbFavorite_MouseDoubleCick;
            // 
            // btSelect
            // 
            btSelect.Location = new Point(363, 113);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(56, 53);
            btSelect.TabIndex = 3;
            btSelect.Text = ">";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // btDeselect
            // 
            btDeselect.Location = new Point(363, 172);
            btDeselect.Name = "btDeselect";
            btDeselect.Size = new Size(56, 53);
            btDeselect.TabIndex = 4;
            btDeselect.Text = "<";
            btDeselect.UseVisualStyleBackColor = true;
            btDeselect.Click += btDeselect_Click;
            // 
            // btSelectAll
            // 
            btSelectAll.Location = new Point(363, 231);
            btSelectAll.Name = "btSelectAll";
            btSelectAll.Size = new Size(56, 53);
            btSelectAll.TabIndex = 5;
            btSelectAll.Text = ">>";
            btSelectAll.UseVisualStyleBackColor = true;
            btSelectAll.Click += btSelectAll_Click;
            // 
            // btDeselectAll
            // 
            btDeselectAll.Location = new Point(363, 290);
            btDeselectAll.Name = "btDeselectAll";
            btDeselectAll.Size = new Size(56, 53);
            btDeselectAll.TabIndex = 6;
            btDeselectAll.Text = "<<";
            btDeselectAll.UseVisualStyleBackColor = true;
            btDeselectAll.Click += btDeselectAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 7;
            label1.Text = "Danh sách bài hát ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 11);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 8;
            label2.Text = "Danh sách bài hát yêu thích";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btDeselectAll);
            Controls.Add(btSelectAll);
            Controls.Add(btDeselect);
            Controls.Add(btSelect);
            Controls.Add(lbFavorite);
            Controls.Add(lbSong);
            Name = "Form1";
            Text = "Music List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion // Đặt lại #endregion

        // Khai báo biến Controls (Đã được khôi phục)
        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btDeselectAll;
        private Label label1;
        private Label label2;
    }
}