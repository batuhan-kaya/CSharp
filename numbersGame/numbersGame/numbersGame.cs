using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var Random = new Random();
            int randomNumber = Random.Next(0, 100);
            for (int i = 9; i >=0; i--)
            {
                Console.WriteLine("0-100 Arası sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi<0 || sayi>=101)

                {
                    i++;
                }
                else if(sayi == randomNumber)
                {
                    Console.WriteLine("Tebrikler bildiniz. Sayı = {0}", randomNumber);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if(sayi > randomNumber)
                {
                    Console.WriteLine("Sayı daha küçüktür, kalan hakkınız = {0}", i);
                }
                else
                {
                    Console.WriteLine("Sayı daha büyüktür, kalan hakkınız = {0}", i);
                }
            }
            Console.Write("Hakkınız bitti.");
            Console.ReadLine();
        }
    }
}
