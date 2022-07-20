//принимает координаты 2 точек и находит расстояние между ними в 3Д. например А(3,6,8), В(2,1,-7)|=>15,84

int coordXPointA;
int coordYPointA;
int coordZPointA;
int coordXPointB;
int coordYPointB;
int coordZPointB;

double lengthAB;


//считывает координаты A и В
void readDataOfPoint()
{
    Console.WriteLine("Введите координату X точкм А");
    coordXPointA=int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точкм А");
    coordYPointA=int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точкм А");
    coordZPointA=int.Parse(Console.ReadLine());


    Console.WriteLine("Введите координату X точкм B");
    coordXPointB=int.Parse(Console.ReadLine());

  
    Console.WriteLine("Введите координату Y точкм B");
    coordYPointB=int.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите координату Z точкм B");
    coordZPointB=int.Parse(Console.ReadLine());
    
}



//вычисляет расстояние между А и В
void calculateLengthAB()
{
    lengthAB=Math.Sqrt(Math.Pow((coordXPointA-coordXPointB),2)+Math.Pow((coordYPointA-coordYPointB),2)+Math.Pow((coordZPointA-coordZPointB),2));
}

readDataOfPoint();
calculateLengthAB();

Console.WriteLine(lengthAB);
