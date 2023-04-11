using System.Linq.Expressions;

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();
try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old.");
}
catch
{ 
}
WriteLine("After parsing");

CatchBlock (FormatException)
{
    WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");  
}
