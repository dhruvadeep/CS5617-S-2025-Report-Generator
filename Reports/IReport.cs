/*************************************
 * File     =   IReport.cs
 * 
 * Author   =   Dhruvadeep Malakar
 * 
 * Product  =   ReportGenerator
 * 
 * Project  =   Reports
 * 
 * Description =   Interface representing a report with a title and description.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports;
public interface IReport
{
    string Title { get; }
    string Description { get; }
}
