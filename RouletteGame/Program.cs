using System;

namespace RouletteGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempts = 0;
            while (attempts != 10)
            {
                Console.WriteLine("Roulette Game. You have a max attempt of 10");
                Console.WriteLine($"Attempts: {attempts}");
                Console.WriteLine("1. Numbers: the number of the bin");
                Console.WriteLine("2. Evens/Odds: even or odd numbers");
                Console.WriteLine("3. Reds/Blacks: red or black colored numbers");
                Console.WriteLine("4. Lows/Highs: low (1 – 18) or high (19 – 36) numbers.");
                Console.WriteLine("5. Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36");
                Console.WriteLine("6. Columns: first, second, or third columns");
                Console.WriteLine("7. Street: rows, e.g., 1/2/3 or 22/23/24");
                Console.WriteLine("8. Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26");
                //Console.WriteLine("9. Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36");
                Console.WriteLine("9. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27");

                Console.WriteLine("Enter the option");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("You chose option 1");
                        Option1 option1 = new Option1();
                        option1.NumberSelection();
                        attempts++;

                        break;

                    case "2":
                        Console.WriteLine("You chose option 2");
                        Option2 option2 = new Option2();
                        option2.EvenOrOdd();
                        attempts++;
                        break;
                    case "3":
                        Console.WriteLine("You chose option 3");
                        Option3 option3 = new Option3();
                        option3.RedOrBlack();
                        attempts++;
                        break;
                    case "4":
                        Console.WriteLine("You chose option 4");
                        Option4 option4 = new Option4();
                        option4.HighOrLow();
                        attempts++;
                        break;
                    case "5":
                        Console.WriteLine("You chose option 5");
                        Option5 option5 = new Option5();
                        option5.Dozens();
                        attempts++;
                        break;
                    case "6":
                        Console.WriteLine("You chose option 6");
                        Option6 option6 = new Option6();
                        option6.Columns();
                        attempts++;
                        break;
                    case "7":
                        Console.WriteLine("You chose option 7");
                        Option7 option7 = new Option7();
                        option7.Streets();
                        attempts++;
                        break;
                    case "8":

                        break;
                    default:
                        Console.WriteLine("Not the correct option");
                        break;
                }


            }
            Console.WriteLine("Thank you for playing");

        }
    }
}