using CSharpExercises.Exercises;

namespace CSharpExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\n=== Exercises ===");
                Console.WriteLine("1. Range sum");
                Console.WriteLine("2. Digit sum");
                Console.WriteLine("3. Digit sum (recursion)");
                Console.WriteLine("4. Greatest common divisor (DividentCalc)");
                Console.WriteLine("5. Pi estimation (Monte Carlo)");
                Console.WriteLine("6. Values above a limit (Above)");
                Console.WriteLine("7. Best attempt (BestAttempt)");
                Console.WriteLine("8. Cold working sensors (ColderThan)");
                Console.WriteLine("q. Quit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine()?.Trim().ToLower() ?? "q";
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        RangeSumExercise.Run();
                        break;

                    case "2":
                        DigitSumExercise.Run();
                        break;

                    case "3":
                        DigitSumRecursionExercise.Run();
                        break;

                    case "4":
                        DividentCalcExercise.Run();
                        break;

                    case "5":
                        PiEstimationExercise.Run();
                        break;

                    case "6":
                        AboveExercise.Run();
                        break;

                    case "7":
                        BestAttemptExercise.Run();
                        break;

                    case "8":
                        ColderThanExercise.Run();
                        break;

                    case "q":
                        Console.WriteLine("Exiting program. Goodbye!");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
