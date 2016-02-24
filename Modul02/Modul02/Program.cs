using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul02
{
    class Program
    {
        static void Main(string[] args)
        {

            // definirane na promenlivi

            int a = 0, b = 0;
            int sum = 0;

            // subirane na 4isla

            a = 10;
            b = 5;
            sum = a + b;
            
            // pisane v konzolata

            Console.Write(a);
            Console.Write(" + ");
            Console.Write(b);
            Console.Write (" = ");
            Console.WriteLine(sum);

            //dopulnitelni operatori

            Console.WriteLine("\nIzpolzvane na +=");
            a += b;
            Console.WriteLine(a);

            Console.WriteLine("\nIzpolzvane na -=");
            a -= b;
            Console.WriteLine(a);
            Console.WriteLine("\nIzpolzvane na *=");
            a *= b;
            Console.WriteLine(a);
            Console.WriteLine("\nIzpolzvane na ++");
            a++;
            Console.WriteLine(a);

            Console.WriteLine("\nIzpolzvane na --");
            a--;
            Console.WriteLine(a);


            Console.WriteLine ("Standartno delene:" + (7 / 3).ToString());   //  -> 2 (7/3 = 2,3333)
            Console.WriteLine("Ostatuk ot delene:" + (7 % 3).ToString());    //  -> 1 (1/3 = 0,3333)

        
        
        
        }
    }
}
