using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        public double balance = 20.00;
        public string currentBalance()
        {
            string showBalance = "You currently have: $"+balance+"";
            return showBalance;
        }
    }
}
