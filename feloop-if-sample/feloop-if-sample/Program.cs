using System;

namespace feloop_if_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsolda unicode karakterlerin gözükmesi için gerekli, yoksa Türkçe karakterler gözükmeyecek.
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"10'dan büyük: {GreaterThanTen(number)}");
            Console.WriteLine($"5'e bölünebilir: {DividedByFive(number)}");
            Console.WriteLine($"10'dan büyük ve 5'e bölünebilir: {GreaterThanTenAndDividedByFive(number)}");
            Console.WriteLine($"10'dan büyük veya 5'e bölünebilir: {GreaterThanTenOrDividedByFive(number)}");

            Console.ReadKey();

        }

        static bool GreaterThanTen(int x)
        {
            if (x > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool DividedByFive(int x)
        {
            if (x % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool GreaterThanTenAndDividedByFive(int x)
        {
            if (GreaterThanTen(x) && DividedByFive(x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool GreaterThanTenOrDividedByFive(int x)
        {
            if (GreaterThanTen(x) || DividedByFive(x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}