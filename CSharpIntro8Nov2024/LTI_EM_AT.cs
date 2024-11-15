using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro8Nov2024
{

    class LTI_EM_AT_Demos
    {

        static void Main()
        {
            LTI_ImplicitlyTypedDemo objlti = new LTI_ImplicitlyTypedDemo();

            objlti.ExecuteDemo();

            AT_OIDemo aT_OIDemo = new AT_OIDemo();

            aT_OIDemo.ExecuteDemo();



            // Extension Method Demo
            char c='A';

            ExtensionMethodDemo.IsValidEmpIDChar(c);

            c.IsValidEmpIDChar();

            string st = "";
            st.IsValidEmpIDChar();

           
            Employee employee = new Employee();
            employee.IsValidEmpIDChar();


            Console.ReadKey();

        }
    }

    internal class LTI_ImplicitlyTypedDemo
    {
      

        public void ExecuteDemo()
        {
            var i = 100;

            //var j;

            //var k = null;

            //i = "";


        }


    }




    internal class AT_OIDemo
    {


        public void ExecuteDemo()
        {
          Employee employee = new Employee { EmpID=1000,Address="Blr", EmpName="Ganesh"  };


         var employee1 = new Employee { EmpID = 1000, Address = "Blr", EmpName = "Ganesh" };

            // Anonymous Type
            var employee2 = new  { EmpID = 1000, Address = "Blr", EmpName = "Ganesh" };
            var employee3 = new { EmpID = 1001, Address = "Mys", EmpName = "Mahesh" };

            var employee4 = new { EmpID = 1001, EmpName = "Mahesh", Address = "Mys" };


            Console.WriteLine(  employee.GetType());
            Console.WriteLine(employee1.GetType());
            Console.WriteLine(employee2.GetType());
            Console.WriteLine(employee3.GetType());
            Console.WriteLine(employee4.GetType());

            //var j;

            //var k = null;

            //i = "";


        }


    }




    static class ExtensionMethodDemo
    {

        public static bool IsValidEmpIDChar(this object ch, string arg2="")
        {
            return true;

        
        }



    }

}
