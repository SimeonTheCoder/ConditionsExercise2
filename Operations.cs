using System;

class Operations
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
      
        char operation = char.Parse(Console.ReadLine());

        double result = 0;
        string evenOrOdd = "";

        switch (operation)
        {
            case '+':
                result = n1 + n2;
            
                if(result%2 == 0)
                {
                 	evenOrOdd = "even"; 
                }else{
                 	evenOrOdd = "odd"; 
                }
            
                Console.WriteLine($"{n1} + {n2} = {result} - {evenOrOdd}");
            
                break;

            case '-':
                result = n1 - n2;
            
                if(result%2 == 0)
                {
                 	evenOrOdd = "even"; 
                }else{
                 	evenOrOdd = "odd"; 
                }
            
                Console.WriteLine($"{n1} - {n2} = {result} - {evenOrOdd}");
            
                break;

            case '*':
                result = n1 * n2;
            	
            	if(result%2 == 0)
                {
                 	evenOrOdd = "even"; 
                }else{
                 	evenOrOdd = "odd"; 
                }
            
                Console.WriteLine($"{n1} * {n2} = {result} - {evenOrOdd}");
            
                break;

            case '/':
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 / (n2 + 0f);
                  
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
            
                break;

            case '%':
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;
                  
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            
                break;
        }
    }
}