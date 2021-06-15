<Query Kind="Statements" />

new TimeSpan(2, 30, 0).Dump();

var t1 = TimeSpan.FromHours(2.5).Dump();
var t2 = TimeSpan.FromHours(-2.5).Dump();
TimeSpan r = t1 + t2;
r.Dump();

var r2 = TimeSpan.FromHours(2) + TimeSpan.FromMinutes(30);
r2.Dump();

var r3 = TimeSpan.FromDays(10) - TimeSpan.FromMinutes(10);
r3.Dump();
r3.Days.Dump();
r3.Hours.Dump();

TimeSpan.Zero.Dump();

DateTime d = DateTime.Now.Dump();
TimeSpan r4 = DateTime.Now.TimeOfDay.Dump();