<Query Kind="Statements" />

int i = 9;
object o = i;

double d = 1.23D;
object o2 = d;

int i2 = (int)(double)o2;
i2.Dump();