using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RouletteGame
{
    public class Option2
    {
        public void EvenOrOdd()
        {
            
            Console.WriteLine("Choose even or odd");
            Console.WriteLine(" 1. even     2. odd");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You chose even");
                    string[] numbers = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin = new Random();
                    int index = spin.Next(numbers.Length);
                    Console.WriteLine($"Your number is: {numbers[index]}");
                    if (numbers[index] == "2" || numbers[index] == "4" || numbers[index] == "6" || numbers[index] == "8" ||
                        numbers[index] == "10" || numbers[index] == "12" || numbers[index] == "14" || numbers[index] == "16" ||
                        numbers[index] == "18" || numbers[index] == "20" || numbers[index] == "22" || numbers[index] == "24" ||
                        numbers[index] == "26" || numbers[index] == "28" || numbers[index] == "30" || numbers[index] == "32" ||
                        numbers[index] == "34" || numbers[index] == "36")
                    {
                        Console.WriteLine("You hit even");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;

                case "2":
                    Console.WriteLine("You chose odd");
                    string[] numbers2 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin2 = new Random();
                    int index2 = spin2.Next(numbers2.Length);
                    Console.WriteLine($"Your number is: {numbers2[index2]}");
                    if (numbers2[index2] == "1" || numbers2[index2] == "3"|| numbers2[index2] == "5" || numbers2[index2] == "7"||
                        numbers2[index2] == "9" || numbers2[index2] == "11" || numbers2[index2] == "13" || numbers2[index2] == "15" ||
                        numbers2[index2] == "17" || numbers2[index2] == "19" || numbers2[index2] == "21" || numbers2[index2] == "23" ||
                        numbers2[index2] == "25" || numbers2[index2] == "27" || numbers2[index2] == "29" || numbers2[index2] == "31" ||
                        numbers2[index2] == "33" || numbers2[index2] == "35")
                    {
                        Console.WriteLine("You hit odd");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                default:
                    Console.WriteLine("Please choose the right option");
                    break;


            }

        }
    }
}
