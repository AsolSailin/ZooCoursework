using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class Aviary
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int AnimalCount { get; set; }

    public bool Cleaned { get; set; }

    public int TypeId { get; set; }

    public int TemperatureId { get; set; }

    public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();

    public virtual Temperature Temperature { get; set; } = null!;

    public virtual TypeAviary Type { get; set; } = null!;

    public virtual ICollection<UserAviary> UserAviaries { get; set; } = new List<UserAviary>();
}
