string password = "ninja";

if (password.Length < 8 )
{
    WriteLine("Your password is to short. Use at least 8 characters.");
}
else
{
    WriteLine("Your password is strong");
}

object o = "3";
int j = 4;

if (o is int i)
{
WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}

int number = Random.Shared.Next(1, 7);
WriteLine($"My random number is {number}");
 switch (number)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("default");
        break;
}
WriteLine("After end of switch");
A_label:
WriteLine("After A_lable");

Animal?[] animals = new Animal?[]
{
    new Cat 
    { 
        Name = "Karen", 
        Born = new(year: 2022, month: 8, day: 23),
        Legs = 4, 
        IsDomestic = true 
    },
    null,
    new Cat 
    {
        Name = "Mufasa", 
        Born = new(year: 1994, month: 6, day: 12) 
    },
    new Spider 
    {
        Name = "Sid Vicious", 
        Born = DateTime.Today,
        IsPoisonous = true
    },
    new Spider 
    { 
        Name = "Captain Furry", 
        Born = DateTime.Today 
    }
};

foreach(Animal? animal in animals)
{
    string message;

    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"The cat named {fourLeggedCat.Name} has four legs.";
            break;
        case Cat wildCat when wildCat.IsDomestic == false:
            message = $"The non=demestic cat is named {wildCat.Name}";
            break;
        case Cat cat:
            message = $"The cat is named {cat.Name}.";
            break;
        default:
            message = $"The animal named {animal.Name} is a {animal.GetType().Name}.";
            break;
        case Spider spider when spider.IsPoisonous:
            message = $"The {spider.Name} spider is poisonous. Run!";
            break;
        case null:
            message = "The animal is null.";
            break;
    }
    WriteLine($"switch statement: {message}");
}