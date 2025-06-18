public static class Task1
{
    public static void Run()
    {
        // Task 1 logic
        //Write a method that takes a string and returns it reversed.
        //Example: "cloud" → "duolc"
        
        string ReverseString(string input)
        {
            // Your code here
            char[] charArray  = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                charArray[i] = input[input.Length - 1 - i];
            }
            string reversed = "";
            for (int i = 0; i < input.Length; i++)
            {
                reversed += charArray[i];
            }
            return reversed;
        }
        Console.WriteLine("Enter a string to reverse:");
        string userInput = Console.ReadLine();
        string reversedString = ReverseString(userInput);
        Console.WriteLine($"Reversed string: {reversedString}");
    }
}