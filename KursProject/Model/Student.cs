using System;
using System.Collections.Generic;

namespace KursProject.Model;

public partial class Student
{
    public int StudentId { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Stipend { get; set; }

    public int Kurs { get; set; }

    public string? City { get; set; }

    public string? BirthDay { get; set; }

    public int UnivId { get; set; }

    public virtual ICollection<ExamMark> ExamMarks { get; set; } = new List<ExamMark>();

    public virtual University Univ { get; set; } = null!;
}
