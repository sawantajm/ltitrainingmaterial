using System.ComponentModel.DataAnnotations;

namespace onlineExam.Models
{
    public class ForgotPassword
    {
        [Key]
        public string Email { get; set; }
        public bool Emailsent { get; set; }
    }
}
