// <copyright file="HtmlHeader.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the HtmlHeader class.</summary>
namespace GUI508
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// HTML heading tags.
    /// </summary>
    public class HtmlHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlHeader"/> class.
        ///   We want aspx page to use heading tags in this fashion.
        /// </summary>
        public HtmlHeader()
        {
        }

        /// <summary>
        /// Send aspx page to parser to HTML header tags.
        /// </summary>
        /// <param name="list">ASPX page.</param>
        /// <param name="aspxControls">ASPX to find.</param>    
        /// <param name="fileName">ASPX page file name.</param>
        /// <param name="fileDirectoryName">Directory location of aspx file.</param>
        /// <returns>Dictionary with an object for each header tag found on this page.</returns>
        public Dictionary<Guid, Scanner.ASPXControlProperties> ParseHeaderTag(List<string> list, Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls, string fileName, string fileDirectoryName)
        {
            Regex headerComplete = new Regex(@"<h1([\s\S]*?)</h1>", RegexOptions.IgnoreCase);
            Regex headerBeginning = new Regex(@"<h1([\s\S]*?)", RegexOptions.IgnoreCase);
            Dictionary<Guid, Scanner.ASPXControlProperties> dic = RegexParser.FindControl(list, headerComplete, headerBeginning, aspxControls, fileName, fileDirectoryName, "HeaderTags");
            return dic;
        }
    } // end of class
} // end of namespace
