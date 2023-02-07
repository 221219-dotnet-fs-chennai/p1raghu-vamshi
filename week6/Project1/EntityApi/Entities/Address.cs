using System;
using System.Collections.Generic;

namespace EntityApi.Entities;

public partial class Address
{
    public int? UserId { get; set; }

    public long PhoneNumber { get; set; }

    public string? UserAddress { get; set; }

    public string? Country { get; set; }

    public int? Pincode { get; set; }

    public virtual UserDetail? User { get; set; }
}
