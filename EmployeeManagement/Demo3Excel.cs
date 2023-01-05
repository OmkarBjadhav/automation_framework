using ClosedXML.Excel;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    
    public  class Demo3Excel
    {
        [Test,]
        public string  DemoExcelRead ()
        {
           
         IXLWorkbook  book=new XLWorkbook(@"C:\\Users\\omkarj\\Desktop\\C# Project\\AutomationFramework\\EmployeeManagement\\TestData\\orange_data.xlsx");
            IXLWorksheet sheet= book.Worksheet("InValidLoginTest");
          IXLRange  range=sheet.RangeUsed();
            for (int r=2;r<=6;r++)
            {

                for(int c=1;c<=3;c++)
                {
                    string Value = range.Cell(r, c).GetString();
                    //Console.WriteLine(Value);

                    return Value;

                }
            }
            

            

        }
    }
}
