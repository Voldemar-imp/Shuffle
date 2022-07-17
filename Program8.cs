using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySise = 10;
            int[] numbersArray = new int[arraySise];
            int randomMin = 0;
            int randomMax = 90;            
            Random random = new Random();
            string[] stringArray;
            string text = "C# programming lingua non penis canis est";

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = random.Next(randomMin, randomMax+1);              
            }

            WriteArray(numbersArray);
            Console.WriteLine("- числовой массив");            
            ShuffleArray (numbersArray);
            WriteArray (numbersArray);
            Console.WriteLine("- перемешанный числовой массив");
            Console.WriteLine();
            stringArray = text.Split(' ');
            WriteArray(stringArray);
            Console.WriteLine("- строковый массив");
            ShuffleArray(stringArray);
            WriteArray(stringArray);
            Console.WriteLine("- перемешанный строковый массив");
            Console.WriteLine();
        }

        static void ShuffleArray(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int shuffleIndex = random.Next(0, array.Length);
                int swapp = array[i];
                array[i] = array[shuffleIndex];
                array[shuffleIndex] = swapp; 
            }
        }

        static void ShuffleArray(string[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int shuffleIndex = random.Next(0, array.Length);
                string swapp = array[i];
                array[i] = array[shuffleIndex];
                array[shuffleIndex] = swapp;
            }
        }

        static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void WriteArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
