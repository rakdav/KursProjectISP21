using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KursProject.Model;

public partial class Subject:BaseClass
{
    [Key]
    public int SubjId { get; set; }

    private string? subjName;
    public string? SubjName 
    {
        get { return subjName; }
        set
        {
            subjName = value;
            OnPropertyChanged(nameof(SubjName));
        }
    }
    private int hour;
    public int Hour 
    {
        get { return hour; }
        set
        {
            hour = value;
            OnPropertyChanged(nameof(Hour));
        }
    }

    private int semester;
    public int Semester 
    {
        get { return semester; }
        set
        {
            semester = value;
            OnPropertyChanged(nameof(Semester));
        }
    }
}
