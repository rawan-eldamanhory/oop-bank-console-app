using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("Ali", 1000);
            acc1.Add(500);
            acc1.PrintInfo();
            acc1.Subtract(200);
            acc1.PrintInfo();
        }
    }
}
