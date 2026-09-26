namespace C__A_Z_Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\n=== Run Menu ===");
                Console.WriteLine("1. Run function start end number array sum.");
                Console.WriteLine("2. Run function positive/zero number digits sum.");
                Console.WriteLine("q. Quit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine()?.Trim().ToLower();

                // 3. Handle the input
                switch (input)
                {
                    case "1":
                        Console.WriteLine("\nRunning Scenario 1...");
                        RangeSum();
                        break;

                    case "2":
                        Console.WriteLine("\nRunning Scenario 2...");
                        DigitSum();
                        break;

                    case "q":
                        Console.WriteLine("\nExiting program. Goodbye!");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("\nInvalid option. Please try again.");
                        break;
                }
            }
        }
        static int Get_Input(string num_name)
        {
            int validNumber;

            while (true)
            {
                Console.Write($"Please enter {num_name} number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out validNumber))
                {
                    break;
                }

                Console.WriteLine("Invalid input. That is not a whole number. Try again.");
            }

            return validNumber;
        }
        static int Get_Positive_Input()
        {
            int validNumber;

            while (true)
            {
                Console.Write("Please enter number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out validNumber) & validNumber >= 0)
                {
                    break;
                }

                Console.WriteLine("Invalid input. That is not a whole number. Try again.");
            }

            return validNumber;
        }
        static void RangeSum()
        {
            int sum = 0;
            int start = Get_Input("start");
            int end = Get_Input("end");
            while (true) {
                if (end < start)
                {
                    Console.WriteLine("Invalid input. Start number should not be greater than end number. Try again");
                    end = Get_Input("end");
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
        static void DigitSum()
        {
            int num = Get_Positive_Input();
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
