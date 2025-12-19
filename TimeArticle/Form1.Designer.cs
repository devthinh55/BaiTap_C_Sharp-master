namespace TimeArticle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblDisplay = new Label();
            btStart = new Button();
            btStop = new Button();
            tmStopwatch = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplay.Location = new Point(162, 70);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(197, 89);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "00:00";
            // 
            // btStart
            // 
            btStart.Location = new Point(143, 191);
            btStart.Name = "btStart";
            btStart.Size = new Size(101, 41);
            btStart.TabIndex = 1;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.Location = new Point(258, 191);
            btStop.Name = "btStop";
            btStop.Size = new Size(101, 41);
            btStop.TabIndex = 2;
            btStop.Text = "Stop";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // tmStopwatch
            // 
            tmStopwatch.Tick += tmStopwatch_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 450);
            Controls.Add(btStop);
            Controls.Add(btStart);
            Controls.Add(lblDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDisplay;
        private Button btStart;
        private Button btStop;
        private System.Windows.Forms.Timer tmStopwatch;
    }
}
