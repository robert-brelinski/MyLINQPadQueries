<Query Kind="Program" />

void Main()
{
	Lion lion = new();
	lion.walk.Dump();
	lion.beat.Dump();
	
	Animal animal = lion;
	animal.walk.Dump();
	//animal.beat.Dump();
	
	Lion lion2 = lion;
	lion2.walk.Dump();
	lion2.beat.Dump();
	
	//Animal animal2 = lion; //ok
	Animal animal2 = new();  //nie przejdzie
	//Lion li = (Lion)animal2;
	Lion li = animal2 as Lion;
	li.Dump();
	
	if (li is Lion)
		"It's lion".Dump();
	else
		"Not lion at all".Dump();
		
	if (lion is Lion l && l.name == "Leon")
	{
		l.name.Dump();
		l.GetName().Dump();
	}
	else
	{
		"Not lion at all".Dump();
	}
}

class Animal 
{
	public string walk = "Walking";
	public virtual string GetName() => "";
}
class Lion : Animal
{
	public string beat = "Beating";
	public string name = "Leon";
	public override string GetName() => name;
}
