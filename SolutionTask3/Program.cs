string? inputLKneOne = Console.ReadLine();

if (inputLKneOne != null)
{
    int inputNumber = int.Parse(inputLKneOne);
    
    int startNumber = 1;

    string lineOutput = "0";

    while (startNumber <= inputNumber)
    {
        lineOutput = startNumber*(-1)+", "+lineOutput+", "+startNumber;
        startNumber++;
    }
    // lineOutput=lineOutput+inputNumber;

    Console.WriteLine(lineOutput);
}
