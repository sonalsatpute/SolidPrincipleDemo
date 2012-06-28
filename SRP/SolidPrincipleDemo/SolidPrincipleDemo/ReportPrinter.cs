using System;

namespace SolidPrincipleDemo
{
    class ReportPrinter
    {
        public void Print()
        {
            DataAccess dataAccess = new DataAccess();
            ReportFormatter reportFormatter = new ReportFormatter();


            dataAccess.GetData();
            reportFormatter.FormateReport();
            Console.WriteLine("\nPrinting the report to laser printer... .. .");
        }
    }
}