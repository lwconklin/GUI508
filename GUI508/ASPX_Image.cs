// <copyright file="ASPX_Image.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the ASPX_Image class.</summary>
namespace GUI508 
{
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/// <summary>
/// ASPX controls for Image ImageButton and ImageMap class.
/// </summary>
    public class ASPX_Image 
    {
        /// <summary>
        /// Regex expression for an Image  on one line.
        /// </summary>
        private Regex imageComplete;

        /// <summary>
        /// Regex expression for the beginning part of Image.
        /// </summary>
        private Regex imageBeginning;

        /// <summary>
        /// Regex expression for an ImageButton  on one line.
        /// </summary>
        private Regex imageButtonComplete;

        /// <summary>
        /// Regex expression for the beginning part of ImageButton.
        /// </summary>
        private Regex imageButtonBeginning;

        /// <summary>
        /// Regex expression for an ImageMap  on one line.
        /// </summary>
        private Regex imageMapComplete;

        /// <summary>
        /// Regex expression for the beginning part of ImageMap.
        /// </summary>
        private Regex imageMapBeginning;

        /// <summary>
        /// Initializes a new instance of the <see cref="ASPX_Image"/> class.
        /// </summary>
       public ASPX_Image()
       {
           this.imageComplete = new Regex(@"<asp:Image ([\s\S]*?)/>", RegexOptions.IgnoreCase);
           this.imageBeginning = new Regex(@"<asp:Image ([\s\S]*?)", RegexOptions.IgnoreCase);
           this.imageButtonComplete = new Regex(@"<asp:ImageButton ([\s\S]*?)/>", RegexOptions.IgnoreCase);
           this.imageButtonBeginning = new Regex(@"<asp:ImageButton ([\s\S]*?)", RegexOptions.IgnoreCase);
           this.imageMapComplete = new Regex(@"<asp:ImageMap ([\s\S]*?)/>", RegexOptions.IgnoreCase);
           this.imageMapBeginning = new Regex(@"<asp:ImageMap ([\s\S]*?)", RegexOptions.IgnoreCase);
        }

       /// <summary>
       /// Send aspx page to parser to find link buttons.
       /// </summary>
       /// <param name="list">ASPX page.</param>
       /// <param name="aspxControls">ASPX to find.</param>    
       /// <param name="fileName">ASPX page file name.</param>
       /// <param name="fileDirectoryName">Directory location of aspx file.</param>
       /// <returns>Dictionary with an object for each Image found on this page.</returns>
       public Dictionary<Guid, Scanner.ASPXControlProperties> ParseImage(List<string> list, Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls, string fileName, string fileDirectoryName) 
       {
           Dictionary<Guid, Scanner.ASPXControlProperties> dic = RegexParser.FindControl(list, this.imageComplete, this.imageBeginning, aspxControls, fileName, fileDirectoryName, "asp:Image");
           Validation.ValidateImage(ref dic);
           return dic;
       }

       /// <summary>
       /// Send aspx page to parser to find Image buttons.
       /// </summary>
       /// <param name="list">ASPX page.</param>
       /// <param name="aspxControls">ASPX to find.</param>    
       /// <param name="fileName">ASPX page file name.</param>
       /// <param name="fileDirectoryName">Directory location of aspx file.</param>
       /// <returns>Dictionary with an object for each ImageButton found on this page.</returns>
       public Dictionary<Guid, Scanner.ASPXControlProperties> ParseImageButton(List<string> list, Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls, string fileName, string fileDirectoryName) 
       {
           Dictionary<Guid, Scanner.ASPXControlProperties> dic = RegexParser.FindControl(list, this.imageButtonComplete, this.imageButtonBeginning, aspxControls, fileName, fileDirectoryName, "asp:ImageButton");
           Validation.ValidateImageButton(ref dic);
           return dic;
       }

       /// <summary>
       /// Send aspx page to parser to find ImageMap.
       /// </summary>
       /// <param name="list">ASPX page.</param>
       /// <param name="aspxControls">ASPX to find.</param>    
       /// <param name="fileName">ASPX page file name.</param>
       /// <param name="fileDirectoryName">Directory location of aspx file.</param>
       /// <returns>Dictionary with an object for each ImageMap found on this page.</returns>
       public Dictionary<Guid, Scanner.ASPXControlProperties> ParseImageMap(List<string> list, Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls, string fileName, string fileDirectoryName) 
       {
           Dictionary<Guid, Scanner.ASPXControlProperties> dic = RegexParser.FindControl(list, this.imageMapComplete, this.imageMapBeginning, aspxControls, fileName, fileDirectoryName, "asp:ImageMap");
           Validation.ValidateImageMap(ref dic);
           return dic;
       }
    } // end of class
} // end of namespace
