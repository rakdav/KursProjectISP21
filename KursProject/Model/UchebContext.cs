using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KursProject.Model;

public partial class UchebContext : DbContext
{
    public UchebContext()
    {
    }

    public UchebContext(DbContextOptions<UchebContext> options)
        : base(options)
    {

    }

    public virtual DbSet<ExamMark> ExamMarks { get; set; }

    public virtual DbSet<Lecturer> Lecturers { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<SubjLect> SubjLects { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<University> Universities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=ucheb.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ExamMark>(entity =>
        {
            entity.HasKey(e => e.ExamId);

            entity.ToTable("EXAM_MARKS");

            entity.Property(e => e.ExamId)
                .ValueGeneratedNever()
                .HasColumnName("EXAM_ID");
            entity.Property(e => e.ExamDate).HasColumnName("EXAM_DATE");
            entity.Property(e => e.Mark).HasColumnName("MARK");
            entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");
            entity.Property(e => e.SubjId).HasColumnName("SUBJ_ID");

        });

        modelBuilder.Entity<Lecturer>(entity =>
        {
            entity.ToTable("LECTURER");

            entity.Property(e => e.LecturerId).HasColumnName("LECTURER_ID");
            entity.Property(e => e.City).HasColumnName("CITY");
            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.Surname).HasColumnName("SURNAME");
            entity.Property(e => e.UnivId).HasColumnName("UNIV_ID");

        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.BirthDay).HasColumnName("birth_day");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Kurs).HasColumnName("kurs");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Stipend).HasColumnName("stipend");
            entity.Property(e => e.Surname).HasColumnName("surname");
            entity.Property(e => e.UnivId).HasColumnName("univ_id");

            //     entity.HasOne(d => d.Univ).WithMany(p => p.Students).HasForeignKey(d => d.UnivId);
        });

        modelBuilder.Entity<SubjLect>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SUBJ_LECT");

            entity.Property(e => e.LecturerId).HasColumnName("LECTURER _ID");
            entity.Property(e => e.SubjId).HasColumnName("SUBJ_ID");

        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjId);

            entity.ToTable("SUBJECT");

            entity.Property(e => e.SubjId).HasColumnName("SUBJ_ID");
            entity.Property(e => e.Hour).HasColumnName("HOUR");
            entity.Property(e => e.Semester).HasColumnName("SEMESTER");
            entity.Property(e => e.SubjName).HasColumnName("SUBJ_NAME");
        });

        modelBuilder.Entity<University>(entity =>
        {
            entity.HasKey(e => e.UnivId);

            entity.ToTable("UNIVERSITY");

            entity.Property(e => e.UnivId).HasColumnName("UNIV_ID");
            entity.Property(e => e.City).HasColumnName("CITY");
            entity.Property(e => e.Rating).HasColumnName("RATING");
            entity.Property(e => e.UnivName).HasColumnName("UNIV_NAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
