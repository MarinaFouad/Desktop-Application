using Microsoft.VisualBasic;

namespace Project.TeacherForms
{
    partial class FormNewCourse
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
            label11 = new Label();
            label9 = new Label();
            label1 = new Label();
            CourseNameTxt = new TextBox();
            DescriptionTxt = new TextBox();
            label2 = new Label();
            CapacityTxt = new TextBox();
            label3 = new Label();
            NoOfSeassionTxt = new TextBox();
            label4 = new Label();
            FeesTxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            TrackComboBox = new ComboBox();
            label8 = new Label();
            AddCourseBtn = new Button();
            label10 = new Label();
            CalculateBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(-3, 1);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 106);
            panel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Text", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(329, 27);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(367, 53);
            label11.TabIndex = 3;
            label11.Text = "ADD NEW COURSE";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(626, 27);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 28);
            label9.TabIndex = 2;
            label9.Text = "label9";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(133, 163);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 1;
            label1.Text = "Course Name";
            // 
            // CourseNameTxt
            // 
            CourseNameTxt.BackColor = SystemColors.ControlLight;
            CourseNameTxt.BorderStyle = BorderStyle.None;
            CourseNameTxt.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseNameTxt.Location = new Point(312, 170);
            CourseNameTxt.Margin = new Padding(4);
            CourseNameTxt.Name = "CourseNameTxt";
            CourseNameTxt.Size = new Size(197, 24);
            CourseNameTxt.TabIndex = 2;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.BackColor = SystemColors.ControlLight;
            DescriptionTxt.BorderStyle = BorderStyle.None;
            DescriptionTxt.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DescriptionTxt.Location = new Point(312, 277);
            DescriptionTxt.Margin = new Padding(4);
            DescriptionTxt.Multiline = true;
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(271, 87);
            DescriptionTxt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(133, 300);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // CapacityTxt
            // 
            CapacityTxt.BackColor = SystemColors.ControlLight;
            CapacityTxt.BorderStyle = BorderStyle.None;
            CapacityTxt.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CapacityTxt.Location = new Point(730, 174);
            CapacityTxt.Margin = new Padding(4);
            CapacityTxt.Name = "CapacityTxt";
            CapacityTxt.Size = new Size(114, 24);
            CapacityTxt.TabIndex = 6;
            CapacityTxt.KeyPress += CapacityTxt_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(612, 170);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 5;
            label3.Text = "Capacity";
            // 
            // NoOfSeassionTxt
            // 
            NoOfSeassionTxt.BackColor = SystemColors.ControlLight;
            NoOfSeassionTxt.BorderStyle = BorderStyle.None;
            NoOfSeassionTxt.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoOfSeassionTxt.Location = new Point(369, 440);
            NoOfSeassionTxt.Margin = new Padding(4);
            NoOfSeassionTxt.Name = "NoOfSeassionTxt";
            NoOfSeassionTxt.Size = new Size(214, 24);
            NoOfSeassionTxt.TabIndex = 8;
            NoOfSeassionTxt.KeyPress += NoOfSeassionTxt_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(133, 436);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 28);
            label4.TabIndex = 7;
            label4.Text = "Number of Seasions";
            // 
            // FeesTxt
            // 
            FeesTxt.BackColor = SystemColors.ControlLight;
            FeesTxt.BorderStyle = BorderStyle.None;
            FeesTxt.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FeesTxt.Location = new Point(730, 281);
            FeesTxt.Margin = new Padding(4);
            FeesTxt.Name = "FeesTxt";
            FeesTxt.Size = new Size(135, 24);
            FeesTxt.TabIndex = 10;
            FeesTxt.KeyPress += FeesTxt_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(641, 277);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 9;
            label5.Text = "Fees";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(133, 530);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 11;
            label6.Text = "Track";
            // 
            // TrackComboBox
            // 
            TrackComboBox.BackColor = SystemColors.ControlLight;
            TrackComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TrackComboBox.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TrackComboBox.ForeColor = SystemColors.HotTrack;
            TrackComboBox.FormattingEnabled = true;
            TrackComboBox.Location = new Point(314, 537);
            TrackComboBox.Margin = new Padding(4);
            TrackComboBox.Name = "TrackComboBox";
            TrackComboBox.Size = new Size(278, 33);
            TrackComboBox.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Elephant", 18F, FontStyle.Bold);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(1072, 539);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 38);
            label8.TabIndex = 15;
            // 
            // AddCourseBtn
            // 
            AddCourseBtn.BackColor = SystemColors.HotTrack;
            AddCourseBtn.Cursor = Cursors.Hand;
            AddCourseBtn.Font = new Font("Sitka Subheading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCourseBtn.ForeColor = SystemColors.ButtonHighlight;
            AddCourseBtn.Location = new Point(675, 519);
            AddCourseBtn.Margin = new Padding(4);
            AddCourseBtn.Name = "AddCourseBtn";
            AddCourseBtn.Size = new Size(190, 56);
            AddCourseBtn.TabIndex = 17;
            AddCourseBtn.Text = "Add Course";
            AddCourseBtn.UseVisualStyleBackColor = false;
            AddCourseBtn.Click += AddCourseBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(625, 344);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(197, 20);
            label10.TabIndex = 18;
            label10.Text = "You will Earn .7 of this fees";
            // 
            // CalculateBtn
            // 
            CalculateBtn.Location = new Point(713, 389);
            CalculateBtn.Margin = new Padding(4);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(141, 41);
            CalculateBtn.TabIndex = 19;
            CalculateBtn.Text = "Calculate";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // FormNewCourse
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 653);
            Controls.Add(CalculateBtn);
            Controls.Add(label10);
            Controls.Add(AddCourseBtn);
            Controls.Add(label8);
            Controls.Add(TrackComboBox);
            Controls.Add(label6);
            Controls.Add(FeesTxt);
            Controls.Add(label5);
            Controls.Add(NoOfSeassionTxt);
            Controls.Add(label4);
            Controls.Add(CapacityTxt);
            Controls.Add(label3);
            Controls.Add(DescriptionTxt);
            Controls.Add(label2);
            Controls.Add(CourseNameTxt);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ForeColor = SystemColors.HotTrack;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormNewCourse";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormNewCourse";
            Load += FormNewCourse_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox CourseNameTxt;
        private TextBox DescriptionTxt;
        private Label label2;
        private TextBox CapacityTxt;
        private Label label3;
        private TextBox NoOfSeassionTxt;
        private Label label4;
        private TextBox FeesTxt;
        private Label label5;
        private Label label6;
        private ComboBox TrackComboBox;
        private Label label8;
        private Button AddCourseBtn;
        private Label label9;
        private Label label10;
        private Button CalculateBtn;
        private Label label11;
    }
}