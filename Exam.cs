using System;

class Exam{

    static void Main()
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());
      
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinute = int.Parse(Console.ReadLine());

        int examTime = examHour * 60 + examMinute;
        int arrivalTime = arrivalHour * 60 + arrivalMinute;

        int difference = arrivalTime - examTime;

        if (difference >= 60)
        {
            int hours = difference / 60;
            int minutes = difference % 60;
          
            Console.WriteLine("Late\n{0}:{1:00} hours after the start", hours, minutes);
        }
        else if (difference > 0)
        {
            Console.WriteLine("Late\n{0} minutes after the start", difference);
        }
        else if (difference <= -60)
        {
            int hours = Math.Abs(difference) / 60;
            int minutes = Math.Abs(difference) % 60;
          
            Console.WriteLine("Early\n{0}:{1:00} hours before the start", hours, minutes);
        }
        else if (difference <= 0 && difference >= -30)
        {
            Console.WriteLine("On time\n{0} minutes before the start", Math.Abs(difference));
        }
        else if (difference < -30)
        {
            Console.WriteLine("Early\n{0} minutes before the start", Math.Abs(difference));
        }
    }
}