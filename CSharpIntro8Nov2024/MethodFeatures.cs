using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro8Nov2024
{
    internal class MethodFeatures
    {

        static void Main()
        {
            int prm= 0;

            Console.WriteLine(  $"BEFORE prm={prm}");
            DisplayByVal(prm);
            Console.WriteLine($"AFTER prm={prm}");
            DisplayByRef(ref prm);
            Console.WriteLine($"AFTER prm={prm}");
            DisplayByOut(out prm);
            Console.WriteLine($"AFTER prm={prm}");


        }


        static void DisplayByVal(int i)
        {

            i++;

            Console.WriteLine("value of I is {0}",i);

            Console.WriteLine(  $"value of I is {i}");
        
        }

        static void DisplayByRef(ref int i)
        {
            i++;

            Console.WriteLine("value of I is {0}", i);

        }

        static void DisplayByOut(out int i)
        {
            i = 100;


            Console.WriteLine("value of I is {0}", i);


        }





    }
}
