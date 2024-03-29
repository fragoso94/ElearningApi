﻿using System;
using System.Collections.Generic;

namespace ElearningApi.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Status { get; set; }
}
