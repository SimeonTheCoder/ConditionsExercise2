using System;

class SummerOutfit
{
    static void Main()
    {
        int degrees = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();

        string outfit = "";
        string shoes = "";

        if (degrees >= 10 && degrees <= 18)
        {
            switch (timeOfDay)
            {
                case "Morning":
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";

                    break;

                case "Afternoon":
                case "Evening":
                    outfit = "Shirt";
                    shoes = "Moccasins";

                    break;
            }
        }
        else if (degrees > 18 && degrees <= 24)
        {
            switch (timeOfDay)
            {
                case "Morning":
                case "Evening":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
                case "Afternoon":
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    break;
            }
        }

        else if (degrees >= 25)
        {
            switch (timeOfDay)
            {
                case "Morning":
                case "Afternoon":
                    outfit = "T-Shirt";
                    shoes = "Sandals";

                    break;

                case "Evening":
                    outfit = "Shirt";
                    shoes = "Moccasins";

                    break;
            }
        }

        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
}