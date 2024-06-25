using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KursProject.Model;

public partial class ExamMark: BaseClass
{
    [Key]
    public int ExamId { get; set; }
    private int studentId;
    public int StudentId 
    {
        get { return studentId; }
        set
        {
            studentId = value;
            OnPropertyChanged(nameof(StudentId));
        }
    }
    private int subjId;
    public int SubjId 
    {
        get { return subjId; }
        set
        {
            subjId = value;
            OnPropertyChanged(nameof(SubjId));
        }
    }

    public int? mark;
    public int? Mark 
    {
        get { return mark; }
        set
        {
            mark = value;
            OnPropertyChanged(nameof(Mark));
        }
    }

    public string? examDate;
    public string? ExamDate 
    {
        get { return examDate; }
        set
        {
            examDate = value;
            OnPropertyChanged(nameof(ExamDate));
        }
    }
}
