using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.NewFolder
{
    public delegate int MyDelegate(int n1, int n2, int n3);

    public class Cal
    {
        public int Add(int a,int b, int c)
        {
            return a + b + c;
        }
        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }
        public int Mul(int a, int b, int c)
        {
            return a * b * c;
        }

    }
    public class MulticastDelegate
    {
        static void Main(string[] args)
        {
            Cal cl = new Cal();
            MyDelegate mydel = new MyDelegate(cl.Add);
            mydel += new MyDelegate(cl.Sub);
            mydel += new MyDelegate(cl.Mul);
            Delegate[] list = mydel.GetInvocationList();
            
            foreach(Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(5,5,5));
            }





        }
    }
}
