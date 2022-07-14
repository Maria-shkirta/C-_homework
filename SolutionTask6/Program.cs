string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();
string? inputLine3 = Console.ReadLine();

if (inputLine1 != null && inputLine2 != null && inputLine3 != null);
{
   int inputNumber1= int.Parse(inputLine1);
   int inputNumber2= int.Parse(inputLine2);
   int inputNumber3= int.Parse(inputLine3);

    if (inputNumber1 > inputNumber2)
    {
        
        if (inputNumber1 > inputNumber3)
        {
        Console.WriteLine(inputNumber1);
        }
        else Console.WriteLine(inputNumber3);

    }
    else if (inputNumber2 > inputNumber3)
    {
        Console.WriteLine(inputNumber2);
    }
    else Console.WriteLine(inputNumber3);
}