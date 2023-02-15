using System;
using System.Collections.Generic;

namespace EntityApi.Entities;

public partial class Education
{
    public int UserId { get; set; }

    public int RollNo { get; set; }

    public string? University { get; set; }

    public string? UG { get; set; }

    public string? Specialization { get; set; }

    public int PassedOutYear { get; set; }

    public string? Grade { get; set; }

    public virtual UserDetail? User { get; set; }
}
