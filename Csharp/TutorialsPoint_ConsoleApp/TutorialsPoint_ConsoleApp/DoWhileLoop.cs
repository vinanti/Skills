using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class DoWhileLoop
    {
        static void Main1(string[] args)
        {
            string actualpin = "1234";
            int count = 0;
            string pin;
            do
            {
                pin = Console.ReadLine();
                count++;
            } while (pin != actualpin && count < 3);

            if (pin == actualpin)
                Console.WriteLine("Welcome User");
            else
                Console.WriteLine("Account Locked");
        }
    }
}
