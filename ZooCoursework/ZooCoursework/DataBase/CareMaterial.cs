using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class CareMaterial
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int TypeId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<AnimalMaterial> AnimalMaterials { get; set; } = new List<AnimalMaterial>();

    public virtual MaterialType Type { get; set; } = null!;
}
