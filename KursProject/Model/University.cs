using System;
using System.Collections.Generic;

namespace KursProject.Model;

public partial class University
{
    public int UnivId { get; set; }

    public string UnivName { get; set; } = null!;

    public int Rating { get; set; }

    public string City { get; set; } = null!;

    public virtual ICollection<Lecturer> Lecturers { get; set; } = new List<Lecturer>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
