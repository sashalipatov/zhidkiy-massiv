﻿using System;
using System.Linq;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {


            //Номер 1
           /*{
               int[] array = new int[10];
               Random rnd = new Random();
               for (int i = 0; i < array.Rank; i++)
               {
                   array[i] = rnd.Next(4);
                   if (array[i] == 0)
                   {
                       array[i] = 2;
                   }
               }

           }*/

           //Номер 2
           /*{
               int zhiza = Convert.ToInt32(Console.ReadLine());
               int[] array = new int[zhiza];
               for (int i = 0; i < array.Rank; i++)
               {
                   array[i] = Convert.ToInt32(Console.ReadLine());
               }
               for (int i = array.Rank - 1; i >= 0; i--)
               {
                   Console.WriteLine(array[i]);
               }
           }*/

           //Номер 3
           /*{
               int[] numbers = new int[10] { -7, -4, -1, -3, 1, 2, 4, 7, 8, 9 };
               int minValue = numbers.Min();

               Console.WriteLine(minValue);
           }*/

           //Номер 4
           /* {
                int[] array = new int[10] { -4, -2, -1, -3, 1, 2, 4, 5, 7, 9 };

                int sum = 0;
                int multiplication = 0;

                for (int i = 0; i < 10; i++)
                    sum += array[i];

                for (int i = 0; i < 10; i++)
                    multiplication *= array[i];

                Console.WriteLine(sum);
                Console.WriteLine(multiplication);
            }*/

            //Номер 5
           /* {
                int[] array = new int[10];

                Random rand = new Random();

                for (int i = 0; i < array.Length; i++)
                    array[i] = rand.Next(0, 39);

                int lastNumber = Convert.ToInt32(Console.ReadLine());
                int position = Convert.ToInt32(Console.ReadLine());

                if (position >= 0 && position < array.Length)

                    for (int i = array.Length - 1; i > position; i--)
                        array[i] = array[i - 1];

                else position = array.Length - 1;
                array[position] = lastNumber;

                for (int i = 0; i < array.Length; i++)
                    Console.Write($"{array[i]} ");

            }*/

            //Номер 6
           /* {
                int[] array = new int[20];
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                    Console.WriteLine(array[i] = rnd.Next(-7, 9));

                int max = 0;
                for (int i = 0; i < array.Length; i++)
                    if (array[i] > 0) max++;
                Console.Write("Положительный элементы: {0}", max);
                Console.WriteLine();

                int min = array[0];
                int number = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        number = i;
                    }
                }

                Console.WriteLine("Минимальное число \"{0}\"", min, number);
                Console.ReadLine();
            }*/

            //Номер 7
          /*  {
                int[] arr = new int[10];
                Random rnd = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(-7, 9);
                    if (arr[i] > 0)*/
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}