<Query Kind="Statements" />

var obj = "Hello";
obj = "Abcd";

if (obj is string { Length:4 })
{
	"Hooray!".Dump();
	obj.ToString().Dump();
}
else
{
	obj.ToString().Dump();
}