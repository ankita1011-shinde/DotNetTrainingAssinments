using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.NewFolder
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Course { get; set; }

       
    }
    public class Course
    {
       
        public int No { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }


    }
    public class Department
    {

    }
    public class ListExample
    {
        static void Main(string[] args)
        {
            List<Student> slist = new List<Student>()
            {
                new Student{Id =1, Name ="Ankita",Area="khopoli",Course="C#" },
                new Student{Id =2, Name ="Rohit", Area="Pune",   Course="Java" },
                new Student{Id =3, Name ="Ajay",  Area="Panvel", Course="Python" },
                new Student{Id =4, Name ="Rasika",Area="Mumbai", Course="C#" },
                new Student{Id =5, Name ="Manas", Area="Thane",  Course="SQL" }


            };
            foreach(Student s in slist)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Area} {s.Course}");
            }

            Console.WriteLine("*****Course Details******");

            List<Course> Clist = new List<Course>() { 
                new Course{No=1,Name="FullStack",Fees=200000},
                new Course{No=2,Name="Java",Fees=50000},
                new Course{No=3,Name="DotNet",Fees=45000},
                new Course{No=4,Name="Angular",Fees=35000}
            }; 
            foreach(Course c in Clist)
            {
                Console.WriteLine($"{c.No} {c.Name} {c.Fees}");
            }
        }
    }
}
