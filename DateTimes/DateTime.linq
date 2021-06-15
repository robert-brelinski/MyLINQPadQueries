<Query Kind="Statements" />

DateTime.Now.Dump();
DateTimeOffset.Now.Dump();

DateTime.Today.Dump();

DateTime.Now.Year.Dump();
DateTime.Now.Ticks.Dump();
DateTime.Now.DayOfYear.Dump();
DateTime.Now.DayOfWeek.Dump();


TimeSpan hours = TimeSpan.FromHours(12);
DateTime dt = DateTime.Now;
dt.Dump();
(dt - hours).Dump();
dt.AddHours(-12).Dump();
dt.AddHours(hours.TotalHours).Dump();


DateTime.Now.ToString().Dump();
DateTime.Now.ToShortDateString().Dump();
DateTime.Now.ToLongDateString().Dump();

"------------------------------------------".Dump();

DateTime.Now.ToString().Dump();
DateTime.Now.ToString("d").Dump();
DateTime.Now.ToString("D").Dump();
DateTime.Now.ToString("t").Dump();
DateTime.Now.ToString("T").Dump();
DateTime.Now.ToString("f").Dump();
DateTime.Now.ToString("F").Dump();
DateTime.Now.ToString("g").Dump();
DateTime.Now.ToString("G").Dump();
DateTime.Now.ToString("m").Dump();
DateTime.Now.ToString("y").Dump();

"------------------------------------------".Dump();

DateTime.Now.ToString("yyyy-MM-dd").Dump();
DateTime.Now.ToString("yyyy-MM-dd HH:mm").Dump();
