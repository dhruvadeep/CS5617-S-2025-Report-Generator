/*************************************
 * File     =   FileReportSaver.cs
 * 
 * Author   =   Dhruvadeep Malakar
 * 
 * Product  =   ReportGenerator
 * 
 * Project  =   Reports
 * 
 * Description =    Saves reports to a specified file path.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports;
public class FileReportSaver : IReportSaver
{
    public void SaveReport(IReport report, string filePath)
    {
        ArgumentNullException.ThrowIfNull(report);

        if (string.IsNullOrWhiteSpace(filePath))
        {
            throw new ArgumentException("File path cannot be null or whitespace.", nameof(filePath));
        }

        Console.WriteLine($"Saving report to {filePath}...");
        string content = $"Title: {report.Title}\n\nDescription: {report.Description}";
        System.IO.File.WriteAllText(filePath, content);
        Console.WriteLine("Report saved successfully.\n\n");
    }
}
