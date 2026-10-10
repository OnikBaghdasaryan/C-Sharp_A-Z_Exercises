namespace C__A_Z_Excercises
{
    internal static class ConsoleInput
    {
        public static int GetInput(string num_name)
        {
            int validNumber;

            while (true)
            {
                Console.Write($"Please enter {num_name} number: ");
                string input = Console.ReadLine() ?? "";

                if (int.TryParse(input, out validNumber))
                {
                    break;
                }

                Console.WriteLine("Invalid input. That is not a whole number. Try again.");
            }

            return validNumber;
        }

        public static int GetPositiveInput()
        {
            int validNumber;

            while (true)
            {
                Console.Write("Please enter number: ");
                string input = Console.ReadLine() ?? "";

                if (int.TryParse(input, out validNumber) & validNumber >= 0)
                {
                    break;
                }

                Console.WriteLine("Invalid input. That is not a whole positive/zero number. Try again.");
            }

            return validNumber;
        }

        public static int ReadInt(string prompt, int min)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? "";

                if (int.TryParse(input, out int value) && value >= min)
                {
                    return value;
                }

                Console.WriteLine($"Invalid input. Enter a whole number of at least {min}.");
            }
        }

        public static int[] ReadNumbers(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string[] parts = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                int[] numbers = new int[parts.Length];
                bool valid = true;

                for (int i = 0; i < parts.Length && valid; i++)
                {
                    valid = int.TryParse(parts[i], out numbers[i]);
                }

                if (valid)
                {
                    return numbers;
                }

                Console.WriteLine("Invalid input. Use whole numbers separated by spaces.");
            }
        }
    }
}
