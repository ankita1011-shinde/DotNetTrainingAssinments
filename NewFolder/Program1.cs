using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.NewFolder
{
    public class Emplopee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        
    }
   public class Departmt
    {
        public string Dname { get; set; }

        public List<Emplopee> elist = new List<Emplopee>();
    }
    public class Program1
    {
        static void Main(string[] args)
        {
            List<Departmt> dlist = new List<Departmt>() {
            new Departmt{Dname="FrontEnd",

                elist={ new Emplopee{Id =1,Name="Ankita",City="Mumbai"},
                new Emplopee{Id =2,Name="Amit",City="Pune"},
                new Emplopee{Id =3,Name="Swati",City="Pune"}
                                                         }

            },
                new Departmt{Dname="Operation",

                elist={new Emplopee{Id =1,Name="Pooja",City="Mumbai",},
                new Emplopee{Id =2,Name="Raj",City="Thane"},
                new Emplopee{Id =3,Name="Ajay",City="Pune"}
                    },
                }

            };

            foreach(Departmt d in dlist)
            {
                Console.WriteLine(d.Dname);
                foreach(Emplopee e in d.elist)
                {
                    Console.WriteLine($"\t {e.Id}\t{e.Name}\t{e.City}");
                }
            }
        }


    }
}
