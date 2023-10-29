using System;
using System.Collections.Generic;

namespace ZooCoursework.DataBase;

public partial class Temperature
{
    public int Id { get; set; }

    public string DayTime { get; set; } = null!;

    public int Value { get; set; }

    public virtual ICollection<Aviary> Aviaries { get; set; } = new List<Aviary>();

    public virtual ICollection<TemperatureMethod> TemperatureMethods { get; set; } = new List<TemperatureMethod>();
}
