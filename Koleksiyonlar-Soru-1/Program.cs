using System;
using System.Collections;
using System.Linq;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primes = new ArrayList();
            ArrayList nonprimes = new ArrayList();
            int num = 0;
            int flag = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Enter a number");
                

                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out num))
                    {
                        if (num > 0)
                            break;
                    }
                }

                flag = 0;
                for (int j = 2; j <= num-1; j++)
                {
                    if (num % j == 0)
                    {
                        flag = 1;
                        nonprimes.Add(num);
                        break;
                    }
                }

                if (flag == 0)
                    primes.Add(num);
            }
            Console.WriteLine("****** Primes *****");
            primes.Sort();
            primes.Reverse();
            foreach (var item in primes)
                Console.WriteLine(item);
            Console.WriteLine("Eleman sayisi: {0}",primes.Count);
            int sum1 = primes.Cast<int>().Sum();
            if(primes.Count!=0)
                Console.WriteLine("Ortalama: {0}",sum1/primes.Count);
            
            Console.WriteLine("****** Non-Primes *****");
            nonprimes.Sort();
            nonprimes.Reverse();
            foreach (var item in nonprimes)
                Console.WriteLine(item);
            Console.WriteLine("Eleman sayisi: {0}",nonprimes.Count);
            int sum2 = nonprimes.Cast<int>().Sum();
            if(nonprimes.Count!=0)
                Console.WriteLine("Ortalama: {0}",sum2/nonprimes.Count);
        }
    }
}
