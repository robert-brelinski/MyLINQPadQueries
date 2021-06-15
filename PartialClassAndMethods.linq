<Query Kind="Program" />

void Main()
{
	A a = new();
	
	$"{a.GetName():C2} {a.GetMoney()}".Dump();
	a.ImPartial("Partial method calling");
}

partial class A 
{
	public decimal GetMoney() => 20_000.00M;
	
	public partial void ImPartial(string p);
}


partial class A 
{
	public string GetName() => "Robert";
	
	public partial void ImPartial(string p)
	{
		p.Dump();
	}
}
