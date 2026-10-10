namespace CSharpExercises.Exercises
{
    internal static class BestAttemptExercise
    {
        public static void Run()
        {
            int studentCount = ConsoleInput.ReadInt("Students: ", 1);
            Attempt[][] students = new Attempt[studentCount][];

            for (int i = 0; i < studentCount; i++)
            {
                string prompt = $"Student {i + 1} attempts as score day pairs (e.g. 70 1 90 2): ";
                int[] numbers = ConsoleInput.ReadNumbers(prompt);

                while (numbers.Length == 0 || numbers.Length % 2 != 0)
                {
                    Console.WriteLine("Enter at least one attempt, each as a score followed by a day.");
                    numbers = ConsoleInput.ReadNumbers(prompt);
                }

                students[i] = new Attempt[numbers.Length / 2];

                for (int j = 0; j < students[i].Length; j++)
                {
                    students[i][j] = new Attempt { Score = numbers[j * 2], Day = numbers[j * 2 + 1] };
                }
            }

            Attempt[] best = BestAttempt(students);

            for (int i = 0; i < best.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: ({best[i].Score}, day {best[i].Day})");
            }
        }

        public static Attempt[] BestAttempt(Attempt[][] students)
        {
            Attempt[] result = new Attempt[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                Attempt best = students[i][0];

                for (int j = 1; j < students[i].Length; j++)
                {
                    Attempt current = students[i][j];

                    if (current.Score > best.Score || (current.Score == best.Score && current.Day < best.Day))
                    {
                        best = current;
                    }
                }

                result[i] = best;
            }

            return result;
        }
    }
}
