using NUnit.Framework;
using Roulette.Application;
using Roulette.Data.Models;

namespace Roulette.UnitTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Bet_Contains_NoCurrent_Payout()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { Red = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { Red = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual(200, returnValues.totalPayout);
        }

        [Test]
        public void Bet_Contains_OtherPayout()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { Red = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { Red = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 100);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual(300, returnValues.totalPayout);
        }
        [Test]
        public void Bet_Contains_Red()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { Red = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { Red = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("Red", returnValues.BetType);
        }
        [Test]
        public void Bet_Contains_Black()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { Black = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { Black = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("Black", returnValues.BetType);
        }

        [Test]
        public void Bet_Contains_No_Match()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { Black = 1, Red = 1, BetAmount = 100, Number = 1 };
            BetResult betResult = new BetResult { Red = 0, Black = 0, Number = 2 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 100);


            //Assert
            Assert.AreEqual("not a winning gamble", returnValues.BetType);
            Assert.AreEqual(0, returnValues.winnings);
            Assert.AreEqual(100, returnValues.totalPayout);
        }
        [Test]
        public void Bet_Contains_Even_Number()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { Even = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { Even = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("Even", returnValues.BetType);
        }
        [Test]
        public void Bet_Contains_Odd_Number()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { Odd = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { Odd = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("Odd", returnValues.BetType);
        }
        [Test]
        public void Bet_Contains_Number_In_FirstHalf()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { FirstHalf = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { FirstHalf = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("1-18", returnValues.BetType);
        }
        [Test]
        public void Bet_Contains_Number_In_SecondHalf()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { SecondHalf = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { SecondHalf = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("19-36", returnValues.BetType);
        }
        [Test]
        public void Bet_Contains_First12()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { FirstTwelve = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { FirstTwelve = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("First12", returnValues.BetType);
        }
        [Test]
        public void Bet_Contains_Second12()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { SecondTwelve = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { SecondTwelve = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("Second12", returnValues.BetType);
        }
        [Test]
        public void Bet_Contains_Third12()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { ThirdTwelve = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { ThirdTwelve = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("Third12", returnValues.BetType);
        }
        [Test]
        public void Bet_Contains_First2to1()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { FirstTwotoOne = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { FirstTwotoOne = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("1st 2-1", returnValues.BetType);
        }
        [Test]
        public void Bet_Contains_Second2to1()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { SecondTwotoOne = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { SecondTwotoOne = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("2nd 2-1", returnValues.BetType);
        }
        [Test]
        public void Bet_Contains_Third2to1()
        {
            //Arrange 
            CustomerBet customerBet = new CustomerBet() { ThirdTwotoOne = 1, BetAmount = 100 };
            BetResult betResult = new BetResult { ThirdTwotoOne = 1 };

            //Act
            var returnValues = customerBet.GetValue(betResult, 0);


            //Assert
            Assert.AreEqual(200, returnValues.winnings);
            Assert.AreEqual("3rd 2-1", returnValues.BetType);
        }
    }
}