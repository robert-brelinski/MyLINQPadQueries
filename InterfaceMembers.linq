<Query Kind="Program" />

void Main()
{
	A a = new();
	a.Foo();
	((IMyLogger)a).Log("Hello"); //if not implemented
	a.Log("AAA");
	IMyLogger.Prefix = "DEBUG:";
	IMyLogger.Prefix.Dump();
}

interface IMyLogger
{
	static string Prefix = "";
	void Log(string text) => text.Dump();
	void Foo();
}

class A : IMyLogger
{
	public void Log(string text) => $"{text} from A".Dump();
	public void Foo() => "Foo2".Dump();
}
