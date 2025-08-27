/*************************************
 * File     =   IReportGenerator.cs
 * 
 * Author   =   Dhruvadeep Malakar
 * 
 * Product  =   ReportGenerator
 * 
 * Project  =   Reports
 * 
 * Description =   Interface for generating reports.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports;
public interface IReportGenerator
{
    IReport Generate(string title, string description);
}
