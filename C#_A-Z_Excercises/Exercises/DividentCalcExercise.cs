namespace C__A_Z_Excercises.Exercises
{
    internal static class DividentCalcExercise
    {
        public static void Run()
        {
            int num1 = ConsoleInput.GetInput("first");
            int num2 = ConsoleInput.GetInput("second");
            DividentCalc(num1, num2);
        }

        public static void DividentCalc(int num1, int num2)
        {
            if (num2 == 0 | num1 == 0){
                Console.WriteLine("No zeros accepted.");
                return;
            }
            int div = num1 % num2;
            if (div == 0)
            {
                Console.WriteLine(num2);
            }
            else
            {
                DividentCalc(num2,div);
            }
        }
    }
}
