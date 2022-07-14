string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();

if (inputLine1 != null && inputLine2 != null);
{
   int inputNumber1= int.Parse(inputLine1);
   int inputNumber2= int.Parse(inputLine2);

    if (inputNumber1 > inputNumber2)
    {
        Console.WriteLine(inputNumber1);
    }
    else Console.WriteLine(inputNumber2);

}