using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class UserAviary
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int AviaryId { get; set; }

    public virtual Aviary Aviary { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
