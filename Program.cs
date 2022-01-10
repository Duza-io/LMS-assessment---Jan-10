using System;

namespace LMS_assessment___Jan_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] option = new string[] {"1. Credit", "2. Debit"};

            AccountCreditInformation[] storage = new AccountCreditInformation[2];

            Console.WriteLine("Choose one: ");

            for (int i = 0; i < option.Length; i++)
            {
                Console.WriteLine(option[i]);
            }

            Console.Write("Enter: ");
            var input = Console.ReadLine();
            int x;

            while (!int.TryParse(input, out x) || x > 2 || x <= 0)
            {
                Console.Write("Try again: ");
                input = Console.ReadLine();
            }

            switch (x)
            {
                case 1:
                    storage[0] = new DebitInformation("Mark", 19, 200.00, "Cainta, Rizal", 0912345678);
                    Console.WriteLine(storage[0]);
                    AccountCreditInformation.Credit();
                    break;
                case 2:
                    storage[1] = new DebitInformation("Andrew", 20, 500.00, "Quezon City", 1234567890);
                    Console.WriteLine(storage[1]);
                    DebitInformation.Debit();
                    break;
            }
        }
    }
}
