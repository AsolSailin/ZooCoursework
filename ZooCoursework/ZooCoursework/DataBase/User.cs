using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class User
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Patronymic { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<UserAviary> UserAviaries { get; set; } = new List<UserAviary>();
}
