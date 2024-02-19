using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project
{
    public partial class StudentForm : Form
    {
        readonly AcademicCourseDbContext context = new();
        readonly Account? account = LoginForm.LoginAccount;

        public StudentForm()
        {

            InitializeComponent();

            int? studentId = account?.Id;

            Student? student1 = context.Students.FirstOrDefault(s => s.AccountsId == studentId);

            InsertProfileData(student1);

            profilePanel.Visible = false;

            schedulePanel.Visible = false;

        }


        #region HelpingMethods

        private void FillTheTable(Student? student)
        {
            coursesTable.Rows.Clear();
            string? name, date, time;
            if (student is not null)
            {
                int totalNumOfCourses = student.Courses.Count;

                List<Course> studentCourses = [.. student.Courses];

                totalCoursesLabel.Text = totalNumOfCourses.ToString();

                foreach (var course in studentCourses)
                {
                    name = course.Name;
                    date = context.CoursesSchedules
                        .FirstOrDefault(c => c.CoursesId == course.Id)?
                        .Date.ToString();
                    time = context.CoursesSchedules
                        .FirstOrDefault(c => c.CoursesId == course.Id)?
                        .Time.ToString();

                    coursesTable.Rows.Add(name, date, time);
                }
            }
        }

        private void InsertProfileData(Student? student)
        {
            idTextBox.Text = student?.Id.ToString();

            nameTextBox.Text = student?.Name;

            phoneTextBox.Text = student?.Phone;

            addressTextBox.Text = student?.Adress;


        }

        private void UpdateProfileData(int? Id)
        {
            string? newName = nameTextBox.Text.Trim();
            string? newPhone = phoneTextBox.Text.Trim();
            string? newAddress = addressTextBox.Text.Trim();

            if (!IsValidInput(newName, newPhone, newAddress))
            {
                MessageBox.Show("Enter a Valid Data");
                return;
            }

            try
            {
                context.Students
                    .Where(s => s.Id == Id)
                    .ExecuteUpdate(s => s
                        .SetProperty(n => n.Name, n => newName)
                        .SetProperty(p => p.Phone, p => newPhone)
                        .SetProperty(a => a.Adress, newAddress));

                MessageBox.Show("Information Updated Successfully");
                DisableTextBoxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in update");

            }


        }

        private void DisableTextBoxes()
        {
            nameTextBox.Enabled = false;
            phoneTextBox.Enabled = false;
            addressTextBox.Enabled = false;
        }

        private static bool IsValidInput(string? newName, string? newPhone, string? newAddress)
        {
            bool isValid = newName != "" &&
                           newPhone != "" &&
                           newAddress != "" &&
                           long.TryParse(newPhone, out long x) &&
                           newPhone.Length == 11;

            return isValid;
        }

        #endregion


        #region ClickHandlingMethods

        private void Profile_Click(object sender, EventArgs e)
        {
            schedulePanel.Visible = false;

            profilePanel.Visible = true;
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            int? studentId = account?.Id;

            Student? student = context.Students
                        .Where(s => s.Id == studentId)    //
                        .Include(s => s.Courses)
                        .FirstOrDefault();

            string? Date = context
                      .CoursesSchedules
                      .FirstOrDefault(s => s.CoursesId == studentId)?
                      .Date
                      .ToString();

            FillTheTable(student);

            schedulePanel.Visible = true;

            profilePanel.Visible = false;

        }

        private void CoursesBtn_Click(object sender, EventArgs e)
        {
            Dispose();

            new CoursesFrame(account?.Id).Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e) =>
            Application.Exit();

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            UpdateProfileData(account?.Id);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
        }

        private void EnableTextBoxes()
        {
            nameTextBox.Enabled = true;
            phoneTextBox.Enabled = true;
            addressTextBox.Enabled = true;
        }

        #endregion


        #region DesignHandlingMethods

        private void Profile_MouseEnter(object sender, EventArgs e) =>
            ProfileBtn.BackColor = Color.FromArgb(3, 18, 28);


        private void ScheduleBtn_MouseEnter(object sender, EventArgs e) =>
            ScheduleBtn.BackColor = Color.FromArgb(3, 18, 28);


        private void CoursesBtn_MouseEnter(object sender, EventArgs e) =>
            CoursesBtn.BackColor = Color.FromArgb(3, 18, 28);


        private void EditBtn_MouseEnter(object sender, EventArgs e) =>
            EditBtn.BackColor = Color.FromArgb(3, 18, 33);


        private void SaveBtn_MouseEnter(object sender, EventArgs e) =>
            SaveBtn.BackColor = Color.FromArgb(3, 18, 33);


        private void ExitBtn_MouseEnter(object sender, EventArgs e) =>
            ExitBtn.BackColor = Color.Red;


        private void EditBtn_MouseLeave(object sender, EventArgs e) =>
            EditBtn.BackColor = Color.Transparent;


        private void SaveBtn_MouseLeave(object sender, EventArgs e) =>
            SaveBtn.BackColor = Color.Transparent;


        private void ExitBtn_MouseLeave(object sender, EventArgs e) =>
            ExitBtn.BackColor = Color.Transparent;

        private void ScheduleBtn_MouseLeave(object sender, EventArgs e) =>
            ScheduleBtn.BackColor = Color.FromArgb(75, 150, 163);

        private void ProfileBtn_MouseLeave(object sender, EventArgs e) =>
            ProfileBtn.BackColor = Color.FromArgb(75, 150, 163);

        private void CoursesBtn_MouseLeave(object sender, EventArgs e) =>
            CoursesBtn.BackColor = Color.FromArgb(75, 150, 163);

        #endregion

    }
}

