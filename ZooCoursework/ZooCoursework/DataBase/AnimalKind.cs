using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class AnimalKind
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();
}
