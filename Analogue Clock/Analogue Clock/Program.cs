namespace Analogue_Clock
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter the Hours : ");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Minutes : ");
            int minutes = int.Parse(Console.ReadLine());

            if ((hours >= 0 && hours < 24) && (minutes >= 0 && minutes < 60))
            {
                double hoursInDegrees = (hours * 30) + (minutes * 0.5);
                double minutesInDegrees = minutes * 6;
                double diff = Math.Abs(hoursInDegrees);

                if (diff > 180)
                {
                    diff = 360 - diff;
                }
                Console.WriteLine($"The Angle between {hours} hour and {minutes} minutes is {diff} degrees.");
            }
            else
            {
                Console.WriteLine("Invalid Time Input, Please Try Again");
            }

            Console.WriteLine();
            Main();
        }
    }
}