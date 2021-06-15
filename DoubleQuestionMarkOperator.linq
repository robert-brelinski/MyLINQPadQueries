<Query Kind="Statements" />

string s1 = null;
string s2 = "Abcd";

//if (s == null) s = "Hello1";
//s.Dump();

s1 ??= "Hello2";
s1.Dump();

s2 ??= "Hello3";
s2.Dump();
