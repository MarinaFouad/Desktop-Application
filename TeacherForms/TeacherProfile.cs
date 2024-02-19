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

namespace Project
{
    public partial class TeacherProfile : Form
    {
        private AcademicCourseDbContext dbContext;
        public TeacherProfile()
        {
            InitializeComponent();
            UserNameTxt.Enabled = false;
            PasswordName.Enabled = false;
            dbContext = new AcademicCourseDbContext();
            LoadTeacherProfile();

        }
        private void LoadTeacherProfile()
        {
            int teacherId = LoginForm.LoginAccount.Id;
            Teacher teacher = dbContext.Teachers.Include(c=>c.Courses)
                .Include(a=>a.Accounts).FirstOrDefault(t => t.Accounts.Id == teacherId);

            if (teacher != null)
            {
                UserNameTxt.Text = teacher.Accounts.UserName;
                PasswordName.Text = teacher.Accounts.Password;
                ChangeEmail.Text = teacher.Phone;
                changeAddress.Text = teacher.Adress;
                NumberChange.Text = teacher.Courses.Count.ToString();
            }
            else
            {
                MessageBox.Show("Teacher's information not found!");
            }

        }

        private void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            UserNameTxt.Enabled = true;
            PasswordName.Enabled = true;
           

        }

       
        private bool IsUsernameUnique(string username)
        {
            return !dbContext.Accounts.Any(acc => acc.UserName == username && acc.Id != LoginForm.LoginAccount.Id);
        }
        private void UpdateTeacherProfile(string newUsername, string newPassword)
        {
            var teacher = dbContext.Teachers
                 .Include(a => a.Accounts)
                .FirstOrDefault(t => t.Accounts.Id == LoginForm.LoginAccount.Id);
            if (teacher != null)
            {
                teacher.Accounts.UserName = newUsername;
                teacher.Accounts.Password = newPassword;
                dbContext.SaveChanges();
                MessageBox.Show("Profile updated successfully!");
                LoadTeacherProfile();
            }
            else
            {
                MessageBox.Show("Account not found!");
            }
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            var UpdateUserName = UserNameTxt.Text;
            var UpdatePassword = PasswordName.Text;
            if (string.IsNullOrWhiteSpace(UpdateUserName) || string.IsNullOrWhiteSpace(UpdatePassword))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            if (!IsUsernameUnique(UpdateUserName) )
            {
                MessageBox.Show("Username is already Exist. Please choose a different username.");
                return;
            }

            UpdateTeacherProfile(UpdateUserName, UpdatePassword);

            UserNameTxt.Enabled = false;
            PasswordName.Enabled = false;

        }
    }
}
