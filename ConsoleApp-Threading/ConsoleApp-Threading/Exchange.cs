
class Exchange
{
	
	public static void Transfer(Wallet from,  Wallet to, int amount)
	{
		lock (from)
		{
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId+" lock "+ from);
            if (Monitor.TryEnter(to, 1500))
			{
				Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " entered "+ to);

				try
				{
					from.Withdraw(amount);
					to.Deposit(amount);
				}
				catch { Console.WriteLine("catching"); }
				finally { Monitor.Exit(to); }
			}else Console.WriteLine("un able to lock");
        }
	}

	
}