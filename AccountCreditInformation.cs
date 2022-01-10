using System;

namespace LMS_assessment___Jan_10
{
    abstract class AccountCreditInformation
    {
        private string name;
        private int age;
        private double amount;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public AccountCreditInformation(string name, int age, double amount)
        {
            Name = name;
            Age = age;
            Amount = amount;
        }

        public override string ToString()
        {
            return string.Format($"\nName: {Name} \nAge: {Age} \nAmount: {Amount}\n");
        }

        public static void Credit()
        {
            Console.Write("Balance is credited.");
            Console.ReadKey(true);
        }
    }
}
