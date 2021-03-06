<Query Kind="Program" />

void Main()
{
	Sides.Bottom.Dump();
	Sides.Bottom.ToString().Dump();
	
	Sides s = Sides.Left | Sides.Right;
	s.ToString().Dump();
	
	int t = (int)Sides.Top;
	t.Dump();
	
	((Sides)2).Dump();
	
	
	foreach (int x in Enum.GetValues(typeof(Sides)))
		x.Dump();

	foreach (string y in Enum.GetNames(typeof(Sides)))
		y.Dump();

}

[Flags]
public enum Sides
{
	Top = 2,
	Right = 4,
	Bottom = 8,
	Left = 16
}