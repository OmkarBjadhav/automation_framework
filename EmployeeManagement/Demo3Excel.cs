using ClosedXML.Excel;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using EmployeeManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    
    public  class Demo3Excel
    {
        [Test]
        public void  DemoExcelRead ()
        {
            string val;
         IXLWorkbook  book=new XLWorkbook(@"C:\\Users\\omkarj\\Desktop\\C# Project\\AutomationFramework\\EmployeeManagement\\TestData\\orange_data.xlsx");
            IXLWorksheet sheet= book.Worksheet("InValidLoginTest");
          IXLRange  range=sheet.RangeUsed();

            object[] allData = new object[6];
            for (int r=2;r<=6;r++)
            {
                string[] dataset1=new string[3];
                for(int c=1;c<=3;c++)
                {
                    string Value = range.Cell(r, c).GetString();
                    //Console.WriteLine(Value);
                  

                }
                allData[0] = dataset1;
            }
          




        }
    }
}
