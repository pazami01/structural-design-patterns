using System;
using System.Collections.Generic;
using System.Text;

namespace ProtectedProxy
{
    public class ReportGenerator : IReportGenerator
    {
        public string GenerateDailyReport()
        {
            string report = "*************************Location X Daily Report*************************\n"
                + "Location ID: 012\n"
                + "Today's Date: Sun Sep 14 13:28:12 IST 2014\n"
                + "Total Pizza Sell: 112\n"
                + "Total Sale: $2534\n"
                + "Net Profit: $1985\n"
                + "*************************************************************************";

            return report;
        }
    }
}
