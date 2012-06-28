namespace SolidPrincipleDemo
{
    public class Report
    {
        public virtual void Print()
        {
            ReportPrinter reportPrinter = new ReportPrinter();
            reportPrinter.Print();
        }
    }

    class TabloidReport : Report
    {
        public override void Print()
        {
            ReportPrinter reportPrinter = new TabloidReportPrinter();
            reportPrinter.Print();
        }
    }
}