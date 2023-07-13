using Xunit;
using Lab02_UnitTesting;

namespace Lab02Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(50)]
        [InlineData (100)]
        [InlineData(1000)]
        public void TestViewBalance(decimal initialBalance)
        {
            Lab02_UnitTesting.Program.Balance = initialBalance;
            var balance = Lab02_UnitTesting.Program.ViewBalance();
            Assert.Equal(initialBalance, balance);
        }

        [Theory]
        [InlineData (50, 25, 25)]
        [InlineData (100, 200, 0)]
        [InlineData (1000, 300, 700)]
        public void TestDeposit(decimal initialBalance, decimal withdrawalAmount, decimal expectedWithdrawal)
        {
            Lab02_UnitTesting.Program.Balance = initialBalance;
            var withdrawal = Lab02_UnitTesting.Program.Withdraw(withdrawalAmount);
            Assert.Equal(expectedWithdrawal, withdrawal);
        }
    }
}