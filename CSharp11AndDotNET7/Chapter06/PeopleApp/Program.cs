using Packt.Shared;
Person harry = new()
{
    Name = "Harry",
    DateOfBirth = new(year: 2001, month: 3, day: 25)
};
harry.WriteToConsole();

System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2; 
WriteLine(format: "Key {0} has value: {1}",
 arg0: key,
 arg1: lookupObject[key]);

WriteLine(format: "Key {0} has value: {1}",
 arg0: harry,
 arg1: lookupObject[harry]);

Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(format: "Key {0} has value: {1}",
 arg0: key,
 arg1: lookupIntString[key]);

harry.Shout = Harry_Shout;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person? p = sender as Person;
    if (p is null) return;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}
static void Harry_Shout2(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person? p = sender as Person;
    if (p is null) return;
    WriteLine($"Stop it!");
}
harry.Shout += Harry_Shout;

harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout2;

void OutputPeopleNames(IEnumerable<Person?> people, string title)
{
    WriteLine(title);
    foreach (Person? p in people)
    {
        WriteLine(" {0}",
        p is null ? "<null> Person" : p.Name ?? "<null> Name");
        /* if p is null then output: <null> Person
        else output: p.Name
        unless p.Name is null in which case output: <null> Name */
    }
}
Person?[] people =
{
            null,
            new() { Name = "Simon" },
            new() { Name = "Jenny" },
            new() { Name = "Adam" },
            new() { Name = null },
            new() { Name = "Richard" }
        };
OutputPeopleNames(people, "Initial list of people:");
Array.Sort(people);
OutputPeopleNames(people, "After sorting using Person's IComparable implementation:");
