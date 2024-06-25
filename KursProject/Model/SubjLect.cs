using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KursProject.Model;

public partial class SubjLect:BaseClass
{
    [Key]
    public int LecturerId { get; set; }

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
}
