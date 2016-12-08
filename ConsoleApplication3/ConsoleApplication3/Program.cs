using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("sayi gir");
            string sayi = Console.ReadLine();
            palindromolm(sayi);
        }
     static int palindromolm(string b)
        {
            int sercan = b.Length;
            int[] tutan = new int[b.Length];
            int[] tutan2 = new int[b.Length];
            int deger = Convert.ToInt32(b);
            int deger2 = Convert.ToInt32(b);
            int x;
            bool y = true;       
            for (int i = 0; i < sercan; i++)
            {
                x = deger % 10;
                tutan[i] = x;
                deger /= 10;
            }

            for (int j = sercan - 1; j >= 0; j--)
            {
                x = deger2 % 10;
                tutan2[j] = x;
                deger2 /= 10;
            }

            for (int i = 0; i < sercan; i++)
            {
                if (tutan[i] != tutan2[i])
                {
                    y = false;                  
                }
            }
            if (y == false)
            {
                int z = Convert.ToInt32(b);
                z++;
                string q = Convert.ToString(z);
                palindromolm(q);
            }
            else
            {
                Console.WriteLine("sayi="+b);     
            }
            Console.ReadLine();
            return 0;
        }
    }
}
