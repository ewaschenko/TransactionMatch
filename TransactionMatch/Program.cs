using WS;

Currency cad = new Currency(CurrencyBase.CAD);
cad.AddCurrency(CurrencyBase.USD, 1.2m);

Currency usd = new Currency(CurrencyBase.USD);
usd.AddCurrency(CurrencyBase.CAD, 0.8m);

Account account = new Account(cad);

TransactionManager manager = new TransactionManager(account);

List<Transaction> transactionList = new List<Transaction>();

transactionList.Add(new Transaction(123, 40, CurrencyBase.CAD, TransactionType.CASH_DEPOSIT));
transactionList.Add(new Transaction(124, 500, CurrencyBase.CAD, TransactionType.CASH_DEPOSIT));
transactionList.Add(new Transaction(125, 300, CurrencyBase.USD, TransactionType.CASH_WITHDRAWAL));

foreach (Transaction element in transactionList)
{
	manager.Execute(element);
}

Console.WriteLine(account);