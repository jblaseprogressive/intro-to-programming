using Banking.Domain;

namespace Banking.UnitTests.BankAccount;
public class MakingWithdraws
{
    [Theory]
    [InlineData(82.23)]
    [InlineData(200)]
    public void MakingAWithdrawalDecreasesTheBalance(decimal amountToWraithdraw)

    {
        // Given
        var account = new Account();
        var openingBalance = account.GetBalance();

        // When
        account.Withdraw(amountToWraithdraw);


        //then
        Assert.Equal(openingBalance - amountToWraithdraw, account.GetBalance());
    }



    [Fact]
    public void CanTakeEntireBalance()
    {
        var account = new Account();

        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }
}
