<Query Kind="Program" />

void Main()
{
	//Equality comparison
	string.Equals("Foo", "Bar").Dump();
	string.Equals("Foo", "Foo").Dump();
	string.Equals("Foo", "foo").Dump();
	
	"Foo".Equals("Foo").Dump();
	
	string.Equals("foo", "Foo", StringComparison.OrdinalIgnoreCase).Dump();

	//Order comparison
	"Robert".CompareTo("Robert").Dump();
	"Adam".CompareTo("Eva").Dump();
	"Eva".CompareTo("Adam").Dump();
	"Adam".CompareTo("Adam").Dump();
	
	string.Compare("foo", "FOO", true).Dump();
}

