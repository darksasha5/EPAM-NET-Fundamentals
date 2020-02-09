﻿using System.Collections.Generic;
using System.Text;
using ClassLibrary.BL.Interfaces;
using ClassLibrary.BL.Model;

namespace ClassLibrary.BL.Reporting
{
    public class TxtReportWriter : IReportWriter
    {
        public Report GenerateReport(IEnumerable<Attendance> attendances)
        {
            var sb = new StringBuilder();

            foreach (var attendance in attendances)
            {
                sb.AppendLine(attendance.ToString()); //TODO Format
            }

            return new Report() { Content = sb.ToString(), ContentType = "text/plain" };
        }
    }
}