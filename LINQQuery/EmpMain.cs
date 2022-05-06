using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.LINQQuery
{
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Salary{ get; set; }
        public string Department { get; set; }
    }
    class EmpMain
    {
        static void Main(string[] args)
        {
            List<Emp> emplist = new List<Emp>()
            {
                new Emp{Id=1,Name="ankita",City="Mumbai",Salary=35000,Department="Developer"},
                new Emp{Id=2,Name="amit",City="thane",Salary=30000,Department="java"},
                new Emp{Id=3,Name="jay",City="pune",Salary=40000,Department="maintanance"},
                new Emp{Id=4,Name="vijay",City="pune",Salary=31000,Department="operation"},
                new Emp{Id=5,Name="sayli",City="Mumbai",Salary=38000,Department="Developer"},
                new Emp{Id=6,Name="shweta",City="Mumbai",Salary=35000,Department="Developer"},
                new Emp{Id=7,Name="anki",City="thane",Salary=32000,Department="java"},
                new Emp{Id=8,Name="rohit",City="pune",Salary=54000,Department="Hr Department"},
                new Emp{Id=9,Name="vinay",City="Mumbai",Salary=36000,Department="Developer"},
                new Emp{Id=10,Name="neha",City="pune",Salary=44000,Department="Developer"},
                new Emp{Id=11,Name="raj",City="Mumbai",Salary=29000,Department="Developer"},
            };
            //1 whose salary is greater than 45000
            var result1 = from p in emplist
                         where p.Salary>45000
                         select p;

            foreach(Emp e in result1)
            {
                Console.WriteLine($"\t{e.Id}\t{e.Name}\t{e.City}\t{e.Salary}\t{e.Department}");
            }
            Console.WriteLine("***************");
            //2  all name in ascending order
            var result2 = from p in emplist
                         
                         orderby p.Name
                         select p;

            foreach (Emp e in result2)
            {
                Console.WriteLine($"\t{e.Id}\t{e.Name}\t{e.City}\t{e.Salary}\t{e.Department}");
            }
            Console.WriteLine("***********");
            //3 display emp whoes lis in mumbai
             var result3 = from p in emplist
                          where p.City.Contains("mumbai")

                          select p;

             foreach (Emp e in result3)
             {
                Console.WriteLine($"\t{e.Id}\t{e.Name}\t{e.City}\t{e.Salary}\t{e.Department}");
            }
            Console.WriteLine("***************");
            
            //4 dispaley whoes from Hr 
            var result4 = from p in emplist
                          where p.Department.Contains("Hr")

                          select p;

            foreach (Emp e in result4)
            {
                Console.WriteLine($"\t{e.Id}\t{e.Name}\t{e.City}\t{e.Salary}\t{e.Department}");
            }
            Console.WriteLine("***************");
            //5 salary in decsending order
            var result5 = from p in emplist
                         
                          orderby p.Salary descending

                          select p;

            foreach (Emp e in result5)
            {
                Console.WriteLine($"\t{e.Id}\t{e.Name}\t{e.City}\t{e.Salary}\t{e.Department}");
            }
            Console.WriteLine("***************");

            //6 name start with a or k
            var result6 = from p in emplist
                          where p.Name.StartsWith('a') || p.Name.StartsWith('k')

                          select p;

            foreach (Emp e in result6)
            {
                Console.WriteLine($"\t{e.Id}\t{e.Name}\t{e.City}\t{e.Salary}\t{e.Department}");
            }
            Console.WriteLine("***************");

            //7 whoes city is pune and salary is less than 35000
            var result7 = from p in emplist
                          where p.City.Contains("Pune") && p.Salary <35000

                          select p;

            foreach (Emp e in result7)
            {
                Console.WriteLine($"\t{e.Id}\t{e.Name}\t{e.City}\t{e.Salary}\t{e.Department}");
            }
        }
    }
}
