<Query Kind="Statements" />

(string ,decimal ) tuple= new ("Ahmed",500M);
Console.WriteLine(tuple.Item1+" "+ tuple.Item2);

(string Name, decimal Salary) tuple1 = (Name:"Ahmed", Salary:500M);
(string Name, decimal Salary) tuple2 = (Name:"Ahmed", Salary:500M);
var comparer=tuple1 != tuple2;
comparer.Dump();
tuple1.Name.Dump();
tuple1.Salary.Dump();


(double , double) calculateTaxWithSalary(double salary){

return (salary,salary*0.1); 
}