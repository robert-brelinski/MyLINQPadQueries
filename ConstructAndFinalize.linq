<Query Kind="Program" />

void Main()
{
	Final f = new();
}

class Final
{
	public string Name = "Robert";
	public Final() => ($"Construct {Name}").Dump();
	~Final() => ($"Finialize {Name}").Dump();
}
