using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class TypeAviary
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Aviary> Aviaries { get; set; } = new List<Aviary>();
}
