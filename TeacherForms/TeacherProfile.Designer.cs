namespace Project
{
    partial class TeacherProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherProfile));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            NumberChange = new Label();
            label4 = new Label();
            ChangeEmail = new Label();
            changeAddress = new Label();
            Address = new Label();
            UserNameTxt = new TextBox();
            PasswordName = new TextBox();
            label3 = new Label();
            label6 = new Label();
            UpdateProfileBtn = new Button();
            DoneBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 106);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(329, 12);
            label1.Name = "label1";
            label1.Size = new Size(301, 54);
            label1.TabIndex = 1;
            label1.Text = "Teacher Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(35, 315);
            label2.Margin = new Padding(30, 30, 10, 10);
            label2.Name = "label2";
            label2.Size = new Size(137, 62);
            label2.TabIndex = 3;
            label2.Text = "Number of Courses : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // NumberChange
            // 
            NumberChange.AutoSize = true;
            NumberChange.BackColor = Color.Transparent;
            NumberChange.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            NumberChange.Location = new Point(291, 315);
            NumberChange.Margin = new Padding(30, 30, 10, 10);
            NumberChange.Name = "NumberChange";
            NumberChange.Size = new Size(67, 31);
            NumberChange.TabIndex = 5;
            NumberChange.Text = "Num";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(35, 35);
            label4.Margin = new Padding(30, 30, 10, 10);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(94, 31);
            label4.TabIndex = 7;
            label4.Text = "Phone :";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChangeEmail
            // 
            ChangeEmail.AutoSize = true;
            ChangeEmail.BackColor = Color.Transparent;
            ChangeEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            ChangeEmail.Location = new Point(291, 35);
            ChangeEmail.Margin = new Padding(30, 30, 10, 10);
            ChangeEmail.Name = "ChangeEmail";
            ChangeEmail.Size = new Size(168, 31);
            ChangeEmail.TabIndex = 8;
            ChangeEmail.Text = "Phone Change";
            // 
            // changeAddress
            // 
            changeAddress.AutoSize = true;
            changeAddress.BackColor = Color.Transparent;
            changeAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            changeAddress.Location = new Point(291, 158);
            changeAddress.Margin = new Padding(30, 30, 10, 10);
            changeAddress.Name = "changeAddress";
            changeAddress.Size = new Size(166, 62);
            changeAddress.TabIndex = 10;
            changeAddress.Text = "changeAddress";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            Address.Location = new Point(35, 158);
            Address.Margin = new Padding(30, 30, 10, 10);
            Address.Name = "Address";
            Address.Size = new Size(111, 31);
            Address.TabIndex = 9;
            Address.Text = "Address :";
            // 
            // UserNameTxt
            // 
            UserNameTxt.BackColor = SystemColors.Info;
            UserNameTxt.BorderStyle = BorderStyle.None;
            UserNameTxt.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTxt.Location = new Point(91, 291);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(216, 31);
            UserNameTxt.TabIndex = 13;
            UserNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordName
            // 
            PasswordName.BackColor = SystemColors.Info;
            PasswordName.BorderStyle = BorderStyle.None;
            PasswordName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordName.Location = new Point(91, 385);
            PasswordName.Name = "PasswordName";
            PasswordName.Size = new Size(216, 31);
            PasswordName.TabIndex = 14;
            PasswordName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(137, 250);
            label3.Name = "label3";
            label3.Size = new Size(125, 31);
            label3.TabIndex = 15;
            label3.Text = "UserName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(137, 337);
            label6.Name = "label6";
            label6.Size = new Size(115, 31);
            label6.TabIndex = 16;
            label6.Text = "password";
            // 
            // UpdateProfileBtn
            // 
            UpdateProfileBtn.BackColor = SystemColors.HotTrack;
            UpdateProfileBtn.Cursor = Cursors.Hand;
            UpdateProfileBtn.FlatStyle = FlatStyle.Flat;
            UpdateProfileBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            UpdateProfileBtn.ForeColor = SystemColors.ButtonHighlight;
            UpdateProfileBtn.Location = new Point(91, 443);
            UpdateProfileBtn.Name = "UpdateProfileBtn";
            UpdateProfileBtn.Size = new Size(201, 74);
            UpdateProfileBtn.TabIndex = 17;
            UpdateProfileBtn.Text = "Update Profile";
            UpdateProfileBtn.UseVisualStyleBackColor = false;
            UpdateProfileBtn.Click += UpdateProfileBtn_Click;
            // 
            // DoneBtn
            // 
            DoneBtn.BackColor = SystemColors.HotTrack;
            DoneBtn.Cursor = Cursors.Hand;
            DoneBtn.FlatStyle = FlatStyle.Flat;
            DoneBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            DoneBtn.ForeColor = SystemColors.ButtonHighlight;
            DoneBtn.Location = new Point(124, 535);
            DoneBtn.Name = "DoneBtn";
            DoneBtn.Size = new Size(138, 42);
            DoneBtn.TabIndex = 18;
            DoneBtn.Text = "Done";
            DoneBtn.UseVisualStyleBackColor = false;
            DoneBtn.Click += DoneBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.BackColor = SystemColors.Highlight;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.65313F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.34687F));
            tableLayoutPanel1.Controls.Add(ChangeEmail, 1, 0);
            tableLayoutPanel1.Controls.Add(changeAddress, 1, 1);
            tableLayoutPanel1.Controls.Add(Address, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(NumberChange, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Font = new Font("Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 2);
            tableLayoutPanel1.ForeColor = Color.FromArgb(0, 0, 64);
            tableLayoutPanel1.Location = new Point(390, 140);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 154F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(477, 411);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // TeacherProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 653);
            Controls.Add(DoneBtn);
            Controls.Add(UpdateProfileBtn);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(PasswordName);
            Controls.Add(UserNameTxt);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TeacherProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        internal Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label NumberChange;
        private Label label4;
        private Label ChangeEmail;
        private Label changeAddress;
        private Label Address;
        private TextBox UserNameTxt;
        private TextBox PasswordName;
        private Label label3;
        private Label label6;
        private Button UpdateProfileBtn;
        private Button DoneBtn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}