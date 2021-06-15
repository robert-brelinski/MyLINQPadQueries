<Query Kind="Statements" />

var bob = ("Robert", 34, "C# Developer");
bob.Dump();
bob.Item1.Dump();

//Equivalent
ValueTuple<string, int, string> bob2 = ValueTuple.Create("Robert", 34, "C# Developer");
bob2.Dump();

(string, int) joe = ("Joe", 36);
joe.Dump();

var ann = (Name:"Ann", Age:26);
ann.Dump();

var t = (Day:DateTime.Now.Day, Month:DateTime.Now.Month, Year:DateTime.Now.Year);
t.Dump();
$"{t.Day}.{t.Month.ToString("D2")}.{t.Year}".Dump();
$"{t.Year}-{t.Month}-{t.Day}".Dump();

(int year, int month, _) = t;
year.Dump();
month.Dump();