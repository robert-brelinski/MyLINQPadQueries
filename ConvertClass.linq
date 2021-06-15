<Query Kind="Statements" />

double x = 3.5;
int y = (int)x;
y.Dump();

int y2 = Convert.ToInt32(x);
y2.Dump();

Type t = typeof(int);
object source = "42";
object result = Convert.ChangeType(source, t);
result.GetType().Dump();
result.Dump();

byte[] data = { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
string r = Convert.ToBase64String(data);
r.Dump();
data.Dump();