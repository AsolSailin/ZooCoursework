using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class TemperatureMethod
{
    public int Id { get; set; }

    public int TemperatureId { get; set; }

    public int MethodId { get; set; }

    public virtual CoolingMethod Method { get; set; } = null!;

    public virtual Temperature Temperature { get; set; } = null!;
}
