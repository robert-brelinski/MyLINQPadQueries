<Query Kind="Program" />

void Main()
{
	"Test".HasCapitalChar().Dump();
	"Test".IsCapitalized().Dump();
	"TEST".IsCapitalized().Dump();
	"test".IsCapitalized().Dump();
}

public static class StringHelper
{
	public static bool HasCapitalChar(this string s)
	{
		return s.Any(char.IsUpper);
	}
	
	public static bool IsCapitalized(this string s)
	{
		return s.ToUpper().Equals(s);
	}
}
