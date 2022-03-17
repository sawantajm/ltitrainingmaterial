using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace modelValidation.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }


        public int CategoryId { get; set; }
        [Required (ErrorMessage ="Please Enter CategoryName")]
        public string CategoryName { get; set; } = null!;
        [Required(ErrorMessage ="Please Enter Description")]
        [StringLength(10,ErrorMessage="Description maximum Length Should be 10")]
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
