// See https://aka.ms/new-console-template for more information

using Summative_6;

class Program
{
    static void Main()
    {
        Console.WriteLine("try entering a radius for the circle:");
        double radius = GetRadiusFromUser();

        Circle instance1 = new Circle(radius);
        Console.WriteLine($"Circle with ID {instance1.GetID()} has been created.");
        Console.WriteLine($"Circumference would be {instance1.GetCircumference():F2} and area would be {instance1.GetArea():F2}");
    }

    static double GetRadiusFromUser()
    {
        while (true)
        {
            try
            {
                double input = double.Parse(Console.ReadLine());
                if (input >= 0)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("try to enter a non-negative number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. try to enter a valid number.");
            }
        }
    }
}

