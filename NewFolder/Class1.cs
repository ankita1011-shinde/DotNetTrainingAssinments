using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.NewFolder
{
    
    class Emp:IComparable
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public double Sal { get; set; }

        public int CompareTo(Object obj)
        {
            Emp p2 =(Emp)obj;
            if(this.Sal > p2.Sal)
            {
                return 1;

            }
            else
            {
                return 0; 
            }
        }
    }
   /* public class Test : IComparer
    {
        public int Compare(Object x,object y)   //boxing
        {
            Emp emp1 = (Emp)x;
            Emp emp2 = (Emp)y;
            if (emp1.Sal > emp2.Sal)
                return 1;
            else
                return 0;
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            Emp p1 = new Emp { Name = "Ankita",Sal=30000 };
            Emp p2 = new Emp { Name = "Nisha", Sal = 40000 };

            int result = p1.CompareTo(p2);
            if(result == 1)
            {
                Console.WriteLine($"{p1.Name} have more salary than {p2.Name}");
            }
            else
            {
                Console.WriteLine($"{p2.Name} have more salary than {p1.Name}");
            }

            Console.WriteLine("...............");


           /* Emp p3 = new Emp {Name = "Rohit",Sal=50000};
            Emp p4 = new Emp { Name = "Ajay", Sal = 40000 };

            Test test = new Test();
            int r = test.Compare(p3, p4);
            if(r==1)
            {
                Console.WriteLine($"{p3.Name} have more salary than {p4.Name}");
            }
            else
            {
                Console.WriteLine($"{p4.Name} have more salary than {p3.Name}");
            }*/
        }

       
    }
    
}
