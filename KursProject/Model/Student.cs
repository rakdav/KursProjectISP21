using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace KursProject.Model;

public partial class Student: INotifyPropertyChanged
{
    [Key]
    public int StudentId { get; set; }
    

    public event PropertyChangedEventHandler? PropertyChanged;
    private string surname;
    public string Surname
    {
        get { return surname; }
        set
        {
            surname = value;
            OnPropertyChanged("Surname");
        }
    }

    public string Name { get; set; } = null!;

    public int Stipend { get; set; }

    public int Kurs { get; set; }

    public string? City { get; set; }

    public string? BirthDay { get; set; }

    public int UnivId { get; set; }

    public virtual ICollection<ExamMark> ExamMarks { get; set; } = new List<ExamMark>();

    public virtual University Univ { get; set; } = null!;
}
