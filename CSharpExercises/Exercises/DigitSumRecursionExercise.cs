namespace CSharpExercises.Exercises
{
    internal static class DigitSumRecursionExercise
    {
        public static void Run()
        {
            DigitSumRecursion(ConsoleInput.GetPositiveInput());
        }

        public static int DigitSumRecursion(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum > 9)
            {
                sum = DigitSumRecursion(sum);
            }
            else
            {
                Console.WriteLine($"The sum is : {sum}");
            }
            return sum;
        }
    }
}
