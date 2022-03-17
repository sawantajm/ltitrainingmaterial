using System;
using System.Collections.Generic;

namespace onlineExam.Models
{
    public partial class Exam
    {
        public int ExamId { get; set; }
        public string? Questions { get; set; }
        public int? QuestionId { get; set; }
        public int? FileId { get; set; }
        public string? SubjectId { get; set; }
    }
}
