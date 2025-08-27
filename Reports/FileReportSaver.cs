// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

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

        string content = $"Title: {report.Title}\n\nDescription: {report.Description}";
        System.IO.File.WriteAllText(filePath, content);
    }
}
