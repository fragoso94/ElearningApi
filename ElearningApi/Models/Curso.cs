using System;
using System.Collections.Generic;

namespace ElearningApi.Models;

public partial class Curso
{
    public int Id { get; set; }

    public string? Image { get; set; }

    public string? Category { get; set; }

    public string? Name { get; set; }

    public decimal? Duration { get; set; }

    public decimal? Price { get; set; }

    public decimal? Rating { get; set; }
}
