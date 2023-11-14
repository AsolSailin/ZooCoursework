﻿using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class Report
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public bool IsAccepted { get; set; }

    public int UserId { get; set; }

    public int AviaryId { get; set; }

    public virtual Aviary Aviary { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
