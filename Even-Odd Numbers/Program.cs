namespace Even_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the counter (we will iterate from 0 to n)
            int count = 0;

            // Counters: how many even/odd numbers we found
            int totalEven = 0;
            int totalOdd = 0;

            // Sums of even/odd numbers (long is safer for larger sums)
            long sumEven = 0;
            long sumOdd = 0;

            Console.WriteLine("Sort the chosen number into odd/even:\n");

            // Read the limit number (n) from the user safely
            // TryParse prevents exceptions if the input is not a valid integer
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                // If input is invalid or negative, show an error and stop the program
                Console.WriteLine("Error: please enter a non-negative integer.");
                return;
            }

            Console.WriteLine("_____________________________________");

            // Loop through all numbers from 0 to n (inclusive)
            while (count <= n)
            {
                // Check if the number is even:
                // count % 2 is the remainder after dividing by 2
                if (count % 2 == 0)
                {
                    // Even number found -> increment even counter
                    totalEven++;

                    // Add the even number to the even sum
                    sumEven += count;

                    // Print the even number
                    Console.WriteLine($"Even number:______{count}");
                }
                else
                {
                    // Odd number found -> increment odd counter
                    totalOdd++;

                    // Add the odd number to the odd sum
                    sumOdd += count;

                    // Print the odd number
                    Console.WriteLine($"Odd number:__________{count}");
                }

                // Move to the next number
                count++;
            }

            Console.WriteLine("_____________________________________");

            // Print totals and sums for even numbers
            Console.WriteLine($"Total/even numbers:      {totalEven}");
            Console.WriteLine($"Sum/even numbers =       {sumEven}");

            Console.WriteLine("--------------------------------------");

            // Print totals and sums for odd numbers
            Console.WriteLine($"Total/odd numbers:       {totalOdd}");
            Console.WriteLine($"Sum/odd numbers =        {sumOdd}");

            // Wait for Enter so the console does not close immediately
            Console.ReadLine();

        }
    }
}
