using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public double dailyMoneySpent;
        Player player;
        public Store(Player player)
        {
            this.player = player;
            dailyMoneySpent = 0;
        }
        public double StoreMenu()
        {
            
            Console.Clear();
            string buy;
            Console.WriteLine(""+ player.wallet.CurrentBalance()+" and Your current inventory is: \n" +player.inventory.InventoryReport()+"");
            Console.WriteLine("\nWhat would you like to buy today?\n\n[1] Cups\n[2] Lemons\n[3] Sugar\n[4] Ice\n[5] Nothing\n\nPlease enter the number of your choice.");
            buy = Console.ReadLine();
            
            switch (buy)
            {
                case "1":
                    dailyMoneySpent += BuyCups(GetChoiceOfCups(), player.inventory);
                    BuyMore();
                    break;
                case "2":
                    dailyMoneySpent += BuyLemons(GetChoiceOfLemons(), player.inventory);
                    BuyMore();
                    break;
                case "3":
                    dailyMoneySpent += BuySugar(GetChoiceOfSugar(), player.inventory);
                    BuyMore();
                    break;
                case "4":
                    dailyMoneySpent += BuyIce(GetChoiceOfIce(), player.inventory);
                    BuyMore();
                    break;
                case "5":
                    dailyMoneySpent += 0;
                    break;
                default:
                    Console.WriteLine("Invalid entry\n\n");
                    StoreMenu();
                    break;

            }
            return dailyMoneySpent;
        }

        public int GetChoiceOfCups()
        {
            Console.Clear();
            Console.WriteLine(player.wallet.CurrentBalance());
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t50 Cups - $1.00\n[2]\t100 Cups - $1.75\n[3]\t250 Cups - $3.50\n\n");
            int usersChoice = Int32.Parse(Console.ReadLine());
            return usersChoice;
        }
        public double BuyCups(int usersChoice, Inventory inventory) {
            
            if (usersChoice == 1)
            {
                if (player.wallet.balance >= 1.00)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        inventory.cupList.Add(new Cups());
                    }


                    player.wallet.balance -= 1.00;
                    return 1.00;
                }else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            } else if(usersChoice == 2)
            {
                if (player.wallet.balance >= 1.75)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        inventory.cupList.Add(new Cups());
                    }
                    player.wallet.balance -= 1.75;
                    return 1.75;
                }
                else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            } else if(usersChoice == 3)
            {
                if (player.wallet.balance >= 3.50)
                {
                    for (int i = 0; i < 250; i++)
                    {
                        inventory.cupList.Add(new Cups());
                    }
                    player.wallet.balance -= 3.50;
                    return 3.50;
                }
                else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            } else
            {
                Console.WriteLine("Invalid entry\n\n");
                return BuyCups(GetChoiceOfCups(), inventory);
            }
            
        }

        public int GetChoiceOfLemons()
        {
            Console.Clear();
            Console.WriteLine(player.wallet.CurrentBalance());
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t12 Lemons - $1.00\n[2]\t24 Lemons - $1.75\n[3]\t48 Lemons - $3.00\n\n");
            int usersChoice = Int32.Parse(Console.ReadLine());
            return usersChoice;
        }
        
        public double BuyLemons(int usersChoice, Inventory inventory) {
            
            if (usersChoice == 1)
            {
                if (player.wallet.balance >= 1.00)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        inventory.lemonList.Add(new Lemons());
                    }
                    player.wallet.balance -= 1.00;
                    return 1.00;
                }
                else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            }
            else if (usersChoice == 2)
            {
                if (player.wallet.balance >= 1.75)
                {
                    for (int i = 0; i < 24; i++)
                    {
                        inventory.lemonList.Add(new Lemons());
                    }
                    player.wallet.balance -= 1.75;
                    return 1.75;
                }
                else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            }
            else if (usersChoice == 3)
            {
                if (player.wallet.balance >= 3.00)
                {
                    for (int i = 0; i < 48; i++)
                    {
                        inventory.lemonList.Add(new Lemons());
                    }
                    player.wallet.balance -= 3.00;
                    return 3.00;
                }
                else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            }
            else
            {
                Console.WriteLine("Invalid entry\n\n");
                return BuyLemons(GetChoiceOfLemons(), inventory);
            }
        }

        public int GetChoiceOfSugar()
        {
            Console.Clear();
            Console.WriteLine(player.wallet.CurrentBalance());
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t15 Cups of sugar - $1.00\n[2]\t30 Cups of sugar - $1.75\n[3]\t60 Cups of sugar - $3.00\n\n");
            int usersChoice = Int32.Parse(Console.ReadLine());
            return usersChoice;
        }

        public double BuySugar(int usersChoice, Inventory inventory)
        { 
            
            if (usersChoice == 1)
            {
                if (player.wallet.balance >= 1.00)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        inventory.sugarList.Add(new Sugar());
                    }
                    player.wallet.balance -= 1.00;
                    return 1.00;
                }
                else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            }
            else if (usersChoice == 2)
            {
                if (player.wallet.balance >= 1.75)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        inventory.sugarList.Add(new Sugar());
                    }
                    player.wallet.balance -= 1.75;
                    return 1.75;
                }
                else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            }
            else if (usersChoice == 3)
            {
                if (player.wallet.balance >= 3.00)
                {
                    for (int i = 0; i < 60; i++)
                    {
                        inventory.sugarList.Add(new Sugar());
                    }
                    player.wallet.balance -= 3.00;
                    return 3.00;
                }
                else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            }
            else
            {
                Console.WriteLine("Invalid entry\n\n");
                return BuySugar(GetChoiceOfSugar(), inventory);
            }
        }

        public int GetChoiceOfIce()
        {
            Console.Clear();
            Console.WriteLine(player.wallet.CurrentBalance());
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t100 Cubes - $1.00\n[2]\t200 Cubes - $1.75\n[3]\t500 Cubes - $3.50\n\n");
            int usersChoice = Int32.Parse(Console.ReadLine());
            return usersChoice;
        }

        public double BuyIce(int usersChoice, Inventory inventory)
        { 
            
            if (usersChoice == 1)
            {
                if (player.wallet.balance >= 1.00)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        inventory.iceList.Add(new Ice());
                    }
                    player.wallet.balance -= 1.00;
                    return 1.00;
                }
                else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            }
            else if (usersChoice == 2)
            {
                if (player.wallet.balance >= 1.75)
                {
                    for (int i = 0; i < 200; i++)
                    {
                        inventory.iceList.Add(new Ice());
                    }
                    player.wallet.balance -= 1.75;
                    return 1.75;
                }
                else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            }
            else if (usersChoice == 3)
            {
                if (player.wallet.balance >= 3.00)
                {
                    for (int i = 0; i < 500; i++)
                    {
                        inventory.iceList.Add(new Ice());
                    }
                    player.wallet.balance -= 3.00;
                    return 3.00;
                }
                else
                {
                    Console.WriteLine("Not enough funds in your wallet!");
                    return 0.00;
                }
            }
            else
            {
                Console.WriteLine("Invalid entry\n\n");
                return BuyIce(GetChoiceOfIce(), inventory);
            }
        }

        public void BuyMore()
        {
            string buyMore;
            Console.WriteLine(""+ player.wallet.CurrentBalance()+" and \n\n"+ player.inventory.InventoryReport()+"");
            Console.WriteLine("\nWould you like to continue shopping? Enter 'y' for yes or 'n' for no.");
            buyMore = Console.ReadLine();
            switch (buyMore)
            {
                case "y":
                    StoreMenu();
                    break;

                case "n":

                    break;

                default:
                    Console.WriteLine("Invalid entry");
                    BuyMore();
                    break;
            }

        }
    }
}
