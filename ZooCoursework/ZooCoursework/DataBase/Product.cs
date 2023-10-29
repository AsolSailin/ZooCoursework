using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AnimalProduct> AnimalProducts { get; set; } = new List<AnimalProduct>();
}
