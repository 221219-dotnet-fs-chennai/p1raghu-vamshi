using System;
using System.Collections.Generic;

namespace EntityApi.Entities;

public partial class UserDetail
{
    public int UserId { get; set; }

    public int  Age { get; set; }

    public string? Salutation { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<Education> Educations { get; } = new List<Education>();

    public virtual ICollection<Skill> Skills { get; } = new List<Skill>();
}
