// <copyright file="ASPX_Literal.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the ASPX_Literal class.</summary>
namespace GUI508
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// ASPX controls for Literal class.
    /// </summary>
    public class ASPX_Literal
    {
        /// <summary>
        /// Regex expression for an Literal on one line.
        /// </summary>
        private Regex literalComplete;

        /// <summary>
        /// Regex expression for the beginning part of literal.
        /// </summary>
        private Regex literalBeginning;

        /// <summary>
        /// Initializes a new instance of the <see cref="ASPX_Literal"/> class.
        /// </summary>
        public ASPX_Literal()
        {
            this.literalComplete = new Regex(@"<asp:Literal ([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.literalBeginning = new Regex(@"<asp:Literal ([\s\S]*?)", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Send aspx page to parser to find literal control.
        /// </summary>
        /// <param name="list">ASPX page.</param>
        /// <param name="aspxControls">ASPX to find.</param>    
        /// <param name="fileName">ASPX page file name.</param>
        /// <param name="fileDirectoryName">Directory location of aspx file.</param>
        /// <returns>Dictionary with an object for each literal control found on this page.</returns>
        public Dictionary<Guid, Scanner.ASPXControlProperties> ParseLiteral(List<string> list, Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls, string fileName, string fileDirectoryName)
        {
            Dictionary<Guid, Scanner.ASPXControlProperties> dic = RegexParser.FindControl(list, this.literalComplete, this.literalBeginning, aspxControls, fileName, fileDirectoryName, "asp:Literal");
           Validation.ValidateLiteral(ref dic);
            return dic;
        }
    } // end of class
} // end of namespace
