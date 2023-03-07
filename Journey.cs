using System;

class Journey
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
      
        string season = Console.ReadLine();

        string destination = "";
      	string vacationType = "";
      
        double price = 0;

        if (budget <= 100)
        {
            destination = "Bulgaria";
          
            if (season == "summer")
            {
                vacationType = "Camp";
              
                price = budget * 0.3;
            }
            else if (season == "winter")
            {
                vacationType = "Hotel";
              
                price = budget * 0.7;
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
          
            if (season == "summer")
            {
                vacationType = "Camp";
              
                price = budget * 0.4;
            }
            else if (season == "winter")
            {
                vacationType = "Hotel";
              
                price = budget * 0.8;
            }
        }
        else if (budget > 1000)
        {
            destination = "Europe";
            vacationType = "Hotel";
          
            price = budget * 0.9;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{vacationType} - {price:f2}");
    }
}