using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project
{
    public partial class AdminForm : Form
    {
        AcademicCourseDbContext dbContext;
        Regex validatePhoneNumberRegex;
        public AdminForm()
        {
            InitializeComponent();
            this.FormClosed += AdminForm_FormClosed;
            dbContext = new AcademicCourseDbContext();
            ///////////////////////////////
            display();
            TrackData.RowHeaderMouseClick += TrackData_RowHeaderMouseClick;
            button4.Enabled = false;
            TrackData.SelectionChanged += TrackData_SelectionChanged;
            ///////////////////////////
            displayStudent();
            EditStudent.Enabled = false;
            StudentBill.Enabled = false;
            BillText.Enabled = false;
            StudentGrid.RowHeaderMouseClick += StudentGrid_RowHeaderMouseClick;
            StudentGrid.SelectionChanged += StudentGrid_SelectionChanged;
            validatePhoneNumberRegex = new Regex("^01[0125]{1,1}[0-9]{8,8}$");
            filterComboBox();
            StudentFilter.SelectionChangeCommitted += StudentFilter_SelectionChangeCommitted;

            billComboBox();
            billCombo.SelectionChangeCommitted += BillCombo_SelectionChangeCommitted;
            ///////////////////////////
            //teacher
            displayTeacher();
            TeditBtn.Enabled = false;
            TbillBtn.Enabled = false;
            Tbill.Enabled = false;
            Tdata.RowHeaderMouseClick += Tdata_RowHeaderMouseClick;
            Tdata.SelectionChanged += Tdata_SelectionChanged;
            TfilterComboBox();
            Tfilter.SelectionChangeCommitted += Tfilter_SelectionChangeCommitted;
            TearningComboBox();
            Tearning.SelectionChangeCommitted += Tearning_SelectionChangeCommitted;
            //TEACHER Search Type
            TcomboSearch.Items.Add("Name");
            TcomboSearch.Items.Add("Phone");
            TcomboSearch.Items.Add("Address");

            TcomboSearch.SelectedItem = "Name";
            //STUDENT Search Type
            StudentComboSearch.Items.Add("Name");
            StudentComboSearch.Items.Add("Phone");
            StudentComboSearch.Items.Add("Address");

            StudentComboSearch.SelectedItem = "Name";


            #region Close Lable
            // Style the close label
            close.Font = new Font("Arial", 10, FontStyle.Bold);
            close.ForeColor = Color.Red;
            close.Cursor = Cursors.Hand;
            #endregion

            #region Apply design to DataGridView controls
            ApplyDesignToDataGridView(Tdata);
            ApplyDesignToDataGridView(StudentGrid);
            ApplyDesignToDataGridView(TrackData);
            #endregion
            #region Side Bar
            // Style the buttons
            StyleButton(TeacherBtn);
            StyleButton(StudentBtn);
            StyleButton(TrackBtn);

            // Style the panel (sidebar)
            flowLayoutPanel1.BackColor = SystemColors.HotTrack;
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.AutoScroll = true;
            #endregion
            #region group boxes
            StyleGroupBox(groupBox5);
            StyleGroupBox(groupBox4);
            StyleGroupBox(groupBox1);
            StyleGroupBox(groupBox3);
            StyleGroupBox(groupBox2);
            #endregion

        }
        #region Function to apply design to DataGridView
        private void ApplyDesignToDataGridView(DataGridView dataGridView)
        {
            // Set DataGridView properties
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = SystemColors.HotTrack; // Change selected row color to HotTrack
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack; // Change column header color to HotTrack
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Adjust column headers height
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersHeight = 30;

            // Set row height
            dataGridView.RowTemplate.Height = 30;
        }
        #endregion
        #region Function to apply style to buttons
        private void StyleButton(Button button)
        {
            button.BackColor = SystemColors.HotTrack;
            button.ForeColor = SystemColors.ControlLightLight;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Size = new Size(120, 40);
            button.Margin = new Padding(0, 0, 0, 20);
            // Add hover effect
            button.MouseEnter += (sender, e) =>
            {
                button.BackColor = Color.FromArgb(0, 102, 204);
            };
            button.MouseLeave += (sender, e) =>
            {
                button.BackColor = SystemColors.HotTrack;
            };
            // Change color when clicked
            button.Click += (sender, e) =>
            {
                button.BackColor = Color.FromArgb(0, 77, 153);
            };
        }
        #endregion
        #region Function to apply style to group box
        private void StyleGroupBox(GroupBox groupBox)
        {
            // Set background color
            groupBox.BackColor = Color.FromArgb(240, 240, 240);

            // Set text color
            groupBox.ForeColor = Color.FromArgb(64, 64, 64);

            // Create a border with a specific color and width
            groupBox.Paint += (sender, e) =>
            {
                GroupBox box = sender as GroupBox;
                e.Graphics.Clear(Color.FromArgb(240, 240, 240));
                e.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 10, 1);
                e.Graphics.DrawLine(new Pen(Color.FromArgb(190, 190, 190), 2), new Point(0, 7), new Point(8, 7)); // Top-left corner
                e.Graphics.DrawLine(new Pen(Color.FromArgb(190, 190, 190), 2), new Point((int)(e.Graphics.MeasureString(box.Text, box.Font).Width + 8), 7), new Point(box.Width, 7)); // Top-right corner
                e.Graphics.DrawLine(new Pen(Color.FromArgb(190, 190, 190), 2), new Point(0, 7), new Point(0, box.Height)); // Left border
                e.Graphics.DrawLine(new Pen(Color.FromArgb(190, 190, 190), 2), new Point(0, box.Height), new Point(box.Width, box.Height)); // Bottom border
                e.Graphics.DrawLine(new Pen(Color.FromArgb(190, 190, 190), 2), new Point(box.Width, 7), new Point(box.Width, box.Height)); // Right border
            };
        }
        #endregion


        private void TrackData_SelectionChanged(object? sender, EventArgs e)
        {
            button4.Enabled = false;
            button3.Enabled = true;
            trackName.Clear();
        }

        private void TrackData_RowHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TrackData.Rows[e.RowIndex];
                if (row != null)
                {
                    trackName.Text = row.Cells["Name"].Value.ToString();
                    button4.Enabled = true;
                    button3.Enabled = false;
                }
            }
        }

        public void display()
        {
            TrackData.DataSource = dbContext.Tracks.Select(t => new { ID = t.Id, Name = t.Name }).ToList();

            int rowCount = dbContext.Tracks.Count();
            if (rowCount == 0 )
            {
                TrackNumbers.Text = "You currently have no tracks";
            } else 
            {
                TrackNumbers.Text = $"You currently have {rowCount} tracks";
            }
            //

        }
        private void AdminForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // should be deleted
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherBtn_Click(object sender, EventArgs e)
        {
            ShowTabPage(TeacherTab);
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            ShowTabPage(StudentTab);
        }

        private void TrackBtn_Click(object sender, EventArgs e)
        {
            ShowTabPage(TrackTab);
        }

        // control tabs by buttons
        private void ShowTabPage(TabPage tabPage)
        {
            tabControl1.SelectTab(tabPage);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TeacherTab_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (trackName.Text.Trim() != "")
            {
                Track newTrack = new Track() { Name = trackName.Text.Trim() };
                dbContext.Tracks.Add(newTrack);
                dbContext.SaveChanges();
                trackName.Clear();
                MessageBox.Show($"Track Added Successfully with ID = {newTrack.Id}");
                display();
            }
            else
            {
                MessageBox.Show("Please enter track name");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (searchTrack.Text != "")
            {
                var temp = dbContext.Tracks.Where(s => s.Name.ToLower().Contains(searchTrack.Text.ToLower()))
                    .Select(t => new { ID = t.Id, Name = t.Name }).ToList();
                TrackData.DataSource = temp;

                searchTrack.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();
            searchTrack.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TrackData.SelectedRows.Count >= 0)
            {
                if (trackName.Text.Trim() != "")
                {

                    Track? editTrack = dbContext.Tracks
                        .Where(s => s.Id == (int)TrackData
                        .SelectedRows[0].Cells["ID"].Value)
                        .FirstOrDefault();
                    if (editTrack != null)
                    {
                        editTrack.Name = trackName.Text.Trim().ToLower();
                        dbContext.Tracks.Update(editTrack);
                        dbContext.SaveChanges();
                        trackName.Clear();
                        MessageBox.Show($"Track edited Successfully with ID = {editTrack.Id}");
                        display();
                    }


                }
                else
                {
                    MessageBox.Show("Please enter track name");
                }
            }
            else
            {
                MessageBox.Show("You must select row to edit");
            }

        }

        #region Student
        public void displayStudent()
        {
            StudentGrid.DataSource = dbContext.Students.
                Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Bill, Phone = t.Phone, Adress = t.Adress }).ToList();
            int total = (int)dbContext.Students.Sum(s => s.Bill);
            StudentTotalBill.Text = total.ToString() + " L.E";
        }
        private void StudentSearch_Click(object sender, EventArgs e)
        {
            if (StudentSearchBar.Text.Trim() != "")
            {
                string selectedField = StudentComboSearch.SelectedItem.ToString();
                var query = dbContext.Students
                    .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Bill, Phone = t.Phone, Adress = t.Adress });

                if (selectedField == "Name")
                {
                    var temp = query.Where(s => s.Name.ToLower().Contains(StudentSearchBar.Text.Trim().ToLower())).ToList();
                    StudentGrid.DataSource = temp;
                }
                else if (selectedField == "Phone")
                {
                    var temp = query.Where(s => s.Phone.ToLower().Contains(StudentSearchBar.Text.Trim().ToLower())).ToList();
                    StudentGrid.DataSource = temp;
                }
                else if (selectedField == "Address")
                {
                    var temp = query.Where(s => s.Adress.ToLower().Contains(StudentSearchBar.Text.Trim().ToLower())).ToList();
                    StudentGrid.DataSource = temp;
                }

                StudentSearchBar.Clear();
            }
        }


        private void StudentReset_Click(object sender, EventArgs e)
        {
            displayStudent();
            StudentSearchBar.Clear();

        }
        private void StudentGrid_SelectionChanged(object? sender, EventArgs e)
        {
            EditStudent.Enabled = false;
            AddStudent.Enabled = true;
            StudentBill.Enabled = false;
            StudentUserName.Enabled = true;
            BillText.Enabled = false;
            StudentUserName.Clear();
            StudentName.Clear();
            BillText.Clear();
            StudentPhone.Clear();
            StudentAddress.Clear();
        }

        private void StudentGrid_RowHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = StudentGrid.Rows[e.RowIndex];
                if (row != null)
                {
                    StudentName.Text = row.Cells["Name"].Value.ToString();
                    BillText.Text = row.Cells["Bill"].Value.ToString();
                    StudentPhone.Text = row.Cells["Phone"].Value.ToString();
                    StudentAddress.Text = row.Cells["Adress"].Value.ToString();
                    EditStudent.Enabled = true;
                    AddStudent.Enabled = false;
                    StudentBill.Enabled = true;
                    BillText.Enabled = true;
                    StudentUserName.Enabled = false;
                    StudentUserName.Clear();

                }
            }
        }
        private void AddStudent_Click(object sender, EventArgs e)
        {
            //if(validatePhoneNumberRegex.IsMatch(StudentPhone.Text))
            //MessageBox.Show(validatePhoneNumberRegex.IsMatch(StudentPhone.Text).ToString());
            if (StudentName.Text.Trim() != "" && StudentAddress.Text.Trim() != "" &&
                StudentUserName.Text.Trim() != "" && validatePhoneNumberRegex.IsMatch(StudentPhone.Text))
            {
                Account addedAccount = new Account()
                {
                    UserName = StudentUserName.Text.Trim(),
                    Password = "1",
                    Type = "Student"
                };
                var checkUserName = dbContext.Accounts
                        .Where(s => s.UserName == addedAccount.UserName)
                        .FirstOrDefault();
                if (checkUserName == null)
                {
                    dbContext.Accounts.Add(addedAccount);
                    dbContext.SaveChanges();
                    Student addedStudent = new Student()
                    {
                        Name = StudentName.Text.Trim(),
                        Adress = StudentAddress.Text.Trim(),
                        Phone = StudentPhone.Text.Trim(),
                        Bill = 0,
                        AccountsId = addedAccount.Id
                    };
                    dbContext.Students.Add(addedStudent);
                    dbContext.SaveChanges();
                    MessageBox.Show($"Student Added Successfully user name: {addedAccount.UserName} and Password: {addedAccount.Password}");
                    StudentUserName.Clear();
                    StudentName.Clear();
                    StudentAddress.Clear();
                    StudentPhone.Clear();
                    displayStudent();
                }
                else
                {
                    MessageBox.Show("This Account user name is already exisit");
                }

            }
            else if (StudentName.Text.Trim() != "" && StudentAddress.Text.Trim() != "" &&
                StudentUserName.Text.Trim() != "" && StudentPhone.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Valid Phone number");
            }
            else
            {
                MessageBox.Show("Some data are missing");
            }
        }

        private void EditStudent_Click(object sender, EventArgs e)
        {
            if (StudentGrid.SelectedRows.Count >= 0)
            {
                if (StudentName.Text.Trim() != "" && StudentAddress.Text.Trim() != "" &&
                 validatePhoneNumberRegex.IsMatch(StudentPhone.Text))
                {

                    Student? editStudent = dbContext.Students
                        .Where(s => s.Id == (int)StudentGrid
                        .SelectedRows[0].Cells["ID"].Value)
                        .FirstOrDefault();
                    if (editStudent != null)
                    {
                        editStudent.Name = StudentName.Text.Trim().ToLower();
                        editStudent.Phone = StudentPhone.Text.Trim().ToLower();
                        editStudent.Adress = StudentAddress.Text.Trim().ToLower();
                        dbContext.Students.Update(editStudent);
                        dbContext.SaveChanges();
                        MessageBox.Show($"Student edited Successfully with ID = {editStudent.Id}");
                        StudentUserName.Clear();
                        StudentName.Clear();
                        StudentAddress.Clear();
                        StudentPhone.Clear();
                        BillText.Clear();
                        displayStudent();
                    }


                }
                else if (StudentName.Text.Trim() != "" && StudentAddress.Text.Trim() != "" &&
                    StudentPhone.Text.Trim() != "")
                {
                    MessageBox.Show("Please enter Valid Phone number");
                }
                else
                {
                    MessageBox.Show("Some data are missing");
                }
            }
            else
            {
                MessageBox.Show("You must select Student to edit");
            }

        }

        private void StudentBill_Click(object sender, EventArgs e)
        {
            if (StudentGrid.SelectedRows.Count >= 0)
            {
                if (BillText.Text.Trim() != "" && int.TryParse(BillText.Text, out _))
                {

                    Student? targetStudent = dbContext.Students
                        .Where(s => s.Id == (int)StudentGrid
                        .SelectedRows[0].Cells["ID"].Value)
                        .FirstOrDefault();
                    int payValue = int.Parse(BillText.Text);
                    if (targetStudent != null && payValue > 0)
                    {

                        if (payValue <= targetStudent.Bill)
                        {
                            targetStudent.Bill -= payValue;
                            dbContext.Students.Update(targetStudent);
                            dbContext.SaveChanges();
                            MessageBox.Show($"{payValue} LE has been paid successfully remain" +
                                $" bill = {targetStudent.Bill} LE");
                            StudentUserName.Clear();
                            StudentName.Clear();
                            StudentAddress.Clear();
                            StudentPhone.Clear();
                            BillText.Clear();
                            displayStudent();
                        }
                        else
                        {
                            MessageBox.Show("Payment can not exceed Bill Value");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter valid value for Bill");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter valid value for Bill");
                }
            }
            else
            {
                MessageBox.Show("You must select student to pay his Bill");
            }
        }

        public void filterComboBox()
        {
            StudentFilter.DataSource = dbContext.Courses.ToList();
            StudentFilter.DisplayMember = "Name";
            StudentFilter.ValueMember = "Id";
        }
        private void StudentFilter_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            List<Student> temp = new List<Student>();
            foreach (var item in dbContext.Students.Include(s => s.Courses))
            {
                foreach (var item2 in item.Courses)
                {
                    if (item2.Id == (int)StudentFilter.SelectedValue)
                    {
                        temp.Add(item);
                        break;
                    }
                }
            }
            StudentGrid.DataSource = temp.Select(t => new
            {
                ID = t.Id,
                Name = t.Name,
                Bill = t.Bill,
                Phone = t.Phone,
                Adress = t.Adress
            }).ToList();

        }

        public void billComboBox()
        {
            billCombo.Items.Add("Bill > 0");
            billCombo.Items.Add("Bill > 500");
            billCombo.Items.Add("Bill > 1000");

        }
        private void BillCombo_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            if (billCombo.SelectedItem.ToString() == "Bill > 0")
            {
                var temp = dbContext.Students.Where(s => s.Bill > 0)
                   .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Bill, Phone = t.Phone, Adress = t.Adress }).ToList();
                StudentGrid.DataSource = temp;

            }
            else if (billCombo.SelectedItem.ToString() == "Bill > 500")
            {
                var temp = dbContext.Students.Where(s => s.Bill > 500)
                .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Bill, Phone = t.Phone, Adress = t.Adress }).ToList();
                StudentGrid.DataSource = temp;
            }
            else if (billCombo.SelectedItem.ToString() == "Bill > 1000")
            {
                var temp = dbContext.Students.Where(s => s.Bill > 1000)
                .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Bill, Phone = t.Phone, Adress = t.Adress }).ToList();
                StudentGrid.DataSource = temp;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (StudentMin.Text.Trim() != "" && int.TryParse(StudentMin.Text, out _)
               && StudentMax.Text.Trim() != "" && int.TryParse(StudentMax.Text, out _))
            {
                if (int.Parse(StudentMin.Text) >= 0 && int.Parse(StudentMax.Text) > int.Parse(StudentMin.Text))
                {
                    var temp = dbContext.Students.Where(s => s.Bill >= int.Parse(StudentMin.Text) &&
                        s.Bill <= int.Parse(StudentMax.Text))
                     .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Bill, Phone = t.Phone, Adress = t.Adress }).ToList();
                    StudentGrid.DataSource = temp;
                }
                else
                {
                    MessageBox.Show("Please ensure Min and Max are positive numbers with Max greater than Min.");
                }
            }
            else
            {
                MessageBox.Show("Please ensure Min and Max values are valid.");
            }
        }
        #endregion

        /// ///////////////////////////////////////////////////////////////

        #region Teacher
        public void displayTeacher()
        {
            Tdata.DataSource = dbContext.Teachers.
               Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Earning, Phone = t.Phone, Adress = t.Adress }).ToList();

            int total = (int)dbContext.Teachers.Sum(s => s.Earning);
            TtotalBill.Text = total.ToString()+" L.E";
        }
        private void TsearchBtn_Click(object sender, EventArgs e)
        {

            if (Tsearch.Text.Trim() != "")
            {
                string x = TcomboSearch.SelectedItem.ToString();
                if (x == "Name")
                {
                    var temp = dbContext.Teachers.Where(s => s.Name.ToLower().Contains(Tsearch.Text.Trim().ToLower()))
                      .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Earning, Phone = t.Phone, Adress = t.Adress }).ToList();
                    Tdata.DataSource = temp;

                    Tsearch.Clear();
                }
                else if (x == "Phone")
                {
                    var temp = dbContext.Teachers.Where(s => s.Phone.ToLower().Contains(Tsearch.Text.Trim().ToLower()))
                    .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Earning, Phone = t.Phone, Adress = t.Adress }).ToList();
                    Tdata.DataSource = temp;

                    Tsearch.Clear();
                }
                else if (x == "Address")
                {
                    var temp = dbContext.Teachers.Where(s => s.Adress.ToLower().Contains(Tsearch.Text.Trim().ToLower()))
                     .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Earning, Phone = t.Phone, Adress = t.Adress }).ToList();
                    Tdata.DataSource = temp;

                    Tsearch.Clear();
                }

            }
        }
        private void TresetBtn_Click(object sender, EventArgs e)
        {
            displayTeacher();
            Tsearch.Clear();
        }
        private void Tdata_SelectionChanged(object? sender, EventArgs e)
        {
            TeditBtn.Enabled = false;
            TaddBtn.Enabled = true;
            TbillBtn.Enabled = false;
            TuserName.Enabled = true;
            Tbill.Enabled = false;
            TuserName.Clear();
            Tname.Clear();
            Tbill.Clear();
            Tphone.Clear();
            Taddress.Clear();
        }
        private void Tdata_RowHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Tdata.Rows[e.RowIndex];
                if (row != null)
                {
                    Tname.Text = row.Cells["Name"].Value.ToString();
                    Tphone.Text = row.Cells["Phone"].Value.ToString();
                    Taddress.Text = row.Cells["Adress"].Value.ToString();
                    Tbill.Text = row.Cells["Bill"].Value.ToString();
                    TeditBtn.Enabled = true;
                    TaddBtn.Enabled = false;
                    TbillBtn.Enabled = true;
                    Tbill.Enabled = true;
                    TuserName.Enabled = false;
                    TuserName.Clear();

                }
            }
        }
        private void TaddBtn_Click(object sender, EventArgs e)
        {
            //if(validatePhoneNumberRegex.IsMatch(StudentPhone.Text))
            //MessageBox.Show(validatePhoneNumberRegex.IsMatch(StudentPhone.Text).ToString());
            if (Tname.Text.Trim() != "" && Taddress.Text.Trim() != "" &&
                TuserName.Text.Trim() != "" && validatePhoneNumberRegex.IsMatch(Tphone.Text))
            {
                Account addedAccount = new Account()
                {
                    UserName = TuserName.Text.Trim(),
                    Password = "1",
                    Type = "Teacher"
                };
                var checkUserName = dbContext.Accounts
                        .Where(s => s.UserName == addedAccount.UserName)
                        .FirstOrDefault();
                if (checkUserName == null)
                {
                    dbContext.Accounts.Add(addedAccount);
                    dbContext.SaveChanges();
                    Teacher addedTeacher = new Teacher()
                    {
                        Name = Tname.Text.Trim(),
                        Adress = Taddress.Text.Trim(),
                        Phone = Tphone.Text.Trim(),
                        Earning = 0,
                        AccountsId = addedAccount.Id
                    };
                    dbContext.Teachers.Add(addedTeacher);
                    dbContext.SaveChanges();
                    MessageBox.Show($"Teacher Added Successfully user name: {addedAccount.UserName} and Password: {addedAccount.Password}");
                    TuserName.Clear();
                    Tname.Clear();
                    Taddress.Clear();
                    Tphone.Clear();
                    displayTeacher();
                }
                else
                {
                    MessageBox.Show("This Account user name is already exisit");
                }

            }
            else if (Tname.Text.Trim() != "" && Taddress.Text.Trim() != "" &&
                TuserName.Text.Trim() != "" && Tphone.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Valid Phone number");
            }
            else
            {
                MessageBox.Show("Some data are missing");
            }
        }
        private void TeditBtn_Click(object sender, EventArgs e)
        {
            if (Tdata.SelectedRows.Count >= 0)
            {
                if (Tname.Text.Trim() != "" && Taddress.Text.Trim() != "" &&
                 validatePhoneNumberRegex.IsMatch(Tphone.Text))
                {

                    Teacher? editTeacher = dbContext.Teachers
                        .Where(s => s.Id == (int)Tdata
                        .SelectedRows[0].Cells["ID"].Value)
                        .FirstOrDefault();
                    if (editTeacher != null)
                    {
                        editTeacher.Name = Tname.Text.Trim().ToLower();
                        editTeacher.Phone = Tphone.Text.Trim().ToLower();
                        editTeacher.Adress = Taddress.Text.Trim().ToLower();
                        dbContext.Teachers.Update(editTeacher);
                        dbContext.SaveChanges();
                        MessageBox.Show($"Teacher information has been successfully updated. Teacher ID: {editTeacher.Id}");
                        TuserName.Clear();
                        Tname.Clear();
                        Taddress.Clear();
                        Tphone.Clear();
                        Tbill.Clear();
                        displayTeacher();
                    }


                }
                else if (Tname.Text.Trim() != "" && Taddress.Text.Trim() != "" &&
                    Tphone.Text.Trim() != "")
                {
                    MessageBox.Show("Please enter a valid phone number.");
                }
                else
                {
                    MessageBox.Show("Some data is missing. Please fill in all required fields.");
                }
            }
            else
            {
                MessageBox.Show("Please select a teacher to edit.");
            }
        }
        private void TbillBtn_Click(object sender, EventArgs e)
        {
            if (Tdata.SelectedRows.Count >= 0)
            {
                if (Tbill.Text.Trim() != "" && int.TryParse(Tbill.Text, out _))
                {

                    Teacher? targetTeacher = dbContext.Teachers
                        .Where(s => s.Id == (int)Tdata
                        .SelectedRows[0].Cells["ID"].Value)
                        .FirstOrDefault();
                    int payValue = int.Parse(Tbill.Text);
                    if (targetTeacher != null && payValue > 0)
                    {

                        if (payValue <= targetTeacher.Earning)
                        {
                            targetTeacher.Earning -= payValue;
                            dbContext.Teachers.Update(targetTeacher);
                            dbContext.SaveChanges();
                            MessageBox.Show($"Payment of {payValue} LE was successfully made to Teacher {targetTeacher.Name}. Remaining balance for {targetTeacher.Name}: {targetTeacher.Earning} LE");
                            TuserName.Clear();
                            Tname.Clear();
                            Taddress.Clear();
                            Tphone.Clear();
                            Tbill.Clear();
                            displayTeacher();
                        }
                        else
                        {
                            MessageBox.Show("Payment cannot exceed the Bill value.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid value for payment.");

                    }

                }
                else
                {
                    MessageBox.Show("Please enter a valid value for payment.");
                }
            }
            else
            {
                MessageBox.Show("You must select a teacher to pay their Bills.");
            }
        }
        public void TfilterComboBox()
        {
            Tfilter.DataSource = dbContext.Courses.ToList();
            Tfilter.DisplayMember = "Name";
            Tfilter.ValueMember = "Id";
        }
        private void Tfilter_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            List<Teacher> temp = new List<Teacher>();

            var teacherCourses = dbContext.Teachers
                .Join(
                    dbContext.Courses,
                    teacher => teacher.Id,
                    course => course.TeacherId,
                    (teacher, course) => new
                    {
                        Teacher = teacher,
                        Course = course
                    });

            foreach (var item in teacherCourses)
            {
                if (item.Course.Id == (int)Tfilter.SelectedValue)
                {
                    temp.Add(item.Teacher);
                }
            }

            Tdata.DataSource = temp.Select(t => new
            {
                ID = t.Id,
                Name = t.Name,
                Bill = t.Earning,
                Phone = t.Phone,
                Address = t.Adress
            }).ToList();
        }
        public void TearningComboBox()
        {
            Tearning.Items.Add("Bill > 0");
            Tearning.Items.Add("Bill > 500");
            Tearning.Items.Add("Bill > 1000");
        }
        private void Tearning_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            if (Tearning.SelectedItem.ToString() == "Bill > 0")
            {
                var temp = dbContext.Teachers.Where(s => s.Earning > 0)
                   .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Earning, Phone = t.Phone, Adress = t.Adress }).ToList();
                Tdata.DataSource = temp;

            }
            else if (Tearning.SelectedItem.ToString() == "Bill > 500")
            {
                var temp = dbContext.Teachers.Where(s => s.Earning > 500)
   .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Earning, Phone = t.Phone, Adress = t.Adress }).ToList();
                Tdata.DataSource = temp;
            }
            else if (Tearning.SelectedItem.ToString() == "Bill > 1000")
            {
                var temp = dbContext.Teachers.Where(s => s.Earning > 1000)
   .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Earning, Phone = t.Phone, Adress = t.Adress }).ToList();
                Tdata.DataSource = temp;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (Tmin.Text.Trim() != "" && int.TryParse(Tmin.Text, out _)
                && Tmax.Text.Trim() != "" && int.TryParse(Tmax.Text, out _))
            {
                if (int.Parse(Tmin.Text) >= 0 && int.Parse(Tmax.Text) > int.Parse(Tmin.Text))
                {
                    var temp = dbContext.Teachers.Where(s => s.Earning >= int.Parse(Tmin.Text) &&
                        s.Earning <= int.Parse(Tmax.Text))
                     .Select(t => new { ID = t.Id, Name = t.Name, Bill = t.Earning, Phone = t.Phone, Adress = t.Adress }).ToList();
                    Tdata.DataSource = temp;
                }
                else
                {
                    MessageBox.Show("Please ensure Min and Max are positive numbers with Max greater than Min.");
                }
            }
            else
            {
                MessageBox.Show("Please ensure Min and Max values are valid.");
            }
        }
        #endregion

    }
}
