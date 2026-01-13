// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hey what's ur name");
string? name = Console.ReadLine();

if(string.IsNullOrWhiteSpace(name)){ name = "Unkown"; }

Console.WriteLine($"Hey how is it going {name}");

Console.WriteLine("What's your age my I ask?");
string? input = Console.ReadLine();

if(int.TryParse(input, out int age))
{
    if (age < 18)
{
    Console.WriteLine("Ah so you're not an adult");
  }
else
    {
        Console.WriteLine("Ah so you're an adult");
    }
}

if(int.IsNegative(age))
{
    Console.WriteLine("Youre not fooling me");
}









