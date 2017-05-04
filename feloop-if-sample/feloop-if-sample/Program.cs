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
            //if (GreaterThanTen(x))
            //{
            //    if (DividedByFive(x))
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    return false;
            //}
            if (GreaterThanTen(x) && DividedByFive(x))
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