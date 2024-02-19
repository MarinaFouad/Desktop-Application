using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Linq;
using System.Windows.Forms;
using Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Project.TeacherForms
    {
    public partial class FormTeacherCourse : Form
    {
        private AcademicCourseDbContext dbContext;

        public FormTeacherCourse()
        {

            InitializeComponent();
            dbContext = new AcademicCourseDbContext();
            LoadCourses();
        }

        #region Loading DataGrid
        private void LoadCourses()
        {
            dataGridView1.Rows.Clear();
            Teacher teacher = dbContext.Teachers
                    .Include(c => c.Courses)
                     .FirstOrDefault(t => t.AccountsId == LoginForm.LoginAccount.Id);

            var courses = dbContext.Courses.Include(s => s.CoursesSchedules)
                .Include(t => t.Track)
                .Where(c => c.TeacherId == teacher.Id).ToList();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("CourseName", "Course Name");
                dataGridView1.Columns.Add("Description", "Description");
                dataGridView1.Columns.Add("Capacity", "Capacity");
                dataGridView1.Columns.Add("NumberOfSessions", "Number of Sessions");
                dataGridView1.Columns.Add("Fees", "Fees");
                dataGridView1.Columns.Add("Track", "Track");
            }
            HashSet<int> addedCourses = new HashSet<int>(); 

            foreach (var course in courses)
            {
                if (!addedCourses.Contains(course.Id))
                {
                    dataGridView1.Rows.Add(
                        course.Name,
                        course.Description,
                        course.Capcity,
                        course.SessionNumber,
                        course.Fees,
                        course.Track.Name
                    );

                    addedCourses.Add(course.Id);
                }
            }
        }

        #endregion

        #region Searching Btn by trackname or desc. or course name all in one text box

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Teacher teacher = dbContext.Teachers
                    .Include(c => c.Courses)
                     .FirstOrDefault(t => t.AccountsId == LoginForm.LoginAccount.Id);

            var search1 = SearchTxt.Text.ToLower();
            var setSearch = dbContext.Courses.Include(t => t.Track)
                .Where(c => c.Name.ToLower().Contains(search1) ||
                 c.Description.ToLower().Contains(search1) ||
                 c.Track.Name.ToLower().Contains(search1)
                 ).Where(c => c.TeacherId == teacher.Id).ToList();
            dataGridView1.Rows.Clear();

            foreach (var course in setSearch)
            {
                dataGridView1.Rows.Add(
                    course.Name,
                    course.Description,
                    course.Capcity,
                    course.SessionNumber,
                    course.Fees,
                    course.Track.Name
                );
            }
        }
        #endregion


        private void ResetBtn_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }


        #region Delete btn 
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                string courseName = dataGridView1.Rows[selectedIndex].Cells["CourseName"].Value.ToString();

                var courseToDelete = dbContext.Courses.Include(s=>s.CoursesSchedules)
                    .Include(s=>s.Students)
                    .FirstOrDefault(c => c.Name == courseName);

                if (courseToDelete != null)
                {
                    dbContext.Students.RemoveRange(courseToDelete.Students);

                    dbContext.CoursesSchedules.RemoveRange(courseToDelete.CoursesSchedules);
                    dbContext.Courses.Remove(courseToDelete);
                    
                    dbContext.SaveChanges();

                    LoadCourses();

                    MessageBox.Show("Course deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Course not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        #endregion
    }

}
