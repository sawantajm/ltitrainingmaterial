using System.ComponentModel.DataAnnotations;

namespace modelValidation.VM
{
    public class CustomerVM
    {
        [Key]

        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public int OrderId { get; set; }
        
        public DateTime? OrderDate { get; internal set; }
    }
}
