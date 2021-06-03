using System;

namespace CasinoDiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {

            string userAnswer = "y";
            int i = 1;
            
            Console.WriteLine("Welcome to the Grand Circus Casino!");

            Console.WriteLine("How many sides should each die have?");
            int sides = int.Parse(Console.ReadLine());
            while (userAnswer == "y")
            {
                Console.WriteLine("Roll:{0}", i);
                int dice1 = getRandomNumber(sides);

                int dice2 = getRandomNumber(sides);


                Console.WriteLine("You rolled a {0} and a {1} ({2} Total)", dice1, dice2, dice1 + dice2);
                PrintOutcomes(dice1, dice2);

                Console.WriteLine("Roll again (y/n)?");
                userAnswer = Console.ReadLine();
                if (userAnswer == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                }
                i = i + 1;
                

            }
        }

        public static int getRandomNumber(int sides)
        {
            Random random = new Random();
            return random.Next(1, sides);

        }
        public static void PrintOutcomes(int dice1, int dice2)
        {
            if (dice1 == 1 && dice2 == 1)
            {
                Console.WriteLine("Snake eyes");
            }
            if (dice1 == 1 && dice2 == 2)
            {
                Console.WriteLine("Ace Deuce");
            }
            if (dice1 == 6 && dice2 == 6)
            {
                Console.WriteLine("Box Cars");
            }
            if ((dice1 + dice2 == 7) || (dice1 + dice2 == 11))
            {
                Console.WriteLine("Win!");
            }
            if ((dice1 + dice2 == 2)||(dice1 + dice2 == 3)|| (dice1 + dice2 == 12))
            {
                Console.WriteLine("Craps!");
            }
        }
    }
}
