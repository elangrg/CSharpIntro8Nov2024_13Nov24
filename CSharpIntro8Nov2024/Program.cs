using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro8Nov2024
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int j = 1000;



            int i = j;

            short s = 100;

            i = s;

            s = (short) i;


            string st = "5000";



            i = int.Parse(st);

            st = i.ToString();


            object o = i; //boxing
            int k =(int) o; // unboxing


            #region Intro code
            Console.WriteLine("Hello World");
            #endregion

            DisplayA();

            DisplayC();
         

            Console.ReadKey();


        }

        static void DisplayA() {
            int i = 100;

            DisplayB();

            Console.WriteLine(" In DisplayA ..." + i); }

        static void DisplayB() {
            int j = 100;
            
            Console.WriteLine(" In DisplayB ..." + j); }


        static void DisplayC()
        {
            int j = 100;
           

            Console.WriteLine(" In DisplayB ..." + j);
        }
    }
}


