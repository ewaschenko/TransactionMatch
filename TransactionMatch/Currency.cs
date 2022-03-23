namespace WS
{
	public class Currency
	{
		public CurrencyBase currencyBase { get; private set; }
		Dictionary<CurrencyBase, decimal> exchangeList;

		public Currency(CurrencyBase currencyBase)
		{
			this.currencyBase = currencyBase;
			exchangeList = new Dictionary<CurrencyBase, decimal>();
		}

		public void AddCurrency(CurrencyBase currencyBase, decimal amount)
		{
			exchangeList.Add(currencyBase, amount);
		}

		public decimal GetExchangeRate(CurrencyBase currencyBase, decimal amount)
		{
			decimal exchangeRate;

			if (exchangeList.TryGetValue(currencyBase, out exchangeRate))
			{
				return exchangeRate * amount;
			}
			else
			{
				throw new Exception($"Unable To Convert To Currency {currencyBase}");
			}
		}
	}
}
