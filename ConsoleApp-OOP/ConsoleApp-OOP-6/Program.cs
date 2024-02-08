using System.ComponentModel.DataAnnotations;

Console.WriteLine($"===================================operator overloading ===================================");

Wallet w1 = new Wallet { Id = 1, Amount = 10m }; 
Wallet w2 = new Wallet { Id = 2, Amount = 20m };
Console.WriteLine($"w1 =>{ w1}");
Console.WriteLine($"w2 =>{ w2}");
Console.WriteLine($"w3 =>{ w1+w2}");
Console.WriteLine($"w1==w2 =>{ w1==w2}");
Console.WriteLine($"w1!=w2 =>{ w1!=w2}");
Console.WriteLine($"w1>w2 =>{ w1>w2}");
Console.WriteLine($"w1<w2 =>{ w1<w2}");
Console.WriteLine($"w1>=w2 =>{ w1>=w2}");
Console.WriteLine($"w1<=w2 =>{ w1<=w2}");

class Wallet{
    public int Id { get; set; }
    public decimal Amount { get; set; }
	public override string ToString()
	{
		return $"id= {Id}- amount= {Amount}";
	}
	public static Wallet operator +(Wallet left,Wallet right)
    {
        return new Wallet { Amount=left.Amount+right.Amount};
    }
   public static bool operator ==(Wallet left, Wallet right) { return left.Amount==right.Amount; }
   public static bool operator !=(Wallet left, Wallet right) { return left.Amount != right.Amount; }
	public static bool operator >(Wallet left, Wallet right) { return left.Amount > right.Amount; }
	public static bool operator <(Wallet left, Wallet right) { return left.Amount < right.Amount; }
	public static bool operator >=(Wallet left, Wallet right) { return left.Amount >= right.Amount; }
	public static bool operator <=(Wallet left, Wallet right) { return left.Amount <= right.Amount; }
}