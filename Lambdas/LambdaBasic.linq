<Query Kind="Program" />

void Main()
{
	// (params) => expresssion
	// (params) => { block of instructions }
	Transformer sqr = x => x * x;
	sqr(2).Dump();
	
	Func<int, int> d = x => x * x * x;
	d(2).Dump();
}

delegate int Transformer(int x);
