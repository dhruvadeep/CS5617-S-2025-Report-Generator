// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Reports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Tests;

[TestClass]
public class ReportTests
{
    [TestMethod]
    public void ReportStoringCorrectValues()
    {
        var report = new Report("Test Title", "Test Description");

        Assert.AreEqual("Test Title", report.Title);
        Assert.AreEqual("Test Description", report.Description);
    }
}
