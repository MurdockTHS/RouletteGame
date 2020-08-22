using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame
{
    public class Option4
    {
        public void HighOrLow()
        {
            Console.WriteLine("Choose Low or High");
            Console.WriteLine("Low: 1 - 18        High: 19 - 36");
            Console.WriteLine("1.Low       2. High");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You chose low");
                    string[] numbers = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin = new Random();
                    int index = spin.Next(numbers.Length);
                    Console.WriteLine($"Your number is: {numbers[index]}");
                    if (numbers[index] == "1" || numbers[index] == "2" || numbers[index] == "3" || numbers[index] == "4" ||
                        numbers[index] == "5" || numbers[index] == "6" || numbers[index] == "7" || numbers[index] == "8" ||
                        numbers[index] == "9" || numbers[index] == "10" || numbers[index] == "11" || numbers[index] == "12" ||
                        numbers[index] == "13" || numbers[index] == "14" || numbers[index] == "15" || numbers[index] == "16" ||
                        numbers[index] == "17" || numbers[index] == "18")
                    {
                        Console.WriteLine("You hit low!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt get low");
                    }
                    break;

                case "2":
                    Console.WriteLine("You chose high");
                    string[] numbers2 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin2 = new Random();
                    int index2 = spin2.Next(numbers2.Length);
                    Console.WriteLine($"Your number is: {numbers2[index2]}");
                    if (numbers2[index2] == "19" || numbers2[index2] == "20" || numbers2[index2] == "21" || numbers2[index2] == "22" ||
                        numbers2[index2] == "23" || numbers2[index2] == "24" || numbers2[index2] == "25" || numbers2[index2] == "26" ||
                        numbers2[index2] == "27" || numbers2[index2] == "28" || numbers2[index2] == "29" || numbers2[index2] == "30" ||
                        numbers2[index2] == "31" || numbers2[index2] == "32" || numbers2[index2] == "33" || numbers2[index2] == "34" ||
                        numbers2[index2] == "35" || numbers2[index2] == "36")
                    {
                        Console.WriteLine("You hit high");
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
