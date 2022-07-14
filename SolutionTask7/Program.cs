string? inputLine = Console.ReadLine();

if (inputLine != null);
{
   int inputNumber= int.Parse(inputLine);
   int outputNumber= inputNumber%2;

   if (outputNumber == 0)
   {
    Console.WriteLine("Да");
   }
   else Console.WriteLine("Нет");

}