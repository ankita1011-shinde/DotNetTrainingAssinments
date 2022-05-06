using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdvanceTraining2May.NewFolder
{
    class Employee
    {
       public int Id { get; set; }
       public  string Name { get; set; }   
        public double Sal { get; set; }    
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>() {
                new Employee {Id =1, Name= "Ankita" , Sal=35000},
                new Employee {Id=2, Name= "Nisha" , Sal=30000},
                 new Employee {Id =3, Name= "Rohit" , Sal=50000},
                 new Employee {Id =4, Name= "Ajay" , Sal=34000},
            };

            foreach(Employee o in emplist)
            {
                Console.WriteLine($" {o.Id} {o.Name} {o.Sal}");
            }
        }
    }
}
