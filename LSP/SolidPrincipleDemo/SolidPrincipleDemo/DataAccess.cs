using System;
using System.Collections.Generic;

namespace SolidPrincipleDemo
{
    class DataAccess
    {
        public List<ReportDataElement> GetData()
        {
            Console.WriteLine("\nGetting the data... .. .");
            return new List<ReportDataElement>()
                       {
                           new ReportDataElement()
                               {
                                   CustomerFirtName = "Sonal"
                               }
                       };
        }
    }
}