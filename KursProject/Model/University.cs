using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KursProject.Model;

public partial class University:BaseClass
{
    [Key]
    public int UnivId { get; set; }

    private string? univName;
    public string? UnivName 
    {
        get { return univName; }
        set
        {
            univName = value;
            OnPropertyChanged(nameof(UnivName));
        }
    }

    private int rating;
    public int Rating 
    {
        get { return rating; }
        set
        {
            rating = value;
            OnPropertyChanged(nameof(Rating));
        }
    }

    private string? city;
    public string? City 
    {
        get { return city; }
        set
        {
            city = value;
            OnPropertyChanged(nameof(City));
        }
    }

}
