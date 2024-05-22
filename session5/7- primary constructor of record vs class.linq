<Query Kind="Program" />

void Main()
{
	var person =  new Person("eslam","123");
	var copy = person with {id="123"};
	
	(person == copy).Dump();
	person.Dump();
	copy.Dump();
	
	var cls = new percl("mohamed","123");
	cls.Dump();
	var c = new percl("","");
	c.Name="";
	//c.name not applicaple as primary constructor of class define private field but for record public , init
}

record Person(string name,string id);

class percl(string name,string id){
public string Name = name;
public string Id = id;

};
