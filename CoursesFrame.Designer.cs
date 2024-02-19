namespace Project
{
    partial class CoursesFrame
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
            EnrollBtn = new Button();
            EnrolledCoursesBtn = new Button();
            PaymentBtn = new Button();
            label6 = new Label();
            enrolledCoursesPanel = new Panel();
            label10 = new Label();
            studentEnrolledTable = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            paymentPanel = new Panel();
            label7 = new Label();
            label14 = new Label();
            totalCostLabel = new Label();
            label12 = new Label();
            enrollPanel = new Panel();
            costLabel = new Label();
            courseNameLbl = new Label();
            studentNamelbl = new Label();
            label8 = new Label();
            ConfirmButton = new Button();
            ClearBtn = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            coursesTable = new DataGridView();
            CourseName = new DataGridViewTextBoxColumn();
            CourseDescription = new DataGridViewTextBoxColumn();
            CourseCapacity = new DataGridViewTextBoxColumn();
            SessionNumber = new DataGridViewTextBoxColumn();
            courseFees = new DataGridViewTextBoxColumn();
            label2 = new Label();
            allCoursesComboBox = new ComboBox();
            nameLabel = new Label();
            ExitBtn = new Button();
            courseLabel = new Label();
            enrolledCoursesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentEnrolledTable).BeginInit();
            paymentPanel.SuspendLayout();
            enrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursesTable).BeginInit();
            SuspendLayout();
            // 
            // EnrollBtn
            // 
            EnrollBtn.FlatAppearance.BorderSize = 0;
            EnrollBtn.FlatStyle = FlatStyle.Flat;
            EnrollBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            EnrollBtn.ForeColor = Color.WhiteSmoke;
            EnrollBtn.Location = new Point(-1, 181);
            EnrollBtn.Name = "EnrollBtn";
            EnrollBtn.Size = new Size(199, 80);
            EnrollBtn.TabIndex = 14;
            EnrollBtn.Text = "Enroll";
            EnrollBtn.UseVisualStyleBackColor = true;
            EnrollBtn.Click += EnrollBtn_Click;
            EnrollBtn.MouseEnter += EnrollBtn_MouseEnter;
            EnrollBtn.MouseLeave += EnrollBtn_MouseLeave;
            // 
            // EnrolledCoursesBtn
            // 
            EnrolledCoursesBtn.FlatAppearance.BorderSize = 0;
            EnrolledCoursesBtn.FlatStyle = FlatStyle.Flat;
            EnrolledCoursesBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            EnrolledCoursesBtn.ForeColor = Color.WhiteSmoke;
            EnrolledCoursesBtn.Location = new Point(-1, 259);
            EnrolledCoursesBtn.Name = "EnrolledCoursesBtn";
            EnrolledCoursesBtn.Size = new Size(199, 80);
            EnrolledCoursesBtn.TabIndex = 15;
            EnrolledCoursesBtn.Text = "Enrolled Courses";
            EnrolledCoursesBtn.UseVisualStyleBackColor = true;
            EnrolledCoursesBtn.Click += EnrolledCoursesBtn_Click;
            EnrolledCoursesBtn.MouseEnter += EnrolledCoursesBtn_MouseEnter;
            EnrolledCoursesBtn.MouseLeave += EnrolledCoursesBtn_MouseLeave;
            // 
            // PaymentBtn
            // 
            PaymentBtn.FlatAppearance.BorderSize = 0;
            PaymentBtn.FlatStyle = FlatStyle.Flat;
            PaymentBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            PaymentBtn.ForeColor = Color.WhiteSmoke;
            PaymentBtn.Location = new Point(-1, 337);
            PaymentBtn.Name = "PaymentBtn";
            PaymentBtn.Size = new Size(199, 80);
            PaymentBtn.TabIndex = 20;
            PaymentBtn.Text = "Payment";
            PaymentBtn.UseVisualStyleBackColor = true;
            PaymentBtn.Click += PaymentBtn_Click;
            PaymentBtn.MouseEnter += PaymentBtn_MouseEnter;
            PaymentBtn.MouseLeave += PaymentBtn_MouseLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Ink Free", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(3, 90);
            label6.Name = "label6";
            label6.Size = new Size(187, 60);
            label6.TabIndex = 21;
            label6.Text = "Courses";
            // 
            // enrolledCoursesPanel
            // 
            enrolledCoursesPanel.BackColor = Color.FromArgb(3, 18, 28);
            enrolledCoursesPanel.Controls.Add(label10);
            enrolledCoursesPanel.Controls.Add(studentEnrolledTable);
            enrolledCoursesPanel.Location = new Point(196, -1);
            enrolledCoursesPanel.Name = "enrolledCoursesPanel";
            enrolledCoursesPanel.Size = new Size(829, 584);
            enrolledCoursesPanel.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Emoji", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(81, 10);
            label10.Name = "label10";
            label10.Size = new Size(629, 70);
            label10.TabIndex = 22;
            label10.Text = "Student Enrolled Courses";
            // 
            // studentEnrolledTable
            // 
            studentEnrolledTable.AllowUserToAddRows = false;
            studentEnrolledTable.AllowUserToDeleteRows = false;
            studentEnrolledTable.AllowUserToResizeColumns = false;
            studentEnrolledTable.AllowUserToResizeRows = false;
            studentEnrolledTable.BackgroundColor = Color.FromArgb(3, 18, 28);
            studentEnrolledTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentEnrolledTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            studentEnrolledTable.GridColor = Color.Black;
            studentEnrolledTable.Location = new Point(1, 83);
            studentEnrolledTable.Name = "studentEnrolledTable";
            studentEnrolledTable.Size = new Size(825, 466);
            studentEnrolledTable.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Course Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Description";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Capacity";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Session Number";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Fees";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // paymentPanel
            // 
            paymentPanel.BackColor = Color.FromArgb(3, 18, 28);
            paymentPanel.Controls.Add(label7);
            paymentPanel.Controls.Add(label14);
            paymentPanel.Controls.Add(totalCostLabel);
            paymentPanel.Controls.Add(label12);
            paymentPanel.Location = new Point(196, -1);
            paymentPanel.Name = "paymentPanel";
            paymentPanel.Size = new Size(858, 581);
            paymentPanel.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(134, 31);
            label7.Name = "label7";
            label7.Size = new Size(572, 70);
            label7.TabIndex = 27;
            label7.Text = "Student Total Payment";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.FlatStyle = FlatStyle.System;
            label14.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(446, 151);
            label14.Name = "label14";
            label14.Size = new Size(55, 38);
            label14.TabIndex = 26;
            label14.Text = "L.E";
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.FlatStyle = FlatStyle.System;
            totalCostLabel.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            totalCostLabel.ForeColor = Color.White;
            totalCostLabel.Location = new Point(325, 151);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(56, 38);
            totalCostLabel.TabIndex = 25;
            totalCostLabel.Text = ". . .";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.System;
            label12.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(28, 151);
            label12.Name = "label12";
            label12.Size = new Size(291, 38);
            label12.TabIndex = 24;
            label12.Text = "Total Student Bill = ";
            // 
            // enrollPanel
            // 
            enrollPanel.AccessibleRole = AccessibleRole.None;
            enrollPanel.AllowDrop = true;
            enrollPanel.AutoScroll = true;
            enrollPanel.BackColor = Color.FromArgb(3, 18, 28);
            enrollPanel.Controls.Add(costLabel);
            enrollPanel.Controls.Add(courseNameLbl);
            enrollPanel.Controls.Add(studentNamelbl);
            enrollPanel.Controls.Add(label8);
            enrollPanel.Controls.Add(ConfirmButton);
            enrollPanel.Controls.Add(ClearBtn);
            enrollPanel.Controls.Add(label5);
            enrollPanel.Controls.Add(label4);
            enrollPanel.Controls.Add(label1);
            enrollPanel.Controls.Add(label3);
            enrollPanel.Controls.Add(coursesTable);
            enrollPanel.Controls.Add(label2);
            enrollPanel.Controls.Add(allCoursesComboBox);
            enrollPanel.Controls.Add(nameLabel);
            enrollPanel.Controls.Add(courseLabel);
            enrollPanel.Location = new Point(196, -1);
            enrollPanel.Name = "enrollPanel";
            enrollPanel.Size = new Size(896, 578);
            enrollPanel.TabIndex = 29;
            enrollPanel.Visible = false;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costLabel.ForeColor = Color.DodgerBlue;
            costLabel.Location = new Point(207, 470);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(0, 37);
            costLabel.TabIndex = 30;
            // 
            // courseNameLbl
            // 
            courseNameLbl.AutoSize = true;
            courseNameLbl.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            courseNameLbl.ForeColor = Color.DodgerBlue;
            courseNameLbl.Location = new Point(593, 404);
            courseNameLbl.Name = "courseNameLbl";
            courseNameLbl.Size = new Size(0, 37);
            courseNameLbl.TabIndex = 29;
            // 
            // studentNamelbl
            // 
            studentNamelbl.AutoSize = true;
            studentNamelbl.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentNamelbl.ForeColor = Color.DodgerBlue;
            studentNamelbl.Location = new Point(214, 409);
            studentNamelbl.Name = "studentNamelbl";
            studentNamelbl.Size = new Size(0, 37);
            studentNamelbl.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Italic);
            label8.ForeColor = Color.White;
            label8.Location = new Point(304, 475);
            label8.Name = "label8";
            label8.Size = new Size(55, 32);
            label8.TabIndex = 27;
            label8.Text = "EGP";
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.Transparent;
            ConfirmButton.Cursor = Cursors.Hand;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            ConfirmButton.ForeColor = SystemColors.ControlLight;
            ConfirmButton.Location = new Point(401, 517);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(189, 42);
            ConfirmButton.TabIndex = 26;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            ConfirmButton.MouseEnter += ConfirmButton_MouseEnter;
            ConfirmButton.MouseLeave += ConfirmButton_MouseLeave;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.Transparent;
            ClearBtn.Cursor = Cursors.Hand;
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            ClearBtn.ForeColor = SystemColors.ControlLight;
            ClearBtn.Location = new Point(610, 517);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(189, 42);
            ClearBtn.TabIndex = 25;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            ClearBtn.MouseEnter += ClearBtn_MouseEnter;
            ClearBtn.MouseLeave += ClearBtn_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 470);
            label5.Name = "label5";
            label5.Size = new Size(155, 32);
            label5.TabIndex = 24;
            label5.Text = "Course Fees :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(401, 414);
            label4.Name = "label4";
            label4.Size = new Size(171, 32);
            label4.TabIndex = 23;
            label4.Text = "Course Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 409);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 22;
            label1.Text = "Student Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 356);
            label3.Name = "label3";
            label3.Size = new Size(250, 32);
            label3.TabIndex = 21;
            label3.Text = "Choose Your Course : ";
            // 
            // coursesTable
            // 
            coursesTable.AllowUserToAddRows = false;
            coursesTable.AllowUserToDeleteRows = false;
            coursesTable.AllowUserToResizeColumns = false;
            coursesTable.AllowUserToResizeRows = false;
            coursesTable.BackgroundColor = Color.FromArgb(3, 18, 28);
            coursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesTable.Columns.AddRange(new DataGridViewColumn[] { CourseName, CourseDescription, CourseCapacity, SessionNumber, courseFees });
            coursesTable.GridColor = Color.Black;
            coursesTable.Location = new Point(8, 113);
            coursesTable.Name = "coursesTable";
            coursesTable.Size = new Size(803, 240);
            coursesTable.TabIndex = 20;
            // 
            // CourseName
            // 
            CourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseName.HeaderText = "Course Name";
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            // 
            // CourseDescription
            // 
            CourseDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseDescription.HeaderText = "Description";
            CourseDescription.Name = "CourseDescription";
            // 
            // CourseCapacity
            // 
            CourseCapacity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseCapacity.HeaderText = "Capacity";
            CourseCapacity.Name = "CourseCapacity";
            // 
            // SessionNumber
            // 
            SessionNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SessionNumber.HeaderText = "Session Number";
            SessionNumber.Name = "SessionNumber";
            SessionNumber.ReadOnly = true;
            // 
            // courseFees
            // 
            courseFees.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            courseFees.HeaderText = "Fees";
            courseFees.Name = "courseFees";
            courseFees.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(131, 28);
            label2.Name = "label2";
            label2.Size = new Size(540, 70);
            label2.TabIndex = 19;
            label2.Text = "Enroll To New Course";
            // 
            // allCoursesComboBox
            // 
            allCoursesComboBox.BackColor = Color.FromArgb(3, 27, 40);
            allCoursesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            allCoursesComboBox.FlatStyle = FlatStyle.Flat;
            allCoursesComboBox.ForeColor = Color.White;
            allCoursesComboBox.FormattingEnabled = true;
            allCoursesComboBox.Location = new Point(304, 367);
            allCoursesComboBox.Name = "allCoursesComboBox";
            allCoursesComboBox.Size = new Size(222, 23);
            allCoursesComboBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(203, 214);
            nameLabel.MaximumSize = new Size(197, 71);
            nameLabel.MinimumSize = new Size(185, 21);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(197, 28);
            nameLabel.TabIndex = 8;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.ForeColor = SystemColors.ControlLight;
            ExitBtn.Location = new Point(-1, -1);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(38, 41);
            ExitBtn.TabIndex = 27;
            ExitBtn.Text = "X";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            ExitBtn.MouseEnter += ExitBtn_MouseEnter;
            ExitBtn.MouseLeave += ExitBtn_MouseLeave;
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            courseLabel.ForeColor = Color.DodgerBlue;
            courseLabel.Location = new Point(369, 265);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new Size(22, 37);
            courseLabel.TabIndex = 31;
            courseLabel.Text = ".";
            // 
            // CoursesFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 150, 163);
            ClientSize = new Size(1019, 571);
            Controls.Add(enrollPanel);
            Controls.Add(ExitBtn);
            Controls.Add(paymentPanel);
            Controls.Add(enrolledCoursesPanel);
            Controls.Add(label6);
            Controls.Add(PaymentBtn);
            Controls.Add(EnrolledCoursesBtn);
            Controls.Add(EnrollBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CoursesFrame";
            Text = "Courses";
            enrolledCoursesPanel.ResumeLayout(false);
            enrolledCoursesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentEnrolledTable).EndInit();
            paymentPanel.ResumeLayout(false);
            paymentPanel.PerformLayout();
            enrollPanel.ResumeLayout(false);
            enrollPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coursesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button EnrollBtn;
        private Button EnrolledCoursesBtn;
        private Button PaymentBtn;
        private Label label6;
        private Panel enrolledCoursesPanel;
        private DataGridView studentEnrolledTable;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Panel paymentPanel;
        private Label label14;
        private Label totalCostLabel;
        private Label label12;
        private Button ExitBtn;
        private Label label10;
        private Label label7;
        public Panel enrollPanel;
        private Label costLabel;
        private Label courseNameLbl;
        private Label studentNamelbl;
        private Label label8;
        private Button ConfirmButton;
        private Button ClearBtn;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label3;
        private DataGridView coursesTable;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn CourseDescription;
        private DataGridViewTextBoxColumn CourseCapacity;
        private DataGridViewTextBoxColumn SessionNumber;
        private DataGridViewTextBoxColumn courseFees;
        private Label label2;
        private ComboBox allCoursesComboBox;
        private Label nameLabel;
        private Label courseLabel;
    }
}