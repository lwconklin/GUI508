// <copyright file="RegexParser.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the RegexParser class.</summary>
namespace GUI508 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// ASPX controls for Link and Radio buttons.
    /// </summary>
    public class RegexParser 
    {
        /// <summary>
        /// Regex expression to find terminating end of a control.
        /// </summary>
        private static readonly Regex EndControl = new Regex(@"/>");

        /// <summary>
        /// Represents the results from a single regular expression match.
        /// </summary>
        private static Match m;

        /// <summary>
        /// First line of text in an aspx page.
        /// </summary>
        private static string header;

        /// <summary>
        /// Gets or sets code behind page.
        /// </summary>
        /// <value>File Name.</value>
        public static string CodeBehind { get; set; }

        /// <summary>
        /// Gets or sets code behind page.
        /// </summary>
        /// <value>File Name.</value>
        public static string Culture { get; set; }

        /// <summary>
        /// Gets or sets aspx control id.
        /// </summary>
        /// <value>Aspx control id.</value>
        public static string ControlId { get; set; }

        /// <summary>
        /// Searches an aspx page to find aspx server side controls by type of control.
        /// </summary>
        /// <param name="l">List array of aspx page.</param>
        /// <param name="complete">Complete regex expression.</param>
        /// <param name="beginning">Beginning regex expression.</param>
        /// <param name="aspxControls">Dictionary of aspx controls.</param>
        /// <param name="fileName">Code Behind page.</param>
        /// <param name="fileDirectoryName">Folder location of aspx page.</param>
        /// <param name="controlType">Type of aspx server side control.</param>
        /// <returns>Return set of aspx controls.</returns>
        public static Dictionary<Guid, Scanner.ASPXControlProperties> FindControl(List<string> l, Regex complete, Regex beginning, Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls, string fileName, string fileDirectoryName, string controlType) 
        {
            var pIndex = 0; // primary index
            var sIndex = 0; // secondary index
            List<string> control = new List<string>();
            var end = string.Empty;
            var s = string.Empty;
            var indexOf = 0;
            header = l[0];
            GetASPXHeaderCulture(header);
            GetASPXPageName(header);
            while (pIndex <= l.Count - 1) 
            {
                s = l[pIndex].Trim();
                m = complete.Match(s);
                if (m.Success) 
                {
                    indexOf = s.IndexOf("/>");
                    if (indexOf > 0) 
                    {
                        if (indexOf < s.Length - 1) 
                        {
                            s = s.Substring(0, indexOf + 2);
                        }
                    }

                    indexOf = s.IndexOf("<asp");  // take off text if off of string in front of control
                    if (indexOf >= 1) 
                    {
                        s = s.Substring(indexOf, s.Length - indexOf);
                    }

                    control.Add(s.Trim());
                    FoundControl(aspxControls, control, fileName, fileDirectoryName, pIndex, controlType);
                    break;
                }

                if (!m.Success) 
                {
                    m = beginning.Match(s); ////aspx component is on multiple lines
                    if (m.Success) 
                    {
                        control.Add(s.Trim());
                        sIndex = pIndex + 1;  // Start on next line
                    }
                }

                if (m.Success) 
                { ////get rest of lines until we see end in component. Strip remaining text after end of control
                    while (sIndex <= l.Count - 1) 
                    {
                        m = EndControl.Match(l[sIndex]);
                        if (!m.Success) 
                        {
                            control.Add(l[sIndex].Trim());
                        }
                        else 
                        {
                            indexOf = l[sIndex].IndexOf("/>");
                            if (indexOf > 0) 
                            {
                                if (indexOf < l[sIndex].Length) 
                                {
                                    end = l[sIndex].Substring(0, indexOf + 2);
                                    control.Add(end.Trim());
                                    FoundControl(aspxControls, control, fileName, fileDirectoryName, pIndex, controlType);
                                    pIndex = sIndex; // skip over control that was found, so we can find next control
                                    sIndex = 0;
                                    break;
                                }
                                else 
                                {
                                    control.Add(l[sIndex].Trim());
                                    m = EndControl.Match(l[sIndex].Trim());
                                    if (m.Success) 
                                    { // Check to make sure we are not at the end of the control. If we are output control and search for next control
                                        FoundControl(aspxControls, control, fileName, fileDirectoryName, pIndex, controlType);
                                    pIndex = sIndex; // skip over control that was found, so we can find next control
                                    sIndex = 0;
                                    break;
                                    }
                                }
                            }

                             indexOf = l[sIndex].IndexOf(">");
                             if (indexOf > 0) 
                             {
                                 if (indexOf < l[sIndex].Length - 1) 
                                 {
                                     end = l[sIndex].Substring(0, indexOf + 1);
                                     control[control.Count - 1] = end.Trim();
                                     FoundControl(aspxControls, control, fileName, fileDirectoryName, pIndex, controlType);
                                     pIndex = sIndex; // skip over control that was found, so we can find next control
                                     sIndex = 0;
                                     break;
                                 }
                             }
                        }

                        sIndex++;
                    }
                }

               pIndex++;
            }

        return aspxControls;
        }

        /// <summary>
        /// Saves aspx server side control.
        /// </summary>
        /// <param name="aspxControls">Dictionary of ASPX Controls.</param>
        /// <param name="control">Aspx server side control.</param>
        /// <param name="fileName">Code behind page.</param>
        /// <param name="fileDirectoryName">Location of folder of aspx page.</param>
        /// <param name="lineNumber">Line number.</param>
        /// <param name="controlType">Aspx server side control name.</param>
        private static void FoundControl(Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls, List<string> control, string fileName, string fileDirectoryName, int lineNumber, string controlType) 
        {
            CreateAspxControlString(control);
            SaveInformation(aspxControls, control, fileName, fileDirectoryName, lineNumber, controlType);
            control.Clear();
        }

        /// <summary>
        /// Remove tabs/newlines and concatenate the ASPX control into a single string.
        /// </summary>
        /// <param name="control">Actual aspx control in a string array.</param>
        /// <returns>Returns a single string of an aspx control from a list array.</returns>
        private static string CreateAspxControlString(List<string> control) 
        {
            string aspx_control = string.Empty;
            StringBuilder sb = new StringBuilder();
            if (control.Count > 0) 
            {
                foreach (string s in control) 
                {
                    aspx_control = Regex.Replace(s, @"\t|\n|\r", string.Empty);
                    sb.Append(aspx_control.Trim());
                    aspx_control = string.Empty;
                }
            }

            return sb.ToString().Trim();
        }

        /// <summary>
        /// Saves aspx server side control to dictionary.
        /// </summary>
        /// <param name="aspxControls">Dictionary of aspx controls.</param>
        /// <param name="control">List array of aspx control.</param>
        /// <param name="fileName">Aspx page name.</param>
        /// <param name="fileDirectoryName">Location of aspx.</param>
        /// <param name="lineNumber">Line Number.</param>
        /// <param name="controlType">Aspx server side control name.</param>
        private static void SaveInformation(Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls, List<string> control, string fileName, string fileDirectoryName, int lineNumber, string controlType) 
        {
            Scanner.ASPXControlProperties aspxControlProperties = new Scanner.ASPXControlProperties();
            aspxControlProperties.FileName = fileName;
            aspxControlProperties.Path = fileDirectoryName;
            aspxControlProperties.Culture = Culture;
            aspxControlProperties.CodeBehind = CodeBehind;
            aspxControlProperties.LineNumber = lineNumber + 1;
            aspxControlProperties.AspxControl = CreateAspxControlString(control);
            aspxControlProperties.ControlType = controlType;
            aspxControlProperties.ControlID = GetAnASPXControlId(aspxControlProperties.AspxControl);
            aspxControls.Add(Guid.NewGuid(), aspxControlProperties);
        }

        /// <summary>
        /// Gets Culture attribute(s) from header line in an aspx page.  Page UICulture="es" Culture="es". 
        /// </summary>
        /// <param name="header">Header record.</param>
        private static void GetASPXHeaderCulture(string header) 
        {
            Regex culture = new Regex(@"Culture=([\s\S]*?)", RegexOptions.IgnoreCase);
            Match m = culture.Match(header);
            if (m.Success)
            {
                string codeBehindValuePattern = @"Culture=""(.*?)""";
                Regex regex = new Regex(codeBehindValuePattern, RegexOptions.Singleline);
                MatchCollection collection = regex.Matches(header);
                Match m1 = collection[0];
                if (m1.Groups[1].Value.Equals(string.Empty))
                {
                    Culture = string.Empty;
                }
                else
                {
                    Culture = m1.Groups[1].Value;
                }
            }
        }

        /// <summary>
        /// Get the code behind file name from aspx page header.
        /// </summary>
        /// <param name="header">Header record.</param>
        private static void GetASPXPageName(string header) 
        {
            Regex codeBehind = new Regex(@"CodeFile=([\s\S]*?)", RegexOptions.IgnoreCase);
            Match m = codeBehind.Match(header);
            if (m.Success)
            {
                string codeBehindValuePattern = @"CodeFile=""(.*?)""";
                Regex regex = new Regex(codeBehindValuePattern, RegexOptions.Singleline);
                MatchCollection collection = regex.Matches(header);
                Match m1 = collection[0];
                if (m1.Groups[1].Value.Equals(string.Empty))
                {
                    CodeBehind = string.Empty;
                }
                else
                {
                    CodeBehind = m1.Groups[1].Value;
                }
            }
        }

        /// <summary>
        /// Get the aspx control id.
        /// </summary>
        /// <param name="control">Header record.</param>
        /// <returns>Returns a single string of an aspx control id.</returns>
        private static string GetAnASPXControlId(string control)
        {
            Regex id = new Regex(@"ID=\\([\s\S]*?)", RegexOptions.IgnoreCase);
            Match m = id.Match(header);
            if (m.Success)
            {
                string idValuePattern = @"ID=""(.*?)""";
                Regex regex = new Regex(idValuePattern, RegexOptions.Singleline);
                MatchCollection collection = regex.Matches(header);
                Match m1 = collection[0];
                if (m1.Groups[1].Value.Equals(string.Empty))
                {
                   return string.Empty;
                }
                else
                {
                    return m1.Groups[1].Value;
                }
            }

            return string.Empty;
        }
    } // end of class
} // end of namespace
