namespace CSharpExercises.Exercises
{
    internal static class ColderThanExercise
    {
        public static void Run()
        {
            int rows = ConsoleInput.ReadInt("Rows: ", 1);
            int cols = ConsoleInput.ReadInt("Columns: ", 1);
            Reading[,] grid = new Reading[rows, cols];

            Console.WriteLine("Enter each row as temperatures separated by spaces. Add f for a fault, e.g. 3 9 1f");

            for (int i = 0; i < rows; i++)
            {
                string prompt = $"Row {i} ({cols} sensors): ";
                Reading[]? row = ParseRow(ConsoleInput.ReadWords(prompt), cols);

                while (row == null)
                {
                    Console.WriteLine($"Row must have exactly {cols} sensors, each a whole number with an optional f.");
                    row = ParseRow(ConsoleInput.ReadWords(prompt), cols);
                }

                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = row[j];
                }
            }

            int limit = ConsoleInput.ReadInt("Limit: ", int.MinValue);
            Hit[] hits = ColderThan(grid, limit);

            if (hits.Length == 0)
            {
                Console.WriteLine("Result: empty array");
                return;
            }

            foreach (Hit hit in hits)
            {
                Console.WriteLine($"({hit.Temperature}, row {hit.Row}, col {hit.Col})");
            }
        }

        public static Hit[] ColderThan(Reading[,] grid, int limit)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!grid[i, j].Fault && grid[i, j].Temperature < limit)
                    {
                        count++;
                    }
                }
            }

            Hit[] result = new Hit[count];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Reading reading = grid[i, j];

                    if (!reading.Fault && reading.Temperature < limit)
                    {
                        result[index++] = new Hit { Temperature = reading.Temperature, Row = i, Col = j };
                    }
                }
            }

            return result;
        }

        private static Reading[]? ParseRow(string[] words, int cols)
        {
            if (words.Length != cols)
            {
                return null;
            }

            Reading[] row = new Reading[cols];

            for (int j = 0; j < cols; j++)
            {
                string word = words[j];
                bool fault = word.EndsWith("f", StringComparison.OrdinalIgnoreCase);

                if (fault)
                {
                    word = word[..^1];
                }

                if (!int.TryParse(word, out int temperature))
                {
                    return null;
                }

                row[j] = new Reading { Temperature = temperature, Fault = fault };
            }

            return row;
        }
    }
}
