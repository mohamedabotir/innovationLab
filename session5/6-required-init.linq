<Query Kind="Program" />

void Main()
{
	var person = new Person(){Name="yahia"};
	person.Dump();
}

class Person {
public required string Name{init;get;}
}