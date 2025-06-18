using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose a task to run (1, 2, 3...) or press Enter to exit:");
            string choice = Console.ReadLine();
            if (string.IsNullOrEmpty(choice))
            {
                break; // Exit on empty input
            }

            switch (choice)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                case "3":
                    Task3.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }
        }
    }
}