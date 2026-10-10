namespace CSharpExercises.Exercises
{
    internal static class RangeSumExercise
    {
        public static void Run()
        {
            RangeSum();
        }

        public static void RangeSum()
        {
            int sum = 0;
            int start = ConsoleInput.GetInput("start");
            int end = ConsoleInput.GetInput("end");
            while (true) {
                if (end < start)
                {
                    Console.WriteLine("Invalid input. Start number should not be greater than end number. Try again");
                    end = ConsoleInput.GetInput("end");
                }
                else
                {
                    break;
                }
            }
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum is : {sum}");
        }
    }
}
