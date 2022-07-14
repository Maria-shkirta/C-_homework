string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();

if (inputOne != null && inputTwo != null)
{
    int inputNumberOne = int.Parse(inputOne);
    int inputNumberTwo = int.Parse(inputTwo);

    if (inputNumberTwo == Math.Sqrt(inputNumberOne))
    {
        Console.WriteLine("yes");

    }
    else
    {
        Console.WriteLine("No");
    }
}