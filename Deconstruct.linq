<Query Kind="Program" />

void Main()
{
	Rectangle rect = new(3, 5);
	
	var (width, height) = rect;
	width.Dump();
	height.Dump();
	
	(float width2, float height2) = rect;
	width2.Dump();
	height2.Dump();
	
	(_, float height3) = rect;
	height3.Dump();
}

class Rectangle
{
	public readonly float Width, Height;
	
	public Rectangle (float width, float height)
	{
		Width = width;
		Height = height;
	}
	
	public void Deconstruct(out float width, out float height)
	{
		width = Width;
		height = Height;
	}
}
