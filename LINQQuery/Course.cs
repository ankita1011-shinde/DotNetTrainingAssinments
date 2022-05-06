using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.LINQQuery
{
    class Course
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public double Fees{ get; set; }
         
        
    }
    class CourseMain
    {
        static void Main(string[] args)
        {
            List<Course> clist = new List<Course>() 
            {

                new Course{Id=1,CName="Java",Fees=10000},
                new Course{Id=2,CName="C#",Fees=45000},
                new Course{Id=3,CName="Paython",Fees=36000},
                new Course{Id=4,CName="Testing",Fees=46000},
                new Course{Id=5,CName="C++ ",Fees=13000},
                new Course{Id=6,CName="Oracle",Fees=23000},

            };

            //LINQ query

            //1. find courses fees below 35000

            var res1 = from p in clist
                       where p.Fees < 35000
                       select p;

            foreach(Course c in res1)
            {
                Console.WriteLine($"\t{c.Id}\t{c.CName}\t{c.Fees}");
            }
            Console.WriteLine("************");
            //2.find ditails for c#

            var res2 = from p in clist
                       where p.CName.Contains("C#")
                       select p;
            foreach(Course c in res2)
            {
                Console.WriteLine($"\t{c.Id}\t{c.CName}\t{c.Fees}");
            }
            Console.WriteLine("************");
            //3.start with c
            var res3 = from p in clist
                       where p.CName.StartsWith('C')
                       select p;
            foreach(Course c in res3)
            {
                Console.WriteLine($"\t{c.Id}\t{c.CName}\t{c.Fees}");
            }
            Console.WriteLine("************");
            //4 arrange fees in descending order
            var res4 = from p in clist
                       orderby p.Fees descending
                       select p;
            foreach(Course c in res4)
            {
                Console.WriteLine($"\t{c.Id}\t{c.CName}\t{c.Fees}");
            }
            Console.WriteLine("************");
            //4 fees in range between 35000 to 60000
            var res5 = from p in clist
                       where p.Fees>=35000 || p.Fees<=60000
                       select p;
            foreach (Course c in res5)
            {
                Console.WriteLine($"\t{c.Id}\t{c.CName}\t{c.Fees}");
            }
        }
    }
}
