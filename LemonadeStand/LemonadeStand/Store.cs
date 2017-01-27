using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        Inventory inventory = new Inventory();
        Wallet wallet = new Wallet();
        string buy;
        string buyMore;
        public void StoreMenu()
        {
            
            Console.Clear();
            
            Console.WriteLine(""+ wallet.currentBalance()+" and Your current inventory is: \n" +inventory.inventoryReport()+"");
            Console.WriteLine("\nWhat would you like to buy today?\n\n[1] Cups\n[2] Lemons\n[3] Sugar\n[4] Ice\n\nPlease enter the number of your choice.");
            buy = Console.ReadLine();
            
            switch (buy)
            {
                case "1":
                    BuyMoreCups();
                    BuyMore();
                    break;
                case "2":
                    BuyMoreLemons();
                    break;
                case "3":
                    BuyMoreSugar();
                    break;
                case "4":
                    BuyMoreIce();
                    break;
                default:
                    Console.WriteLine("Invalid entry\n\n");
                    StoreMenu();
                    break;

            }
        }

        public void BuyMoreCups()
        {
            Console.Clear();
            Console.WriteLine(wallet.currentBalance());
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t50 Cups - $1.00\n[2]\t100 Cups - $1.75\n[3]\t250 Cups - $3.50\n\n");
            string usersChoice = Console.ReadLine();
            if (usersChoice == "1")
            {
                for(int i = 0; i < 50; i++)
                {
                    inventory.cupList.Add(new Cups());
                }
                wallet.balance -= 1.00;
            } else if(usersChoice == "2")
            {
                for(int i = 0; i < 100; i++)
                {
                    inventory.cupList.Add(new Cups());
                }
                wallet.balance -= 1.75;
            } else if(usersChoice == "3")
            {
                for(int i = 0; i < 250; i++)
                {
                    inventory.cupList.Add(new Cups());
                }
                wallet.balance -= 3.50;
            } else
            {
                Console.WriteLine("Invalid entry\n\n");
                BuyMoreCups();
            }
            
        }

        public void BuyMoreLemons()
        {
            Console.Clear();
            Console.WriteLine(wallet.currentBalance());
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t12 Lemons - $1.00\n[2]\t24 Lemons - $1.75\n[3]\t48 Lemons - $3.50\n\n");
            string usersChoice = Console.ReadLine();
            if (usersChoice == "1")
            {
                for (int i = 0; i < 50; i++)
                {
                    inventory.lemonList.Add(new Lemons());
                }
                wallet.balance -= 1.00;
            }
            else if (usersChoice == "2")
            {
                for (int i = 0; i < 100; i++)
                {
                    inventory.lemonList.Add(new Lemons());
                }
                wallet.balance -= 1.75;
            }
            else if (usersChoice == "3")
            {
                for (int i = 0; i < 250; i++)
                {
                    inventory.lemonList.Add(new Lemons());
                }
                wallet.balance -= 3.50;
            }
            else
            {
                Console.WriteLine("Invalid entry\n\n");
                BuyMoreLemons();
            }
        }

        public void BuyMoreSugar()
        {
            Console.Clear();
            Console.WriteLine(wallet.currentBalance());
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t50 Cups - $1.00\n[2]\t100 Cups - $1.75\n[3]\t250 Cups - $3.50\n\n");
            string usersChoice = Console.ReadLine();
            if (usersChoice == "1")
            {
                for (int i = 0; i < 50; i++)
                {
                    inventory.cupList.Add(new Cups());
                }
                wallet.balance -= 1.00;
            }
            else if (usersChoice == "2")
            {
                for (int i = 0; i < 100; i++)
                {
                    inventory.cupList.Add(new Cups());
                }
                wallet.balance -= 1.75;
            }
            else if (usersChoice == "3")
            {
                for (int i = 0; i < 250; i++)
                {
                    inventory.cupList.Add(new Cups());
                }
                wallet.balance -= 3.50;
            }
            else
            {
                Console.WriteLine("Invalid entry\n\n");
                BuyMoreCups();
            }
        }

        public void BuyMoreIce()
        {
            Console.Clear();
            Console.WriteLine(wallet.currentBalance());
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t50 Cups - $1.00\n[2]\t100 Cups - $1.75\n[3]\t250 Cups - $3.50\n\n");
            string usersChoice = Console.ReadLine();
            if (usersChoice == "1")
            {
                for (int i = 0; i < 50; i++)
                {
                    inventory.cupList.Add(new Cups());
                }
                wallet.balance -= 1.00;
            }
            else if (usersChoice == "2")
            {
                for (int i = 0; i < 100; i++)
                {
                    inventory.cupList.Add(new Cups());
                }
                wallet.balance -= 1.75;
            }
            else if (usersChoice == "3")
            {
                for (int i = 0; i < 250; i++)
                {
                    inventory.cupList.Add(new Cups());
                }
                wallet.balance -= 3.50;
            }
            else
            {
                Console.WriteLine("Invalid entry\n\n");
                BuyMoreCups();
            }
        }

        public void BuyMore()
        {
            Console.WriteLine(""+ wallet.currentBalance()+" and \n\n"+inventory.inventoryReport()+"");
            Console.WriteLine("\nWould you like to continue shopping? Enter 'Y' for yes or 'N' for no.");
            buyMore = Console.ReadLine();
        }
    }
}
