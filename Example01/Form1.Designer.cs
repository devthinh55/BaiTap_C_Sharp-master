namespace Example01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
      
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            label1 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(32, 99);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(140, 98);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "Nguyen Tuan";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(419, 44);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(346, 23);
            comboBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(32, 193);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(346, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            listBox1.Location = new Point(32, 246);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(116, 94);
            listBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(265, 393);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 9;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(370, 393);
            button2.Name = "button2";
            button2.Size = new Size(87, 23);
            button2.TabIndex = 10;
            button2.Text = "Ok";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private Label label1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}