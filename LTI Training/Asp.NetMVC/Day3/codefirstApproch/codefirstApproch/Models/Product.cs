using System.ComponentModel.DataAnnotations;

namespace codefirstApproch.Models
{
    public class Product
    {
        [Key]
        public int pid { get; set; }
        public string pname { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public string quantity { get; set; }
    }
}
