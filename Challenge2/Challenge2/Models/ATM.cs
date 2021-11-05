using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.Models
{
    class ATM
    {
        public string Name { get; set; }
        public double Money { get; set; }

        public ATM(string name, double money)
        {
            Name = name;
            Money = money;
        }

    }
}
