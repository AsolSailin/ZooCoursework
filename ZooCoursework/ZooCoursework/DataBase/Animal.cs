using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class Animal
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int AviaryId { get; set; }

    public int KindId { get; set; }

    public int ConditionId { get; set; }

    public byte[] Image { get; set; } = null!;

    public virtual ICollection<AnimalMaterial> AnimalMaterials { get; set; } = new List<AnimalMaterial>();

    public virtual ICollection<AnimalProduct> AnimalProducts { get; set; } = new List<AnimalProduct>();

    public virtual Aviary Aviary { get; set; } = null!;

    public virtual ConditionAccommodation Condition { get; set; } = null!;

    public virtual AnimalKind Kind { get; set; } = null!;
}
