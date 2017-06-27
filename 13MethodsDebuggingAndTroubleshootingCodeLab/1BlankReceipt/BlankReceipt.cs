using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void Header()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }

        static void ContentOfBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }

        static void Footer()
        {
            Console.WriteLine("------------------------------\n© SoftUni");
        }

        static void PrintReceipt()
        {
            Header();
            ContentOfBody();
            Footer();
        }
    }
}
