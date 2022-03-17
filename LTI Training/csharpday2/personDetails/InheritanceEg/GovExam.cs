using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEg
{

    class Exam
    {
        public int id { get; set; }

        public string examname { get; set; }

        internal Exam(int id,string examname)
        {
            this.id = id;
            this.examname = examname;

        }
        internal void ExamInfo()
        {
            Console.WriteLine("ExamId: {0} || Exam Name :{1}",id,examname);

        }
    }
    class Student:Exam
    {
        public int id { get; set; }

        public string sname { get; set;}

        public string contactno { get; set; }

        public string staus { get; set; }

       internal Student(int id,string examname,int sid,string sname,string contactno,string status):base(id,examname)
        {
            this.id = sid;
            this.sname = sname;
            this.contactno = contactno;
            this.staus = status;

        }
        internal void Printdata()
        {
            Console.WriteLine("sid :{0} || sname :{1} || contactno: {2}" ,id,sname,contactno);

        }
        protected void ExamStatus()
        {
            Console.WriteLine("Eid:{0} || sid :{1} || Status :{2}",base.id,id,staus);
        }
        ~Student()
        {
            Console.WriteLine("Student Destructor ");
        }
    }

    class ExamResult:Student
    {
       public int score { get; set; }
 
        internal ExamResult(int id, string examname, int sid, string sname, string contactno, string status,int score): base(id, examname,sid,sname,contactno,status)
        {
            this.score = score;
        }
        
       internal void Result()
        {
            ExamStatus();
            Console.WriteLine("Exam Name:{0} || sid : {1} || Score :{2}",examname,id,score);

        }
        ~ExamResult() 
        {
            Console.WriteLine("ExamResult Destructor ");        
        }
    }

    internal class GovExam
    {
        static void Main()
        {
            /* Student student = new Student(1000,"TRB",101,"Hari","7898956232","Attended");*/
            ExamResult examresult = new ExamResult(1000, "TRB", 101, "Hari", "7898956232","Attended",120);
           examresult.ExamInfo();

            // student.Printdata();
            examresult.Result();
           // student.ExamStatus();
        }
    }
}
