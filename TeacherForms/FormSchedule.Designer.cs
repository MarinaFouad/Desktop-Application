using System.Windows.Forms;

namespace Project.TeacherForms
{
    partial class FormSchedule
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            CoursesComboBox = new ComboBox();
            sessionDateTimePicker = new DateTimePicker();
            EnterddateBtn = new Button();
            dataGridView1 = new DataGridView();
            Schedule = new Button();
            EditBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(378, 31);
            label1.Name = "label1";
            label1.Size = new Size(225, 62);
            label1.TabIndex = 1;
            label1.Text = "Schedule";
            // 
            // CoursesComboBox
            // 
            CoursesComboBox.BackColor = SystemColors.GradientActiveCaption;
            CoursesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CoursesComboBox.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CoursesComboBox.FormattingEnabled = true;
            CoursesComboBox.Location = new Point(625, 138);
            CoursesComboBox.Name = "CoursesComboBox";
            CoursesComboBox.Size = new Size(241, 39);
            CoursesComboBox.TabIndex = 1;
            CoursesComboBox.SelectedIndexChanged += CoursesComboBox_SelectedIndexChanged;
            // 
            // sessionDateTimePicker
            // 
            sessionDateTimePicker.CalendarFont = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sessionDateTimePicker.CustomFormat = "MM'/'dd'/'yyyy hh':'mm tt";
            sessionDateTimePicker.Format = DateTimePickerFormat.Custom;
            sessionDateTimePicker.Location = new Point(328, 150);
            sessionDateTimePicker.MinDate = new DateTime(2024, 2, 11, 0, 0, 0, 0);
            sessionDateTimePicker.Name = "sessionDateTimePicker";
            sessionDateTimePicker.Size = new Size(235, 27);
            sessionDateTimePicker.TabIndex = 2;
            // 
            // EnterddateBtn
            // 
            EnterddateBtn.BackColor = SystemColors.HotTrack;
            EnterddateBtn.FlatStyle = FlatStyle.Flat;
            EnterddateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EnterddateBtn.ForeColor = SystemColors.ButtonHighlight;
            EnterddateBtn.Location = new Point(105, 563);
            EnterddateBtn.Name = "EnterddateBtn";
            EnterddateBtn.Size = new Size(161, 60);
            EnterddateBtn.TabIndex = 3;
            EnterddateBtn.Text = "Add Session";
            EnterddateBtn.UseVisualStyleBackColor = false;
            EnterddateBtn.Click += EnterddateBtn_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Constantia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(880, 335);
            dataGridView1.TabIndex = 4;
            // 
            // Schedule
            // 
            Schedule.BackColor = SystemColors.HotTrack;
            Schedule.FlatStyle = FlatStyle.Flat;
            Schedule.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Schedule.ForeColor = SystemColors.ButtonHighlight;
            Schedule.Location = new Point(104, 138);
            Schedule.Name = "Schedule";
            Schedule.Size = new Size(162, 61);
            Schedule.TabIndex = 5;
            Schedule.Text = "View Schedule";
            Schedule.UseVisualStyleBackColor = false;
            Schedule.Click += Schedule_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = SystemColors.HotTrack;
            EditBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EditBtn.ForeColor = SystemColors.ButtonHighlight;
            EditBtn.Location = new Point(669, 564);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(149, 59);
            EditBtn.TabIndex = 6;
            EditBtn.Text = "Delete Date";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // FormSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 653);
            Controls.Add(EditBtn);
            Controls.Add(Schedule);
            Controls.Add(dataGridView1);
            Controls.Add(EnterddateBtn);
            Controls.Add(sessionDateTimePicker);
            Controls.Add(CoursesComboBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSchedule";
            Text = "FormSchedule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox CoursesComboBox;
        private DateTimePicker sessionDateTimePicker;
        private Button EnterddateBtn;
        private DataGridView dataGridView1;
        private Button Schedule;
        private Button EditBtn;
    }
}