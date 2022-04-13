using System;

namespace ucgen.olusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("yükseklik:");
            int yukseklık = int.Parse(Console.ReadLine());
            for (int i = 0; i <= yukseklık; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    //Boşluk koyarak üçgenin şeklini değiştirebilirsiniz.
                    Console.Write("  *  ");
                    Console.Write("  ");
                    //Dik üçgen
                    //Console.Write("*");
                    // Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
