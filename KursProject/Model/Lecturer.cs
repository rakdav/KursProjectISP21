using System;
using System.Collections.Generic;

namespace KursProject.Model;

public partial class Lecturer
{
    public int LecturerId { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    public int UnivId { get; set; }

    public virtual University Univ { get; set; } = null!;
}
