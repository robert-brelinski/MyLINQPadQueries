<Query Kind="Program" />

void Main()
{
	Transformer t = delegate (int x) { return x * x; };
	//				(x) => x * x;
}

delegate int Transformer(int x);