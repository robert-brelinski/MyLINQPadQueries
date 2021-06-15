<Query Kind="Program" />

void Main()
{
	for(int prev = 0, curr = 1, next = 0;curr < 200;next++)
	{
		curr.Dump();
	
		next = prev + curr;
		prev = curr;
		curr = next;		
	}
}