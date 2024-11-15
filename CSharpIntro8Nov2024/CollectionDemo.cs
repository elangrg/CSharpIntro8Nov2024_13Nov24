using System;
using System.Collections; // 1.0/1.1
using System.Collections.Generic; // 2.0
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro8Nov2024
{
    internal class CollectionDemo
    {
        static void Main()
        {

             


            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ganesh");
            arrayList.Add(10000);
            arrayList.Add(DateTime.Now);
            arrayList.Add(new Employee());

            foreach (object  itm in arrayList) {
                Console.WriteLine(itm.ToString()  );
            }




            List<Employee> listEmp = new List<Employee>();

            listEmp.Add(new Employee() { EmpID=1000, EmpName="Ganesh", Address="Blr" });

            listEmp.Add(new Employee() { EmpID = 1001, EmpName = "Mahesh", Address = "Blr" });

            listEmp.Add(new Employee() { EmpID = 1002, EmpName = "Dinesh", Address = "Blr" });





            foreach (var emp in listEmp)
            {
                
                Console.WriteLine(emp );
            }

            listEmp.Remove(listEmp.Find(e => e.EmpID == 1002));


           


            List<object> listMixed = new List<object>() { "Mahesh" };
            listMixed.Add("Ganesh");
            listMixed.Add(10000);
            listMixed.Add(DateTime.Now);
            listMixed.Add(new Employee());

            foreach (var itm in listMixed)
            {

                Console.WriteLine(itm);
            }


            List<Employee> emps = new List<Employee>() { 
                new Employee() { EmpID = 1000, EmpName = "Ganesh", Address = "Blr" }, 
                new Employee() { EmpID = 1000, EmpName = "Ganesh", Address = "Blr" } 
            };


            Dictionary<string,string> dictEmps = new Dictionary<string,string>();


            dictEmps.Add("IBM10001", "Ganesh");
            dictEmps.Add("IBM10002", "Mahesh");
            dictEmps.Add("IBM10003", "Dinesh");

            foreach (KeyValuePair<string,string> itm in dictEmps)
            {
                Console.WriteLine(  itm.Key  +  itm.Value);
            }



            foreach (var item in new StringEnumerable())
            {
                Console.WriteLine(  item);
            }



            // iterator Example - 2.0

            foreach (var item in GetNames(true))
            {
                Console.WriteLine(  item);
            }



            Console.ReadKey();
       }


        static IEnumerable GetNames(bool allVals=false)
        {
            yield return "Ganesh";
            yield return "Mahesh";
            yield return "Dinesh";

            if (allVals == false) yield break;

            yield return "Amaresh";
            yield return "Suresh";


        }

    }
    // problem
    class empCol:ArrayList {


        public override int Add(object value)
        {

            if (value is Employee)
            {

                return base.Add(value);
            }

            return -1;

        }

    }



    class StringEnumerable : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return   new StringEnumerator(new List<string> { "Ganesh", "Mahesh", "Dinesh" }); 
        }
    }


    class StringEnumerator : IEnumerator
    {
        List<string> _data;

        int index = -1;

        public StringEnumerator(List<string> data)
        {
                _data = data;
        }


        

        public object Current
        {
            get { return _data[index]; }
           
        }


        public bool MoveNext()
        {
            index++;

            if (index >= _data.Count) {return false; }
                

            return true;


        }

        public void Reset()
        {
            index = -1;
        }
    }


}
