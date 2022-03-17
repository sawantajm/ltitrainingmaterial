using System.ComponentModel.DataAnnotations;

namespace databaseconn.Models
{
    public class CustOrdersOrders
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
    public Nullable<DateTime> RequiredDate { get; set; }
     public Nullable<DateTime> ShippedDate { get; set; }
    }
}
