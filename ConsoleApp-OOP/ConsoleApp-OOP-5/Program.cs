Console.WriteLine("=================events==============================");

var product = new Product() { Id = 1, Name = "Coffe", Price = 5m };
ProductConsumer.onPriceChange += ProductConsumer_onPriceChange;
Console.WriteLine(product);
Thread.Sleep(1000);
ProductConsumer.ChangePrice(product, 10m);
Thread.Sleep(1000);
ProductConsumer.ChangePrice(product, 7);
Thread.Sleep(1000);
ProductConsumer.ChangePrice(product, 7m);


void ProductConsumer_onPriceChange(Product product, decimal price)
{
	if (price > product.Price)
	{
		product.Price = price;
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(product);
	}
	else if (price < product.Price)
	{
		product.Price = price;
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine(product);
	}else 
	{
		product.Price = price;
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine(product);
	}
}

delegate void OnPriceChangeHandler(Product product, decimal price);
class Product
{
	public int Id { get; set; }
	public string Name { get; set; }
	public decimal Price { get; set; }
	public override string ToString()
	{
		return $"id: {Id} - name: {Name} - price: {Price}";
	}

}
class ProductConsumer
{
	public static event OnPriceChangeHandler onPriceChange;
	public static void ChangePrice(Product product, decimal newPrice)
	{
		if (onPriceChange is not null)
		{
			onPriceChange(product, newPrice);
		}
	}
}
