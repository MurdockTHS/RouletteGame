using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame
{
    public class Option9
    {
        public void Corners()
        {
            Console.WriteLine("Choose one of the 22 options");
            Console.WriteLine("1. 1/2/4/5  2. 2/3/5/6  3.  4/5/7/8  4. 7/8/10/11");
            Console.WriteLine("5. 10/11/13/14  6.  13/14/16/17  7.  16/17/19/20");
            Console.WriteLine("8. 19/20/22/23  9.  22/23/25/26  10.  25/26/28/29");
            Console.WriteLine("11. 28/29/31/32  12.  31/32/34/35  13. 5/6/8/9");

            Console.WriteLine("14. 8/9/11/12  15.  11/12/14/15  16.  14/15/17/18");
            Console.WriteLine("17. 17/18/20/21  18.  20/21/23/24  19.  23/24/26/27");
            Console.WriteLine("20. 26/27/29/30  21.  29/30/32/33  22.  32/33/35/36");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You chose corner 1");
                    string[] numbers = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin = new Random();
                    int index = spin.Next(numbers.Length);
                    Console.WriteLine($"Your number is: {numbers[index]}");
                    if (numbers[index] == "1" || numbers[index] == "2" || numbers[index] == "4"|| numbers[index] == "5")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "2":
                    Console.WriteLine("You chose corner 2 ");
                    string[] numbers2 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin2 = new Random();
                    int index2 = spin2.Next(numbers2.Length);
                    Console.WriteLine($"Your number is: {numbers2[index2]}");
                    if (numbers2[index2] == "2" || numbers2[index2] == "3" || numbers2[index2] == "5"|| numbers2[index2] == "6")
                    {
                        Console.WriteLine("You hit ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "3":
                    Console.WriteLine("You chose corner 3 ");
                    string[] numbers3 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin3 = new Random();
                    int index3 = spin3.Next(numbers3.Length);
                    Console.WriteLine($"Your number is: {numbers3[index3]}");
                    if (numbers3[index3] == "4" || numbers3[index3] == "5" || numbers3[index3] == "7"|| numbers3[index3] == "8")
                    {
                        Console.WriteLine("You hit");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "4":
                    Console.WriteLine("You chose corner 4");
                    string[] numbers4 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin4 = new Random();
                    int index4 = spin4.Next(numbers4.Length);
                    Console.WriteLine($"Your number is: {numbers4[index4]}");
                    if (numbers4[index4] == "7" || numbers4[index4] == "8" || numbers4[index4] == "10"|| numbers4[index4] == "11")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "5":
                    Console.WriteLine("You chose corner 5 ");
                    string[] numbers5 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin5 = new Random();
                    int index5 = spin5.Next(numbers5.Length);
                    Console.WriteLine($"Your number is: {numbers5[index5]}");
                    if (numbers5[index5] == "13" || numbers5[index5] == "14" || numbers5[index5] == "10"|| numbers5[index5] == "11")
                    {
                        Console.WriteLine("You hit ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "6":
                    Console.WriteLine("You chose corner 6 ");
                    string[] numbers6 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin6 = new Random();
                    int index6 = spin6.Next(numbers6.Length);
                    Console.WriteLine($"Your number is: {numbers6[index6]}");
                    if (numbers6[index6] == "16" || numbers6[index6] == "17" || numbers6[index6] == "13"|| numbers6[index6] == "14")
                    {
                        Console.WriteLine("You hit");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "7":
                    Console.WriteLine("You chose corner 7");
                    string[] numbers7 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin7 = new Random();
                    int index7 = spin7.Next(numbers7.Length);
                    Console.WriteLine($"Your number is: {numbers7[index7]}");
                    if (numbers7[index7] == "19" || numbers7[index7] == "20" || numbers7[index7] == "16"|| numbers7[index7] == "17")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "8":
                    Console.WriteLine("You chose corner 8 ");
                    string[] numbers8 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin8 = new Random();
                    int index8 = spin8.Next(numbers8.Length);
                    Console.WriteLine($"Your number is: {numbers8[index8]}");
                    if (numbers8[index8] == "22" || numbers8[index8] == "23" || numbers8[index8] == "19" || numbers8[index8] == "20")
                    {
                        Console.WriteLine("You hit ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "9":
                    Console.WriteLine("You chose corner 9 ");
                    string[] numbers9 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin9 = new Random();
                    int index9 = spin9.Next(numbers9.Length);
                    Console.WriteLine($"Your number is: {numbers9[index9]}");
                    if (numbers9[index9] == "23" || numbers9[index9] == "22" || numbers9[index9] == "25"|| numbers9[index9] == "26")
                    {
                        Console.WriteLine("You hit");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "10":
                    Console.WriteLine("You chose corner 10");
                    string[] numbers10 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin10 = new Random();
                    int index10 = spin10.Next(numbers10.Length);
                    Console.WriteLine($"Your number is: {numbers10[index10]}");
                    if (numbers10[index10] == "25" || numbers10[index10] == "26" || numbers10[index10] == "28"|| numbers10[index10] == "29")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "11":
                    Console.WriteLine("You chose corner 11 ");
                    string[] numbers11 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin11 = new Random();
                    int index11 = spin11.Next(numbers11.Length);
                    Console.WriteLine($"Your number is: {numbers11[index11]}");
                    if (numbers11[index11] == "28" || numbers11[index11] == "29" || numbers11[index11] == "31"|| numbers11[index11] == "32")
                    {
                        Console.WriteLine("You hit ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "12":
                    Console.WriteLine("You chose corner 12 ");
                    string[] numbers12 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin12 = new Random();
                    int index12 = spin12.Next(numbers12.Length);
                    Console.WriteLine($"Your number is: {numbers12[index12]}");
                    if (numbers12[index12] == "31" || numbers12[index12] == "32" || numbers12[index12] == "34"|| numbers12[index12] == "35")
                    {
                        Console.WriteLine("You hit");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;

                case "13":
                    Console.WriteLine("You chose corner 13");
                    string[] numbers13 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin13 = new Random();
                    int index13 = spin13.Next(numbers13.Length);
                    Console.WriteLine($"Your number is: {numbers13[index13]}");
                    if (numbers13[index13] == "5" || numbers13[index13] == "6" || numbers13[index13] == "8" || numbers13[index13] == "9")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "14":
                    Console.WriteLine("You chose corner 14 ");
                    string[] numbers14 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin14 = new Random();
                    int index14 = spin14.Next(numbers14.Length);
                    Console.WriteLine($"Your number is: {numbers14[index14]}");
                    if (numbers14[index14] == "8" || numbers14[index14] == "9" || numbers14[index14] == "11" || numbers14[index14] == "12")
                    {
                        Console.WriteLine("You hit ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "15":
                    Console.WriteLine("You chose corner 15 ");
                    string[] numbers15 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin15 = new Random();
                    int index15 = spin15.Next(numbers15.Length);
                    Console.WriteLine($"Your number is: {numbers15[index15]}");
                    if (numbers15[index15] == "11" || numbers15[index15] == "12" || numbers15[index15] == "14" || numbers15[index15] == "15")
                    {
                        Console.WriteLine("You hit");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "16":
                    Console.WriteLine("You chose corner 16");
                    string[] numbers16 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin16 = new Random();
                    int index16 = spin16.Next(numbers16.Length);
                    Console.WriteLine($"Your number is: {numbers16[index16]}");
                    if (numbers16[index16] == "14" || numbers16[index16] == "15" || numbers16[index16] == "17" || numbers16[index16] == "18")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "17":
                    Console.WriteLine("You chose corner 17 ");
                    string[] numbers17 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin17 = new Random();
                    int index17 = spin17.Next(numbers17.Length);
                    Console.WriteLine($"Your number is: {numbers17[index17]}");
                    if (numbers17[index17] == "17" || numbers17[index17] == "18" || numbers17[index17] == "20" || numbers17[index17] == "21")
                    {
                        Console.WriteLine("You hit ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "18":
                    Console.WriteLine("You chose corner 18 ");
                    string[] numbers18 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin18 = new Random();
                    int index18 = spin18.Next(numbers18.Length);
                    Console.WriteLine($"Your number is: {numbers18[index18]}");
                    if (numbers18[index18] == "20" || numbers18[index18] == "21" || numbers18[index18] == "23" || numbers18[index18] == "24")
                    {
                        Console.WriteLine("You hit");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "19":
                    Console.WriteLine("You chose corner 19");
                    string[] numbers19 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin19 = new Random();
                    int index19 = spin19.Next(numbers19.Length);
                    Console.WriteLine($"Your number is: {numbers19[index19]}");
                    if (numbers19[index19] == "23" || numbers19[index19] == "24" || numbers19[index19] == "26" || numbers19[index19] == "27")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                case "20":
                    Console.WriteLine("You chose corner 20 ");
                    string[] numbers20 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin20 = new Random();
                    int index20 = spin20.Next(numbers20.Length);
                    Console.WriteLine($"Your number is: {numbers20[index20]}");
                    if (numbers20[index20] == "26" || numbers20[index20] == "27" || numbers20[index20] == "29" || numbers20[index20] == "30")
                    {
                        Console.WriteLine("You hit ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "21":
                    Console.WriteLine("You chose corner 21 ");
                    string[] numbers21 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin21 = new Random();
                    int index21 = spin21.Next(numbers21.Length);
                    Console.WriteLine($"Your number is: {numbers21[index21]}");
                    if (numbers21[index21] == "29" || numbers21[index21] == "30" || numbers21[index21] == "32" || numbers21[index21] == "33")
                    {
                        Console.WriteLine("You hit");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you did not win this one");
                    }
                    break;
                case "22":
                    Console.WriteLine("You chose corner 22");
                    string[] numbers22 = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
                    Random spin22 = new Random();
                    int index22 = spin22.Next(numbers22.Length);
                    Console.WriteLine($"Your number is: {numbers22[index22]}");
                    if (numbers22[index22] == "33" || numbers22[index22] == "34" || numbers22[index22] == "35" || numbers22[index22] == "36")

                    {
                        Console.WriteLine("You hit!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry didnt hit");
                    }
                    break;

                default:
                    Console.WriteLine("Not the correct option");
                    break;
            }
        }
    }
}
