using System.Diagnostics;

//ThreadInfo();
//Example1();
//Example2();
//Example3();
Example5();
static void ThreadInfo()
{
	Console.WriteLine($"Process Name :{Process.GetCurrentProcess().ProcessName}");
	Console.WriteLine($"Process Id :{Process.GetCurrentProcess().Id}");
	Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
	Console.WriteLine($"Processor Id: {Thread.GetCurrentProcessorId()}");
	Thread.CurrentThread.Name = "Main Thread";
	Console.WriteLine($"Thread name: {Thread.CurrentThread.Name}");
	Console.WriteLine($"Thread is background: {Thread.CurrentThread.IsBackground}");
	Console.WriteLine($"Thread is threadpool: {Thread.CurrentThread.IsThreadPoolThread}");
}
static void Example1()
{
	var wallet = new Wallet(200);
	Console.WriteLine("from main thread" + wallet.Balance);
	var t = new Thread(wallet.DoTrans);
	//status from start to running
	t.Start();
	t.Join();
}
static void Example2()
{
	var wallet = new Wallet();
	Console.WriteLine("from main thread : " + wallet.Balance);
	var t1 = new Thread(() => wallet.Deposit(100));
	//status from start to running
	t1.Start();
	t1.Join();
	Console.WriteLine("after Deposit : " + wallet.Balance);

}
static void Example3()
{
	var wallet = new Wallet();
	Console.WriteLine("from main thread : " + wallet.Balance);
	var t1 = new Thread(() => wallet.Withdraw(100));
	var t2 = new Thread(() => wallet.Withdraw(100));
	//status from start to running
	t1.Start();
	t2.Start();
	t1.Join();
	t2.Join();
	Console.WriteLine("after withdraw : " + wallet.Balance);
}
static void Example4()
{
	var w1 = new Wallet(1000);
	var w2 = new Wallet(1000);
	Console.WriteLine($"w1 balance:  {w1.Balance}");
	Console.WriteLine($"w2 balance:  {w2.Balance}");

	var t1 = new Thread(() => Exchange.Transfer( w1,w2, 200));
	var t2 = new Thread(() => Exchange.Transfer( w2, w1, 500));
	t1.Start();
	t2.Start();
	t1.Join();
	t2.Join();
	Console.WriteLine($"w1 balance:  {w1.Balance}");
	Console.WriteLine($"w2 balance:  {w2.Balance}");
}
static void Example5()
{
	var w1 = new Wallet(1000);
	var w2 = new Wallet(1000);
	Console.WriteLine($"w1 balance:  {w1.Balance}");
	Console.WriteLine($"w2 balance:  {w2.Balance}");
		Task.Run(()=>Exchange.Transfer(w1, w2, 500)).Wait();
		Task.Run(()=>Exchange.Transfer(w2, w1, 900)).Wait();
	Console.WriteLine($"w1 balance:  {w1.Balance}");
	Console.WriteLine($"w2 balance:  {w2.Balance}");
}