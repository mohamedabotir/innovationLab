<Query Kind="Statements" />

List<int> array = new(){
    1,2,3,4,5
};
Range expression = 0..2;

array[^array.Count].Dump();
var copyArray = array[expression];
copyArray.Dump();
