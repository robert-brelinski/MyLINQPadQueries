<Query Kind="Statements" />

"Hello".Dump();
new string('*', 10).Dump();

foreach (char c in "Hello")
{
	if(c == 'l')
		c.Dump();
}

char[] word = "word".ToCharArray();
string s = new string(word).ToUpper();
s.Dump();

string e = "";

(e == string.Empty).Dump();
(e == "").Dump();
(e.Length == 0).Dump();
