<Query Kind="Program" />

void Main()
{
	Panda edi = new Panda { Name = "Edi", Age=3, Height=1.2F };
	
	edi.Dump();
	edi.ToString();
}

class Panda
{
	public string Name { get; set; }
	public int Age { get; set; }
	public float Height { get; set; }
	
	public override string ToString() => $"{Name} is {Age} years ago and his height is {Height} meters".Dump();
}
