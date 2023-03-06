using System;

class Cinema
{
    static void Main(string[] args)
    {
        string projectionType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        double total = 0;

        switch (projectionType)
        {
            case "Premiere":
                total = rows * columns * 12.00;

                break;

            case "Normal":
                total = rows * columns * 7.50;

                break;

            case "Discount":
                total = rows * columns * 5.00;

                break;
        }

        Console.WriteLine("{0:f2} leva", total);
    }
}