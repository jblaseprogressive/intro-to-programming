namespace Banking.Domain;

public class GoldAccount : Account
{
    public GoldAccount(ICalculateBonusesForDeposits bonusCalculator) : base(bonusCalculator)
    {
    }

    public override void Deposit(TransactionValueTypes.Deposit amountToDeposit)
    {
        var updatedDeposit = TransactionValueTypes.Deposit.CreateFrom(amountToDeposit.Value * 1.10M);
        base.Deposit(updatedDeposit);
    }
}