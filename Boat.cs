using System;

class FishingBoat
{
    static void Main()
    {
        int budget = int.Parse(Console.ReadLine());

        string season = Console.ReadLine();

        int fishermenCount = int.Parse(Console.ReadLine());

        double boatPrice = 0;

        switch (season)
        {
            case "Spring":
                boatPrice = 3000;

                break;

            case "Summer":
            case "Autumn":
                boatPrice = 4200;

                break;

            case "Winter":
                boatPrice = 2600;

                break;
        }

        if (fishermenCount <= 6)
        {
            boatPrice *= 0.9;
        }
        else if (fishermenCount <= 11)
        {
            boatPrice *= 0.85;
        }
        else
        {
            boatPrice *= 0.75;
        }

        if (fishermenCount % 2 == 0 && season != "Autumn") boatPrice *= 0.95;

        if (budget >= boatPrice)
        {
            Console.WriteLine($"Yes! You have {budget - boatPrice:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {boatPrice - budget:f2} leva.");
        }
    }
}