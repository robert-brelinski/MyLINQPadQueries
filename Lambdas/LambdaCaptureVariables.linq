<Query Kind="Program" />

void Main()
{
	int factor = 4;
	
	Func<int, int> d = x => x * factor;
	
	d(2).Dump();
}

// You can define other methods, fields, classes and namespaces here
