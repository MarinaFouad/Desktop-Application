using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.TeacherForms;

namespace Project
{
    public partial class TeacherForm : Form
    {
        //Define 

        TeacherProfile Teacherprofile;
        FormNewCourse NewCourse;
        FormTeacherCourse TeacherCourse;
        FormTeacherPayment FormTeacherPayment;
        FormSchedule FormSchedule;
        public TeacherForm()
        {
            InitializeComponent();
            this.FormClosed += TeacherForm_FormClosed;
            //this part to test saving login acc
            Label dd = new Label();
            dd.Location = new Point(0, 0);
            dd.AutoSize = true;
            dd.Text = $"userName: {LoginForm.LoginAccount.UserName} , AccId: {LoginForm.LoginAccount.Id}";
            this.Controls.Add(dd);
        }

        private void TeacherForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void HideOrCloseOtherForms(Form currentForm)
        {
            foreach (Form form in MdiChildren)
            {
                if (form == currentForm)
                    continue;

                if (!form.IsDisposed && form.Visible)
                {
                    form.Close(); 
                }
            }
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            if (Teacherprofile == null)
            {
                Teacherprofile = new TeacherProfile();
                Teacherprofile.FormClosed += Profile_FormClosed;
                Teacherprofile.MdiParent = this;
                Teacherprofile.StartPosition = FormStartPosition.Manual;
            }

            HideOrCloseOtherForms(Teacherprofile);
            Teacherprofile.Show();
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            if (NewCourse == null)
            {
                NewCourse = new FormNewCourse();
                NewCourse.FormClosed += NewCourse_FormClosed;
                NewCourse.MdiParent = this;
                NewCourse.StartPosition = FormStartPosition.Manual;
            }

            HideOrCloseOtherForms(NewCourse);
            NewCourse.Show();
        }

        private void CoursesBtn_Click(object sender, EventArgs e)
        {
            if (TeacherCourse == null)
            {
                TeacherCourse = new FormTeacherCourse();
                TeacherCourse.FormClosed += TeacherCourse_FormClosed;
                TeacherCourse.MdiParent = this;
                TeacherCourse.StartPosition = FormStartPosition.Manual;
            }

            HideOrCloseOtherForms(TeacherCourse);
            TeacherCourse.Show();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            if (FormTeacherPayment == null)
            {
                FormTeacherPayment = new FormTeacherPayment();
                FormTeacherPayment.FormClosed += FormTeacherPayment_FormClosed;
                FormTeacherPayment.MdiParent = this;
                FormTeacherPayment.StartPosition = FormStartPosition.Manual;
            }

            HideOrCloseOtherForms(FormTeacherPayment);
            FormTeacherPayment.Show();
        }


        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            if (FormSchedule == null)
            {
                FormSchedule = new FormSchedule();
                FormSchedule.FormClosed += FormSchedule_FormClosed; ;
                FormSchedule.MdiParent = this;
                FormSchedule.StartPosition = FormStartPosition.Manual;
            }

            HideOrCloseOtherForms(FormSchedule);
            FormSchedule.Show();
        }

        private void FormSchedule_FormClosed(object? sender, FormClosedEventArgs e)
        {
            FormSchedule = null;
        }

        private void Profile_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Teacherprofile = null;
        }
       




        private void NewCourse_FormClosed(object? sender, FormClosedEventArgs e)
        {
            NewCourse = null;
        }



        private void TeacherCourse_FormClosed(object? sender, FormClosedEventArgs e)
        {
            TeacherCourse = null;
        }

        




        private void FormTeacherPayment_FormClosed(object? sender, FormClosedEventArgs e)
        {
            FormTeacherPayment = null;
        }


        #region clicked
        private void AddCourse_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
