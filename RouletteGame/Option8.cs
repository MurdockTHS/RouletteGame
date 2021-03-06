﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame
{
    public class Option8
    {
        public void DoubleRows()
        {
            Console.WriteLine("Choose the 11 options");
            Console.WriteLine("1. 1/2/3,4/5/6   2. 4/5/6,7/8/9  3. 7/8/9,10/11/12  4. 10/11/12,13/14/15");
            Console.WriteLine("5. 13/14/15,16/17/18   6. 16/17/18,19/20/21   7. 19/20/21,22/23/24   8. 22/23/24,25/26/27");
            Console.WriteLine("9. 25/26/27,28/29/30  10. 28/29/30,31/32/33  11. 31/32/33,34/35/36  ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You chose double rows 1");
                    string[] numbers = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin = new Random();
                    int index = spin.Next(numbers.Length);
                    Console.WriteLine($"Your number is: {numbers[index]}");
                    if (numbers[index] == "1" || numbers[index] == "2" || numbers[index] == "3"||
                        numbers[index] == "4" || numbers[index] == "5" || numbers[index] == "6")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "2":
                    Console.WriteLine("You chose double row 2 ");
                    string[] numbers2 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin2 = new Random();
                    int index2 = spin2.Next(numbers2.Length);
                    Console.WriteLine($"Your number is: {numbers2[index2]}");
                    if (numbers2[index2] == "7" || numbers2[index2] == "8" || numbers2[index2] == "9" ||
                        numbers2[index2] == "4" || numbers2[index2] == "5" || numbers2[index2] == "6")
                    {
                        Console.WriteLine("You hit ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "3":
                    Console.WriteLine("You chose double row 3 ");
                    string[] numbers3 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin3 = new Random();
                    int index3 = spin3.Next(numbers3.Length);
                    Console.WriteLine($"Your number is: {numbers3[index3]}");
                    if (numbers3[index3] == "7" || numbers3[index3] == "8" || numbers3[index3] == "9"||
                        numbers3[index3] == "10" || numbers3[index3] == "11" || numbers3[index3] == "12")
                    {
                        Console.WriteLine("You hit");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "4":
                    Console.WriteLine("You chose double row 4");
                    string[] numbers4 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin4 = new Random();
                    int index4 = spin4.Next(numbers4.Length);
                    Console.WriteLine($"Your number is: {numbers4[index4]}");
                    if (numbers4[index4] == "10" || numbers4[index4] == "11" || numbers4[index4] == "12"||
                        numbers4[index4] == "13" || numbers4[index4] == "14" || numbers4[index4] == "15")
                        

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "5":
                    Console.WriteLine("You chose double row 5 ");
                    string[] numbers5 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin5 = new Random();
                    int index5 = spin5.Next(numbers5.Length);
                    Console.WriteLine($"Your number is: {numbers5[index5]}");
                    if (numbers5[index5] == "13" || numbers5[index5] == "14" || numbers5[index5] == "15"||
                        numbers5[index5] == "16" || numbers5[index5] == "17" || numbers5[index5] == "18")
                    {
                        Console.WriteLine("You hit ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "6":
                    Console.WriteLine("You chose double row 6 ");
                    string[] numbers6 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin6 = new Random();
                    int index6 = spin6.Next(numbers6.Length);
                    Console.WriteLine($"Your number is: {numbers6[index6]}");
                    if (numbers6[index6] == "16" || numbers6[index6] == "17" || numbers6[index6] == "18"||
                        numbers6[index6] == "19" || numbers6[index6] == "20" || numbers6[index6] == "21")
                    {
                        Console.WriteLine("You hit");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "7":
                    Console.WriteLine("You chose double row 7");
                    string[] numbers7 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin7 = new Random();
                    int index7 = spin7.Next(numbers7.Length);
                    Console.WriteLine($"Your number is: {numbers7[index7]}");
                    if (numbers7[index7] == "19" || numbers7[index7] == "20" || numbers7[index7] == "21"||
                        numbers7[index7] == "21" || numbers7[index7] == "22" || numbers7[index7] == "23")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "8":
                    Console.WriteLine("You chose double row 8 ");
                    string[] numbers8 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin8 = new Random();
                    int index8 = spin8.Next(numbers8.Length);
                    Console.WriteLine($"Your number is: {numbers8[index8]}");
                    if (numbers8[index8] == "22" || numbers8[index8] == "23" || numbers8[index8] == "24"||
                        numbers8[index8] == "25" || numbers8[index8] == "26" || numbers8[index8] == "27")
                    {
                        Console.WriteLine("You hit ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "9":
                    Console.WriteLine("You chose double row 9 ");
                    string[] numbers9 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin9 = new Random();
                    int index9 = spin9.Next(numbers9.Length);
                    Console.WriteLine($"Your number is: {numbers9[index9]}");
                    if (numbers9[index9] == "25" || numbers9[index9] == "26" || numbers9[index9] == "27"||
                        numbers9[index9] == "28" || numbers9[index9] == "29" || numbers9[index9] == "30")
                    {
                        Console.WriteLine("You hit");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "10":
                    Console.WriteLine("You chose double row 10");
                    string[] numbers10 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin10 = new Random();
                    int index10 = spin10.Next(numbers10.Length);
                    Console.WriteLine($"Your number is: {numbers10[index10]}");
                    if (numbers10[index10] == "28" || numbers10[index10] == "29" || numbers10[index10] == "30"||
                        numbers10[index10] == "31" || numbers10[index10] == "32" || numbers10[index10] == "33")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "11":
                    Console.WriteLine("You chose double row 11 ");
                    string[] numbers11 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin11 = new Random();
                    int index11 = spin11.Next(numbers11.Length);
                    Console.WriteLine($"Your number is: {numbers11[index11]}");
                    if (numbers11[index11] == "31" || numbers11[index11] == "32" || numbers11[index11] == "33"||
                        numbers11[index11] == "34" || numbers11[index11] == "35" || numbers11[index11] == "36")
                    {
                        Console.WriteLine("You hit ");
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
