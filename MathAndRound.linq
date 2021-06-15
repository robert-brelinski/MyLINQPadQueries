<Query Kind="Statements" />

Math.Round(3.5).Dump();
Math.Truncate(3.5).Dump();
Math.Ceiling(3.5).Dump();
Math.Floor(3.5).Dump();

Math.Max(3.5, 3.4).Dump();
Math.Min(3.5, 3.4).Dump();

Math.Abs(-3.5).Dump();
Math.Sign(3.5).Dump();
Math.Sign(-3.5).Dump();

Math.Pow(2, 3).Dump();
Math.Exp(2).Dump();

Random rand = new();
Random rand2 = new(1);

rand.Next(10).Dump();
rand.Next(10).Dump();

rand2.Next(10).Dump();
rand2.Next(10).Dump();

//Cryptography random numbers
var rrand = System.Security.Cryptography.RandomNumberGenerator.Create();
byte[] bytes = new byte[32];
rrand.GetBytes(bytes);
int i = BitConverter.ToInt32(bytes);
i.Dump();
