public static class Task4
{
    public static void Run()
    {
        // Task 4 logic
        // Given a list of integers and a target number, return the indices of the two numbers that add up to the target.
        // Example:
        // Input: nums = [2, 7, 11, 15], target = 9
        // Output: [0, 1] (because 2 + 7 = 9)
        // Don’t use brute-force (no nested loops unless explained).
        // Use a dictionary to track values you’ve seen.

        int[] TwoSum(int[] nums, int target)
        {
            // Your code here
            Dictionary<int, int> numIndices = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numIndices.ContainsKey(complement))
                {
                    return new int[] { numIndices[complement], i }; // Return indices of the two numbers
                }
                if (!numIndices.ContainsKey(nums[i]))
                {
                    numIndices[nums[i]] = i; // Store the index of the current number
                }
            }
            return new int[0]; // Return an empty array if no solution is found
        }

        Console.WriteLine("Enter a list of integers separated by spaces:");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No input provided. Exiting.");
            return; // Exit if no input is provided
        }
        string[] inputArray = input.Split(' ');
        int[] nums = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (int.TryParse(inputArray[i], out int number))
            {
                nums[i] = number;
            }
            else
            {
                Console.WriteLine($"Invalid number '{inputArray[i]}'. Please enter valid integers.");
                return; // Exit if invalid input is found
            }
        }
        Console.WriteLine("Enter the target number:");
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            Console.WriteLine("Invalid target number. Please enter a valid integer.");
            return; // Exit if invalid target is provided
        }
        int[] result = TwoSum(nums, target);
        if (result.Length == 0)
        {
            Console.WriteLine("No two numbers found that add up to the target.");
        }
        else
        {
            Console.WriteLine($"Indices of the two numbers that add up to {target}: [{result[0]}, {result[1]}]");
        }

    }
}