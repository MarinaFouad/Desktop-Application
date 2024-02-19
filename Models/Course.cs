using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Capcity { get; set; }

    public int SessionNumber { get; set; }

    public int Fees { get; set; }

    public int TrackId { get; set; }

    public int TeacherId { get; set; }

    public virtual ICollection<CoursesSchedule> CoursesSchedules { get; set; } = new List<CoursesSchedule>();

    public virtual Teacher Teacher { get; set; } = null!;

    public virtual Track Track { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
