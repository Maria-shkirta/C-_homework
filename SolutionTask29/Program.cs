// задает массив из 8 элементов и выводит их на экран. 6, 33, 1=> [6, 33, 1]

System.Random numberSintezator = new Random();

void Calculate()
{
    int i = 0;
    Console.Write("[");
    while (i < 8-1)
    {
        Console.Write(numberSintezator.Next(0, 100)+",");
        i++; 

    }
     Console.Write(numberSintezator.Next(0, 100));
        Console.Write("]");
}

Calculate();
