// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports;
public class ReportGenerator : IReportGenerator
{
    public IReport GenerateReport(string title, string description)
    {
        return new Report(title, description);
    }
}

