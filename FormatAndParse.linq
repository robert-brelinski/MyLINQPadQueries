<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

bool res = int.TryParse("1", out int i);
res.Dump();
i.Dump();


bool res2 = int.TryParse("q", out int j);
res2.Dump();
j.Dump();

bool res3 = int.TryParse("1", out _);
res.Dump();


3.ToString("C").Dump();

var curr = new NumberFormatInfo();
curr.CurrencySymbol = "\u20AC";
3.ToString("C", curr).Dump();


CultureInfo uk = CultureInfo.GetCultureInfo("gb-GB");
3.ToString("C", uk).Dump();

CultureInfo de = CultureInfo.GetCultureInfo("de-DE");
3.ToString("C", de).Dump();

CultureInfo iv = CultureInfo.InvariantCulture;
3.ToString("C", iv).Dump();

NumberFormatInfo f = new();
f.NumberGroupSeparator = " ";
1234567890.1234567.ToString("N3", f).Dump();

string format = "Credit = {0:C}";
string.Format(format, 500, 2).Dump();

1.ToString("D2").Dump();
11.ToString("D2").Dump();

0.3.ToString("P0").Dump();


NumberFormatInfo ni = new();
ni.CurrencySymbol = "PLN";
ni.CurrencyGroupSeparator = " ";
double million = double.Parse("1 000 000 000 PLN", NumberStyles.Currency, ni);
million.Dump();