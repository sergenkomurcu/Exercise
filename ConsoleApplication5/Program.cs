using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("sayi gir");
              string sayi = Console.ReadLine();
            //kendi haric hicbir sayiya bolunemeyen
            int deger = Convert.ToInt32(sayi);
            bool x = true;
            int[] hafiza = new int[deger];
            for(int i=2;i<deger-1;i++)
            {
                if(deger%i==0)

                {
                    x = false;
                    Console.WriteLine("sayi asal degildir");
                    break;
                }
            }

            if (x == true)
            {
                Console.WriteLine("sayi asaldir");

            }
             
            Console.ReadLine();

        }
    }
}
