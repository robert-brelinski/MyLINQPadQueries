<Query Kind="Program" />

void Main()
{
	int a = 1, b = 2;
	$"{a} {b}".Dump();
	A.Swap<int>(ref a, ref b);
	$"{a} {b}".Dump();
}

public static class A
{
	public static void Swap<T>(ref T a, ref T b)
	{
		T temp = a;
		a = b;
		b = temp;
	}
}
