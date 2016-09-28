// <copyright file="ASPXPage.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the ASPXPage class.</summary>
namespace GUI508
{
using System;
using System.Windows.Forms;

    /// <summary>
    /// ASPX page class.
    /// </summary>
    public partial class ASPXPage : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ASPXPage"/> class.
        /// </summary>
        public ASPXPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Displays details concerning a selected aspx server side control.
        /// </summary>
        /// <param name="page">Struct of properties about a server-side control.</param>
        public void FillForm(Scanner.ASPXPageProperties page)
        {
            this.ASPXPageName.Text = this.ASPXPageName.Text + page.FileName;
            this.Directory.Text = this.Directory.Text + page.Path;

            foreach (string line in page.PageMessages)
            {
                listASPX.Items.Add(line.Trim());
                listMessages.Items.Add(Environment.NewLine);
            }

            listASPX.Items.Add(Environment.NewLine);
        }
    }
}
