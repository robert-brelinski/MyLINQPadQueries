<Query Kind="Program">
  <NuGetReference>Bogus</NuGetReference>
  <Namespace>Bogus</Namespace>
</Query>

void Main()
{
	var t = new Faker<Person>()
	.RuleFor(x => x.Name, y => y.Name.FirstName())
	.RuleFor(x => x.Age, y => y.Random.Int(20, 40));
	
	t.Generate().Dump();
}

class Person
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Surname { get; set; }
	public int Age { get; set; }
}
