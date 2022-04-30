using System;
using System.Linq;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]  liste = new int[6] { 1, 3, 33, 44, 56, 101 };

            Console.WriteLine("tekler");
            var tekler =
                         from sayi in liste
                         where sayi % 2 == 1
                         select sayi;
            foreach (var tekSayi in tekler)
            {
                Console.WriteLine(tekSayi);
            }

            Console.WriteLine("ciftler");
            var ciftler=from sayi in liste
                        where sayi % 2==0
                        select sayi;

            foreach (var ciftSayi in ciftler)
            {
                Console.WriteLine(ciftSayi);
            }

            Console.ReadKey();
        }
    }
}
