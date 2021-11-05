using Challenge2.Models;
using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank1 = new Bank("Raiffeisen");
            ATM atm1 = new ATM("ATM4152", 200000.0); 
            ATM atm2 = new ATM("ATM2412", 300000.0);
            Client client1 = new Client("Jhon Smith", 1000000.0);
            Client client2 = new Client("Bob Doe", 10000.0);

            bank1.AddATM(atm1);
            bank1.AddATM(atm2);
            bank1.RegisterClient(client1);
            bank1.RegisterClient(client2);

            client1.Withdraw(atm1, 2000.0);
            client1.Withdraw(atm1, 200000.0);
            client2.Withdraw(atm2, 200000.0);
            client2.Deposit(atm2, 200000.0);

            client1.ToString();
            client2.ToString();
        }
    }
}
