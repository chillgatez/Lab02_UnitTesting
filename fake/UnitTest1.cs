namespace Lab02_ATMUnitTest
{
    using Xunit;
    using Lab02_UnitTesting;


        public class UnitTest1
        {
            [Theory]
            [InlineData(0)]
            [InlineData(50)]
            [InlineData(100)]
            public void TestViewBalance(decimal initialBalance)
            {
                Lab02_UnitTesting.Program.Balance = initialBalance;
                var balance = Lab02_UnitTesting.Program.ViewBalance();
                Assert.Equal(initialBalance, balance);
            }

            [Theory]
            [InlineData(50, 25, 25)]
            [InlineData(100, 200, 0)]
            public void TestWithdrawal(decimal initialBalance, decimal withdrawalAmount, decimal expectedWithdrawal)
            {
                Lab02_UnitTesting.Program.Balance = initialBalance;
                var withdrawal = Lab02_UnitTesting.Program.Withdraw(withdrawalAmount);
                Assert.Equal(expectedWithdrawal, withdrawal);
            }
        
            [Theory]
            [InlineData(50, 25, 25)]
            [InlineData(100, -25, 0)]
            public void TestDeposit(decimal initialBalance, decimal depositAmount, decimal expectedDeposit)
            {
                Lab02_UnitTesting.Program.Balance = initialBalance;
                var deposit = Lab02_UnitTesting.Program.Deposit(depositAmount);
                Assert.Equal(expectedDeposit, deposit);
            }
        }
    
}