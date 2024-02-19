using Microsoft.Data.SqlClient;
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
    public partial class FormSchedule : Form
    {
        private AcademicCourseDbContext dbContext;
        int teacherId = LoginForm.LoginAccount.Id;

        public FormSchedule()
        {
            InitializeComponent();
            dbContext = new AcademicCourseDbContext();
            LoadCourses();
        }

        #region load courrses in ComboBox

        public void LoadCourses()
        {
            Teacher teacher = dbContext.Teachers
                    .Include(c => c.Courses)
                     .FirstOrDefault(t => t.AccountsId == LoginForm.LoginAccount.Id);

            var TeacherCourses = dbContext.Courses.Include(s => s.CoursesSchedules)
                .Include(t => t.Track)
                .Where(c => c.TeacherId == teacher.Id).ToList();
          
            foreach (var course in TeacherCourses)
            {
                CoursesComboBox.Items.Add(course.Name);
            }
        }
        #endregion

        #region CoursesComboBox_SelectedIndexChanged

        private void CoursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoursesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            string selectedCourseName = CoursesComboBox.SelectedItem.ToString();
            var selectedCourse = dbContext.Courses.FirstOrDefault(c => c.Name == selectedCourseName);

        }
        #endregion

        #region Enter the schedule 

        private void EnterddateBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CoursesComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a course.");
                    return;
                }

                string selectedCourseName = CoursesComboBox.SelectedItem.ToString();
                var selectedCourse = dbContext.Courses.Include(c => c.CoursesSchedules)
                    .FirstOrDefault(c => c.Name == selectedCourseName);

                int numberOfSessions = selectedCourse.SessionNumber;

                var existingScheduledDates = selectedCourse.CoursesSchedules.Select(s => s.Date).ToList();

                int sessionsAdded = 0;

                for (int i = existingScheduledDates.Count; i < numberOfSessions; i++)
                {
                    DateTime selectedSession = sessionDateTimePicker.Value.AddDays(7 * i);
                   
                    if(selectedSession.Date < (DateTime.Now).Date)
                    {
                        MessageBox.Show($"{selectedSession} isn't future  ");
                        continue;
                    }
                    else if (selectedSession.Hour < 9 || selectedSession.Hour >= 23)
                    {
                        MessageBox.Show("Please enter a time between 9 AM and 11 PM.");
                        return;
                    }

                    else if (IsDateConflict(selectedSession) || existingScheduledDates.Contains(DateOnly.FromDateTime(selectedSession)))
                    {
                        MessageBox.Show($"{selectedSession} is Conflict day ");
                        continue;
                    }
                    else
                    {
                        CoursesSchedule newSchedule = new CoursesSchedule
                        {
                            CoursesId = selectedCourse.Id,
                            Date = DateOnly.FromDateTime(selectedSession),
                            Time = selectedSession.Hour
                        };

                        selectedCourse.CoursesSchedules.Add(newSchedule);
                        sessionsAdded++;
                    }
                }

                if (sessionsAdded > 0)
                {
                    MessageBox.Show($"Assigned {sessionsAdded } sessions to course: {selectedCourseName}");
                }
                else if (numberOfSessions == existingScheduledDates.Count)
                {
                    MessageBox.Show($"You have {numberOfSessions} sessions. You can delete any of these time slots.");
                }
                else
                {
                    MessageBox.Show("There are conflicts with other schedules.");
                }

                dbContext.SaveChanges();
                LoadSCheduleCourses();
            }
            catch (DbUpdateException ex) when (IsScheduleConstraintViolation(ex))
            {
                MessageBox.Show("Please choose a different time between 9Am to 11 PM");
            }
        }


        #endregion



        #region Load in dataGrid 

        private void LoadSCheduleCourses()
        {

            dataGridView1.Rows.Clear();
            if (CoursesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            string selectedCourseName = CoursesComboBox.SelectedItem.ToString();
            var selectedCourse = dbContext.Courses.Include(c => c.CoursesSchedules)
                .FirstOrDefault(c => c.Name == selectedCourseName);

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("CourseDate", "Course Date");
                dataGridView1.Columns.Add("Time", "Time");
            }

            foreach (var schedule in selectedCourse.CoursesSchedules)
            {
                dataGridView1.Rows.Add(
                    schedule.Date.ToString("MM/dd/yyyy"),
                    schedule.Time.ToString() + " O'clock"
                );
            }
        }
        #endregion

        #region Check if conflict Date 
        private bool IsDateConflict(DateTime selectedDate)
        {
            var dbContext = new AcademicCourseDbContext();

            Teacher teacher = dbContext.Teachers
                    .Include(c => c.Courses)
                     .FirstOrDefault(t => t.AccountsId == LoginForm.LoginAccount.Id);


            var coursesWithSameStartDate = dbContext.Courses
                .Where(c => c.TeacherId == teacher.Id && c.CoursesSchedules
                .Any(s => s.Date == DateOnly.FromDateTime(selectedDate)))
                .ToList();

            
            if (coursesWithSameStartDate.Any())
            {
                MessageBox.Show($"There is a course scheduled in same Day ");
                return true;
            }
           

            return false;
        }
        #endregion





        private bool IsScheduleConstraintViolation(DbUpdateException ex)
        {
            return ex.InnerException is SqlException sqlException && sqlException.Number == 547;
        }



        public void RefreshDataGridView()
        {
            LoadSCheduleCourses();
        }

        private void Schedule_Click(object sender, EventArgs e)
        {
            LoadSCheduleCourses();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                string dateSelected = dataGridView1.Rows[selectedIndex].Cells["CourseDate"].Value.ToString();

                if (DateOnly.TryParse(dateSelected, out DateOnly selectedDate))
                {
                    var selectedCourseName = CoursesComboBox.SelectedItem.ToString();
                    var selectedCourse = dbContext.Courses.Include(c => c.CoursesSchedules)
                                            .FirstOrDefault(c => c.Name == selectedCourseName);

                    var scheduleToDelete = selectedCourse.CoursesSchedules.FirstOrDefault(s => s.Date == selectedDate);

                    if (scheduleToDelete != null)
                    {
                        
                            dbContext.CoursesSchedules.Remove(scheduleToDelete);
                            dbContext.SaveChanges();
                            RefreshDataGridView();
                            MessageBox.Show("Session date and time deleted successfully.");
                       
                       
                    }
                    else
                    {
                        MessageBox.Show("Selected session not found in the database.");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


    }
}
