// <copyright file="StartUpInitialization.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>Initialization of the worker list of what controls are going to be scanned.</summary>
namespace GUI508
{
using System.Collections.Generic;
using System.Text.RegularExpressions;

    /// <summary>
    /// Before scanning to some preliminary initialization work.
    /// </summary>
    public class StartUpInitialization
    {
        /// <summary>
        /// List holding all ASPX controls.
        /// </summary>
        public static List<AspxControlInformation> AspxList = new List<AspxControlInformation>();

        /// <summary>
        /// Instantiation of Aspx Control Information.
        /// </summary>
        public AspxControlInformation Aci = new AspxControlInformation();

        /// <summary>
        /// Initial method to set up information about ASPX controls.
        /// </summary>
        public void Initalization()
        {
            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:Image";
            this.Aci.RegexComplete = new Regex(@"<asp:Image ([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:Image ([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:ImageButton";
            this.Aci.RegexComplete = new Regex(@"<asp:ImageButton ([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:ImageButton ([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:ImageMap";
            this.Aci.RegexComplete = new Regex(@"<asp:ImageMap ([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:ImageMap ([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:RadioButton";
            this.Aci.RegexComplete = new Regex(@"<asp:RadioButton ([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:RadioButton ([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:LinkButton";
            this.Aci.RegexComplete = new Regex(@"<asp:LinkButton ([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:LinkButton ([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:Literal";
            this.Aci.RegexComplete = new Regex(@"<asp:Literal ([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:Literal ([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "header";
            this.Aci.RegexComplete = new Regex(@"<h1([\s\S]*?)</h1>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<h1([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:Button";
            this.Aci.RegexComplete = new Regex(@"<asp:Button([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:Button([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:CheckBox";
            this.Aci.RegexComplete = new Regex(@"<asp:CheckBox([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:CheckBox([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:HyperLink";
            this.Aci.RegexComplete = new Regex(@"<asp:HyperLink([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:HyperLink([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:Label";
            this.Aci.RegexComplete = new Regex(@"<asp:Label([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:Label([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:Panel";
            this.Aci.RegexComplete = new Regex(@"<asp:Panel([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:Panel([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:PlaceHolder";
            this.Aci.RegexComplete = new Regex(@"<asp:PlaceHolder([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:PlaceHolder([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:Table";
            this.Aci.RegexComplete = new Regex(@"<asp:Table([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:Table([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:TableCell";
            this.Aci.RegexComplete = new Regex(@"<asp:TableCell([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:TableCell([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:TableRow";
            this.Aci.RegexComplete = new Regex(@"<asp:TableRow([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:TableRow([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:TextBox";
            this.Aci.RegexComplete = new Regex(@"<asp:TextBox([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:TextBox([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:repeater";
            this.Aci.RegexComplete = new Regex(@"<asp:repeater([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:repeater([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:ListBox";
            this.Aci.RegexComplete = new Regex(@"<asp:ListBox([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:ListBox([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:CheckBoxList";
            this.Aci.RegexComplete = new Regex(@"<asp:CheckBoxList([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:CheckBoxList([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:RadioButtonList";
            this.Aci.RegexComplete = new Regex(@"<asp:RadioButtonList([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:RadioButtonList([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:DataGrid";
            this.Aci.RegexComplete = new Regex(@"<asp:DataGrid([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:DataGrid([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:DropDownList";
            this.Aci.RegexComplete = new Regex(@"<asp:DropDownList([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:DropDownList([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:AdRotator";
            this.Aci.RegexComplete = new Regex(@"<asp:AdRotator([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:AdRotator([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:Calendar";
            this.Aci.RegexComplete = new Regex(@"<asp:Calendar([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:Calendar([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);

            this.Aci.IsParsable = true;
            this.Aci.ControlName = "asp:Xml";
            this.Aci.RegexComplete = new Regex(@"<asp:Xml([\s\S]*?)/>", RegexOptions.IgnoreCase);
            this.Aci.RegexBeginning = new Regex(@"<asp:Xml([\s\S]*?)", RegexOptions.IgnoreCase);
            AspxList.Add(this.Aci);
        }

        /// <summary>
        /// Struct to hold information about ASPX control to be scanned.
        /// </summary>
        public struct AspxControlInformation
        {
            /// <summary>
            /// Boolean field to let scanner know this ASPX control should be scanned.
            /// </summary>
            public bool IsParsable;

            /// <summary>
            /// String name of aspx control.
            /// </summary>
            public string ControlName;

            /// <summary>
            /// Regex expression for a complete aspx control on one line.
            /// </summary>
            public Regex RegexComplete;

            /// <summary>
            /// Regex expression if aspx control is on multiple lines.
            /// </summary>
            public Regex RegexBeginning;
        }
    } // end of class
} // end of namespace
