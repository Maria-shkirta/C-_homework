string? inputLKneOne = Console.ReadLine();

if (inputLKneOne != null)
{
    int inputNumber = int.Parse(inputLKneOne);
    
    int startNumber = 4;
    string lineOutput = "2";

    while (startNumber <= inputNumber)
    {
        
        lineOutput = lineOutput+", "+startNumber;
        startNumber = startNumber+2;
    }

    Console.WriteLine(lineOutput);
}
