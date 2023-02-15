using System;
using System.Collections.Generic;

namespace EntityApi.Entities;

public partial class Skill
{
    public int UserId { get; set; }

    public int SkillId { get; set; }

    public string? SkillName { get; set; }

    public virtual UserDetail? User { get; set; }
}
