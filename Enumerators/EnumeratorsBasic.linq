<Query Kind="Statements" />

foreach (char c in "beer")
	c.Dump();
	
"-------------------------------------------------".Dump();

using(var enumerator = "beer".GetEnumerator())
{
	while(enumerator.MoveNext())
	{
		var element = enumerator.Current;
		element.Dump();
	}
}
