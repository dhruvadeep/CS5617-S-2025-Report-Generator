using Reports;

namespace Execute;

public class Program
{
    static void Main()
    {
        Console.WriteLine("=== Report Generator ===");

        IReportGenerator generator = new ReportGenerator();

        IReport report = generator.GenerateReport(
            "Monthly Report",
            "This is the monthly report description."
        );

        // Save the report to a file.
        IReportSaver saver = new FileReportSaver();
        string filePath = "C:\\Users\\dhruv\\OneDrive\\Desktop\\DotDot\\report.txt";
        saver.SaveReport(report, filePath);
    }
}
