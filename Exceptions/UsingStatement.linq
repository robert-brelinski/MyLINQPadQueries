<Query Kind="Statements" />

using(StreamReader reader = File.OpenText(@"C:\Users\DELL\Documents\LINQPad Queries\Input\Test.txt"))
{
	reader.ReadLine().Dump();
}

//above is equivalent to below

{
	StreamReader reader2 = File.OpenText(@"C:\Users\DELL\Documents\LINQPad Queries\Input\Test.txt");
	try
	{
		reader2.ReadLine().Dump();
	}
	finally
	{
		if(reader2 != null)
			((IDisposable)reader2).Dispose();
	}
}

// and below, using as an expression

if(File.Exists((@"C:\Users\DELL\Documents\LINQPad Queries\Input\Test.txt")))
{
	using var reader = File.OpenText((@"C:\Users\DELL\Documents\LINQPad Queries\Input\Test.txt"));
	reader.ReadLine().Dump();
}