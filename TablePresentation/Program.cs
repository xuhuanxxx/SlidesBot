﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ExcelManipulater;

namespace TablePresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = System.Environment.CurrentDirectory + "\\a.xlsx";
            Console.WriteLine(fileName);
            DataSet sheets = ExcelReader.ImportDataFromAllSheets(fileName);
            if (sheets != null)
            {
                foreach (DataTable dt in sheets.Tables)
                {
                    Console.WriteLine(dt.TableName.ToString());
                }
                //ExcelWriter.ExportDataToExcel(sheets, "copy.xls");
            }

            Console.WriteLine("Finish");
            Console.ReadKey();
        }
    }
}
