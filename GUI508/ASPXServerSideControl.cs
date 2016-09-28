// <copyright file="ASPXServerSideControl.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the User Interface class.</summary>
namespace GUI508
{
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    /// <summary>
    /// Winform UI to display details of a selected aspx server-side control.
    /// </summary>
    public partial class ASPXServerSideControl : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ASPXServerSideControl"/> class.
        /// </summary>
        public ASPXServerSideControl()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Displays details concerning a selected aspx server side control.
        /// </summary>
        /// <param name="aspxControlProperties">Struct of properties about a server-side control.</param>
        public void FillForm(Scanner.ASPXControlProperties aspxControlProperties)
        {
            aspxPageFolder.Text = aspxControlProperties.FileName;
            codeBehindFolder.Text = aspxControlProperties.CodeBehind;
            lineNumber.Text = lineNumber.Text + " " + aspxControlProperties.LineNumber;
            foreach (string line in this.CreatePrettyListing(aspxControlProperties.AspxControl))
            {
                listASPX.Items.Add(line.Trim());
            }

            listASPX.Items.Add(Environment.NewLine);
            listMessages.Items.Clear();
            if (aspxControlProperties.ControlMessages != null)
            {
                List<string> l = new List<string>();
                foreach (string errorId in aspxControlProperties.ControlMessages)
                {
                    l = GuideLineMessages.Messages[errorId];
                    foreach (string s in l)
                    {
                        listMessages.Items.Add(s);
                    }

                    listMessages.Items.Add(Environment.NewLine);
                }
            }
        }

        /// <summary>
        /// Creates a pretty version of aspx control in horizontal format.
        /// </summary>
        /// <param name="aspxControl">Vertical string of an aspx control.</param>
        /// <returns>Generic List.</returns>
        private List<string> CreatePrettyListing(string aspxControl)
        {
            List<string> listing = new List<string>();
            bool first = false;
            char[] s = new char[5120];
            int index = 0;
            foreach (char c in aspxControl)
            {
                if (c.Equals('"'))
                {
                    if (!first.Equals(true))
                    {
                        s[index] = c;
                        index++;
                        first = true;
                    }
                    else
                    {
                        first = false;
                        s[index] = c;
                        listing.Add(new string(s));
                        Array.Clear(s, 0, s.Length);
                        index = 0;
                    }
                }
                else
                {
                    if (c.Equals(' ') && (!index.Equals(0)))
                    {
                        if (!first.Equals(true))
                        {
                            listing.Add(new string(s));
                            Array.Clear(s, 0, s.Length);
                            index = 0;
                        }
                        else
                        {
                            s[index] = c;
                            index++;
                        }
                    }
                    else
                    {
                        s[index] = c;
                        index++;
                    }
                }
            }

            listing.Add(new string(s));
            return listing;
        }
    } // end of class
} // end of namespace
