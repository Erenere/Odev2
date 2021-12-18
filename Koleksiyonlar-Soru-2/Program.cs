using System;
using System.Collections;
using System.Linq;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int[] smallNumbers = new int[3];
            int[] bigNumbers = new int[3];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}. sayiyi girin",i+1);
                var num = Convert.ToInt32(Console.ReadLine());
                numbers[i] = num;
            }
            
            Array.Sort(numbers);
            for (int i = 0; i < 3; i++)
            {
                smallNumbers[i] = numbers[i];
                bigNumbers[i] = numbers[numbers.Length-1-i];
            }
            
            Console.WriteLine("En kucuk 3");
            Array.ForEach(smallNumbers, (Console.WriteLine));
            Console.WriteLine("En buyuk 3");
            Array.ForEach(bigNumbers, (Console.WriteLine));

        }
    }
}