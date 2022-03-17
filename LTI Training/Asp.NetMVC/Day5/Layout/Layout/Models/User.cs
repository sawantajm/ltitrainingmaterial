using System.ComponentModel.DataAnnotations;

namespace Layout.Models
{
    public class User
    {
        [Key]
        public int uid { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
    }
}
