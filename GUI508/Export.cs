// <copyright file="Export.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the Export data in CSV format class.</summary>
namespace GUI508
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Controls exporting data to text file in CVS format.
    /// </summary>
    public class Export
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Export"/> class.
        /// </summary>
        public Export()
        {
        }

        /// <summary>
        /// Export ASP .Net control grid to csv text file.
        /// </summary>
        /// <param name="saveCSV">Where file is to be outputted to.</param>
        public void ExportASP_NetControlsToCVS(string saveCSV)
        {
            System.IO.StreamWriter csvFileWriter = new StreamWriter(saveCSV, false);
            string columnHeaderText = "Alert, Asp.Net Control Name, Line Number, ASP.NetCode, Code Behind File, Directory";
            csvFileWriter.WriteLine(columnHeaderText);
            StringBuilder line = new StringBuilder();
            foreach (KeyValuePair<string, Scanner.ASPXControlProperties> kvp in Scanner.AspxControlsSorted)
            {
                if (!kvp.Value.ControlType.Equals("HeaderTags"))
                {
                    if ((kvp.Value.ControlMessages != null) && (kvp.Value.ControlMessages.Count > 0))
                    {
                        line.Append("Y,");
                    }
                    else
                    {
                        line.Append(string.Empty + ",");
                    }

                    line.Append(kvp.Value.ControlType + ",");
                    line.Append(kvp.Value.LineNumber + ",");
                    line.Append(kvp.Value.AspxControl + ",");
                    line.Append(kvp.Value.CodeBehind + ",");
                    line.Append(kvp.Value.Path);
                    csvFileWriter.WriteLine(line);
                    line.Clear();
                }
            }

            csvFileWriter.Flush();
            csvFileWriter.Close();
        }

        /// <summary>
        /// Export aspx page grid to csv text file.
        /// </summary>
        /// <param name="saveCSV">Where file is to be outputted to.</param>
        public void ExportPagesToCSV(string saveCSV)
        {
            System.IO.StreamWriter csvFileWriter = new StreamWriter(saveCSV, false);
            string columnHeaderText = "Alert, Page, Directory";
            csvFileWriter.WriteLine(columnHeaderText);
            StringBuilder line = new StringBuilder();
            foreach (KeyValuePair<string, Scanner.ASPXPageProperties> kvp in Scanner.AspxPages)
            {
                 if ((kvp.Value.PageMessages != null) && (kvp.Value.PageMessages.Count > 0))
                 {
                        line.Append("Y,");
                 }
                 else
                 {
                        line.Append(string.Empty + ",");
                 }

                    line.Append(kvp.Value.FileName + ",");
                    line.Append(kvp.Value.Path + ",");
                    csvFileWriter.WriteLine(line);
                    line.Clear();
                }

            csvFileWriter.Flush();
            csvFileWriter.Close();
        }
    } // end of class
} // end of namespace
