using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining2May.NewFolder
{
    public delegate void MyDele2();
    public class Bank
    {
        public double Bal;
        public event MyDele2 CreditInAcc;
        public event MyDele2 LowBal;
        public event MyDele2 ZeroBal;
        public Bank()
        {
            Bal = 5000;
        }
        public void CreateAmount(double Amount)
        {
            Bal = Bal + Amount;
            CreditInAcc();
        }
            
            
        public void Debit(double debit)
        {
            if(Bal==0)
            {
                ZeroBal();
            }
            else if(Bal<debit)
            {
                LowBal();
            }
            else
            {
                Bal = Bal - debit;
            }
            Console.WriteLine($"Current Balance {Bal}");
        }

       

    }
    public class Errormsg
    {
        public void CreditMsg()
        {
            Console.WriteLine("Your account has been credited");
        }
        public void LowBalMsg()
        {
            Console.WriteLine("You have unsufficient balance to debit the amount");
        }
        public void ZeroBakMsg()
        {
            Console.WriteLine("Account balance is zero");
        }
    }
    class BankMain
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Errormsg msg = new Errormsg();
            bank.CreditInAcc += new MyDele2(msg.CreditMsg);
            bank.LowBal += new MyDele2(msg.LowBalMsg);
            bank.ZeroBal += new MyDele2(msg.ZeroBakMsg);
            bank.CreateAmount(1000);
            bank.Debit(7000);
        }
    }
}
