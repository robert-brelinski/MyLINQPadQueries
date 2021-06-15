<Query Kind="Program" />

void Main()
{
	ChildClass c = new ChildClass();
	c.Get().Dump();
}

class BaseClass
{
	public string Name { get; set; }
	
	public virtual string Get()
	{
		return "Robert";
	}
}

class ChildClass : BaseClass
{
	public override string Get()
	{
		var r = base.Get();
		return $"{r} - Robert2";
	}
}
