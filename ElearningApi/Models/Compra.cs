using System;
using System.Collections.Generic;

namespace ElearningApi.Models;

public partial class Compra
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public int IdCourse { get; set; }

    public DateTime Date { get; set; }
}
