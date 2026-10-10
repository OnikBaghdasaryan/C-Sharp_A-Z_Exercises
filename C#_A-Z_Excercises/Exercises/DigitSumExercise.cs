namespace C__A_Z_Excercises.Exercises
{
    internal static class DigitSumExercise
    {
        public static void Run()
        {
            DigitSum();
        }

        public static void DigitSum()
        {
            int num = ConsoleInput.GetPositiveInput();
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"The sum is : {sum}");
        }
    }
}
