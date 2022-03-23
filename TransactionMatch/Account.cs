namespace WS
{
	public class Account
	{

		decimal accountBalance;
		Currency currency;
		public Account(Currency currency)
		{
			this.currency = currency;
			this.accountBalance = 100;
		}

		public void AddTransaction(Transaction transaction)
		{
			decimal amount = transaction.amount;

			if (transaction.type == TransactionType.CASH_DEPOSIT)
			{
				amount = Math.Abs(amount);
			}
			else
			{
				amount = Math.Abs(amount) * -1;
			}

			// Convert Currency
			if (transaction.currencyBase != currency.currencyBase)
			{
				amount = currency.GetExchangeRate(transaction.currencyBase, amount);
			}

			decimal tempBalance = accountBalance + amount;

			if (tempBalance < 0)
			{
				Console.WriteLine($"Cannot Execute Transaction Id: {transaction.id} - Insufficient Funds");
				return;
			}
			else
			{
				accountBalance = tempBalance;
			}
		}

		public override string ToString()
		{
			return $"Account Balance: ${accountBalance} {currency.currencyBase}";
		}
	}
}
