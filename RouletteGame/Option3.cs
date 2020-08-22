using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame
{
    public class Option3
    {
        public void RedOrBlack()
        {
            Console.WriteLine("Choose red or black");
            Console.WriteLine("Red: 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 ");
            Console.WriteLine("Black: 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35");
            Console.WriteLine(" 1. red     2. black");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You chose red");
                    string[] numbers = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin = new Random();
                    int index = spin.Next(numbers.Length);
                    Console.WriteLine($"Your number is: {numbers[index]}");
                    if (numbers[index] == "1" || numbers[index] == "3" || numbers[index] == "5" || numbers[index] == "7" ||
                        numbers[index] == "9" || numbers[index] == "12" || numbers[index] == "14" || numbers[index] == "16" ||
                        numbers[index] == "18" || numbers[index] == "19" || numbers[index] == "21" || numbers[index] == "23" ||
                        numbers[index] == "25" || numbers[index] == "27" || numbers[index] == "30" || numbers[index] == "32" ||
                        numbers[index] == "34" || numbers[index] == "36")
                    {
                        Console.WriteLine("You hit red!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt get red");
                    }
                    break;

                case "2":
                    Console.WriteLine("You chose black");
                    string[] numbers2 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin2 = new Random();
                    int index2 = spin2.Next(numbers2.Length);
                    Console.WriteLine($"Your number is: {numbers2[index2]}");
                    if (numbers2[index2] == "2" || numbers2[index2] == "4" || numbers2[index2] == "6" || numbers2[index2] == "8" ||
                        numbers2[index2] == "10" || numbers2[index2] == "11" || numbers2[index2] == "13" || numbers2[index2] == "15" ||
                        numbers2[index2] == "17" || numbers2[index2] == "20" || numbers2[index2] == "22" || numbers2[index2] == "24" ||
                        numbers2[index2] == "26" || numbers2[index2] == "28" || numbers2[index2] == "29" || numbers2[index2] == "31" ||
                        numbers2[index2] == "33" || numbers2[index2] == "35")
                    {
                        Console.WriteLine("You hit black");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
            }
        }
    }
}
