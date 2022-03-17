using System.ComponentModel.DataAnnotations;

namespace tryfilereading.Models
{
    public class fileupload
    {
        [Key]
        public int Qid { get; set; }
        public int Qnumber { get; set; }
        public string quetion { get; set; }
    }
}
