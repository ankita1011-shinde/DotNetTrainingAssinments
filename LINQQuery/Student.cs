using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.LINQQuery
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percent { get; set; }
        public string Branch { get; set; }
    }
    class StMain
    {
        static void Main(string[] args)
        {
            List<Student> stllist = new List<Student>()
            { 
            new Student{RollNo =4,Name="rohit",Percent=76},
            new Student{RollNo =3,Name="ved",Percent=86},
            new Student{RollNo =8,Name="sneha",Percent=45},
            new Student{RollNo =2,Name="raj",Percent=55},
            new Student{RollNo =6,Name="ankita",Percent=82},
            new Student{RollNo =5,Name="anuja",Percent=60},
            new Student{RollNo =9,Name="bala",Percent=65},
            new Student{RollNo =1,Name="zareen",Percent=88},
            new Student{RollNo =7,Name="kiran",Percent=40},
            };
            //1.arrange rollno in asscending order
            var r1 = from s in stllist
                     orderby s.RollNo
                     select s;
            foreach(Student s in r1)
            {
                Console.WriteLine($"{s.RollNo}\t{s.Name}\t{s.Percent}\t{s.Branch}");
            }
            Console.WriteLine("**********************");
            //2.arrange name in asscending order
            var r2 = from s in stllist
                     orderby s.Name
                     select s;
            foreach (Student s in r2)
            {
                Console.WriteLine($"{s.RollNo}\t{s.Name}\t{s.Percent}\t{s.Branch}");
            }
            Console.WriteLine("**********************");
            //3.find whoes % above 60
            var r3 = from s in stllist
                     where s.Percent>=60
                     select s;
            foreach (Student s in r3)
            {
                Console.WriteLine($"{s.RollNo}\t{s.Name}\t{s.Percent}\t{s.Branch}");
            }
            Console.WriteLine("**********************");
            //4.find whoes % above 50
            var r4 = from s in stllist
                     where s.Percent < 50
                     select s;
            foreach (Student s in r4)
            {
                Console.WriteLine($"{s.RollNo}\t{s.Name}\t{s.Percent}\t{s.Branch}");
            }
            Console.WriteLine("**********************");
            //4.find % above 70 and name starts with a or r
            var r5 = from s in stllist
                     where s.Percent >70 && (s.Name.StartsWith('a') || s.Name.StartsWith('r'))
                     select s;
            foreach (Student s in r5)
            {
                Console.WriteLine($"{s.RollNo}\t{s.Name}\t{s.Percent}\t{s.Branch}");
            }
            Console.WriteLine("**********************");
            //5.find percentage list between 50 to 80
            var r6 = from s in stllist
                     where s.Percent >=50 && s.Percent<=80
                     select s;
            foreach (Student s in r6)
            {
                Console.WriteLine($"{s.RollNo}\t{s.Name}\t{s.Percent}\t{s.Branch}"); 
            }

        }
    }
}
