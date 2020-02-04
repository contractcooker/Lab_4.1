using System;

namespace Lab_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sides, die1, die2, counter = 1;
            bool flag = true;
            Console.Write("How many sides should each die have? <<");
            sides = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"Roll {counter}:");
                counter++;

                die1 = RollDice(sides);
                die2 = RollDice(sides);

                OutputDiceCombos(die1, die2, sides);
                flag = GoAgain();

            } while (flag);
        }

        private static bool GoAgain()
        {
            char input;
            
            do
            {
                /**/
                Console.Write("Roll again? (y/n): ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if ("YyNn".Contains(input))
                {
                    break;
                }
                Console.WriteLine("Invalid Input!");
                
            } while (!"YyNn".Contains(input));
            if ("Nn".Contains(input))
            {
                return false;
            }

            return true;

        }

        private static void OutputDiceCombos(int die1, int die2, int sides)
        {

            Console.WriteLine($"you rolled a {die1} and a {die2} ({die1 +die2} total)");
            if (sides == 6)
            {
                if (die1 + die2 == 2 || die1 + die2 == 3 || die1 + die2 == 12)
                {
                    Console.WriteLine("Craps!");
                    if (die1 + die2 == 12)
                    {
                        Console.WriteLine("Box Cars");
                    }
                }
                if (die1 + die2 == 7 || die1 + die2 == 11)
                {
                    Console.WriteLine("Winner!");
                }
                if (die1 + die2 == 2)
                {
                    Console.WriteLine("Snake Eyes");
                }
                if (die1 + die2 == 3)
                {
                    Console.WriteLine("Ace Deuce");
                }

            }
        }

        private static int RollDice(int sides)
        {
            Random random = new Random();
            return random.Next(1, sides+1);
        }
    }
}
