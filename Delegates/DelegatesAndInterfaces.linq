<Query Kind="Program" />

void Main()
{
	int[] values = {1, 2, 4};
	
	Util.Transform(values, new Square());
	foreach(int i in values) i.Dump();

	Util.Transform(values, new Cube());
	foreach(int i in values) i.Dump();
}

public interface ITransformer
{
	int Transform(int x);
}

public class Util
{
	public static void Transform(int[] values, ITransformer t)
	{
		for(int i = 0; i < values.Length; i++) values[i] = t.Transform(values[i]);
	}
	
}

class Square : ITransformer
{
	public int Transform(int x) => x * x;
}

class Cube : ITransformer
{
	public int Transform(int x) => x * x * x;
}
