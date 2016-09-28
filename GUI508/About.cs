// <copyright file="About.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>Basic application information.</summary>
namespace GUI508
{
using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

    /// <summary>
    /// Controls About box form.
    /// </summary>
    public partial class About : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="About"/> class.
        /// </summary>
        public About()
        {
            this.InitializeComponent();
            StringBuilder sb = new StringBuilder();
            this.Text = string.Format("About {0}", this.AssemblyTitle);
            this.labelVersion.Text = string.Format("Version {0}", this.AssemblyVersion);
            this.labelCopyright.Text = this.AssemblyCopyright;
            this.labelCompanyName.Text = this.AssemblyCompany;
            sb.AppendLine(this.AssemblyDescription);
            sb.Append(Environment.NewLine);
            sb.AppendLine("Author: Larry Conkin");
            sb.AppendLine("Application Email: ABC@ABC.org");
            sb.AppendLine("Twitter: @abc");
            sb.AppendLine("Facebook: blah@facebook.com");
            sb.AppendLine("Notes: https://msdn.microsoft.com/en-us/library/ms228004.aspx");
            this.textBoxDescription.Text = sb.ToString();
        }

        /// <summary>
        /// Gets or Sets the title of program.
        /// </summary>
        /// <value>Title of program.</value>
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != string.Empty)
                    {
                        return titleAttribute.Title;
                    }
                }

                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        /// Gets the version number of this program.
        /// </summary>
        /// <value>Version number program.</value>
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        /// <summary>
        /// Gets or Sets a brief description of this program.
        /// </summary>
        /// <value>Description of Program.</value>
        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }

                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        /// <summary>
        /// Gets for set the copyright this program is written under.
        /// </summary>
        /// <value>Copyright of program.</value>
        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }

                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        /// <summary>
        /// Gets the Company or Companies who helped in the development of the program.
        /// </summary>
        /// <value>The name of the company.</value>
        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }

                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
    } // end of class
} // end of namespace
