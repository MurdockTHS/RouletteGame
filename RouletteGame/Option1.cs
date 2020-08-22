﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RouletteGame
{
    public class Option1
    {
        public void NumberSelection()
        {
            string guess;
            Console.WriteLine("Please select a number from 0 - 36 and 00");
            guess = Console.ReadLine();
            string[] numbers = { "1", "2","3","4","5","6","7","8","9","10",
                                "11","12","13","14","15","16","17","18","19",
                                "20","21","22","23","24","25","26","27","28",
                                "29","30","31","32","33","34","35","36","0","00" };
            Random spin = new Random();
            int index = spin.Next(numbers.Length);
            Console.WriteLine($"Your number is: {numbers[index]}");
            if( guess == numbers[index])
            {
                Console.WriteLine("You got it!");
            }
            else
            {
                Console.WriteLine("Sorry you missed");
            }
        }

    }
}
