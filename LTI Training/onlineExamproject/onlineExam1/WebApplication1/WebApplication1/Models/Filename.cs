using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Filename
    {
        public Filename()
        {
            QuestionDetails = new HashSet<QuestionDetail>();
        }

        public int FileId { get; set; }
        public string? FileName1 { get; set; }

        public virtual ICollection<QuestionDetail> QuestionDetails { get; set; }
    }
}
