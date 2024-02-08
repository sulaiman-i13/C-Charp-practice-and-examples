
Console.WriteLine("================struct====================");
Product product1;
product1._id = 1;
product1._price = 10;
product1._name = "product1";
Product product2 = new Product()
{
	_id = 2,
	_price = 20,
	_name = "product2",
};
Product product3 = new Product(3, 30);
Product product4 = new Product(4, 40);
product4=product1 + product2;
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);
Console.WriteLine(product4);

struct Product
{
	public int _id;
	public int _price;
	public string _name;
	//cant use parameterless Ctor
	// Product() { }
	public Product(int id, int price)
	{
		_id = id;
		_price = price;
		_name = $"product+{DateTime.Now}";
	}


	void ChangePrice(int price)
	{
		_price = price;
	}
	public override string ToString()
	{
		return $"(id={_id} ,Price={_price},name={_name})";
	}
	public static Product operator +(Product left, Product right) {
		return new Product { _price = left._price + right._price }; }


}
