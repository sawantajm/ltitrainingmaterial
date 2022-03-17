using System.ComponentModel.DataAnnotations;
namespace modelValidation.VM
{
    public class supliersorders
    {

        [Key]
        public int ProducId { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public int SupplierId { get; set; }
        public double UnitPrice { get; set; }




    }
}
