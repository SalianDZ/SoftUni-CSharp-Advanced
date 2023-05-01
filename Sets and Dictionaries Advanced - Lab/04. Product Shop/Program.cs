Dictionary<string, Dictionary<string, double>> shops = new();

while (true)
{
    string[] data = Console.ReadLine().Split(", ");

	if (data[0] == "Revision")
	{
		break;
	}
	
	string shop = data[0];
	string product = data[1];
	double price = double.Parse(data[2]);

	if (!shops.ContainsKey(shop))
	{
		shops.Add(shop, new Dictionary<string, double>());
	}
	else
	{
		shops[shop].Add(product, price);
	}

	if (!shops[shop].ContainsKey(product))
	{
		shops[shop].Add(product, price);
	}
	else
	{
		shops[shop][product] = price;
	}
}

shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
foreach (var shop in shops)
{
	Console.WriteLine($"{shop.Key}-> ");

	foreach (var product in shop.Value)
	{
		Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
	}
}