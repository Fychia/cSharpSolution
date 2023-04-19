namespace PharmacyManagement
{
    partial class Load
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
            loadProgressbar = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            timerLoad = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // loadProgressbar
            // 
            loadProgressbar.BackColor = Color.MintCream;
            loadProgressbar.Location = new Point(12, 533);
            loadProgressbar.Name = "loadProgressbar";
            loadProgressbar.Size = new Size(1078, 23);
            loadProgressbar.TabIndex = 0;
            loadProgressbar.Click += progressBar1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 24);
            label1.TabIndex = 1;
            label1.Text = "Pharmacy";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1018, 514);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 2;
            label2.Text = "Version 1.0";
            // 
            // timerLoad
            // 
            timerLoad.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1101, 564);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loadProgressbar);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pharmacy Management";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar loadProgressbar;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timerLoad;
    }
}