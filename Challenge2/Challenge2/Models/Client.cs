using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.Models
{
    class Client
    {
        public string Name { get; set; }
        public int AccountNo { get; set; }
        public double Amount { get; set; }

        public Client(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }
        public void Deposit(ATM atm, double amount)
        {
            atm.Money += amount;
            Amount += amount;
        }

        public void Withdraw(ATM atm, double amount)
        {
            if (atm.Money >= amount)
            {
                if (Amount >= amount)
                {
                    atm.Money -= amount;
                    Amount -= amount;
                }
                else
                {
                    Console.WriteLine("You are poor, dude!\n");
                }
            }
            else
            {
                Console.WriteLine("ATM does not have that much money!\n");
            }

        }

        public void ToString()
        {
            Console.WriteLine($"Client: {Name},\nAccountNo: {AccountNo},\nAmount: {Amount}\n");
        }
    }
}
