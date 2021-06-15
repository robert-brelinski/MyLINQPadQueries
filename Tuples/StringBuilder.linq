<Query Kind="Statements" />

StringBuilder s = new StringBuilder("Hello");
s.Dump();

s.Append(" world");
s.Dump();

s.Length.Dump();

s.AppendLine("Hello Robert!");
s.ToString().Dump();