using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.LINQQuery
{
    public class Product1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
    }
    class ProdMain
    {
        static void Main(string[] args)
        {
            List<Product1> product = new List<Product1>()
            {
                new Product1{Id =1,Name = "Lenovo",Rate=50000 },
                new Product1{Id =2,Name = "Mac",Rate=68000 },
                new Product1{Id =3,Name = "Dell",Rate=52000 },
                new Product1{Id =4,Name = "Accer",Rate=54000 },
                new Product1{Id =5,Name = "Sony",Rate=56000 },
            };

            /* var res = from d in product
                       where d.Rate < 55000
                       orderby d.Rate
                       select d;*/

            /* var res = from d in product
                       where d.Rate < 50000 && d.Rate < 56000
                       orderby d.Rate
                       select d;*/

            var res = from d in product
                      where d.Name.StartsWith('l')
                      
                      select d;
            foreach (Product1 d in res)
            {
                Console.WriteLine($"{d.Id} {d.Name} {d.Rate}");
            }

        }
    }
}
