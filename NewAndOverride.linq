<Query Kind="Program" />

void Main()
{
	OtherClass other = new();
	other.GetFirstName().Dump();
	
	MyClass my = other;
	my.GetFirstName().Dump();
	
	BaseClass b = my;
	b.GetFirstName().Dump();
}

public class BaseClass
{
	public virtual string GetFirstName() => "Adam";
	public string GetLastName => "Adams";
}

public class MyClass : BaseClass
{
	public sealed override string GetFirstName() => "Eva";
}

public class OtherClass : MyClass
{
	//public override string GetFirstName() => "No";
	public new string GetFirstName() => "Yes";
}
