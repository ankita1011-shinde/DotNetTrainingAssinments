using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.NewFolder
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        static void Main(string[] args)
        {
           

            Stack<Product> stack = new Stack<Product>();  //Non Generic  FILO
            stack.Push(new Product { Id = 1, Name = "Ankita" });
            stack.Push(new Product { Id = 2, Name = "Rohit" });
            stack.Push(new Product { Id = 3, Name = "Sayli" });
            stack.Push(new Product { Id = 4, Name = "Deepa" });
            stack.Push(new Product { Id = 5, Name = "Rupali" });

            stack.Pop();//remove last element
            
            foreach (Product p in stack)
            {
                Console.WriteLine($"{p.Id} {p.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("*******  For Queue   *********");

            Queue<Product> queue = new Queue<Product>();//FIFO
            queue.Enqueue(new Product { Id = 1, Name = "Rani" });
            queue.Enqueue(new Product { Id = 2, Name = "Amit" });
            queue.Enqueue(new Product { Id = 3, Name = "Sahil" });
            queue.Enqueue(new Product { Id = 4, Name = "Reshma" });

            queue.Dequeue();//Remove 1st element

            foreach (Product pt in queue)
            {
                Console.WriteLine($"{pt.Id} {pt.Name}");
            }
        }



    }
      
   
  /* class StackQueueEx
    {
    static void Main(string[] args)
    {

    }

    }*/
}
