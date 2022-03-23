namespace WS
{
	public class TransactionManager
	{
		Account account;

		public TransactionManager(Account account)
		{
			this.account = account;
		}

		public void Execute(Transaction transaction)
		{
			switch (transaction.type)
			{
				case TransactionType.CASH_DEPOSIT:
					account.AddTransaction(transaction);
					break;
				case TransactionType.CASH_WITHDRAWAL:
					account.AddTransaction(transaction);
					break;
				default:
					throw new Exception("Invalid Transaction Type");
			}
		}
	}
}
