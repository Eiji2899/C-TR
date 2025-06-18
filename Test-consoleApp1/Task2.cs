public static class Task2
{
    public static void Run()
    {
        // Task 2 logic
        //Write a method that takes a list of integers and returns the largest number.
        //Example: [4, 9, 2, 11, 5] → 11

        int FindMax(List<int> numbers)
        {
            // Your code here
            int temp = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0)
                {
                    temp = numbers[i];
                }
                else if (numbers[i] > temp)
                {
                    temp = numbers[i];
                }
            }
            return temp;
        }
        Console.WriteLine("Enter a list of integers and after each number press enter and for exit press 2 enter:");
        List<int> numbers = new List<int>();
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break; // Exit on empty input
            }
            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }

        int maximum = FindMax(numbers);
        Console.WriteLine($"The largest number is: {maximum}");
    }
}