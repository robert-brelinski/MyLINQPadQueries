<Query Kind="Program" />

void Main()
{
	Stock s = new("A");
	
	s.PriceChanged += Change;
	//s.PriceChanged = Change; //not availiable for events (delegates only)
	
	s.Price = 11M;
	s.Price = 12M;
	s.Price = 15.99M;
	s.Price = 15.99M; //nothing changed
	
	void Change(decimal a, decimal b) => $"CHANGED {s.Price}".Dump();
}

public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

public class Stock
{
	string symbol;
	decimal price;
	
	public Stock(string symbol)
	{
		this.symbol = symbol;
	}
	
	public event PriceChangedHandler PriceChanged;
	
	public decimal Price
	{
		get { return price; }
		
		set
		{
			if(price == value) return;
			decimal oldPrice = price;
			price = value;
			if(PriceChanged != null) PriceChanged(oldPrice, price);
		}
	}
}
