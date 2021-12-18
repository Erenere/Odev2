using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sesliHarfler = new string[] {"a", "e", "i", "o", "u"};
            string[] cumledekiSesliler = new string[5];
            
            Console.WriteLine("Cumle Girin: ");
            string cumle = Console.ReadLine();

            for(int i=0;i<sesliHarfler.Length; i++)
            {
                if (cumle.Contains(sesliHarfler[i]))
                {
                    cumledekiSesliler[i] = sesliHarfler[i];
                }
            }
            Array.Sort(cumledekiSesliler);
            Console.WriteLine("Sesli Harfler: ");
            Array.ForEach(cumledekiSesliler,(Console.WriteLine));
        }
    }
}