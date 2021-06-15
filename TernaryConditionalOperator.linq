<Query Kind="Program" />

void Main()
{
	int q = 1;
	
	bool res = (q == 2) ? true : false;
	
	string res2 = (q == 1) ? "Ok" : "No way!";
	
	res.Dump();
	res2.Dump();
}