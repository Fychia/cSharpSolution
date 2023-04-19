namespace PharmacyManagement
{
    partial class Login
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
            label1 = new Label();
            txt_Password = new TextBox();
            txt_UserID = new TextBox();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(81, 26);
            label1.Name = "label1";
            label1.Size = new Size(126, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // txt_Password
            // 
            txt_Password.Cursor = Cursors.Hand;
            txt_Password.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.ForeColor = Color.MidnightBlue;
            txt_Password.Location = new Point(35, 175);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "Password";
            txt_Password.Size = new Size(217, 34);
            txt_Password.TabIndex = 3;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_UserID
            // 
            txt_UserID.Cursor = Cursors.Hand;
            txt_UserID.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_UserID.ForeColor = Color.MidnightBlue;
            txt_UserID.Location = new Point(35, 112);
            txt_UserID.Name = "txt_UserID";
            txt_UserID.PlaceholderText = "User ID";
            txt_UserID.Size = new Size(217, 34);
            txt_UserID.TabIndex = 4;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.MidnightBlue;
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.FlatStyle = FlatStyle.Popup;
            btn_Login.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.ForeColor = SystemColors.Window;
            btn_Login.Location = new Point(69, 234);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(149, 35);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Sign In";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 314);
            Controls.Add(btn_Login);
            Controls.Add(txt_UserID);
            Controls.Add(txt_Password);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Password;
        private TextBox txt_UserID;
        private Button btn_Login;
    }
}