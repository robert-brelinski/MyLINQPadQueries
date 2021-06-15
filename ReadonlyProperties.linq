<Query Kind="Program" />

void Main()
{
	Octopus billy = new("Billy", 124);
	//billy.name = "Billy"; //Constructors, setters and methods only
	billy.age.Dump();
	billy.number.Dump();
	billy.age = 11;
	billy.age.Dump();
	//billy.number = 124; //Constructors and setters only
	
	billy.Dump();
	billy.GetHeight().Dump();
	
	Octopus ann = new("Ann", 120, 26);
	ann.Dump();
}

class Octopus
{
	public Octopus(string name, int number)
	{
		this.name = name;
		this.number = number;
	}
	
	public Octopus(string name, int number, int age) : this(name, number)
	{
		this.age = age;
	}
	
	private string name;
	public int age = 10;
	public readonly int number = 123;
	
	const decimal height = 1.22M;
	
	public decimal GetHeight()
	{
		return height;
	}
}
