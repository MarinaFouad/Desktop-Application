using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public double Bill { get; set; }

    public int AccountsId { get; set; }

    public virtual Account Accounts { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
