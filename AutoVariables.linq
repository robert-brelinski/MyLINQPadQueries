<Query Kind="Statements" />

//Variables automatically generated

bool success = int.TryParse("123", out int result);

result.Dump();

decimal number = default;

number.Dump();

var x = "Hello!";

if (x is string s)
{
	x = "Second";
	x.Dump();
	s.Dump();
}