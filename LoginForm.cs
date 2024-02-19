using System.Data.SqlClient;
using Project;
using Project.Models;

namespace Project
{
    public partial class LoginForm : Form
    {
        AcademicCourseDbContext dbContext;
        public static Account? LoginAccount;
        public LoginForm()
        {
            InitializeComponent();
            dbContext = new AcademicCourseDbContext();
            label2.Click += Label2_Click;
            label3.Click += Label3_Click;
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (TextUserName.Text != "" && TextBoxPassword.Text != "")
            {
                Account? targetAcc = dbContext.Accounts.Where(acc => acc.UserName == TextUserName.Text).FirstOrDefault();
                if (targetAcc != null)
                {
                    if (targetAcc.Password == TextBoxPassword.Text)
                    {
                        LoginAccount = targetAcc;
                        if (targetAcc.Type == "Admin")
                        {
                            new AdminForm().Show();
                            this.Hide();
                        }
                        else if (targetAcc.Type == "Teacher")
                        {
                            new TeacherForm().Show();
                            this.Hide();
                        }
                        else if (targetAcc.Type == "Student")
                        {
                            new StudentForm().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Some thing is incorrect please try again");
                            TextBoxPassword.Clear();
                            TextUserName.Clear();
                            TextUserName.Focus();
                        }
                    }
                    else
                    { 
                        MessageBox.Show("Wrong Password");
                        TextBoxPassword.Clear();
                        TextUserName.Clear();
                        TextUserName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist");
                    TextBoxPassword.Clear();
                    TextUserName.Clear();
                    TextUserName.Focus();
                }
            }
            else
            { 
                MessageBox.Show("Some data are missing");
                TextBoxPassword.Clear();
                TextUserName.Clear();
                TextUserName.Focus();
            }
        }

        private void Label3_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label2_Click(object? sender, EventArgs e)
        {
            TextUserName.Clear();
            TextBoxPassword.Clear();
            TextUserName.Focus();

        }

        private void LoginForm_Load(object sender, EventArgs e){}
    }
}
