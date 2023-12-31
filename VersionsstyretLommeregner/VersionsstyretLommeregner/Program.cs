﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionsstyretLommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tal1 = 0;
            double tal2 = 0;
            double res = 0;
            string funktion = "";

            Console.Write("Indtast tal: ");
            string check1 = Console.ReadLine();
            while (double.TryParse(check1, out double n) == false)
            {
                Console.Write("Indtast tal: ");
                check1 = Console.ReadLine();
            }
            tal1 = Convert.ToDouble(check1);

            Console.Write("Indtast tal: ");
            string check2 = Console.ReadLine();

            while (double.TryParse(check2, out double n) == false)
            {
                Console.Write("Indtast tal: ");
                check2 = Console.ReadLine();
            }
            tal2 = Convert.ToDouble(check2);

            Console.Write("Vælg funktion: ");
            funktion = Console.ReadLine();

            switch (funktion)
            {
                case "+":
                    {
                        res = tal1 + tal2;
                        break;
                    }
                case "-":
                    {
                        res = tal1 - tal2;
                        break;
                    }
                case "*":
                    {
                        res = tal1 * tal2;
                        break;
                    }
                case "/":
                    {
                        res = tal1 / tal2;
                        break;
                    }
                case "%":
                    {
                        res = tal1 % tal2;
                        break;
                    }
                case "^":
                    {
                        res = Math.Pow(tal1, tal2);
                        break;
                    }
                case "Root":
                    {
                        res = Math.Sqrt(tal1 / tal2);
                        break;
                    }
                case "spil":
                    {
                        MathGame();
                        break;
                    }
            }
            Console.WriteLine(res);
            Console.ReadKey();

        }
        static void MathGame()
        {
            Random random = new Random();
            int num1 = random.Next(1, 11);
            int num2 = random.Next(1, 11);
            int res = num1 + num2;
            Console.Write($"{num1} + {num2} = ");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == res)
            {
                Console.WriteLine("Rigtigt!");
            }
            else
            {
                Console.WriteLine("Forkert!");
            }
        }
    }
}
