using System;

namespace _29._12._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adlar = { "Hikmet Abbasov", "Rauf Orucov", "Nihat Memmedzade"};

            Console.WriteLine("1. Butun telebelere bax");
            Console.WriteLine("2. Secilmis telebeye bax");
            Console.WriteLine("3. Telebe adini deyis");

            Console.WriteLine("Emeliyyat nomresini daxil et: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                for (int i = 0; i < adlar.Length; i++)
                {
                    Console.WriteLine(adlar[i]);
                }
            }
            else if(n == 2)
            {
                Console.WriteLine("Indeksi daxil et: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(adlar[index]);
            }
            else if(n == 3)
            {
                Console.WriteLine("1.Hikmet Abbasov");
                Console.WriteLine("2.Rauf Orucov");
                Console.WriteLine("3.Nihat Memmedzade");

                Console.WriteLine("Adini deyismek istediyiniz telebenin sira nomresini daxil et: ");
                int indeks = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni adi daxil et: ");
                string ad = Console.ReadLine();

                adlar[indeks-1] = ad;
                for (int i = 0; i < adlar.Length; i++)
                {
                    Console.WriteLine(adlar[i]);
                }
            }
            else
            {
                Console.WriteLine("Emeliyyat yanlisdir!");
            }

        }
    }
}
