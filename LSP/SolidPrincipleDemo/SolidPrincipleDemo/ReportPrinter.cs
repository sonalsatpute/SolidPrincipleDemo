using System;

namespace SolidPrincipleDemo
{
    class ReportPrinter
    {
        public virtual void Print()
        {
            DataAccess dataAccess = new DataAccess();
            ReportFormatter reportFormatter = new ReportFormatter();


            dataAccess.GetData();
            reportFormatter.FormateReport();
            Console.WriteLine("\nPrinting the report to laser printer... .. .");
        }
    }


    internal class TabloidReportPrinter : ReportPrinter
    {
        public override void Print()
        {
            DataAccess dataAccess = new DataAccess();
            ReportFormatter reportFormatter = new TabloidReportFormatter();


            dataAccess.GetData();
            reportFormatter.FormateReport();
            Console.WriteLine("\nPrinting the report to do-matrix printer... .. .");        
        }
    }
}