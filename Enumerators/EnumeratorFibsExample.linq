<Query Kind="Program" />

void Main()
{
	foreach (int f in Fibs(12))
		f.Dump();

	//equivalent to below
	var sequence = Fibs(12);
	using(var enumerator = sequence.GetEnumerator())
	{
		while (enumerator.MoveNext())
			enumerator.Current.Dump();
	}
	
	foreach (int i in EvenNumbersOnly(Fibs(12)))
		i.Dump();
}

static IEnumerable<int> Fibs(int fibCount)
{
	for(int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
	{
		yield return prevFib; // Next element for this enumerator

		int newFib = prevFib + curFib;
		prevFib = curFib;
		curFib = newFib;
	}
}

static IEnumerable<int> EvenNumbersOnly(IEnumerable<int> sequence)
{
	foreach (int x in sequence)
		if ((x % 2) == 0)
			yield return x;
}
