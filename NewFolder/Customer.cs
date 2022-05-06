using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.NewFolder
{
     class Customer
    {
      public int CId { get;set; }
        public string CName { get; set; }
        public String CAddress { get; set; }

        public List<Account> acntlist = new List<Account>();
    }
    public class Account
    {
        public string AccountType { get; set; }
        public float AccountNo { get;set;}

        public List<Loan> loanlist = new List<Loan>();
    }
    public class Loan
    {
        public string LoanType { get; set; }
    }
    class CustomerMain
    {
        static void Main(string[] args)
        {
            List<Customer> clist = new List<Customer>()
            {
            new Customer{CId=1,CName="Ankita",CAddress="Mumbai",
            acntlist={ new Account { AccountNo = 36662, AccountType = "Savings", loanlist = { new Loan {LoanType="HomeLoan" }  } } }

            },
            new Customer{CId=2,CName="sayli",CAddress="pune",
            acntlist={ new Account { AccountNo =256772, AccountType = "Savings", loanlist = { new Loan {LoanType="CarLoan" }  } } }
            }

            
            };
            foreach (Customer c in clist)
            {
                Console.WriteLine($"Id:{c.CId}\tName:{c.CName}\tLocaton:{c.CAddress}");
                foreach(Account acc in c.acntlist)
                {
                    Console.WriteLine($"\n\tAccNo:{acc.AccountNo}\tAccount Type:{acc.AccountType}");
                    foreach(Loan l in acc.loanlist)
                    {
                        Console.WriteLine($"\n\tLoan:{l.LoanType}");
                    }
                }
            }
        }
    }
}
