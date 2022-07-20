//принимает координаты 2 точек и находит расстояние между ними в 2Д. например А(3,6), В(2,1)|=>5,09

int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;
double lengthAB;


//считывает координаты A и В
void readDataOfPoint()
{
    Console.WriteLine("Введите координату X точкм А");
    coordXPointA=int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точкм А");
    coordYPointA=int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату X точкм B");
    coordXPointB=int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точкм B");
    coordYPointB=int.Parse(Console.ReadLine());
    
}



//вычисляет расстояние между А и В
void calculateLengthAB()
{
    lengthAB=Math.Sqrt(Math.Pow((coordXPointA-coordXPointB),2)+Math.Pow((coordYPointA-coordYPointB),2));
}

readDataOfPoint();
calculateLengthAB();

Console.WriteLine(lengthAB);
