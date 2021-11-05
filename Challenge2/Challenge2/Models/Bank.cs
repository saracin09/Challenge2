using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.Models
{
    class Bank 
    {
        public string Name { get; set; }
        public List<ATM> ATMS;
        public List<Client> Clients;

        public Bank(string name)
        {
            Name = name;
            ATMS = new List<ATM>();
            Clients = new List<Client>();
        }

        public void AddATM(ATM atm)
        {
            ATMS.Add(atm);
        }

        public void RegisterClient(Client client)
        {
            int generatedAccountNo = new Random().Next(10000, 99999);
            client.AccountNo = Clients.Any(v => v.AccountNo == generatedAccountNo) ? new Random().Next(10000, 99999) : generatedAccountNo;
          
            Clients.Add(client);
        }
    }
}
