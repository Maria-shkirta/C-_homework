System.Random numberSintezator = new Random();

//метод решения задачи вариант1
void variant1(System.Random numberSintezator)
{
    int number= numberSintezator.Next(10,100);

int firstNumber= number/10;
int secondNumber= number%10;

Console.WriteLine(number);

//Вариант1
if (firstNumber>secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}

}



//Метод решения задачи вариант2
void variant2(System.Random numberSintezator)
{
    char[] digits= numberSintezator.Next(10,100).ToString().ToCharArray();

int firstNumber= ((int)digits[0])-48;
int secondNumber= ((int)digits[0])-48;

int resultNumber= firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

}
 

variant1(numberSintezator);

variant2(numberSintezator);