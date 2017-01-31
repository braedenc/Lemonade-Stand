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
            
            Console.WriteLine(""+ wallet.CurrentBalance()+" and Your current inventory is: \n" +inventory.InventoryReport()+"");
            Console.WriteLine("\nWhat would you like to buy today?\n\n[1] Cups\n[2] Lemons\n[3] Sugar\n[4] Ice\n\nPlease enter the number of your choice.");
            buy = Console.ReadLine();
            
            switch (buy)
            {
                case "1":
                    BuyCups();
                    BuyMore();
                    break;
                case "2":
                    BuyLemons();
                    BuyMore();
                    break;
                case "3":
                    BuySugar();
                    BuyMore();
                    break;
                case "4":
                    BuyIce();
                    BuyMore();
                    break;
                default:
                    Console.WriteLine("Invalid entry\n\n");
                    StoreMenu();
                    break;

            }
        }

        public void BuyCups()
        {
            Console.Clear();
            Console.WriteLine(wallet.CurrentBalance());
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
                BuyCups();
            }
            
        }

        public void BuyLemons()
        {
            Console.Clear();
            Console.WriteLine(wallet.CurrentBalance());
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t12 Lemons - $1.00\n[2]\t24 Lemons - $1.75\n[3]\t48 Lemons - $3.00\n\n");
            string usersChoice = Console.ReadLine();
            if (usersChoice == "1")
            {
                for (int i = 0; i < 12; i++)
                {
                    inventory.lemonList.Add(new Lemons());
                }
                wallet.balance -= 1.00;
            }
            else if (usersChoice == "2")
            {
                for (int i = 0; i < 24; i++)
                {
                    inventory.lemonList.Add(new Lemons());
                }
                wallet.balance -= 1.75;
            }
            else if (usersChoice == "3")
            {
                for (int i = 0; i < 48; i++)
                {
                    inventory.lemonList.Add(new Lemons());
                }
                wallet.balance -= 3.00;
            }
            else
            {
                Console.WriteLine("Invalid entry\n\n");
                BuyLemons();
            }
        }

        public void BuySugar()
        {
            Console.Clear();
            Console.WriteLine(wallet.CurrentBalance());
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t15 Cups of sugar - $1.00\n[2]\t30 Cups of sugar - $1.75\n[3]\t60 Cups of sugar - $3.00\n\n");
            string usersChoice = Console.ReadLine();
            if (usersChoice == "1")
            {
                for (int i = 0; i < 15; i++)
                {
                    inventory.sugarList.Add(new Sugar());
                }
                wallet.balance -= 1.00;
            }
            else if (usersChoice == "2")
            {
                for (int i = 0; i < 30; i++)
                {
                    inventory.sugarList.Add(new Sugar());
                }
                wallet.balance -= 1.75;
            }
            else if (usersChoice == "3")
            {
                for (int i = 0; i < 60; i++)
                {
                    inventory.sugarList.Add(new Sugar());
                }
                wallet.balance -= 3.00;
            }
            else
            {
                Console.WriteLine("Invalid entry\n\n");
                BuySugar();
            }
        }

        public void BuyIce()
        {
            Console.Clear();
            Console.WriteLine(wallet.CurrentBalance());
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t100 Cubes - $1.00\n[2]\t200 Cubes - $1.75\n[3]\t500 Cubes - $3.50\n\n");
            string usersChoice = Console.ReadLine();
            if (usersChoice == "1")
            {
                for (int i = 0; i < 100; i++)
                {
                    inventory.iceList.Add(new Ice());
                }
                wallet.balance -= 1.00;
            }
            else if (usersChoice == "2")
            {
                for (int i = 0; i < 200; i++)
                {
                    inventory.iceList.Add(new Ice());
                }
                wallet.balance -= 1.75;
            }
            else if (usersChoice == "3")
            {
                for (int i = 0; i < 500; i++)
                {
                    inventory.iceList.Add(new Ice());
                }
                wallet.balance -= 3.00;
            }
            else
            {
                Console.WriteLine("Invalid entry\n\n");
                BuyIce();
            }
        }

        public void BuyMore()
        {
            Console.WriteLine(""+ wallet.CurrentBalance()+" and \n\n"+inventory.InventoryReport()+"");
            Console.WriteLine("\nWould you like to continue shopping? Enter 'Y' for yes or 'N' for no.");
            buyMore = Console.ReadLine();
            switch (buyMore)
            {
                case "Y":
                    StoreMenu();
                    break;

                case "N":

                    break;

                default:
                    Console.WriteLine("Invalid entry");
                    BuyMore();
                    break;
            }

        }
    }
}
