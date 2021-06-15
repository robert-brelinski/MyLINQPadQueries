<Query Kind="Program" />

void Main()
{
	char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};
	vowels[..2].Dump();
	vowels[2..].Dump();
	vowels[2..^2].Dump();

	var o = new Sentence();
	o.words[0].Dump();
	o[0].Dump();
	o[0..2].Dump();
	o[^1].Dump();
	o[^2].Dump();
}

class Sentence
{
 public string[] words = "The quick brown fox".Split();
 
 public string this [Index index] => words[index];
 public string[] this [Range range] => words[range];
}
