using System;

namespace Kare.olusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kenar1: ");
            int kenar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("kenar2: ");
            int kenar2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= kenar1; i++)
            {
                for (int ş = 1; ş <= kenar2; ş++)
                {
                    if (i == 1 || i == kenar1)
                        Console.Write("*");
                    else if
                        (ş == 1 || ş == kenar2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            #region Kare-2.yol
            ////Tek kenar isteyerek kare oluşturma

            //Console.WriteLine("kenar: ");
            //int kenar = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= kenar; i++)
            //{
            //    for (int j = 1; j <= kenar; j++)
            //    {
            //        if (i == 1 || i == kenar || j == 1 ||j==kenar )
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey(); 
            #endregion
        }
    }    
}
