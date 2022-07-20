//по заданному номеру четверти показывает диапозон возможных координат точек в этой области (x и y).

void printAnswer(int number)
{
    if (inputNumber==1) Console.WriteLine("Допсутимо: x>0, y>0");
    if (inputNumber==2) Console.WriteLine("Допсутимо: x<0, y>0");
    if (inputNumber==3) Console.WriteLine("Допсутимо: x<0, y<0");
    if (inputNumber==4) Console.WriteLine("Допсутимо: x>0, y<0");

}

string? inputLine=Console.ReadLine();

if (inputLine!=null)
{
    int inputNumber=int.Parse(inputLine);

    printAnswer(inputNumber);


}