namespace Project
{
    partial class StudentForm
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
            ScheduleBtn = new Button();
            CoursesBtn = new Button();
            ExitBtn = new Button();
            schedulePanel = new Panel();
            coursesTable = new DataGridView();
            CourseName = new DataGridViewTextBoxColumn();
            CourseDate = new DataGridViewTextBoxColumn();
            CourseTime = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label8 = new Label();
            totalCoursesLabel = new Label();
            profilePanel = new Panel();
            EditBtn = new Button();
            SaveBtn = new Button();
            label10 = new Label();
            label6 = new Label();
            phoneTextBox = new TextBox();
            addressTextBox = new TextBox();
            label4 = new Label();
            nameTextBox = new TextBox();
            idTextBox = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            ProfileBtn = new Button();
            schedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursesTable).BeginInit();
            profilePanel.SuspendLayout();
            SuspendLayout();
            // 
            // ScheduleBtn
            // 
            ScheduleBtn.BackColor = Color.Transparent;
            ScheduleBtn.Cursor = Cursors.Hand;
            ScheduleBtn.FlatAppearance.BorderSize = 0;
            ScheduleBtn.FlatStyle = FlatStyle.Flat;
            ScheduleBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScheduleBtn.ForeColor = Color.WhiteSmoke;
            ScheduleBtn.Location = new Point(-2, 264);
            ScheduleBtn.Name = "ScheduleBtn";
            ScheduleBtn.Size = new Size(212, 80);
            ScheduleBtn.TabIndex = 12;
            ScheduleBtn.Text = "Schedule";
            ScheduleBtn.UseVisualStyleBackColor = false;
            ScheduleBtn.Click += ScheduleBtn_Click;
            ScheduleBtn.MouseEnter += ScheduleBtn_MouseEnter;
            ScheduleBtn.MouseLeave += ScheduleBtn_MouseLeave;
            // 
            // CoursesBtn
            // 
            CoursesBtn.BackColor = Color.Transparent;
            CoursesBtn.Cursor = Cursors.Hand;
            CoursesBtn.FlatAppearance.BorderSize = 0;
            CoursesBtn.FlatStyle = FlatStyle.Flat;
            CoursesBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CoursesBtn.ForeColor = Color.WhiteSmoke;
            CoursesBtn.Location = new Point(-2, 344);
            CoursesBtn.Name = "CoursesBtn";
            CoursesBtn.Size = new Size(212, 80);
            CoursesBtn.TabIndex = 13;
            CoursesBtn.Text = "Courses";
            CoursesBtn.UseVisualStyleBackColor = false;
            CoursesBtn.Click += CoursesBtn_Click;
            CoursesBtn.MouseEnter += CoursesBtn_MouseEnter;
            CoursesBtn.MouseLeave += CoursesBtn_MouseLeave;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.ForeColor = SystemColors.ControlLight;
            ExitBtn.Location = new Point(-2, 0);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(38, 41);
            ExitBtn.TabIndex = 26;
            ExitBtn.Text = "X";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            ExitBtn.MouseEnter += ExitBtn_MouseEnter;
            ExitBtn.MouseLeave += ExitBtn_MouseLeave;
            // 
            // schedulePanel
            // 
            schedulePanel.BackColor = Color.FromArgb(3, 18, 28);
            schedulePanel.BorderStyle = BorderStyle.Fixed3D;
            schedulePanel.CausesValidation = false;
            schedulePanel.Controls.Add(coursesTable);
            schedulePanel.Controls.Add(label7);
            schedulePanel.Controls.Add(label8);
            schedulePanel.Controls.Add(totalCoursesLabel);
            schedulePanel.Location = new Point(198, 0);
            schedulePanel.Name = "schedulePanel";
            schedulePanel.Size = new Size(833, 573);
            schedulePanel.TabIndex = 16;
            // 
            // coursesTable
            // 
            coursesTable.AllowUserToAddRows = false;
            coursesTable.AllowUserToDeleteRows = false;
            coursesTable.AllowUserToResizeColumns = false;
            coursesTable.AllowUserToResizeRows = false;
            coursesTable.BackgroundColor = Color.FromArgb(3, 18, 28);
            coursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesTable.Columns.AddRange(new DataGridViewColumn[] { CourseName, CourseDate, CourseTime });
            coursesTable.GridColor = Color.Black;
            coursesTable.Location = new Point(7, 115);
            coursesTable.Name = "coursesTable";
            coursesTable.Size = new Size(804, 402);
            coursesTable.TabIndex = 10;
            // 
            // CourseName
            // 
            CourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseName.HeaderText = "Course Name";
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            // 
            // CourseDate
            // 
            CourseDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseDate.HeaderText = "Course Date";
            CourseDate.Name = "CourseDate";
            // 
            // CourseTime
            // 
            CourseTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseTime.HeaderText = "Course Time";
            CourseTime.Name = "CourseTime";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 33F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 6);
            label7.Name = "label7";
            label7.Size = new Size(562, 58);
            label7.TabIndex = 6;
            label7.Text = "Student Enrolled Courses :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20.25F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(11, 529);
            label8.Name = "label8";
            label8.Size = new Size(105, 31);
            label8.TabIndex = 9;
            label8.Text = "Total = ";
            // 
            // totalCoursesLabel
            // 
            totalCoursesLabel.AutoSize = true;
            totalCoursesLabel.Font = new Font("Microsoft Sans Serif", 20.25F);
            totalCoursesLabel.ForeColor = Color.White;
            totalCoursesLabel.Location = new Point(122, 529);
            totalCoursesLabel.Name = "totalCoursesLabel";
            totalCoursesLabel.Size = new Size(52, 31);
            totalCoursesLabel.TabIndex = 8;
            totalCoursesLabel.Text = ". . .";
            // 
            // profilePanel
            // 
            profilePanel.AccessibleRole = AccessibleRole.None;
            profilePanel.BackColor = Color.FromArgb(3, 18, 28);
            profilePanel.Controls.Add(EditBtn);
            profilePanel.Controls.Add(SaveBtn);
            profilePanel.Controls.Add(label10);
            profilePanel.Controls.Add(label6);
            profilePanel.Controls.Add(phoneTextBox);
            profilePanel.Controls.Add(addressTextBox);
            profilePanel.Controls.Add(label4);
            profilePanel.Controls.Add(nameTextBox);
            profilePanel.Controls.Add(idTextBox);
            profilePanel.Controls.Add(label5);
            profilePanel.Controls.Add(label3);
            profilePanel.Controls.Add(label2);
            profilePanel.Controls.Add(label1);
            profilePanel.Location = new Point(198, 0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(852, 623);
            profilePanel.TabIndex = 27;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Transparent;
            EditBtn.Cursor = Cursors.Hand;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            EditBtn.ForeColor = SystemColors.ControlLight;
            EditBtn.Location = new Point(575, 388);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(189, 64);
            EditBtn.TabIndex = 25;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            EditBtn.MouseEnter += EditBtn_MouseEnter;
            EditBtn.MouseLeave += ExitBtn_MouseLeave;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Transparent;
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            SaveBtn.ForeColor = SystemColors.ControlLight;
            SaveBtn.Location = new Point(575, 465);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(189, 64);
            SaveBtn.TabIndex = 18;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            SaveBtn.MouseEnter += SaveBtn_MouseEnter;
            SaveBtn.MouseLeave += SaveBtn_MouseLeave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(588, 147);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 24;
            label10.Text = "Student Profile :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(588, 178);
            label6.Name = "label6";
            label6.Size = new Size(141, 60);
            label6.TabIndex = 23;
            label6.Text = "Here you can see the \r\nstudent details and you \r\ncan also update his \r\ninformation.";
            // 
            // phoneTextBox
            // 
            phoneTextBox.BackColor = Color.FromArgb(3, 27, 40);
            phoneTextBox.BorderStyle = BorderStyle.None;
            phoneTextBox.Enabled = false;
            phoneTextBox.Font = new Font("Segoe UI", 18F);
            phoneTextBox.ForeColor = Color.WhiteSmoke;
            phoneTextBox.Location = new Point(220, 385);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(311, 32);
            phoneTextBox.TabIndex = 22;
            // 
            // addressTextBox
            // 
            addressTextBox.BackColor = Color.FromArgb(3, 27, 40);
            addressTextBox.BorderStyle = BorderStyle.None;
            addressTextBox.Enabled = false;
            addressTextBox.Font = new Font("Segoe UI", 18F);
            addressTextBox.ForeColor = Color.WhiteSmoke;
            addressTextBox.Location = new Point(220, 304);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(311, 32);
            addressTextBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(61, 295);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 20;
            label4.Text = "Address :";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(3, 27, 40);
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Enabled = false;
            nameTextBox.Font = new Font("Segoe UI", 18F);
            nameTextBox.ForeColor = Color.WhiteSmoke;
            nameTextBox.Location = new Point(220, 226);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(311, 32);
            nameTextBox.TabIndex = 19;
            // 
            // idTextBox
            // 
            idTextBox.BackColor = Color.FromArgb(3, 27, 40);
            idTextBox.BorderStyle = BorderStyle.None;
            idTextBox.Enabled = false;
            idTextBox.Font = new Font("Segoe UI", 18F);
            idTextBox.ForeColor = Color.WhiteSmoke;
            idTextBox.Location = new Point(220, 144);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(311, 32);
            idTextBox.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(61, 376);
            label5.Name = "label5";
            label5.Size = new Size(94, 32);
            label5.TabIndex = 16;
            label5.Text = "Phone :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 215);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 14;
            label3.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 144);
            label2.Name = "label2";
            label2.Size = new Size(49, 32);
            label2.TabIndex = 13;
            label2.Text = "ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(216, 9);
            label1.Name = "label1";
            label1.Size = new Size(385, 70);
            label1.TabIndex = 12;
            label1.Text = "Student Profile";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Ink Free", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(-2, 86);
            label9.Name = "label9";
            label9.Size = new Size(212, 60);
            label9.TabIndex = 17;
            label9.Text = "Student \r\n";
            // 
            // ProfileBtn
            // 
            ProfileBtn.BackColor = Color.Transparent;
            ProfileBtn.Cursor = Cursors.Hand;
            ProfileBtn.FlatAppearance.BorderSize = 0;
            ProfileBtn.FlatStyle = FlatStyle.Flat;
            ProfileBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileBtn.ForeColor = Color.WhiteSmoke;
            ProfileBtn.Location = new Point(-2, 184);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.RightToLeft = RightToLeft.No;
            ProfileBtn.Size = new Size(212, 80);
            ProfileBtn.TabIndex = 15;
            ProfileBtn.Text = "Profile";
            ProfileBtn.UseVisualStyleBackColor = false;
            ProfileBtn.Click += Profile_Click;
            ProfileBtn.MouseEnter += Profile_MouseEnter;
            ProfileBtn.MouseLeave += ProfileBtn_MouseLeave;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 150, 163);
            ClientSize = new Size(1019, 571);
            Controls.Add(profilePanel);
            Controls.Add(ExitBtn);
            Controls.Add(schedulePanel);
            Controls.Add(ScheduleBtn);
            Controls.Add(CoursesBtn);
            Controls.Add(ProfileBtn);
            Controls.Add(label9);
            ForeColor = SystemColors.MenuHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentForm";
            Text = "StudentForm";
            schedulePanel.ResumeLayout(false);
            schedulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coursesTable).EndInit();
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ScheduleBtn;
        private Button CoursesBtn;
        private Panel schedulePanel;
        private Label label7;
        private Label label8;
        private Label totalCoursesLabel;
        private Label label9;
        private Button ProfileBtn;
        private Button ExitBtn;
        private DataGridView coursesTable;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn CourseDate;
        private DataGridViewTextBoxColumn CourseTime;
        private Panel profilePanel;
        private Button EditBtn;
        private Button SaveBtn;
        private Label label10;
        private Label label6;
        private TextBox phoneTextBox;
        private TextBox addressTextBox;
        private Label label4;
        private TextBox nameTextBox;
        private TextBox idTextBox;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}