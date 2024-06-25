using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KursProject.Model;

public partial class Lecturer:BaseClass
{
    [Key]
    public int LecturerId { get; set; }

    private string? surname;
    public string? Surname {
        get { return surname; }
        set
        {
            surname = value;
            OnPropertyChanged(nameof(Surname));
        }
    }

    private string? name;
    public string? Name 
    {
        get { return name; }
        set
        {
            name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    private string? city;
    public string? City 
    {
        get { return city; }
        set
        {
            city = value;
            OnPropertyChanged(nameof(city));
        }
    }
    public int univId;
    public int UnivId 
    {
        get { return univId; }
        set
        {
            univId = value;
            OnPropertyChanged(nameof(UnivId));
        }
    }
}
