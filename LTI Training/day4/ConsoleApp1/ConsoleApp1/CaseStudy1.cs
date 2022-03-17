using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum feedback
    {
        poor=1,good,verygood,Excelant
    }

    class School
    {
        static string Schoolname;

        public string branchname { get; set; }

        static School()
        {
            Schoolname = "KV";
        }


    }
    class Student:School
    {
        public int id { get; set; }

        public string name { get; set; }

        public int physics { get; set; }
        public int chemistry { get; set; }

        public int math { get; set; }

        internal Student(int id, string name, int physics,int chemistry, int math)
        {
            this.id = id;
            this.name = name;
            this.physics = physics;
            this.chemistry = chemistry;
            this.math = math;

        }

        internal void CalculateCutoff()
        {
            try
            {
                branchname = "BioMath";
                float cutoff = ((physics + chemistry + math) / 3);
                dynamic fb;
                if (cutoff > 190)
                {
                    fb =feedback.Excelant;
                }

                else if(cutoff>170 && cutoff<189)
                {
                    fb = feedback.verygood;
                }
                else if(cutoff>160 &&  cutoff<169)
                {
                    fb = feedback.good;
                }
                else
                {
                    fb = feedback.poor;
                }

                    Console.WriteLine("Brach Name:{0}||ID:{1} || Name: {2} || FeedBack :{3}",branchname, id, name, fb);
            }
            catch(Exception e)
            {
                Console.WriteLine("please Enter Valid Details ");
            }
         }
    }
    internal class CaseStudy1
    {
        static void Main()
        {
            List<Student> st = new List<Student>();
            st.Add(new Student(1, "Ajay", 180, 190, 170));
            st.Add(new Student(2, "Anu", 190, 192, 199));
            st.Add(new Student(3, "Banu", 170, 169, 180));

            
            foreach(Student s in st)
            {
                s.CalculateCutoff();
            }
            





        }
        
    }
}
