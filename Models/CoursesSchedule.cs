using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class CoursesSchedule
{
    public int CoursesId { get; set; }

    public DateOnly Date { get; set; }

    public int Time { get; set; }

    public virtual Course Courses { get; set; } = null!;
}
