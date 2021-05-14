using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PerimetrApp
{
    class Program
    {
        static void Main(string[] args)
        { //Hello
            bool cycle = true;

            while (cycle)
            {
                Console.Clear();
                Console.WriteLine("Choose:\n");
                Console.WriteLine("1.Start finding the perimeter of shape.");
                Console.WriteLine("2.Exit");

                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":

                        Console.WriteLine("\nEnter the number of sides for the shape:");
                        int num = NumbersOfSides();

                        Console.WriteLine("\nEnter side sizes:");
                        double[] myArray = EnterSideSizes(num);

                        double result = Perimetr(myArray);
                        Console.WriteLine($"\nPerimetr = {result}\n");
                        Console.WriteLine("\n\t\t Press any key to continue...");
                        Console.ReadLine();

                        break;

                    case "2":

                        cycle = false;
                        Console.Clear();
                        Console.WriteLine("GoodBye!");
                        Console.ReadLine();

                        break;

                    default:
                        Console.WriteLine("\nUnknown operation!\n");
                        break;
                }
            }
        }

        private static int NumbersOfSides()
        {
            bool convertToInt;
            int result;

            do
            {
                string numbersOfSidesString = Console.ReadLine();

                convertToInt = int.TryParse(numbersOfSidesString, out result);

                if (convertToInt && result  >= 3)
                {
                    break;
                }
                else
                {
                    convertToInt = false;
                    Console.WriteLine("\nUnknown number. Number of sides must be more then 2. ");
                }

            } while (!convertToInt);

            return result;
        }

        private static double[] EnterSideSizes(int num)
        {
            double[] array = new double[num];

            for (int i = 0; i < num; i++)
            {
                bool convertResult;
                double sideSizeDouble;

                do
                {
                    Console.WriteLine($"\nNumber of sides {num}.");
                    Console.WriteLine($"Enter {i + 1} side: ");

                    string sideSize = Console.ReadLine();
                    convertResult = double.TryParse(sideSize, out sideSizeDouble);

                    if (convertResult && sideSizeDouble > 0)
                    {
                        break;
                    }
                    else
                    {
                        convertResult = false;
                        Console.WriteLine("\nUnknown number. Repeat:");
                    }

                } while (!convertResult);

                array[i] = sideSizeDouble;
            }

            return array;
        }

        private static double Perimetr(double[] myArray )
        {
            double perimetr = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                perimetr = myArray[i] + perimetr;
            }

            return perimetr ;
        }
    }
}
