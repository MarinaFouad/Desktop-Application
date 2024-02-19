using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project;

public partial class CoursesFrame : Form
{
    readonly AcademicCourseDbContext context = new();
    public int? Id;
    public int TotalCost = 0;

    public CoursesFrame(int? Id)
    {
        InitializeComponent();
        Student? student = context.Students.FirstOrDefault(s => s.Id == Id);
        totalCostLabel.Text = student?.Bill.ToString();

        this.Id = Id;

        enrollPanel.Visible = false;
        enrolledCoursesPanel.Visible = false;
        paymentPanel.Visible = false;

        //////////////////////////////////////////////////////
        /// Filling the Combo Box
        //////////////////////////////////////////////////////

        List<Course> courses = [.. context.Courses];

        foreach (var course in courses)
            allCoursesComboBox.Items.Add(course.Name);

    }


    #region ClickHandlingMethods

    private void EnrollBtn_Click(object sender, EventArgs e)
    {
        Student? student = context.Students
                    .Include(s => s.Courses)
                    .FirstOrDefault(s => s.Id == Id);

        coursesTable.Rows.Clear();

        FillTheTable(student, coursesTable);

        enrollPanel.Visible = true;

        paymentPanel.Visible = false;

        enrolledCoursesPanel.Visible = false;
    }


    private void ConfirmButton_Click(object sender, EventArgs e)
    {
        courseLabel.Text = allCoursesComboBox.SelectedItem?.ToString();

        Student? student = context
                    .Students
                    .Include(s => s.Courses)
                    .FirstOrDefault(s => s.Id == Id);

        Course? course = context
                    .Courses
                    .FirstOrDefault(c => c.Name == courseLabel.Text);

        if (student is not null && course is not null)
        {
            if (student.Courses.Any(c => c.Id == course.Id))
            {
                MessageBox.Show("The Student Is Already Enrolled.");
                return;
            }

            student.Courses.Add(course);

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                courseLabel.Text = string.Empty;

                MessageBox.Show("An Error Occurs, Try Again Later.");

                return;
            }

            MessageBox.Show("The Purchase Done Successfully.");

            ShowThePurchaseDetails(student, course);

            ChangeTotalPaymentToTheStudentBill(student, course);

            Sending70PercentOfFeesToTeacher(course);
        }
    }


    private void ClearBtn_Click(object sender, EventArgs e)
    {
        costLabel.Text = string.Empty;

        studentNamelbl.Text = string.Empty;

        courseNameLbl.Text = string.Empty;
    }


    private void EnrolledCoursesBtn_Click(object sender, EventArgs e)
    {
        Student? student = context
        .Students
        .Where(s => s.Id == Id)
        .Include(s => s.Courses)
        .FirstOrDefault();

        FillTheTable(student, studentEnrolledTable);

        enrollPanel.Visible = false;

        paymentPanel.Visible = false;

        enrolledCoursesPanel.Visible = true;
    }


    private void ExitBtn_Click(object sender, EventArgs e) =>
        Application.Exit();


    private void PaymentBtn_Click(object sender, EventArgs e)
    {
        enrollPanel.Visible = false;

        paymentPanel.Visible = true;

        enrolledCoursesPanel.Visible = false;
    }

    #endregion


    #region DesignHandlingMethods

    private void EnrollBtn_MouseEnter(object sender, EventArgs e) =>
        EnrollBtn.BackColor = Color.FromArgb(3, 18, 28);


    private void EnrolledCoursesBtn_MouseEnter(object sender, EventArgs e) =>
        EnrolledCoursesBtn.BackColor = Color.FromArgb(3, 18, 28);


    private void PaymentBtn_MouseEnter(object sender, EventArgs e) =>
        PaymentBtn.BackColor = Color.FromArgb(3, 18, 28);


    private void ExitBtn_MouseEnter(object sender, EventArgs e) =>
        ExitBtn.BackColor = Color.Red;


    private void ConfirmButton_MouseEnter(object sender, EventArgs e) =>
        ConfirmButton.BackColor = Color.FromArgb(3, 18, 33);


    private void ClearBtn_MouseEnter(object sender, EventArgs e) =>
        ClearBtn.BackColor = Color.FromArgb(3, 18, 33);


    private void EnrollBtn_MouseLeave(object sender, EventArgs e) =>
        EnrollBtn.BackColor = Color.FromArgb(75, 150, 163);


    private void EnrolledCoursesBtn_MouseLeave(object sender, EventArgs e) =>
        EnrolledCoursesBtn.BackColor = Color.FromArgb(75, 150, 163);


    private void PaymentBtn_MouseLeave(object sender, EventArgs e) =>
        PaymentBtn.BackColor = Color.FromArgb(75, 150, 163);


    private void ExitBtn_MouseLeave(object sender, EventArgs e) =>
        ExitBtn.BackColor = Color.Transparent;


    private void ConfirmButton_MouseLeave(object sender, EventArgs e) =>
        ConfirmButton.BackColor = Color.Transparent;


    private void ClearBtn_MouseLeave(object sender, EventArgs e) =>
        ClearBtn.BackColor = Color.Transparent;

    #endregion


    #region HelpingMethods

    private static void FillTheTable(Student? student, DataGridView table)
    {
        table.Rows.Clear();
        if (student is not null)
        {
            List<Course> studentCourses = [.. student.Courses];

            foreach (var course in studentCourses)
            {
                table.Rows.Add(course.Name, course.Description,
                    course.Capcity, course.SessionNumber, course.Fees);
            }
        }
    }

    private void ShowThePurchaseDetails(Student? student, Course? course)
    {
        studentNamelbl.Text = student?.Name;

        costLabel.Text = course?.Fees.ToString();

        courseNameLbl.Text = course?.Name;
    }

    #endregion


    #region MoneyTransactionMethods

    private void Sending70PercentOfFeesToTeacher(Course course)
    {
        int teacherId = course.TeacherId;

        double teacherEarning = course.Fees * 0.7;

        Teacher? teacher = context.Teachers.FirstOrDefault(x => x.Id == teacherId);

        if (teacher is not null)
        {
            teacher.Earning += teacherEarning;
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Fees Transaction Error, Try Again.");
            }
        }
    }

    private void ChangeTotalPaymentToTheStudentBill(Student student, Course course)
    {
        student.Bill += course.Fees;

        totalCostLabel.Text = student.Bill.ToString();

    }

    #endregion
}
