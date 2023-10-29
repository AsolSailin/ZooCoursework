using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<UserAviary> UserAviaries { get; set; } = new List<UserAviary>();
}
