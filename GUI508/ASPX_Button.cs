// <copyright file="ASPX_Button.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the ASPX_Button class.</summary>
namespace GUI508 
{
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/// <summary>
/// ASPX controls for Link and Radio buttons.
/// </summary>
public class ASPX_Button 
    {
        /// <summary>
        /// Regex expression for a radio button on one line.
        /// </summary>
        private Regex radioComplete;

        /// <summary>
        /// Regex expression for the beginning part of radio button.
        /// </summary>
        private Regex radioBeginning;

        /// <summary>
        /// Regex expression for a link button on one line.
        /// </summary>
        private Regex linkButtonComplete;

        /// <summary>
        /// Regex expression for the beginning part of link button.
        /// </summary>
        private Regex linkButtonBeginning;

        /// <summary>
        /// Initializes a new instance of the <see cref="ASPX_Button"/> class.
        /// </summary>
        public ASPX_Button() 
        {
            this.radioComplete = new Regex(@"<asp:RadioButton ([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.radioBeginning = new Regex(@"<asp:RadioButton ([\s\S]*?)", RegexOptions.IgnoreCase);
            this.linkButtonComplete = new Regex(@"<asp:LinkButton ([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.linkButtonBeginning = new Regex(@"<asp:LinkButton ([\s\S]*?)", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Send aspx page to parser to find radio buttons.
        /// </summary>
        /// <param name="list">ASPX page.</param>
        /// <param name="aspxControls">ASPX to find.</param>    
        /// <param name="fileName">ASPX page file name.</param>
        /// <param name="fileDirectoryName">Directory location of aspx file.</param>
        /// <returns>Dictionary with an object for each radio button found on this page.</returns>
        public Dictionary<Guid, Scanner.ASPXControlProperties> ParseRadioButton(List<string> list, Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls, string fileName, string fileDirectoryName) 
        {
            Dictionary<Guid, Scanner.ASPXControlProperties> dic = RegexParser.FindControl(list, this.radioComplete, this.radioBeginning, aspxControls, fileName, fileDirectoryName, "asp:RadioButton");
            Validation.ValidateRadioButtons(ref dic);
            return dic;
        }

        /// <summary>
        /// Send aspx page to parser to find link buttons.
        /// </summary>
        /// <param name="list">ASPX page.</param>
        /// <param name="aspxControls">ASPX to find.</param>    
        /// <param name="fileName">ASPX page file name.</param>
        /// <param name="fileDirectoryName">Directory location of aspx file.</param>
        /// <returns>Dictionary with an object for each link button found on this page.</returns>
        public Dictionary<Guid, Scanner.ASPXControlProperties> ParseLinkButton(List<string> list, Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls, string fileName, string fileDirectoryName) 
        {
            Dictionary<Guid, Scanner.ASPXControlProperties> dic = RegexParser.FindControl(list, this.linkButtonComplete, this.linkButtonBeginning, aspxControls, fileName, fileDirectoryName, "asp:LinkButton");
            Validation.ValidateImage(ref dic);
            return dic;
        }
    } // end of class
} // end of namespace
