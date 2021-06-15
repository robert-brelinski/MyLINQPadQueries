<Query Kind="Program" />

void Main()
{
	int i = 10;
	i.Dump();
	var j = Foo(ref i);
	j.Dump();
	i.Dump();
	
	SplitName("Robert Breliński", out string f, out string l);
	f.Dump();
	l.Dump();
	
	Util.SplitName("Stevie Ray Vaugan", out string f2, out string l2);
	f2.Dump();
	l2.Dump();
	
	int x = 1;
	int y = 1;
	Util.Inc(x);
	Util.Inc(ref y);
	
	x.Dump();
	y.Dump();
	
	Util.Sum(1, 2, 3, 1, 13).Dump();
	
	int[] items = {1, 2, 3, 4, 5 };
	Util.Sum(items).Dump();
}

public int Foo(ref int x)
{
	return ++x;
}

public void SplitName(string name, out string fname, out string lname)
{
	var splitted = name.Split();
	fname = splitted[0];
	lname = splitted[1];
}

public static class Util
{
	public static void SplitName(string name, out string fname, out string lname)
	{
		var space = name.LastIndexOf(" ");
		fname = name.Substring(0, space);
		lname = name.Substring(space + 1);
	}
	
	public static int Inc(int x) => ++x;
	public static int Inc(ref int x) => ++x;
	
	public static int Sum(params int[] items)
	{
		int sum = 0;
		for(int i = 0; i < items.Length; i++)
		{
			sum += items[i];
		}
		return sum;
	}
}
