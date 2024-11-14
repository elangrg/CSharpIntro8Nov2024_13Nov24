using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro8Nov2024
{
    internal class GenericDemo
    {
        static void Main()
        {

            Console.WriteLine(  Min(500,100));
            Console.WriteLine(Min(10.123, 20.324));

            Console.WriteLine(Min("abc", "xyz"));

            Console.WriteLine(Min<string>("abc",1000.ToString()));


            GenericSyntaxDemo<string> genericSyntaxDemo = new GenericSyntaxDemo<string>();

         Employee e=   genericSyntaxDemo.GenericMethodSyn<string, string, Employee>("", "");


            Console.ReadKey();

        }


        //static int Min(int a, int b)
        //{
        //    if (a < b)
        //    {

        //        return a;
        //    }
        //    else
        //    { 
        //          return b;
        //    }

        //}

        //static double Min(double a, double b)
        //{
        //    if (a < b)
        //    {

        //        return a;
        //    }
        //    else
        //    {
        //        return b;
        //    }

        //}


        // First Solution
        //static IComparable Min(IComparable a, IComparable b)
        //{
        //    if (a.CompareTo(b)<0)
        //    {

        //        return a;
        //    }
        //    else
        //    {
        //        return b;
        //    }

        //}

        static T Min<T>(T a, T b) where T:IComparable<T>
        {

           
            if (a.CompareTo(b) < 0)
            {

                return a;
            }
            else
            {
                return b;
            }

        }

    }





    class GenericSyntaxDemo<T> where T:class
    {

        public TR GenericMethodSyn<T1, T2, TR>(T1 a, T2 b) where T1 : class, IComparable<T1>
            where T2: class, IComparable<T2>
            where TR : new()
        {
            TR obj= new TR();
            return obj;
        }


    }



}
