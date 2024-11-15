using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro8Nov2024
{
    internal class OOPDemo
    {
        static void Main()
        {

            // ClsA objA;
            // ClsB objB = new ClsB();

            //// objA.Display();
            // objB.Display();


            // objA = objB;


            // objB =(ClsB) objA;




            // objA = new ClsC();


            // objA.Display();


            //Employee objEmp = new Employee(1000,"Ganesh","Blr");

            //IBMEmployee objEmp1 = new IBMEmployee();




            //Console.WriteLine(  objEmp);

            //Console.WriteLine(objEmp1);

            //Singleton obj = Singleton.GetObject();


            PropertiesExample obj = new PropertiesExample();
            obj.StudentID = 1000;
           
            Console.WriteLine(obj.StudentID);
            obj.StudentName = "Mahesh";
            obj.StudentName = "A";

            Console.WriteLine(  obj.StudentName);
            obj.DOB = DateTime.Now.AddDays(-10000);
            Console.WriteLine(obj.Age  );

            obj[0] = "C-Sharp";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(obj[i]);
            }



            // Console.WriteLine(StaticCnstrDemo.ObjEmp.Address);


            Console.ReadKey();


        }
    }


  abstract  class ClsA
    {
        #region Access Modifiers Eg
        //public int var_Pub = 0;
        //private int var_Prv = 0;
        //protected int var_Ptd = 0;
        //int var_Defa = 0;
        #endregion

        public abstract void Display();
       

        //public virtual void Display()
        //{
        //    Console.WriteLine("In Display of ClsA");
        //}
    }


    class ClsB:ClsA
    {

        public sealed override void Display()
        {
            Console.WriteLine("In Display of ClsB");
        }
    }


    class ClsC:ClsB
    {
        //public override void Display()
        //{
        //    Console.WriteLine("In Display of ClsC");
        //}


    }


    class Employee
    {
        public int EmpID;
        public string EmpName;
        public string Address;

        public Employee()
        {
            EmpID = 0;
            EmpName = "";
            Address = "";
        }

        public Employee(int _empid, string EmpName)//:this()
        {
            EmpID = _empid;
            this.EmpName = EmpName;
        }

        public Employee(int _empid, string enm, string _address):this(_empid, enm) 
        {
            Address = _address;
        }
        //public override string ToString()
        //{
        //    return $"Emp ID :{EmpID}, Emp Name: {EmpName}, Address: {Address} ";
        //}


    }
    class IBMEmployee:Employee
    {

        public IBMEmployee():base(100,"")
        {
                
        }

    }



    class Singleton
    {

        static Singleton obj;

        private Singleton()
        {
                
        }

        public string msg = "Hello ";
        public static Singleton GetObject()
        {
            if (obj == null)
            { 
                obj = new Singleton();
            }
            
            return obj;
        }

    }


    class StaticCnstrDemo
    {

        public static Employee ObjEmp;

        static  StaticCnstrDemo()
        {
                ObjEmp= new Employee (100,"");

        }

        public StaticCnstrDemo()
        {
                
        }

    }


    class PropertiesExample
    {
        private int _StudentID;

        string[] Skills = {"CSharp","ADO.NET","MVC" };

        public int StudentID
        {
            get { 
                return _StudentID; }

            set {
                _StudentID = value; }
        }


        private string _StudentName;

        public string StudentName
        {
            get { return _StudentName; }
            set { 
                // validation
                if (value.Length>1 )
                {_StudentName = value; }
                 }
        }



        public DateTime DOB { get; set; }



        public int Age
        {// computed prop / Read only
            get { return DOB.Year -DateTime.Now.Year; }

           
        }


        public string this[int index]
        {
            get { return  Skills[index]; }
            set { Skills[index] = value; }
        }


    }
}
