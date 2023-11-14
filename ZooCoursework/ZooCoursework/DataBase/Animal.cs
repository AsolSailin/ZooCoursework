﻿using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class Animal
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public byte[]? Image { get; set; }

    public int AviaryId { get; set; }

    public bool? IsFed { get; set; }

    public virtual ICollection<AnimalMaterial> AnimalMaterials { get; set; } = new List<AnimalMaterial>();

    public virtual Aviary Aviary { get; set; } = null!;
}
