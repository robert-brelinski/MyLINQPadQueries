<Query Kind="Program" />

void Main()
{
	int[] values = {1, 2, 3};
	
	Util.Transform(values, Cube);
	foreach(int i in values)
		$"Cube {i}".Dump();
	
	static int Square(int i) => (i * i).Dump();
	static int Cube(int i) => (i * i * i).Dump();
	
	Transformer t2 = Square;
	t2 += Cube;
	
	t2(2);
}

		

public delegate int Transformer(int x);

public class Util
{
	public static void Transform(int[] values, Transformer t)
	{
		for(int i = 0; i < values.Length; i++)
			values[i] = t(values[i]);
	}
}
