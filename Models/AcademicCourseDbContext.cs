using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Project.Models;

public partial class AcademicCourseDbContext : DbContext
{
    public AcademicCourseDbContext()
    {
    }

    public AcademicCourseDbContext(DbContextOptions<AcademicCourseDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CoursesSchedule> CoursesSchedules { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<Track> Tracks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-1T6LFVE\\SQLEXPRESS;Database=AcademicCourseDB;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Accounts__3214EC273AE2415A");

            entity.HasIndex(e => e.UserName, "UC_UserName").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Course__3214EC275AC4CBBF");

            entity.ToTable("Course");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SessionNumber).HasColumnName("Session_Number");
            entity.Property(e => e.TeacherId).HasColumnName("Teacher_ID");
            entity.Property(e => e.TrackId).HasColumnName("Track_ID");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Courses)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Course__Teacher___34C8D9D1");

            entity.HasOne(d => d.Track).WithMany(p => p.Courses)
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Course__Track_ID__33D4B598");
        });

        modelBuilder.Entity<CoursesSchedule>(entity =>
        {
            entity.HasKey(e => new { e.CoursesId, e.Date }).HasName("PK_Courses_Schedule_Constr");

            entity.ToTable("Courses_Schedule");

            entity.Property(e => e.CoursesId).HasColumnName("Courses_ID");

            entity.HasOne(d => d.Courses).WithMany(p => p.CoursesSchedules)
                .HasForeignKey(d => d.CoursesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Courses_S__Cours__37A5467C");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC273910AB4E");

            entity.ToTable("Student");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountsId).HasColumnName("Accounts_ID");
            entity.Property(e => e.Adress).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Accounts).WithMany(p => p.Students)
                .HasForeignKey(d => d.AccountsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Student__Account__2C3393D0");

            entity.HasMany(d => d.Courses).WithMany(p => p.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentCourse",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Student_C__Cours__3C69FB99"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Student_C__Stude__3B75D760"),
                    j =>
                    {
                        j.HasKey("StudentId", "CourseId").HasName("PK_Student_Course_Constr");
                        j.ToTable("Student_Course");
                        j.IndexerProperty<int>("StudentId").HasColumnName("Student_ID");
                        j.IndexerProperty<int>("CourseId").HasColumnName("Course_ID");
                    });
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teacher__3214EC2701B852A6");

            entity.ToTable("Teacher");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountsId).HasColumnName("Accounts_ID");
            entity.Property(e => e.Adress).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Accounts).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.AccountsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Teacher__Account__286302EC");
        });

        modelBuilder.Entity<Track>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Track__3214EC27DD09D7FE");

            entity.ToTable("Track");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
