// <copyright file="Scanner.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the Scanner class.</summary>
namespace GUI508 
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Driver to control what needs to be scanned.
    /// </summary>
    public class Scanner 
    {
        /// <summary>
        /// Sorted dictionary used by GUI grid for page issues.
        /// </summary>
        public static SortedDictionary<string, Scanner.ASPXPageProperties> AspxPages = new SortedDictionary<string, Scanner.ASPXPageProperties>();

        /// <summary>
        /// Sorted dictionary used by GUI grid.
        /// </summary>
        private static SortedDictionary<string, Scanner.ASPXControlProperties> aspxControls = new SortedDictionary<string, Scanner.ASPXControlProperties>();

        /// <summary>
        /// Definition of list array of strings used to represents an aspx page.
        /// </summary>
        private List<string> aspxFiles;

        /// <summary>
        /// List array of an aspx page.
        /// </summary>
        private List<string> list;

        /// <summary>
        /// Definition of class ASPX_Image.
        /// </summary>
        private ASPX_Image image;

        /// <summary>
        /// Definition of class ASPX_Button.
        /// </summary>
        private ASPX_Button button;

        /// <summary>
        /// Definition of class Html Class.
        /// </summary>
        private HtmlHeader htmlHeader;

        /// <summary>
        /// Definition of class ASPX_Literal Class.
        /// </summary>
        private ASPX_Literal literal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Scanner"/> class.
        /// </summary>
        public Scanner()
        {
            this.aspxFiles = new List<string>();
            this.list = new List<string>();
            this.image = new ASPX_Image();
            this.button = new ASPX_Button();
            this.htmlHeader = new HtmlHeader();
            this.literal = new ASPX_Literal();
        }

        /// <summary>
        /// Gets a sorted dictionary of aspx controls.
        /// </summary>
        /// <value>Aspx controls dictionary.</value>
        public static SortedDictionary<string, Scanner.ASPXControlProperties> AspxControlsSorted 
        { 
            get 
            { 
                return aspxControls; 
            } 
        } 

        /// <summary>
        /// Run scans.
        /// </summary>
        public void ASPXScan() 
        {
            Dictionary<Guid, Scanner.ASPXControlProperties> aspxControl = new Dictionary<Guid, Scanner.ASPXControlProperties>();
            foreach (string file in this.aspxFiles) 
            {
                this.CreateFileListing(file);
                FileInfo fileInfo = new FileInfo(file);
                StartUpInitialization.AspxList.ForEach(delegate(StartUpInitialization.AspxControlInformation aci)
                {
                     if (aci.IsParsable.Equals(true)) 
                     {
                        aspxControl = RegexParser.FindControl(list, aci.RegexComplete, aci.RegexBeginning, aspxControl, fileInfo.Name, fileInfo.DirectoryName, aci.ControlName);
                        if (aspxControl.Count > 0)
                        {
                            Validation.Validate(ref aspxControl, aci.ControlName);
                            this.AddToMasterDictionary(aspxControl);
                            aspxControl.Clear();
                        }
                     }
                 });
                this.list.Clear();
            }

            Validation.ValidatePageAttributes(AspxControlsSorted); 
        }
        
        /// <summary>
        /// Find only aspx pages in folders.
        /// </summary>
        /// <param name="targetDirectory">Folder to be searched.</param>
        public void DirectorySearch(string targetDirectory) 
        {
            List<string> fileEntries = new List<string>();
            string[] dirs = Directory.GetDirectories(targetDirectory);
            if (dirs.Length.Equals(0)) 
            {
                this.ProcessDirectory(targetDirectory);
            }
            else 
            {
                foreach (string s in dirs) 
                {
                    this.ProcessDirectory(s);
                }
            }
        }

        /// <summary>
        /// Search folder.
        /// </summary>
        /// <param name="s">Folder name.</param>
        private void ProcessDirectory(string s) 
        {
           string[] files = Directory.GetFiles(s, "*.aspx");
           foreach (string file in files) 
           {
               this.aspxFiles.Add(file);
           }
       }

        /// <summary>
        /// Add individual aspx controls to master list.
        /// </summary>
        /// <param name="aspxControl"> Dictionary of aspx controls.</param>
        private void AddToMasterDictionary(Dictionary<Guid, Scanner.ASPXControlProperties> aspxControl) 
        {
            string key = string.Empty;
            foreach (KeyValuePair<Guid, Scanner.ASPXControlProperties> kvp in aspxControl) 
            {
                if (aspxControl.Count > 0) 
                {
                    key = kvp.Value.FileName + kvp.Key.ToString();
                    aspxControls.Add(key, kvp.Value);
                }
            }
        }

        /// <summary>
        /// Create a list array of an aspx page.
        /// </summary>
        /// <param name="file">Aspx file name.</param>
        private void CreateFileListing(string file) 
        {
            string line;
            using (StreamReader r = new StreamReader(file)) 
            {
                while ((line = r.ReadLine()) != null) 
                {
                    this.list.Add(line);
                }
            }
         }

        /// <summary>
        /// Different parts of an aspx control on an aspx page.
        /// </summary>
        public struct ASPXControlProperties
        {
            /// <summary>
            /// Array list indicating 508/accessibility complaint or not message numbers per individual aspx control.
            /// </summary>
            /// <value>Error Message.</value>
            public List<string> ControlMessages;

            /// <summary>
            /// Gets or sets the culture default.
            /// </summary>
            /// <value>Name of culture used.</value>
            public string Culture { get; set; }

            /// <summary>
            /// Gets or sets the file name of aspx page.
            /// </summary>
            /// <value>File Name.</value>
            public string FileName { get; set; }

            /// <summary>
            /// Gets or sets location of aspx page.
            /// </summary>
            /// <value>File path.</value>
            public string Path { get; set; }

            /// <summary>
            /// Gets or sets line number of the control of where it was found on the aspx page.
            /// </summary>
            /// <value>Line Number.</value>
            public int LineNumber { get; set; }

            /// <summary>
            /// Gets or sets aspx server side control name.
            /// </summary>
            /// <value>Aspx Control Id.</value>
            public string AspxControl { get; set; }

            /// <summary>
            /// Gets or sets code behind page.
            /// </summary>
            /// <value>File Name.</value>
            public string CodeBehind { get; set; }

            /// <summary>
            /// Gets or sets aspx server side control name.
            /// </summary>
            /// <value>ASPX control type.</value>
            public string ControlType { get; set; }

            /// <summary>
            /// Gets or sets aspx server side control id.
            /// </summary>
            /// <value>ASPX control id.</value>
            public string ControlID { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether the item is in error status.
            /// </summary>
            /// <value>Error Status.</value>
            public bool Status { get; set; }
        }

         /// <summary>
        /// Different parts of an aspx page.
        /// </summary>
        public struct ASPXPageProperties
        {
            /// <summary>
            /// Array list indicating 508 accessibility messages. 
            /// </summary>
            /// <value>Error Message.</value>
            public List<string> PageMessages;

            /// <summary>
            /// Gets or sets the culture default.
            /// </summary>
            /// <value>Name of culture used.</value>
            public string Culture { get; set; }

            /// <summary>
            /// Gets or sets the file name of aspx page.
            /// </summary>
            /// <value>File Name.</value>
            public string FileName { get; set; }

            /// <summary>
            /// Gets or sets location of aspx page.
            /// </summary>
            /// <value>File path.</value>
            public string Path { get; set; }

            /// <summary>
            /// Gets or sets asp.net controls on an aspx page.
            /// </summary>
            /// <value>Total Number of Control per Page.</value>
            public int NumberOfControls { get; set; }
        }
    } //// end of class
} //// end of namespace
