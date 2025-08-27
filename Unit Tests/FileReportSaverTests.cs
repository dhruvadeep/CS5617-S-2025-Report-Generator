using Reports;

namespace Unit_Tests;

[TestClass]
public class FileReportSaverTests
{
    [TestMethod]
    public void FileReportSaver_ShouldSaveReportToFile()
    {
        IReport report = new Report("Test Report", "File save test");
        IReportSaver saver = new FileReportSaver();

        string filePath = Path.Combine(Path.GetTempPath(), "TestReport.txt");
        saver.SaveReport(report, filePath);

        string fileContent = File.ReadAllText(filePath);
        Assert.IsTrue(fileContent.Contains("Test Report"));
        Assert.IsTrue(fileContent.Contains("File save test"));
    }
}
