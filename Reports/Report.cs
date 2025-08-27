/*************************************
 * File     =   Report.cs
 * 
 * Author   =   Dhruvadeep Malakar
 * 
 * Product  =   ReportGenerator
 * 
 * Project  =   Reports
 * 
 * Description =   Internal representation of a report.
 */

namespace Reports;

public class Report : IReport
{
    public string Title { get; }
    public string Description { get; }

    public Report(string title, string description)
    {
        Title = title;
        Description = description;
    }
}
