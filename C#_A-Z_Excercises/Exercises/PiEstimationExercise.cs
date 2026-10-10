namespace C__A_Z_Excercises.Exercises
{
    internal static class PiEstimationExercise
    {
        public static void Run()
        {
            int iterations = ConsoleInput.ReadInt("Iterations: ", 1);
            double pi = EstimatePi(iterations);
            Console.WriteLine($"Estimate: {pi}");
            Console.WriteLine($"Math.PI:  {Math.PI}");
            Console.WriteLine($"Error:    {Math.Abs(pi - Math.PI)}");
        }

        public static double EstimatePi(int iterations)
        {
            Random random = new Random();
            double M = 0;
            double N = 0;
            while (N < iterations) {
                double x = random.NextDouble();
                double y = random.NextDouble();
                if (x * x + y * y <= 1)
                {
                    M++;
                }
                N++;
            }
            return 4 * M / N;
        }
    }
}
