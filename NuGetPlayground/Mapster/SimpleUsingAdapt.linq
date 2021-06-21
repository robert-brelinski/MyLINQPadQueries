<Query Kind="Statements">
  <NuGetReference>Mapster</NuGetReference>
  <Namespace>Mapster</Namespace>
</Query>

Person p = new() 
{
	Id = 1,
	Name = "Robert",
	Surname = "Breliński",
	Age = 34
};

p.Adapt<PersonDto>().Dump();

class Person
{ 
	public int Id { get; set; }
	public string Name { get; set; }
	public string Surname { get; set; }
	public int Age { get; set; }
}

class PersonDto 
{ 
	public string Name { get; set; }
	public int Age { get; set; }
}