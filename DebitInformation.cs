using System;
namespace LMS_assessment___Jan_10
{
    class DebitInformation : AccountCreditInformation
    {
        private string address;
        private int contact;

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public int Contact
        {
            get
            {
                return contact;
            }
            set
            {
                contact = value;
            }
        }

        public DebitInformation(string name, int age, double amount, string address, int contact) : base(name, age, amount)
        {
            Address = address;
            Contact = contact;
        }

        public override string ToString()
        {
            return string.Format($"{base.ToString()}Address: {Address} \nContact: {Contact} \n");
        }

        public static void Debit()
        {
            Console.Write("Balance is debited.");
            Console.ReadKey(true);
        }
    }
}
