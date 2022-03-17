using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Registration
    {
        public int UserId { get; set; }
        public string? Fullname { get; set; }
        public string Email { get; set; } = null!;
        public string? Password { get; set; }
        public string? City { get; set; }
        public DateTime? Dob { get; set; }
        public string? State { get; set; }
        public string? Qualification { get; set; }
        public DateTime? YearOfCompletion { get; set; }
        public string? MobileNo { get; set; }
    }
}
