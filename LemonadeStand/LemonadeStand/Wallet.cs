using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double balance;

        public Wallet()
        {
            balance = 20.00;
        }
        public string CurrentBalance()
        {
            string showBalance = "You currently have: $"+balance+"";
            return showBalance;
        }
    }
}
