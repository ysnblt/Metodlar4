using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan iki adet değer alıp , hangisi büyükse onu ekrana yazdıran program
            Console.WriteLine("Birinci sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            kontrolEt(sayi1, sayi2);
            Console.ReadLine();
            

        }

        static void kontrolEt(int a , int b)
        {
            if(a > b)
            {
                Console.WriteLine("1. sayı 2.sayıdan büyüktür");
            }
            else if(a == b)
            {
                Console.WriteLine("1.sayı 2.sayıya eşittir");
            }
            else
            {
                Console.WriteLine("2.sayı 1.sayıdan büyüktür");
            }
                
        }
    }
}
