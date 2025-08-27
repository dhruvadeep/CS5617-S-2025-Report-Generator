/*************************************
 * File     =   IReportSaver.cs
 * 
 * Author   =   Dhruvadeep Malakar
 * 
 * Product  =   ReportGenerator
 * 
 * Project  =   Reports
 * 
 * Description =   Interface for saving reports to a specified file path.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports;
public interface IReportSaver
{
    void SaveReport(IReport report, string filePath);
}
