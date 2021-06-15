<Query Kind="Program" />

void Main()
{
	Max<int>(12,0).Dump();
	Max<string>("b", "a").Dump();
}

static T Max<T>(T a, T b) where T : IComparable<T> => a.CompareTo(b) > 0 ? a : b;

static void Initialize<T>(T[] array) where T : new()
{
	for(int i = 0; i < array.Length; i++) array[i] = new T();
}
