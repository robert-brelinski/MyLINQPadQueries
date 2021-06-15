<Query Kind="Program" />

void Main()
{
	Stock s = new("Test");
	s.Price = 27.10M;
	s.PriceChanged += stock_PriceChanged;
	s.Price = 32.11M;
	s.Price = 32.12M; //not 10%, no event
	s.Price = 35.66M;
	
	static void stock_PriceChanged(object sender, PriceChangedEventArgs e)
	{
		if((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
		"Alert, 10% stock price increase!".Dump();
	}
}

//EventArgs is a standard input class to event
public class PriceChangedEventArgs : EventArgs
{
	public readonly decimal LastPrice;
	public readonly decimal NewPrice;
	
	public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
	{
		LastPrice = lastPrice;
		NewPrice = newPrice;
	}
}

public class Stock
{
	string symbol;
	decimal price;
	
	public Stock(string symbol)
	{
		this.symbol = symbol;
	}
	
	public event EventHandler<PriceChangedEventArgs> PriceChanged;
	protected virtual void OnPriceChanged(PriceChangedEventArgs e)
	{
		PriceChanged?.Invoke(this, e);
	}
	
	public decimal Price
	{
		get => price;
		set
		{
			if(price == value) return;
			decimal oldPrice = price;
			price = value;
			OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
		}
	}
}
