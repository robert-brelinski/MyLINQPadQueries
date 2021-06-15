<Query Kind="Program" />

void Main()
{
	SubClass s = new();
	s.GetName().Dump();
	s.GetNameFromBase().Dump();
}

public class BaseClass
{
	private string name;
	public BaseClass() => "BaseConstructor".Dump();
	public BaseClass(string name) => (this.name = name).Dump();
	public string GetName() => "Robert";
}

public class SubClass : BaseClass
{
//	public SubClass() => "SubClassConstructor".Dump(); //Then BaseClass() is called

	public SubClass() : base("Edward") => "SubClassConstructor".Dump();
	public new string GetName() => "Eva";
	public string GetNameFromBase() => base.GetName();
}
