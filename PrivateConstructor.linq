<Query Kind="Program" />

void Main()
{
	Tree tree = Tree.GetInstance(11);
	tree.Dump();
}

class Tree
{
	public int Id { get; set; }
	
	private Tree(int id)
	{
		Id = id;
	}
	
	public static Tree GetInstance(int id)
	{
		return new Tree(id);
	}
}
