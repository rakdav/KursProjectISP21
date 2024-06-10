using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KursProject.Model;

public partial class ExamMark: INotifyPropertyChanged
{
    public int ExamId { get; set; }

    public int StudentId { get; set; }

    public int SubjId { get; set; }

    public int? Mark { get; set; }

    public string ExamDate { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subj { get; set; } = null!;

    public event PropertyChangedEventHandler? PropertyChanged;
}
