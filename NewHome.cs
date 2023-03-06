using System;

class Program
{
    const double rosePrice = 5;
    const double dahliaPrice = 3.80;
    const double tulipPrice = 2.80;
    const double narcissusPrice = 3;
    const double gladiolusPrice = 2.50;

    static void Main()
    {
        string flowerType = Console.ReadLine();

        int flowerCount = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        double flowerPrice = 0;

        switch (flowerType)
        {
            case "Roses":
                flowerPrice = rosePrice * flowerCount;

                if (flowerCount > 80) flowerPrice *= 0.9;

                break;

            case "Dahlias":
                flowerPrice = dahliaPrice * flowerCount;

                if (flowerCount > 90) flowerPrice *= 0.85;

                break;

            case "Tulips":
                flowerPrice = tulipPrice * flowerCount;

                if (flowerCount > 80) flowerPrice *= 0.85;

                break;

            case "Narcissus":
                flowerPrice = narcissusPrice * flowerCount;

                if (flowerCount < 120)  flowerPrice *= 1.15;

                break;

            case "Gladiolus":
                flowerPrice = gladiolusPrice * flowerCount;

                if (flowerCount < 80)   flowerPrice *= 1.2;

                break;
        }

        double difference = Math.Abs(budget - flowerPrice);

        if (budget >= flowerPrice)
        {
            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", flowerCount, flowerType, budget - flowerPrice);
        }
        else
        {
            Console.WriteLine("Not enough money, you need {0:F2} leva more.", difference);
        }
    }
}