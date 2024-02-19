namespace Project.TeacherForms
{
    partial class FormTeacherPayment
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridPayments = new DataGridView();
            NumCourses = new Label();
            NumStudent = new Label();
            Totalearn = new Label();
            Total = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPayments).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 124);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(378, 28);
            label1.Name = "label1";
            label1.Size = new Size(207, 60);
            label1.TabIndex = 1;
            label1.Text = "Payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(85, 455);
            label2.Name = "label2";
            label2.Size = new Size(270, 38);
            label2.TabIndex = 1;
            label2.Text = "Number of Courses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.Location = new Point(375, 455);
            label3.Name = "label3";
            label3.Size = new Size(284, 38);
            label3.TabIndex = 2;
            label3.Text = "Number of Students";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.Location = new Point(709, 455);
            label4.Name = "label4";
            label4.Size = new Size(117, 38);
            label4.TabIndex = 3;
            label4.Text = "Earning";
            // 
            // dataGridPayments
            // 
            dataGridViewCellStyle1.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPayments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridPayments.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridPayments.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridPayments.Location = new Point(60, 142);
            dataGridPayments.Name = "dataGridPayments";
            dataGridPayments.RowHeadersWidth = 51;
            dataGridPayments.RowTemplate.Height = 30;
            dataGridPayments.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPayments.Size = new Size(831, 262);
            dataGridPayments.TabIndex = 4;
            // 
            // NumCourses
            // 
            NumCourses.AutoSize = true;
            NumCourses.FlatStyle = FlatStyle.Flat;
            NumCourses.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            NumCourses.ForeColor = SystemColors.HotTrack;
            NumCourses.Location = new Point(150, 515);
            NumCourses.Name = "NumCourses";
            NumCourses.Size = new Size(78, 25);
            NumCourses.TabIndex = 5;
            NumCourses.Text = "Courses";
            // 
            // NumStudent
            // 
            NumStudent.AutoSize = true;
            NumStudent.FlatStyle = FlatStyle.Flat;
            NumStudent.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            NumStudent.ForeColor = SystemColors.HotTrack;
            NumStudent.Location = new Point(480, 515);
            NumStudent.Name = "NumStudent";
            NumStudent.Size = new Size(78, 25);
            NumStudent.TabIndex = 6;
            NumStudent.Text = "Courses";
            // 
            // Totalearn
            // 
            Totalearn.AutoSize = true;
            Totalearn.FlatStyle = FlatStyle.Flat;
            Totalearn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Totalearn.ForeColor = SystemColors.HotTrack;
            Totalearn.Location = new Point(727, 515);
            Totalearn.Name = "Totalearn";
            Totalearn.Size = new Size(78, 25);
            Totalearn.TabIndex = 7;
            Totalearn.Text = "Courses";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.FlatStyle = FlatStyle.Flat;
            Total.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Total.ForeColor = SystemColors.HotTrack;
            Total.Location = new Point(471, 599);
            Total.Name = "Total";
            Total.Size = new Size(78, 25);
            Total.TabIndex = 9;
            Total.Text = "Courses";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Highlight;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(227, 599);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 8;
            label6.Text = "Total Balance  :";
            // 
            // FormTeacherPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 653);
            Controls.Add(Total);
            Controls.Add(label6);
            Controls.Add(Totalearn);
            Controls.Add(NumStudent);
            Controls.Add(NumCourses);
            Controls.Add(dataGridPayments);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTeacherPayment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormTeacherPayment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridPayments;
        private Label NumCourses;
        private Label NumStudent;
        private Label Totalearn;
        private Label Total;
        private Label label6;
    }
}