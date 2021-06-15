<Query Kind="Statements" />

object x = true;

switch (x)
{
	case int i:
		i.Dump();
		break;
	case string s:
		s.Dump();
		break;
	case bool b when b == true:
		b.Dump();
		break;
	case null:
		break;
}