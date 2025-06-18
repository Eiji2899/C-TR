public static class Task3
{
    public static void Run()
    {
        // Task 3 logic
        // Write a method that checks if a given string is a palindrome.
        // (A palindrome reads the same forwards and backwards)
        // Examples:
        // "level" → true
        // "cloud" → false
        // "RaceCar" → true (ignore case)
        // "A man a plan a canal Panama" → true (ignore spaces and case)

        bool IsPalindrome(string input)
        {
            // Your code here
            if (string.IsNullOrEmpty(input))
            {
                return false; // Empty string is not a palindrome
            }
            string lowercaseInput = input.ToLower().Replace(" ", ""); // Ignore case and spaces
            int j = lowercaseInput.Length - 1;
            for (int i = 0; i < lowercaseInput.Length / 2; i++)
            {
                if (lowercaseInput[i] != lowercaseInput[j])
                {
                    return false; // Not a palindrome
                }
                j--;
            }
            return true; // It's a palindrome
        }

        while (true)
        {
            Console.WriteLine("Enter a string to check if it's a palindrome (or press Enter to exit):");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break; // Exit on empty input
            }
            bool isPalindrome = IsPalindrome(input);
            if (isPalindrome)
            {
                Console.WriteLine($"The string '{input}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The string '{input}' is not a palindrome.");
            }
        }
    }
}