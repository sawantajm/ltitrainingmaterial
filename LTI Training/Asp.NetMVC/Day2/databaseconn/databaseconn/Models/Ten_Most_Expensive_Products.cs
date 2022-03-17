
using System.ComponentModel.DataAnnotations;
namespace databaseconn.Models
{
    public class Ten_Most_Expensive_Products
    {
            [Key]
        public string TenMostExpensiveProducts{ get; set; }

        public double UnitPrice { get; set; }

    }
}
