<Query Kind="Program" />

void Main()
{
	int[] values = {1, 2, 3};
	
	Util.Transform(values, Square);
	foreach(int i in values) i.Dump();
	
	Util.Transform2(values, Square);
	foreach(int i in values) i.Dump();
	
	static int Square(int x) => x * x;
}

public delegate T Transformer<T>(T arg);

public class Util
{
	public static void Transform<T>(T[] values, Transformer<T> t) //Generics delegate
	{
		for(int i = 0; i < values.Length; i++)
		{
			values[i] = t(values[i]);
		}
	}
	
	public static void Transform2<T>(T[] values, Func<T, T> transformer) //Generics Func delegate
	{
		for(int i = 0; i < values.Length; i++)
		{
			values[i] = transformer(values[i]);
		}
	}
}
