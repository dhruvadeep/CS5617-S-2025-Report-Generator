using Reports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Tests;

[TestClass]
public class ReportGeneratorTests
{
    [TestMethod]
    public void ReportGeneratorGenerateReportCorrect()
    {
        IReportGenerator generator = new ReportGenerator();
        IReport report = generator.Generate("Sample Title", "Sample Description");

        Assert.AreEqual("Sample Title", report.Title);
        Assert.AreEqual("Sample Description", report.Description);
    }
}
