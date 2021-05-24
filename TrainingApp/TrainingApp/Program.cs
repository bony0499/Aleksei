using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mass rows:");
            int massLenth = MassLenth();

            Console.WriteLine("Enter mass Columns:");
            int massСolumns = MassColumns();

            Console.WriteLine("Enter mass:");
            int[,] myArray = ZapMass(massLenth, massСolumns);
            MassVivod(myArray);
            MassVObratnom(myArray);
            SumChetnix(myArray);
            MinChislo(myArray);
            MaxChislo(myArray);

            Console.ReadLine();
        }
        public static int MassLenth()
        {
            bool convert;
            int result;

            do
            {
                string vvod = Console.ReadLine();
                convert = int.TryParse(vvod, out result);

                if (convert && result > 0)
                {

                }
                else
                {
                    convert = false;
                    Console.WriteLine("Error!");
                    Console.WriteLine("Repeat:");
                }

            } while (!convert);

            return result;
        }

        public static int MassColumns()
        {
            bool convert;
            int result;

            do
            {
                string vvod = Console.ReadLine();
                convert = int.TryParse(vvod, out result);

                if (convert && result > 0)
                {

                }
                else
                {
                    convert = false;
                    Console.WriteLine("Error!");
                    Console.WriteLine("Repeat:");
                }

            } while (!convert);

            return result;
        }

        public static int[,] ZapMass(int rows, int columns)
        {
            int[,] mass = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    bool convert;
                    int num;

                    Console.WriteLine($"\nElement [{i},{j}]:");
                    do
                    {
                        string vvod = Console.ReadLine();

                        convert = int.TryParse(vvod, out num);
                        if (convert)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Error!");
                            Console.WriteLine("Repeat:");
                        }
                    } while (!convert);

                    mass[i, j] = num;
                }
            }

            return mass;
        }
        public static void MassVivod(int[,] mass)
        {
            Console.WriteLine("Vivod massiva.");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write($"\t{mass[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public static void MassVObratnom(int[,] mass)
        {
            Console.WriteLine("\nVivod massiva v obratnom porydke");

            for (int i = mass.GetLength(0)-1; i >= 0; i--)
            {
                for (int j = mass.GetLength(1)-1; j >= 0; j--)
                {
                    Console.Write($"\t{mass[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public static void SumChetnix(int[,] mass)
        {
            int result = 0;

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i, j] % 2 == 0)
                    {
                        result = mass[i, j] + result;
                    }
                }         
            }

            Console.WriteLine($"\n Summa chetnix chisel : {result}");
        }

        public static void MinChislo(int[,] mass)
        {
            int result = mass[0,0];

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i, j] < result)
                    {
                        result = mass[i, j];
                    }
                }
            }

            Console.WriteLine($"\n Minimalnoe chislo : {result}");
        }
        public static void MaxChislo(int[,] mass)
        {
            int result = mass[0, 0];

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i, j] > result)
                    {
                        result = mass[i, j];
                    }
                }
            }

            Console.WriteLine($"\n Minimalnoe chislo : {result}");
        }
    }
}
