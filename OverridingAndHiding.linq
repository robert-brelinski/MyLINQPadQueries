<Query Kind="Program" />

void Main()
{
	Woman w = new Woman();
	
	w.GetMe().Dump();
	w.Get().Dump();
	w.Counter.Dump();
}

public abstract class Human
{
	public abstract string Get();
	public string GetMe() => "Getting";
	
	public int Counter = 0;
}

public class Woman : Human
{
	public override string Get() => "Impl getting";
	
	public new int Counter = 1;
}
