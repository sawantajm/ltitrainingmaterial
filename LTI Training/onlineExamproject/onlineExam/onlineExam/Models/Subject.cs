using System;
using System.Collections.Generic;

namespace onlineExam.Models
{
    public partial class Subject
    {
        public Subject()
        {
            QuestionDetails = new HashSet<QuestionDetail>();
        }

        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }

        public virtual ICollection<QuestionDetail> QuestionDetails { get; set; }
    }
}
