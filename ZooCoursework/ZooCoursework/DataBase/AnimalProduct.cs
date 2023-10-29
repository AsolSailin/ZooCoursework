using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class AnimalProduct
{
    public int Id { get; set; }

    public int AnimalId { get; set; }

    public int ProductId { get; set; }

    public virtual Animal Animal { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
