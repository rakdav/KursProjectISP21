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
            if(value==surname) surname = value;
            OnPropertyChanged(nameof(Surname));
        }
    }

    private string? name;
    public string? Name 
    {
        get { return name; }
        set 
        {
            if(value==name) name = value;
            OnPropertyChanged(nameof(Name));
        } 
    }

    private int stipend;
    public int Stipend 
    {
        get { return stipend; }
        set
        {
            if(value==stipend) stipend = value;
            OnPropertyChanged(nameof(Stipend));
        }
    }

    private int kurs;
    public int Kurs 
    {
        get { return kurs; }
        set
        {
            if(value==kurs) kurs = value;
            OnPropertyChanged(nameof(Kurs));
        }
    }

    private string? city;
    public string? City 
    { get { return city; }
      set 
        {
            if(value==city) city = value;
            OnPropertyChanged(nameof(city));
        } 
    }

    private string? birthDay;
    public string? BirthDay 
    {
        get { return birthDay; }
        set
        {
            if(birthDay==value) birthDay = value;
            OnPropertyChanged(nameof(BirthDay));
        } 
    }

    private int univId;
    public int UnivId 
    { 
        get { return univId; } 
        set 
        {
            if(value==univId) univId = value;
            OnPropertyChanged(nameof(UnivId));
        }
    }

    public virtual ICollection<ExamMark> ExamMarks { get; set; } = new List<ExamMark>();

    public virtual University Univ { get; set; } = null!;
}
