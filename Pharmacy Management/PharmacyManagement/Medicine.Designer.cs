namespace PharmacyManagement
{
    partial class Medicine
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            MedicineName = new DataGridViewTextBoxColumn();
            BuyingPrice = new DataGridViewTextBoxColumn();
            SellingPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ExpiredDate = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tb_MedicineName = new TextBox();
            tb_BuyingPrice = new TextBox();
            tb_SellingPrice = new TextBox();
            tb_Quantity = new TextBox();
            ExpireDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cb_Company = new ComboBox();
            btn_Delete = new Button();
            btn_Add = new Button();
            btn_Update = new Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(322, 23);
            label1.Name = "label1";
            label1.Size = new Size(374, 56);
            label1.TabIndex = 0;
            label1.Text = "Medicine Stock";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ScrollBar;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MedicineName, BuyingPrice, SellingPrice, Quantity, ExpiredDate, Company });
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(428, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(790, 530);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MedicineName
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MedicineName.DefaultCellStyle = dataGridViewCellStyle9;
            MedicineName.HeaderText = "Medicine";
            MedicineName.Name = "MedicineName";
            MedicineName.Width = 200;
            // 
            // BuyingPrice
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BuyingPrice.DefaultCellStyle = dataGridViewCellStyle10;
            BuyingPrice.HeaderText = "Buying Price";
            BuyingPrice.Name = "BuyingPrice";
            // 
            // SellingPrice
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SellingPrice.DefaultCellStyle = dataGridViewCellStyle11;
            SellingPrice.HeaderText = "Selling Price";
            SellingPrice.Name = "SellingPrice";
            // 
            // Quantity
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Quantity.DefaultCellStyle = dataGridViewCellStyle12;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // ExpiredDate
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ExpiredDate.DefaultCellStyle = dataGridViewCellStyle13;
            ExpiredDate.HeaderText = "Expire Date";
            ExpiredDate.Name = "ExpiredDate";
            // 
            // Company
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Company.DefaultCellStyle = dataGridViewCellStyle14;
            Company.HeaderText = "Company";
            Company.Name = "Company";
            Company.Width = 150;
            // 
            // tb_MedicineName
            // 
            tb_MedicineName.BackColor = SystemColors.Window;
            tb_MedicineName.BorderStyle = BorderStyle.FixedSingle;
            tb_MedicineName.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_MedicineName.Location = new Point(27, 143);
            tb_MedicineName.Name = "tb_MedicineName";
            tb_MedicineName.PlaceholderText = "Medicine Name";
            tb_MedicineName.Size = new Size(373, 32);
            tb_MedicineName.TabIndex = 9;
            tb_MedicineName.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_BuyingPrice
            // 
            tb_BuyingPrice.BackColor = SystemColors.Window;
            tb_BuyingPrice.BorderStyle = BorderStyle.FixedSingle;
            tb_BuyingPrice.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_BuyingPrice.Location = new Point(27, 192);
            tb_BuyingPrice.Name = "tb_BuyingPrice";
            tb_BuyingPrice.PlaceholderText = "Buying Price";
            tb_BuyingPrice.Size = new Size(373, 32);
            tb_BuyingPrice.TabIndex = 10;
            tb_BuyingPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_SellingPrice
            // 
            tb_SellingPrice.BackColor = SystemColors.Window;
            tb_SellingPrice.BorderStyle = BorderStyle.FixedSingle;
            tb_SellingPrice.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_SellingPrice.Location = new Point(27, 240);
            tb_SellingPrice.Name = "tb_SellingPrice";
            tb_SellingPrice.PlaceholderText = "Selling Price";
            tb_SellingPrice.Size = new Size(373, 32);
            tb_SellingPrice.TabIndex = 11;
            tb_SellingPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_Quantity
            // 
            tb_Quantity.BackColor = SystemColors.Window;
            tb_Quantity.BorderStyle = BorderStyle.FixedSingle;
            tb_Quantity.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Quantity.Location = new Point(27, 287);
            tb_Quantity.Name = "tb_Quantity";
            tb_Quantity.PlaceholderText = "Quantity";
            tb_Quantity.Size = new Size(373, 32);
            tb_Quantity.TabIndex = 12;
            tb_Quantity.TextAlign = HorizontalAlignment.Center;
            tb_Quantity.TextChanged += textBox2_TextChanged;
            // 
            // ExpireDate
            // 
            ExpireDate.CalendarFont = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExpireDate.CalendarMonthBackground = SystemColors.ScrollBar;
            ExpireDate.Cursor = Cursors.Cross;
            ExpireDate.DropDownAlign = LeftRightAlignment.Right;
            ExpireDate.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExpireDate.Format = DateTimePickerFormat.Short;
            ExpireDate.Location = new Point(27, 373);
            ExpireDate.Name = "ExpireDate";
            ExpireDate.RightToLeft = RightToLeft.No;
            ExpireDate.RightToLeftLayout = true;
            ExpireDate.Size = new Size(373, 32);
            ExpireDate.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(130, 331);
            label2.Name = "label2";
            label2.Size = new Size(164, 24);
            label2.TabIndex = 14;
            label2.Text = "Expiration Date";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(132, 107);
            label3.Name = "label3";
            label3.Size = new Size(162, 24);
            label3.TabIndex = 15;
            label3.Text = "Product details";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(153, 418);
            label4.Name = "label4";
            label4.Size = new Size(106, 24);
            label4.TabIndex = 16;
            label4.Text = "Company";
            label4.Click += label4_Click;
            // 
            // cb_Company
            // 
            cb_Company.FormattingEnabled = true;
            cb_Company.Location = new Point(27, 455);
            cb_Company.Name = "cb_Company";
            cb_Company.Size = new Size(373, 23);
            cb_Company.TabIndex = 17;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = SystemColors.ScrollBar;
            btn_Delete.FlatAppearance.BorderColor = Color.Black;
            btn_Delete.FlatAppearance.BorderSize = 3;
            btn_Delete.FlatStyle = FlatStyle.System;
            btn_Delete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Delete.Location = new Point(27, 563);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(118, 36);
            btn_Delete.TabIndex = 18;
            btn_Delete.Text = "DELETE";
            btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = SystemColors.ScrollBar;
            btn_Add.FlatStyle = FlatStyle.System;
            btn_Add.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.Location = new Point(132, 521);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(162, 36);
            btn_Add.TabIndex = 19;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += button2_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = SystemColors.ScrollBar;
            btn_Update.FlatAppearance.BorderColor = Color.Black;
            btn_Update.FlatAppearance.BorderSize = 3;
            btn_Update.FlatStyle = FlatStyle.System;
            btn_Update.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Update.Location = new Point(282, 563);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(118, 36);
            btn_Update.TabIndex = 20;
            btn_Update.Text = "UPDATE";
            btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ScrollBar;
            btn_back.FlatAppearance.BorderColor = Color.Black;
            btn_back.FlatAppearance.BorderSize = 3;
            btn_back.FlatStyle = FlatStyle.System;
            btn_back.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(37, 36);
            btn_back.TabIndex = 21;
            btn_back.Text = "<";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // Medicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1230, 664);
            Controls.Add(btn_back);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Controls.Add(btn_Delete);
            Controls.Add(cb_Company);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ExpireDate);
            Controls.Add(tb_Quantity);
            Controls.Add(tb_SellingPrice);
            Controls.Add(tb_BuyingPrice);
            Controls.Add(tb_MedicineName);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Medicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pharmacy Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox tb_MedicineName;
        private TextBox tb_BuyingPrice;
        private TextBox tb_SellingPrice;
        private TextBox tb_Quantity;
        private DateTimePicker ExpireDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cb_Company;
        private Button btn_Delete;
        private Button btn_Add;
        private Button btn_Update;
        private Button btn_back;
        private DataGridViewTextBoxColumn MedicineName;
        private DataGridViewTextBoxColumn BuyingPrice;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ExpiredDate;
        private DataGridViewTextBoxColumn Company;
    }
}