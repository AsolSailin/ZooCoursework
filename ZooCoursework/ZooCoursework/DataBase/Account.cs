﻿using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class Account
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
