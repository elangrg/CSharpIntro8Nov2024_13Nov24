﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro8Nov2024
{
    internal class DelegateDemo
    {
        delegate int DlgDemo(int a , int b); // int(int,int)


        static void Main()
        {

            DlgDemo fptr = new DlgDemo(MathFunc.Add); // 1.0
            fptr += MathFunc.Multi;  // 2.0 DTI

            fptr += delegate (int x, int y) // 2.0 Anonymous Block/Method 
                        { 
                            return x + y; 
                        };

            fptr +=  (int x, int y) =>     // 3.0 Anonymous Block/Method -> 0
            {
                return x + y;
            };

            fptr += ( x,  y) =>     // 3.0 Anonymous Block/Method  ->1
            {
                return x + y;
            };

            fptr += (x, y) =>  x + y;   // 3.0 Anonymous Block/Method  ->2
            


            Console.WriteLine(  fptr(100,200) );
            Console.ReadKey();
        }
    }

    class MathFunc
    {
        public static int Add(int a, int b) { return a + b; }
        public static int Multi(int a, int b) { return a * b; }
    }
}
