using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame
{
    public class Option5
    {
        public void Dozens()
        {
            Console.WriteLine("Choose one of the 3 options");
            Console.WriteLine("1. 1 – 12    2. 13 – 24    3. 25 – 36");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You chose 1 - 12");
                    string[] numbers = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin = new Random();
                    int index = spin.Next(numbers.Length);
                    Console.WriteLine($"Your number is: {numbers[index]}");
                    if (numbers[index] == "1" || numbers[index] == "2" || numbers[index] == "3" || numbers[index] == "4" ||
                        numbers[index] == "5" || numbers[index] == "6" || numbers[index] == "7" || numbers[index] == "8" ||
                        numbers[index] == "9" || numbers[index] == "10" || numbers[index] == "11" || numbers[index] == "12")

                    {
                        Console.WriteLine("You hit 1 - 12!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt get 1 - 12");
                    }
                    break;

                case "2":
                    Console.WriteLine("You chose 13 - 24 ");
                    string[] numbers2 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin2 = new Random();
                    int index2 = spin2.Next(numbers2.Length);
                    Console.WriteLine($"Your number is: {numbers2[index2]}");
                    if (numbers2[index2] == "13" || numbers2[index2] == "14" || numbers2[index2] == "15" || numbers2[index2] == "16" ||
                        numbers2[index2] == "17" || numbers2[index2] == "18" || numbers2[index2] == "19" || numbers2[index2] == "20" ||
                        numbers2[index2] == "21" || numbers2[index2] == "22" || numbers2[index2] == "23" || numbers2[index2] == "24")
                    {
                        Console.WriteLine("You hit 13 - 24");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "3":
                    Console.WriteLine("You chose 25 - 36 ");
                    string[] numbers3 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin3 = new Random();
                    int index3 = spin3.Next(numbers3.Length);
                    Console.WriteLine($"Your number is: {numbers3[index3]}");
                    if (numbers3[index3] == "25" || numbers3[index3] == "26" || numbers3[index3] == "27" || numbers3[index3] == "28" ||
                        numbers3[index3] == "29" || numbers3[index3] == "30" || numbers3[index3] == "31" || numbers3[index3] == "32" ||
                        numbers3[index3] == "33" || numbers3[index3] == "34" || numbers3[index3] == "35" || numbers3[index3] == "36")
                    {
                        Console.WriteLine("You hit 25 - 36");
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
