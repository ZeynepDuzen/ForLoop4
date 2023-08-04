using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** kullanicidan negatif deger girilene kadar girilen pozitif degerlerin adeti ve toplamini 
            //hesaplayan kod blogunu yaziniz ***

            int toplam = 0;
            int adet = 0;

            // 1.yol
            do
            {

                Console.WriteLine("Lütfen bir sayi giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 0)
                {
                    break;
                }
                toplam = toplam + sayi;
                adet++;

            } while (true);

            Console.WriteLine("Girilen pozitif degrlerin adeti : " + adet);
            Console.WriteLine("Girilen poziti degerlerin toplami : " + toplam);

            Console.Read();
        }

        
    }
}
