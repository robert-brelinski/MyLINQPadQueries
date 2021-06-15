<Query Kind="Program" />

void Main()
{
	try
	{
		Test.Calc(0);
	}
	catch(DivideByZeroException e)
	{
		e.Message.Dump();
	}
	finally
	{
		"Just say hello!".Dump();
	}
}

class Test
{
	public static int Calc(int x) => 10 / x;
}
