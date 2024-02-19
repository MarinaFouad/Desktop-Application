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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Project.TeacherForms
{
    public partial class FormNewCourse : Form
    {
        private AcademicCourseDbContext dbContext;

        public FormNewCourse()
        {

            InitializeComponent();
            LoadTracks();
            
        }
        
        //to load tracks in CBX
        public void LoadTracks()
        {
           

            var dbContext = new AcademicCourseDbContext();

            var tracks = dbContext.Tracks.ToList();
            foreach (var track in tracks)
            {
                TrackComboBox.Items.Add(track.Name);
            }

        }


        private void AddCourseBtn_Click(object sender, EventArgs e)
        {

            try
            {

                string CourseName = CourseNameTxt.Text;
                string Description = DescriptionTxt.Text;
                int Fees = int.Parse(FeesTxt.Text);
                int NumOfSeassions = int.Parse(NoOfSeassionTxt.Text);
                int Capacity = int.Parse(CapacityTxt.Text);
                string TrackName = TrackComboBox.SelectedItem.ToString();
                //conditions to check if there is any null 
                if (string.IsNullOrEmpty(TrackName))
                {
                    MessageBox.Show("Please select a track.");
                    return;
                }
                int trackId = GetTrackId(TrackName);

                if (Capacity < 1)
                {
                    MessageBox.Show("Enter a Capacity");
                }
                else if (NumOfSeassions < 1)
                {
                    MessageBox.Show("Enter a Number of Sessions");
                }
                else if (Fees < 1)
                {
                    MessageBox.Show("Enter a Fees");
                }
                else if (CourseName == "")
                {
                    MessageBox.Show("Enter a Course Name");
                }
                else if (TrackName == " ")
                {
                    MessageBox.Show("Choose a Track Name");
                }
                else if (string.IsNullOrEmpty(Description))
                {
                    MessageBox.Show("Please Enter the Description");
                }

                else
                {
                    dbContext = new AcademicCourseDbContext();
                    Teacher teacher = dbContext.Teachers
                    .Include(c => c.Courses)
                     .FirstOrDefault(t => t.AccountsId == LoginForm.LoginAccount.Id);

                    if (teacher != null)
                    {
                        // Retrieve teacher ID from the teacher object
                        int teacherId = teacher.Id;

                        // Create the course object
                        Course course0 = new Course
                        {
                            Name = CourseName,
                            Description = Description,
                            Fees = Fees,
                            SessionNumber = NumOfSeassions,
                            Capcity = Capacity,
                            TrackId = trackId,
                            TeacherId = teacherId // Use the teacher ID retrieved from the teacher object
                        };

                        // Add course to the database context and save changes
                        dbContext.Courses.Add(course0);
                        dbContext.SaveChanges();
                        MessageBox.Show("Course added successfully!");
                    }
                }
            }
            //for any Errors
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Fees, Number of Sessions, and Capacity.");
            }
            
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred: " + ex.Message);
            //}
        }


        //to get the Id of the selected track
        private int GetTrackId(string trackName)
        {
            var db = new AcademicCourseDbContext();

            var track = db.Tracks.FirstOrDefault(t => t.Name == trackName);
            if (track != null)
            {
                return track.Id;
            }
            else
            {
                throw new Exception("Track not found in the database.");
            }


        }

        //no letters in the capacity txt
        private void CapacityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //no letters in the fees txt
        private void FeesTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //no letters in the seNo txt
        private void NoOfSeassionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //to calculate fees
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FeesTxt.Text))
            {
                MessageBox.Show("Please Enter the Fees");
            }
            else
            {
                int Fees = int.Parse(FeesTxt.Text);
                MessageBox.Show($"Your Earn Will be = {Fees * .7}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormNewCourse_Load(object sender, EventArgs e)
        {

        }

       
    }
}
