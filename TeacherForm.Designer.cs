namespace Project
{
    partial class TeacherForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            scheduleBtn = new Button();
            panel7 = new Panel();
            ProfileBtn = new Button();
            panel10 = new Panel();
            PaymentBtn = new Button();
            panel8 = new Panel();
            AddCourseBtn = new Button();
            panel3 = new Panel();
            CoursesBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 666);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AccessibleRole = AccessibleRole.None;
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(scheduleBtn);
            panel2.Location = new Point(0, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 86);
            panel2.TabIndex = 5;
            // 
            // scheduleBtn
            // 
            scheduleBtn.BackColor = SystemColors.HotTrack;
            scheduleBtn.Cursor = Cursors.Hand;
            scheduleBtn.FlatAppearance.MouseDownBackColor = Color.Navy;
            scheduleBtn.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            scheduleBtn.FlatStyle = FlatStyle.Flat;
            scheduleBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            scheduleBtn.ForeColor = SystemColors.ControlLightLight;
            scheduleBtn.Location = new Point(-23, -15);
            scheduleBtn.Name = "scheduleBtn";
            scheduleBtn.Padding = new Padding(0, 0, 0, 1);
            scheduleBtn.Size = new Size(257, 134);
            scheduleBtn.TabIndex = 1;
            scheduleBtn.Text = "Schedule";
            scheduleBtn.UseVisualStyleBackColor = false;
            scheduleBtn.Click += scheduleBtn_Click;
            // 
            // panel7
            // 
            panel7.AccessibleRole = AccessibleRole.None;
            panel7.BackColor = SystemColors.HotTrack;
            panel7.Controls.Add(ProfileBtn);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(205, 104);
            panel7.TabIndex = 5;
            // 
            // ProfileBtn
            // 
            ProfileBtn.BackColor = SystemColors.HotTrack;
            ProfileBtn.Cursor = Cursors.Hand;
            ProfileBtn.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            ProfileBtn.FlatStyle = FlatStyle.Flat;
            ProfileBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            ProfileBtn.ForeColor = SystemColors.ControlLightLight;
            ProfileBtn.Location = new Point(-26, -18);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Padding = new Padding(0, 0, 0, 1);
            ProfileBtn.Size = new Size(254, 138);
            ProfileBtn.TabIndex = 1;
            ProfileBtn.Text = "Profile";
            ProfileBtn.UseVisualStyleBackColor = false;
            ProfileBtn.Click += ProfileBtn_Click;
            // 
            // panel10
            // 
            panel10.AccessibleRole = AccessibleRole.None;
            panel10.BackColor = SystemColors.HotTrack;
            panel10.Controls.Add(PaymentBtn);
            panel10.Location = new Point(3, 325);
            panel10.Name = "panel10";
            panel10.Size = new Size(205, 104);
            panel10.TabIndex = 4;
            // 
            // PaymentBtn
            // 
            PaymentBtn.BackColor = SystemColors.HotTrack;
            PaymentBtn.Cursor = Cursors.Hand;
            PaymentBtn.FlatAppearance.MouseDownBackColor = Color.Navy;
            PaymentBtn.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            PaymentBtn.FlatStyle = FlatStyle.Flat;
            PaymentBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            PaymentBtn.ForeColor = SystemColors.ControlLightLight;
            PaymentBtn.Location = new Point(-30, -12);
            PaymentBtn.Name = "PaymentBtn";
            PaymentBtn.Padding = new Padding(0, 0, 0, 1);
            PaymentBtn.Size = new Size(257, 134);
            PaymentBtn.TabIndex = 1;
            PaymentBtn.Text = "Payment";
            PaymentBtn.UseVisualStyleBackColor = false;
            PaymentBtn.Click += PaymentBtn_Click;
            // 
            // panel8
            // 
            panel8.AccessibleRole = AccessibleRole.None;
            panel8.BackColor = SystemColors.HotTrack;
            panel8.Controls.Add(AddCourseBtn);
            panel8.Location = new Point(0, 215);
            panel8.Name = "panel8";
            panel8.Size = new Size(205, 104);
            panel8.TabIndex = 6;
            // 
            // AddCourseBtn
            // 
            AddCourseBtn.BackColor = SystemColors.HotTrack;
            AddCourseBtn.Cursor = Cursors.Hand;
            AddCourseBtn.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            AddCourseBtn.FlatStyle = FlatStyle.Flat;
            AddCourseBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            AddCourseBtn.ForeColor = SystemColors.ControlLightLight;
            AddCourseBtn.Location = new Point(-23, -11);
            AddCourseBtn.Name = "AddCourseBtn";
            AddCourseBtn.Padding = new Padding(0, 0, 0, 1);
            AddCourseBtn.Size = new Size(234, 135);
            AddCourseBtn.TabIndex = 1;
            AddCourseBtn.Text = "Add New Course";
            AddCourseBtn.UseVisualStyleBackColor = false;
            AddCourseBtn.Click += AddCourseBtn_Click;
            // 
            // panel3
            // 
            panel3.AccessibleRole = AccessibleRole.None;
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(CoursesBtn);
            panel3.Location = new Point(3, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 104);
            panel3.TabIndex = 5;
            // 
            // CoursesBtn
            // 
            CoursesBtn.BackColor = SystemColors.HotTrack;
            CoursesBtn.Cursor = Cursors.Hand;
            CoursesBtn.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            CoursesBtn.FlatStyle = FlatStyle.Flat;
            CoursesBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            CoursesBtn.ForeColor = SystemColors.ControlLightLight;
            CoursesBtn.Location = new Point(-32, -16);
            CoursesBtn.Name = "CoursesBtn";
            CoursesBtn.Padding = new Padding(0, 0, 0, 1);
            CoursesBtn.Size = new Size(257, 131);
            CoursesBtn.TabIndex = 1;
            CoursesBtn.Text = "Courses";
            CoursesBtn.UseVisualStyleBackColor = false;
            CoursesBtn.Click += CoursesBtn_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 666);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            IsMdiContainer = true;
            Name = "TeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ProfileBtn;
        private Button AddCourseBtn;
        private Button CoursesBtn;
        private Panel panel10;
        private Button PaymentBtn;
        private Panel panel3;
        private Panel panel7;
        private Panel panel8;
        private Panel panel2;
        private Button scheduleBtn;
    }
}