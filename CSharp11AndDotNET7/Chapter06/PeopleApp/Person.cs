using System.Runtime.InteropServices.JavaScript;

namespace Packt.Shared;
public class Person : object, IComparable<Person?>
{

    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public object AngerLevel { get; internal set;  }

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {

            if (Shout != null)
            {

                Shout(this, EventArgs.Empty);
            }
        }
    }

    public int CompareTo(Person? other)
    {
        throw new NotImplementedException();
    }

    public event EventHandler? Shout;

    public Nullable 

}