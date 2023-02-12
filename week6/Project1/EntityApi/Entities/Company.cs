using System;
using System.Collections.Generic;

namespace EntityApi.Entities;

public partial class Company
{
    public int UserId { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string? CompanyLocation { get; set; }

    public int Experience { get; set; }

    public string? CompanyEmail { get; set; }

    public string? Website { get; set; }

    public virtual UserDetail? User { get; set; }
}
