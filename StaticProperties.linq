<Query Kind="Program" />

void Main()
{
	var bill = new Panda("Bill");
	var ann = new Panda("Ann");
	
	bill.Dump();
	ann.Dump();
	
	Panda.Population.Dump();
}

public class Panda
{
	public static int Population { get; set; }
	public string Name {get; set; }
	
	public Panda(string name)
	{
		Name = name;
		Population++;
	}
}
