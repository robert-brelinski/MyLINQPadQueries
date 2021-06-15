<Query Kind="Statements" />

string name = "Robert";

name.Contains("Rob").Dump();
name.EndsWith("t").Dump();
name.EndsWith("a").Dump();

name.Insert(0, "-").Dump();

name.PadLeft(10, '*').Dump();

string[] s = "Roberto my man!".Split();

foreach (var i in s)
	i.Dump();
	
string t = string.Join("&", s);
t.Dump();