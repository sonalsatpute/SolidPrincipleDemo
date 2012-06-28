using System;

namespace SolidPrincipleDemo
{
    class ReportFormatter
    {
        public virtual void FormateReport()
        {
            Console.WriteLine("\nFormatting report for 8-1/2 X 11... .. .");
        }
    }


    class TabloidReportFormatter : ReportFormatter
    {
        public override void FormateReport()
        {
            Console.WriteLine("\nFormatting report for 11 x 17.... .. .");
        }
    }
}