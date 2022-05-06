using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.NewFolder
{
    public delegate void Mydele(string a);// return type should be same as method
    public class User
    {
        public void UpperCase(string s)
        {
            s = s.ToUpper();
            Console.WriteLine(s);
        }
        public void LowerCase(string s)
        {
           s = s.ToLower();
            Console.WriteLine(s);
        }
    }
    class Assnmt1
    {
        static void Main(string[] args)
        {
            User u = new User();
            Mydele md = new Mydele(u.UpperCase);
            md += new Mydele(u.LowerCase);
            Delegate[] list = md.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                d.DynamicInvoke("Ankita");
            }
        }
    }
}
