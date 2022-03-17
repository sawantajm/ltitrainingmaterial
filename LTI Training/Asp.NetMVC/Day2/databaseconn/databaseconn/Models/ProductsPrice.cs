using System;
using System.Collections.Generic;

namespace databaseconn.Models
{
    public partial class ProductsPrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
