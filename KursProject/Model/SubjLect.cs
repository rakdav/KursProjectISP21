using System;
using System.Collections.Generic;

namespace KursProject.Model;

public partial class SubjLect
{
    public int LecturerId { get; set; }

    public int SubjId { get; set; }

    public virtual Lecturer Lecturer { get; set; } = null!;

    public virtual Subject Subj { get; set; } = null!;
}
