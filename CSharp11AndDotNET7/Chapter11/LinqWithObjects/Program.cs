// See https://aka.ms/new-console-template for more information
string[] names = new[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };

SectionTitle("Deferred execution");

void SectionTitle(string v)
{
    throw new NotImplementedException();
}

var query1 = names.Where(name => name.EndsWith("m"));

foreach (string name in query1)
{
    WriteLine(name); 
    names[2] = "Jimmy"; 
                        
}


var query2 = from name in names where name.EndsWith("m") select name;

