// <copyright file="Validation.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the Validation class.</summary>
namespace GUI508 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class that performs 508/accessibility validation, concerns/hints.
    /// </summary>
    public class Validation 
    {
        /// <summary>
        /// Driver of what validation methods for each control to be used in validation.
        /// </summary>
        /// <param name="aspxControls">Scanner ASPX Control Properties.</param>
        /// <param name="controlName">ASPX name.</param>
        public static void Validate(ref Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls, string controlName)
        {
            switch (controlName)
            {
                case "asp:Image":
                    ValidateImage(ref aspxControls);
                    break;
                case "asp:ImageButton":
                    ValidateImageButton(ref aspxControls);
                    break;
                case "asp:ImageMap":
                    ValidateImageMap(ref aspxControls);
                    break;
                case "<asp:RadioButton":
                    ValidateRadioButtons(ref aspxControls);
                    break;
                case "asp:LinkButton":
                    ValidateLiteral(ref aspxControls);
                    break;
                case "asp:Literal":
                    ValidateLiteral(ref aspxControls);
                    break;
                default:
                    NonValidatedControls(ref aspxControls);
                    break;
            }
        }

        /// <summary>
        /// Validate ASPX Image Button.
        /// </summary>
        /// <param name="aspxControls">Dictionary of aspx controls found.</param>
        public static void ValidateImageButton(ref Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls)
        {
            Scanner.ASPXControlProperties aspxControlProperties = new Scanner.ASPXControlProperties();
            foreach (KeyValuePair<Guid, Scanner.ASPXControlProperties> kvp in aspxControls.ToArray()) 
            {
                 if (aspxControls.Count > 0) 
                 {
                    aspxControlProperties = kvp.Value;
                    aspxControlProperties.ControlMessages = new List<string>();
                    Rules.AlternateText(ref aspxControlProperties);
                    aspxControls[kvp.Key] = aspxControlProperties;
                }
            }
        }

        /// <summary>
        /// Validate ASPX Image.
        /// </summary>
        /// <param name="aspxControls">Dictionary of aspx controls found.</param>
        public static void ValidateImage(ref Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls) 
        {
            Scanner.ASPXControlProperties aspxControlProperties = new Scanner.ASPXControlProperties();
            foreach (KeyValuePair<Guid, Scanner.ASPXControlProperties> kvp in aspxControls.ToArray()) 
            {
                if (aspxControls.Count > 0) 
                {
                    aspxControlProperties = kvp.Value;
                    aspxControlProperties.ControlMessages = new List<string>();
                    Rules.AlternateText(ref aspxControlProperties);
                    aspxControls[kvp.Key] = aspxControlProperties;
                }
            }
        }

        /// <summary>
        ///  Validate ASPX ImageMap.
        /// </summary>
        /// <param name="aspxControls">Dictionary of aspx controls found.</param>
        public static void ValidateImageMap(ref Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls) 
        {
            Scanner.ASPXControlProperties aspxControlProperties = new Scanner.ASPXControlProperties();
            foreach (KeyValuePair<Guid, Scanner.ASPXControlProperties> kvp in aspxControls.ToArray()) 
            {
                if (aspxControls.Count > 0) 
                {
                    aspxControlProperties = kvp.Value;
                    aspxControlProperties.ControlMessages = new List<string>();
                    aspxControlProperties.ControlMessages.Add("IMG004");
                    aspxControls[kvp.Key] = aspxControlProperties;
                }
            }
        }

        /// <summary>
        ///  Validate ASPX Radio Buttons.
        /// </summary>
        /// <param name="aspxControls">Dictionary of aspx controls found.</param>
        public static void ValidateRadioButtons(ref Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls) 
        {
            Scanner.ASPXControlProperties aspxControlProperties = new Scanner.ASPXControlProperties();
            foreach (KeyValuePair<Guid, Scanner.ASPXControlProperties> kvp in aspxControls.ToArray()) 
            {
                if (aspxControls.Count > 0) 
                {
                    aspxControlProperties = kvp.Value;
                    aspxControlProperties.ControlMessages = new List<string>();
                    aspxControlProperties.ControlMessages.Add("RAD0001");
                    aspxControls[kvp.Key] = aspxControlProperties;
                }
            }
        }

        /// <summary>
        ///  Validate ASPX Literal.
        /// </summary>
        /// <param name="aspxControls">Dictionary of aspx controls found.</param>
        public static void ValidateLiteral(ref Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls) 
        {
            Scanner.ASPXControlProperties aspxControlProperties = new Scanner.ASPXControlProperties();
            foreach (KeyValuePair<Guid, Scanner.ASPXControlProperties> kvp in aspxControls.ToArray()) 
            {
                if (aspxControls.Count > 0) 
                {
                    aspxControlProperties = kvp.Value;
                    aspxControlProperties.ControlMessages = new List<string>();
                    aspxControlProperties.ControlMessages.Add("LIT0001");
                    aspxControls[kvp.Key] = aspxControlProperties;
                }
            }
        }

        /// <summary>
        ///  Non vaildated controls.
        /// </summary>
        /// <param name="aspxControls">Dictionary of aspx controls found.</param>
        public static void NonValidatedControls(ref Dictionary<Guid, Scanner.ASPXControlProperties> aspxControls) 
        {
            Scanner.ASPXControlProperties aspxControlProperties = new Scanner.ASPXControlProperties();
            foreach (KeyValuePair<Guid, Scanner.ASPXControlProperties> kvp in aspxControls.ToArray()) 
            {
                if (aspxControls.Count > 0) 
                {
                    aspxControlProperties = kvp.Value;
                    aspxControlProperties.ControlMessages = new List<string>();
                    aspxControlProperties.ControlMessages.Add("XXX0001");
                    aspxControls[kvp.Key] = aspxControlProperties;
                }
            }
        }

        /// <summary>
        /// Validate ASPX pages for Culture, Autopost, Tabindex.
        /// </summary>
        /// <param name="aspxControlsSorted">Sorted dictionary of individual asp net controls.</param>
        public static void ValidatePageAttributes(SortedDictionary<string, Scanner.ASPXControlProperties> aspxControlsSorted)
        {
            bool pageErrorAutoPost = false;
            bool pageErrorIndexTab = false;
            List<string> headerTags = new List<string>();
            if (aspxControlsSorted.Count > 0)
            {
            Scanner.ASPXPageProperties page = new Scanner.ASPXPageProperties();
            if (page.PageMessages == null)
            {
                page.PageMessages  = new List<string>();
            }

            page.FileName = string.Empty;
            Scanner.ASPXControlProperties aspxControlProperties = new Scanner.ASPXControlProperties();
            foreach (KeyValuePair<string, Scanner.ASPXControlProperties> kvp in aspxControlsSorted.ToArray())
            {
                aspxControlProperties = kvp.Value;
                if (page.FileName.Equals(string.Empty))
                {
                    page.FileName = aspxControlProperties.FileName;
                    page.Path = aspxControlProperties.Path;
                    page.NumberOfControls = 0;
                }

                if (!page.FileName.Equals(aspxControlProperties.FileName))
                {
                    Rules.HeaderTags(ref page, headerTags);
                    Scanner.AspxPages.Add(page.FileName, page);
                    headerTags.Clear();
                    page.FileName = aspxControlProperties.FileName;
                    page.Path = aspxControlProperties.Path;
                    page.NumberOfControls = 0;
                    pageErrorAutoPost = false;
                    pageErrorIndexTab = false;
                    page.PageMessages.Clear();
                }

                if (aspxControlProperties.ControlType.Equals("HeaderTags"))
                {
                    Rules.HeaderTags(ref page, headerTags);
                }
                else
                {
                    page.NumberOfControls++;
                    if (Rules.Autopost(aspxControlProperties, ref page).Equals(true)) 
                    {
                        if (pageErrorAutoPost.Equals(false))
                        {
                            pageErrorAutoPost = true;
                            page.PageMessages.Add("AUT001");
                        }
                    }

                    if (Rules.TabIndex(aspxControlProperties, ref page).Equals(true)) 
                    {
                        if (pageErrorIndexTab.Equals(false))
                        {
                            pageErrorIndexTab = true;
                            page.PageMessages.Add("TAB001");
                        }
                    }
                }
            }

            Scanner.AspxPages.Add(page.FileName, page);
            }
            ////todo: lanuage
            ////todo: display in new tab
        }
    } // end of class
} // end of namespace
//// https://msdn.microsoft.com/en-us/library/ms228004.aspx
