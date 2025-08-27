/*************************************
 * File     =   ReportGenerator.cs
 * 
 * Author   =   Dhruvadeep Malakar
 * 
 * Product  =   ReportGenerator
 * 
 * Project  =   Reports
 * 
 * Description =   Report generator implementation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports;
public class ReportGenerator : IReportGenerator
{
    public IReport Generate(string title, string description)
    {
        return new Report(title, description);
    }
}

