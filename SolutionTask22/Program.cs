// на входе число N, на выходе таблица квадратов чисел от 1 до N. 5->1, 4, 9, 16, 25

string? inputLineN=Console.ReadLine();

if (inputLineN!=null)
{
    int numberN=int.Parse(inputLineN);

    string LineN="";
    string LineNN=string.Empty;
    int s=1;

    while (s<=numberN)
    {
        LineN=LineN+s+" ";
        LineNN=LineNN+(s*s).ToString()+" ";
        s++;

    }
    Console.WriteLine(LineN);
    Console.WriteLine(LineNN);
}
