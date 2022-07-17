string? inputNumber=Console.ReadLine();
    
            string answer;
            int num=int.Parse(inputNumber);
            if (((num%7)==0)&&((num%23)==0))
            {
                answer="It's multiple for 7 and 23";
            }
            else 
            {
                answer="It's not multiple for 7 and 23";
            }
            Console.WriteLine(answer);
    