// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var lijst = new List<Person>
{
    new Person()
    {
        Age = 10,
        Name = "Leon"
    },
    new Person()
    {
        Age = 25,
        Name = "Sjaak"
    }
};

var collection = from l in lijst
            where l.Age > 9
            where l.Age < 20
            select l;

foreach (var item in collection)
{
    Console.WriteLine(item);    
}

internal class Person
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string Name { get; set; } = string.Empty;

    override public string ToString() => $"{Name} {Age}";
}

