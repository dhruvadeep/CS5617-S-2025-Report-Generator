// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

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
