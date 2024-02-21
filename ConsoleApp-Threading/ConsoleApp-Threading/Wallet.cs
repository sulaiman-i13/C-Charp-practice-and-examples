public class Wallet
{
	private readonly int[] trans = [10, -30, 20, -40, 50, 10];
	public decimal Balance { get; set; }

	public Wallet(decimal balance = 100m)
	{
		Balance = balance;
	}

	public void DoTrans()
	{
		foreach (var item in trans)
		{
			Thread.Sleep(500);
			Balance += item;
			Console.WriteLine(Balance);
		}
	}
	public void Deposit(int amount)
	{
		Balance += amount;
	}
	object lockObject;
	public void Withdraw(int amount)
	{
		
		
			if ((Balance - amount) < 0) throw new OperationCanceledException();
			Balance -= amount;
		
	}
	public override string ToString()
	{
		return "balance is: " + Balance;
	}
}