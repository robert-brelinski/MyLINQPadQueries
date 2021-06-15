<Query Kind="Program" />

void Main()
{
	//Delegates eliminate depedency between method from caller
	
	Transformer t = Square; //assign method to delegate -> delegate instantiate
	//Transformer t = new Transformer(Square); //equivalent
	
	t(3).Dump();
	t.Invoke(3).Dump(); //equivalent
	t(4).Dump();
}

delegate int Transformer(int x); //delegate definition

static int Square (int x) => x * x; //method
