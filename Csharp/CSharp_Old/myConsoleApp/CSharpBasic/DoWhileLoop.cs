using System;

namespace myConsoleApp
{
    class Program16
    {
        static void Main16(string[] args)
        {
            string actualpin = "4321";
            int count = 0;
            string pin;
            do
            {
                pin = Console.ReadLine();
                count++;
            }while (pin != actualpin && count < 3);
            if(pin == actualpin)
                Console.WriteLine("Welcome User");
            else
                Console.WriteLine("Account Locked");
        }
    }
}
