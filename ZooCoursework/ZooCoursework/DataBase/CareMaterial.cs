using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class CareMaterial
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AnimalMaterial> AnimalMaterials { get; set; } = new List<AnimalMaterial>();
}
