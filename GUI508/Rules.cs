// <copyright file="Rules.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the Rules class.</summary>
namespace GUI508 
{
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Rules to determine if ASPX controls have weakness in 508 compliance.
    /// </summary>
    public class Rules 
    {
        /// <summary>
        /// Is Alternate Text used or not blank by this control.
        /// </summary>
        /// <param name="aspxControlProperties">Individual ASPX Control.</param>
        public static void AlternateText(ref Scanner.ASPXControlProperties aspxControlProperties) 
        {
            Regex alt = new Regex(@"AlternateText=([\s\S]*?)", RegexOptions.IgnoreCase);
            Match m = alt.Match(aspxControlProperties.AspxControl);
            if (m.Success) 
            {
                string altValuePattern = @"AlternateText=""(.*?)""";
                Regex regex = new Regex(altValuePattern, RegexOptions.Singleline);
                MatchCollection collection = regex.Matches(aspxControlProperties.AspxControl);
                Match m1 = collection[0];
                var value = m1.Groups[1].Value;
                if (value.Equals(string.Empty)) 
                {
                    aspxControlProperties.ControlMessages.Add("IMG0001");
                    aspxControlProperties.ErrorStatus = true;
                }
                else 
                {
                    return;
                }
            }
            else 
            {
                AccessibleHeader(ref aspxControlProperties);
            }
        }

        /// <summary>
        /// Is Accessible Header Text used or not blank by this control.
        /// </summary>
        /// <param name="aspxControlProperties">Individual ASPX Control.</param>
        public static void AccessibleHeader(ref Scanner.ASPXControlProperties aspxControlProperties) 
        {
            Regex accessibleHeader = new Regex(@"AccessibleHeaderText=([\s\S]*?)", RegexOptions.IgnoreCase);
            Match m = accessibleHeader.Match(aspxControlProperties.AspxControl);
            if (m.Success) 
            {
                string accessibleValuePattern = @"AccessibleHeaderText=""(.*?)""";
                Regex regex2 = new Regex(accessibleValuePattern, RegexOptions.Singleline);
                MatchCollection collection = regex2.Matches(aspxControlProperties.AspxControl);
                Match m1 = collection[0];
                var value = m1.Groups[1].Value;
                if (value.Equals(string.Empty)) 
                {
                    aspxControlProperties.ControlMessages.Add("IMG0001");
                    aspxControlProperties.ErrorStatus = true;
                    return;
                }
                else 
                {
                    return;
                }
            }
            else 
            {
                aspxControlProperties.ControlMessages.Add("IMG0001");
                aspxControlProperties.ErrorStatus = true;
            }
        }

         /// <summary>
         /// Is tab index being used by an asp net control.
         /// </summary>
        /// <param name="aspxControlProperties">Individual ASPX Control.</param>
        /// <param name="page">Individual ASPX page.</param>
         /// <returns>Tue if control uses tab index.</returns>
        public static bool TabIndex(Scanner.ASPXControlProperties aspxControlProperties, ref Scanner.ASPXPageProperties page)
        {
            bool status = false;
            string pattern = @"tabindex=\d[1-9]\w*";
            Regex tabIndex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (tabIndex.IsMatch(RemoveWhiteSpaces(aspxControlProperties.AspxControl)))
            {
                status = true;
            }

            return status;
        }
 
        /// <summary>
        /// Is autopost used on aspx server-side control.
        /// </summary>
        /// <param name="aspxControlProperties">Individual ASPX Control.</param>
        /// <param name="page">Individual ASPX Page.</param>
        /// <returns>True if control uses autopost.</returns>
        public static bool Autopost(Scanner.ASPXControlProperties aspxControlProperties, ref Scanner.ASPXPageProperties page)
        {
            bool status = false;
            string pattern = @"autopostback\w*"; 
            Regex autopost = new Regex(pattern, RegexOptions.IgnoreCase);
            if (autopost.IsMatch(RemoveWhiteSpaces(aspxControlProperties.AspxControl)))
            {
                status = true;
            }

            return status;
        }

        /// <summary>
        /// Validate header tags H1 thru H6 tags. 
        /// </summary>
        /// <param name="page">ASPX Page Properties.</param>
        /// <param name="tags">List of html header tags.</param>
        public static void HeaderTags(ref Scanner.ASPXPageProperties page, List<string> tags)
        {
            int tagIndex = 1;
            Match m;
           
            int index = 0;
            if (tags.Count.Equals(0))
            {
                page.PageMessages.Add("PAG003");
            }
            else
            {
                while (tagIndex <= tags.Count) 
                {
                    string pattern = string.Format(@"<h{0}>", tagIndex);
                    Regex h = new Regex(pattern, RegexOptions.IgnoreCase);
                    m = h.Match(RemoveWhiteSpaces(tags[0]));
                    if (m.Success.Equals(true))
                    {
                        page.PageMessages.Add("PAG005");
                    }

                    index++;
                    tagIndex++;
                }
            }
        }

        /// <summary>
        /// Remove white space, quotes, and capitalization in a string to help regx pattern matching.
        /// </summary>
        /// <param name="str">Aspx control string.</param>
        /// <returns>String of aspx control modified to help with parsing.</returns>
        public static string RemoveWhiteSpaces(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '=')
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().ToLower();
        }
    } // end of class
} // end of namespace
