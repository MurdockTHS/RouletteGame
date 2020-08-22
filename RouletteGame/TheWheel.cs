using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace RouletteGame
{
    public class TheWheel
    {
        string[] colors = { "Red", "Black", "Green" };
        string[] redNumbers = { "1", "3", "5", "7", "9", "12", "14", "16", "18", "19", "21", "23", "25", "27", "30", "32", "34", "36" };
        string[] blackNumbers = { "2", "4", "6", "8", "10", "11", "13", "15", "17", "20", "22", "24", "26", "28", "29", "31", "33", "35" };
        string[] greenNumbers = { "0", "00" };
        //string[] number = { "1", "2","3","4","5","6","7","8","9","10",
        //                    "11","12","13","14","15","16","17","18","19",
        //                    "20","21","22","23","24","25","26","27","28",
        //                    "29","30","31","32","33","34","35","36","0","00" };
        public void WheelSpin()
        {
            string color, number;
            Random spin = new Random();
            int colorIndex = spin.Next(colors.Length);
            color = colors[colorIndex];

            if (color == "Red")
            {
                int redNumberIndex = spin.Next(redNumbers.Length);
                number = redNumbers[redNumberIndex];
            }
            else if (color == "Black")
            {
                int blackNumberIndex = spin.Next(blackNumbers.Length);
                number = blackNumbers[blackNumberIndex];
            }
            else
            {
                int greenNumbersIndex = spin.Next(greenNumbers.Length);
                number = greenNumbers[greenNumbersIndex];
            }

            Console.WriteLine($"You got {color} {number}");
        }
    }
}