using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ForgotPassword
    {
        public string? Email { get; set; }
        public bool? Emailsent { get; set; }

        public virtual Registration? EmailNavigation { get; set; }
    }
}
