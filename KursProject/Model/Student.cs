using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace KursProject.Model;

public partial class Student: BaseClass
{
    [Key]
    public int StudentId { get; set; }
    
    private string? surname;
    public string? Surname
    {
        get { return surname; }
        set
        {
            surname = value;
            OnPropertyChanged("Surname");
        }
    }

    private string? name;
    public string? Name 
    {
        get { return name; }
        set 
        {
            name = value;
            OnPropertyChanged("Name");
        } 
    }

    private int stipend;
    public int Stipend 
    {
        get { return stipend; }
        set
        {
            stipend = value;
            OnPropertyChanged("Stipend");
        }
    }

    private int kurs;
    public int Kurs 
    {
        get { return kurs; }
        set
        {
            kurs = value;
            OnPropertyChanged("Kurs");
        }
    }

    private string? city;
    public string? City 
    { get { return city; }
      set 
        {
            city = value;
            OnPropertyChanged("City");
        } 
    }

    private string? birthDay;
    public string? BirthDay 
    {
        get { return birthDay; }
        set
        {
            birthDay = value;
            OnPropertyChanged("BirthDay");
        } 
    }

    private int univId;
    public int UnivId 
    { 
        get { return univId; } 
        set 
        {
            univId = value;
            OnPropertyChanged("UnivId");
        }
    }

    public virtual ICollection<ExamMark> ExamMarks { get; set; } = new List<ExamMark>();

    public virtual University Univ { get; set; } = null!;
}
