//Решение артема

int number = new Random.Next(100,1000);
Console.WriteLine("число"+number);
int numberSecondDigit=number/100;
int numberThirdDigit=number%10;
Console.WriteLine("Число после удаления второй цифры"+numberSecondDigit+numberThirdDigit);
