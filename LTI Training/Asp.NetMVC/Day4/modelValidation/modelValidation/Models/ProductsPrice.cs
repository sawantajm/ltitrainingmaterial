﻿using System;
using System.Collections.Generic;

namespace modelValidation.Models
{
    public partial class ProductsPrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
