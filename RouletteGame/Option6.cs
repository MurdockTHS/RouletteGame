using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame
{
    public class Option6
    {
        public void Columns()
        {
            Console.WriteLine("Choose one of the 3 options");
            Console.WriteLine("Column 1: 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34");
            Console.WriteLine("Column 2: 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35");
            Console.WriteLine("Column 3: 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36");
            Console.WriteLine("1. Column 1   2. Column 2   3. Column 3");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You chose Column 1");
                    string[] numbers = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin = new Random();
                    int index = spin.Next(numbers.Length);
                    Console.WriteLine($"Your number is: {numbers[index]}");
                    if (numbers[index] == "1" || numbers[index] == "4" || numbers[index] == "7" || numbers[index] == "10" ||
                        numbers[index] == "13" || numbers[index] == "16" || numbers[index] == "19" || numbers[index] == "22" ||
                        numbers[index] == "25" || numbers[index] == "28" || numbers[index] == "31" || numbers[index] == "34")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "2":
                    Console.WriteLine("You chose Column 2 ");
                    string[] numbers2 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin2 = new Random();
                    int index2 = spin2.Next(numbers2.Length);
                    Console.WriteLine($"Your number is: {numbers2[index2]}");
                    if (numbers2[index2] == "2" || numbers2[index2] == "5" || numbers2[index2] == "8" || numbers2[index2] == "11" ||
                        numbers2[index2] == "14" || numbers2[index2] == "17" || numbers2[index2] == "20" || numbers2[index2] == "23" ||
                        numbers2[index2] == "26" || numbers2[index2] == "29" || numbers2[index2] == "32" || numbers2[index2] == "35")
                    {
                        Console.WriteLine("You hit ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "3":
                    Console.WriteLine("You chose Column 3 ");
                    string[] numbers3 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin3 = new Random();
                    int index3 = spin3.Next(numbers3.Length);
                    Console.WriteLine($"Your number is: {numbers3[index3]}");
                    if (numbers3[index3] == "3" || numbers3[index3] == "6" || numbers3[index3] == "9" || numbers3[index3] == "12" ||
                        numbers3[index3] == "15" || numbers3[index3] == "18" || numbers3[index3] == "21" || numbers3[index3] == "24" ||
                        numbers3[index3] == "27" || numbers3[index3] == "30" || numbers3[index3] == "33" || numbers3[index3] == "36")
                    {
                        Console.WriteLine("You hit");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                default:
                    Console.WriteLine("Not the correct option");
                    break;
            }
        }
    }
}
