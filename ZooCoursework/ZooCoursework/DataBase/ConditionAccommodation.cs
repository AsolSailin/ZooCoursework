using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class ConditionAccommodation
{
    public int Id { get; set; }

    public string MinTemp { get; set; } = null!;

    public string MaxTemp { get; set; } = null!;

    public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();
}
