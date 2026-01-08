using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Money { get; set; }

        public BankAccount(string xname, double xmoney)
        {
            Name = xname;
            Money = xmoney;
        }
        public void Add(double amount)
        {
            Console.WriteLine("Add " + amount + " to the account .");
            Money = Money + amount;
        }
        public void Subtract(double amount)
        {
            Console.WriteLine("Subtract " + amount + " from the account .");
            Money = Money - amount;
        }
        public void PrintInfo()
        {
            Console.WriteLine("NOW " + Name + " has " + Money);
        }
    }
}

