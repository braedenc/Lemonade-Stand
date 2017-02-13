using System;
using LemonadeStand;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;


namespace Lemonade_Stand_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetsWeatherCondition()
        {
            Weather weather = new Weather();
            //Arrange
            string[] conditions = { "clear and sunny", "rainy", "overcast", "partly cloudy" };
            //Act
            weather.ConditionGenerator();
            //Assert
            Assert.IsTrue(conditions.Contains(weather.condition));
        }

        [TestMethod]
        public void GetsTemperature()
        {
            Weather weather = new Weather();
            Random rnd = new Random();
            //Arrange
            int[] temperatures = { rnd.Next(55, 100) };
            //Act
            weather.TempGenerator();
            //Assert
            Assert.IsTrue(temperatures.Contains(weather.temperature));
        }

        [TestMethod]
        public void AddMoreCups()
        {
            //Arrange
            Player player = new Player();
            Store store = new Store(player);
            Inventory inventory = new Inventory();
            int numberOfCups = 50;
            
            //Act
            store.BuyCups(1, inventory);

            //Assert
            Assert.AreEqual(numberOfCups, inventory.cupList.Count);
            
        }

        [TestMethod]
        public void GetsWeatherConditions()
        {
            Weather weather = new Weather();
            //Arrange
            string[] conditions = { "volcanic explosion", "stormy", "windy" };
            //Act
            weather.ConditionGenerator();
            //Assert
            Assert.IsFalse(conditions.Contains(weather.condition));
        }

        [TestMethod]
        public void AddMoneyToWallet()
        {
            //Arrange
            Player player = new Player();
            double price = player.recipe.pricePerCup;
            //Act
            player.SellLemonade();
            //Assert
            Assert.AreNotEqual(price, player.wallet.balance);
        }

        [TestMethod]
        public void CheckPositiveBalance()
        {
            //Arrange
            Wallet wallet = new Wallet();
            string result = "You currently have: $"+20.00;
            //Act
            string balance = wallet.CurrentBalance();
            //Assert
            Assert.AreEqual(result, balance);
        }

        [TestMethod]
        public void AddMoneyToWalletBalance()
        {
            //Arrange
            Player player = new Player();
            double price = player.wallet.balance + player.recipe.pricePerCup;
            //Act
            player.SellLemonade();
            //Assert
            Assert.AreEqual(price, player.wallet.balance);
        }

    }   
}
