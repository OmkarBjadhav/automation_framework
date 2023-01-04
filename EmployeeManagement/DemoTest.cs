using EmployeeManagement.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public  class DemoTest
    {
        public static object[] DemoValidData()
        {
            string[] dataset1 = new string[2];
            dataset1[0] = "John";
            dataset1[1] = "john123";


            string[] dataset2 = new string[2];
            dataset2[0] = "peter";
            dataset2[1] = "peter123";


            string[] dataset3 = new string[2];
            dataset3[0] = "saul";
            dataset3[1] = "saul123";

            object[] allDataSet= new object[3];
            allDataSet[0] = dataset1;
            allDataSet[1] = dataset2;
            allDataSet[2] = dataset3;
            return allDataSet;



        }



        [Test,TestCaseSource(nameof(DemoValidData))]
        public void DemoValidLogin(string username, string password)
        {
            Console.WriteLine("Hello"+username+password);


        }


    }
}
