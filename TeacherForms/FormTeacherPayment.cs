using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.TeacherForms
{
    public partial class FormTeacherPayment : Form
    {
        static int TotalStudent = 0;
        static double TotalEarn = 0;

        private AcademicCourseDbContext dbContext;
        public FormTeacherPayment()
        {
            InitializeComponent();
            dbContext = new AcademicCourseDbContext();
            LoadPayCourses();
            LoadInfoCourses();
        }

        private void LoadInfoCourses()
        {
            Teacher teacher = dbContext.Teachers
             .Include(c => c.Courses)
             .FirstOrDefault(t => t.AccountsId == LoginForm.LoginAccount.Id);

            var courses = dbContext.Courses.Include(s => s.CoursesSchedules)
                .Include(t => t.Track)
                .Where(c => c.TeacherId == teacher.Id).ToList();

            NumCourses.Text = courses.Count.ToString();
            NumStudent.Text = TotalStudent.ToString();
            Totalearn.Text = TotalEarn.ToString();
            Total.Text = teacher.Earning.ToString();

        }

        private void LoadPayCourses()
        {
            dataGridPayments.Rows.Clear();
            Teacher teacher = dbContext.Teachers
             .Include(c => c.Courses)
             .FirstOrDefault(t => t.AccountsId == LoginForm.LoginAccount.Id);

            var courses = dbContext.Courses.Include(s => s.Students)
                .Include(t => t.Track)
                .Where(c => c.TeacherId == teacher.Id).ToList();

            if (dataGridPayments.Columns.Count == 0)
            {
                dataGridPayments.Columns.Add("CourseName", "Course Name");
                dataGridPayments.Columns.Add("NumberOfStudents", "Number of Students");
                dataGridPayments.Columns.Add("Earn", "Earn");
            }

            foreach (var course in courses)
            {

                dataGridPayments.Rows.Add(
                    course.Name,
                    course.Students.Count(),
                    course.Students.Count() * course.Fees * .7
                );
                TotalStudent = TotalStudent + course.Students.Count();
                TotalEarn = TotalEarn + course.Students.Count() * course.Fees * .7;
            }

         }




        }
}
