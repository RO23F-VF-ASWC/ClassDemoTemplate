// See https://aka.ms/new-console-template for more information
using ClassDemoTemplate.template;

Console.WriteLine("Hello, World!");

AbstractADT adt = new ListADT();
//AbstractADT adt = new SetADT();

adt.Add("Peter");
adt.Add("Anders");
adt.Add("Jens Peter");
adt.Add("Michael");
adt.Add("Michael");

Console.WriteLine(adt);