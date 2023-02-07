using System;
using System.Collections.Generic;

namespace EntityApi.Entities;

public partial class UserDetail
{
    public int UserId { get; set; }

    public int Age { get; set; }

    public string? Salutation { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
