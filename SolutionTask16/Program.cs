string? inputFirst=Console.ReadLine();
string? inputSecond=Console.ReadLine();

if ((inputFirst!=null)&&(inputSecond!=null))
{
    int inputNumberFirst=int.Parse(inputFirst);
    int inputNumberSecond=int.Parse(inputSecond);

    int a=inputNumberFirst*inputNumberFirst;
    int b=inputNumberSecond*inputNumberSecond;

    if ((a==inputNumberSecond)||(b==inputNumberFirst))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}