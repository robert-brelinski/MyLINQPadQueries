<Query Kind="Statements" />

//Using declaration
if(File.Exists(@"C:\Users\DELL\Documents\LINQPad Queries\Input\Test.txt"))
{
 using var reader = File.OpenText(@"C:\Users\DELL\Documents\LINQPad Queries\Input\Test.txt");
 reader.ReadLine().Dump();
}
else
{
 "Not exists".Dump();
}