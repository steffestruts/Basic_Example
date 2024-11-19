/*

string welcome = "Välkommen ";
string input = Console.ReadLine()!;

Console.WriteLine(input);
Console.Clear();
Console.WriteLine(welcome + input);

Console.ReadKey();

 */

string name = "";
string email = "";

do
{
    Console.WriteLine("Ange ditt namn: ");
    name = Console.ReadLine()!;

    if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Du måste ange ett namn.");
        Console.ReadKey();
        Console.Clear();
    }
} 
while (string.IsNullOrEmpty(name));

do
{
    Console.WriteLine("Ange en e-postadress: ");
    email = Console.ReadLine()!;

    if (string.IsNullOrEmpty(email))
    {
        Console.WriteLine("Du måste ange en e-postadress.");
        Console.ReadKey();
        Console.Clear();
    }
}
while (string.IsNullOrEmpty(email));

Console.Clear();
Console.WriteLine($"{name} <{email}>");
Console.ReadKey();