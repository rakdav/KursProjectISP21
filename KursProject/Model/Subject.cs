using System;
using System.Collections.Generic;

namespace KursProject.Model;

public partial class Subject
{
    public int SubjId { get; set; }

    public string SubjName { get; set; } = null!;

    public int Hour { get; set; }

    public int Semester { get; set; }

    public virtual ICollection<ExamMark> ExamMarks { get; set; } = new List<ExamMark>();
}
