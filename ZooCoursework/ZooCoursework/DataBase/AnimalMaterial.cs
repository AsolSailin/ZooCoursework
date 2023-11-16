﻿using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class AnimalMaterial
{
    public int Id { get; set; }

    public int AnimalId { get; set; }

    public int MaterialId { get; set; }

    public DateTime? Date { get; set; }

    public virtual Animal Animal { get; set; } = null!;

    public virtual CareMaterial Material { get; set; } = null!;
}
