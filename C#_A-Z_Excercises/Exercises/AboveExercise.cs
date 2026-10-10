namespace C__A_Z_Excercises.Exercises
{
    internal static class AboveExercise
    {
        public static void Run()
        {
            int rows = ConsoleInput.ReadInt("Rows: ", 1);
            int cols = ConsoleInput.ReadInt("Columns: ", 1);
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string prompt = $"Row {i + 1} ({cols} numbers separated by spaces): ";
                int[] row = ConsoleInput.ReadNumbers(prompt);

                while (row.Length != cols)
                {
                    Console.WriteLine($"Row must have exactly {cols} numbers.");
                    row = ConsoleInput.ReadNumbers(prompt);
                }

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int limit = ConsoleInput.ReadInt("Limit: ", int.MinValue);
            int[] result = Above(matrix, limit);

            Console.WriteLine(result.Length == 0 ? "Result: empty array" : $"Result: {string.Join(", ", result)}");
        }

        public static int[] Above(int[,] matrix, int limit)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > limit)
                    {
                        count++;
                    }
                }
            }

            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > limit)
                    {
                        result[index++] = matrix[i, j];
                    }
                }
            }

            return result;
        }
    }
}
