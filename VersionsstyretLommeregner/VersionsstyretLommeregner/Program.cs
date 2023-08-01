using System;
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
            tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Indtast tal: ");
            tal2 = Convert.ToDouble(Console.ReadLine());
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
            }
            Console.Write(res);
            Console.ReadKey();
        }
    }
}
