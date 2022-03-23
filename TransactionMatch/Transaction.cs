namespace WS
{
	public class Transaction
	{
		public int id { get; private set; }
		public decimal amount { get; private set; }
		public CurrencyBase currencyBase { get; private set; }

		public TransactionType type { get; private set; }

		public Transaction(int id, decimal amount, CurrencyBase currencyBase, TransactionType type)
		{
			this.id = id;
			this.amount = amount;
			this.currencyBase = currencyBase;
			this.type = type;
		}
	}
}
