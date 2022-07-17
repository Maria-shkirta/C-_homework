string? input=Console.ReadLine();

Char[]output=input.ToCharArray();

if (output.Length>=3)
{
    Console.WriteLine(output[2]);
}
else 
{
    Console.WriteLine("третьей цифры нет");
}