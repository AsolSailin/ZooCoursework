using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class CoolingMethod
{
    public int Id { get; set; }

    public string CoolingFacility { get; set; } = null!;

    public virtual ICollection<TemperatureMethod> TemperatureMethods { get; set; } = new List<TemperatureMethod>();
}
