// <copyright file="GUI.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
namespace GUI508 
{
    partial class GUI 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) 
        {
            if (disposing && (components != null)) 
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() 
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.GridViewControl = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.ASPXAlert = new System.Windows.Forms.DataGridViewImageColumn();
            this.ControlType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeBehind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dictionaryKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.exportASPNetControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.GridViewPage = new System.Windows.Forms.DataGridView();
            this.SelectPage = new System.Windows.Forms.DataGridViewImageColumn();
            this.AlertPage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ASPXPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectoryPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewControl)).BeginInit();
            this.Menu.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPage)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewControl
            // 
            this.GridViewControl.AllowUserToAddRows = false;
            this.GridViewControl.AllowUserToDeleteRows = false;
            this.GridViewControl.AllowUserToOrderColumns = true;
            this.GridViewControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.ASPXAlert,
            this.ControlType,
            this.Line,
            this.ControlString,
            this.CodeBehind,
            this.Directory,
            this.dictionaryKey});
            this.GridViewControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewControl.Location = new System.Drawing.Point(3, 3);
            this.GridViewControl.Name = "GridViewControl";
            this.GridViewControl.ReadOnly = true;
            this.GridViewControl.RowHeadersVisible = false;
            this.GridViewControl.RowTemplate.Height = 24;
            this.GridViewControl.Size = new System.Drawing.Size(1766, 587);
            this.GridViewControl.TabIndex = 0;
            this.GridViewControl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewControl_CellClick);
            this.GridViewControl.ColumnSortModeChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GridViewControl_ColumnSortModeChanged);
            this.GridViewControl.Sorted += new System.EventHandler(this.GridViewControl_Sorted);
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Select.HeaderText = "Select";
            this.Select.Image = global::GUI508.Properties.Resources.select_text;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Select.ToolTipText = "Select to see details";
            this.Select.Width = 53;
            // 
            // ASPXAlert
            // 
            this.ASPXAlert.HeaderText = "Alert";
            this.ASPXAlert.Name = "ASPXAlert";
            this.ASPXAlert.ReadOnly = true;
            this.ASPXAlert.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ASPXAlert.ToolTipText = "Alert";
            // 
            // ControlType
            // 
            this.ControlType.HeaderText = "ASP.Net Control Name";
            this.ControlType.Name = "ControlType";
            this.ControlType.ReadOnly = true;
            this.ControlType.ToolTipText = "ASPX Server-side Control";
            this.ControlType.Width = 180;
            // 
            // Line
            // 
            this.Line.HeaderText = "Line Number";
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.ToolTipText = "Line Number";
            // 
            // ControlString
            // 
            this.ControlString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ControlString.HeaderText = "ASP.Net Code";
            this.ControlString.Name = "ControlString";
            this.ControlString.ReadOnly = true;
            this.ControlString.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ControlString.ToolTipText = "Server-side control text";
            // 
            // CodeBehind
            // 
            this.CodeBehind.HeaderText = "Code Behind";
            this.CodeBehind.Name = "CodeBehind";
            this.CodeBehind.ReadOnly = true;
            this.CodeBehind.ToolTipText = "Code Behind";
            // 
            // Directory
            // 
            this.Directory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Directory.HeaderText = "Directory";
            this.Directory.Name = "Directory";
            this.Directory.ReadOnly = true;
            this.Directory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Directory.ToolTipText = "Directory";
            this.Directory.Width = 71;
            // 
            // dictionaryKey
            // 
            this.dictionaryKey.HeaderText = "";
            this.dictionaryKey.Name = "dictionaryKey";
            this.dictionaryKey.ReadOnly = true;
            this.dictionaryKey.Visible = false;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceCodeToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1780, 28);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuExport,
            this.mnuExit});
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.sourceCodeToolStripMenuItem.Text = "File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(208, 24);
            this.mnuFileOpen.Text = "Source Code Folder";
            this.mnuFileOpen.Click += new System.EventHandler(this.MnuFileOpen_Click);
            // 
            // mnuExport
            // 
            this.mnuExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportASPNetControlsToolStripMenuItem,
            this.exportPagesToolStripMenuItem});
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(208, 24);
            this.mnuExport.Text = "Export Data";
            this.mnuExport.Click += new System.EventHandler(this.MnuExport_Click);
            // 
            // exportASPNetControlsToolStripMenuItem
            // 
            this.exportASPNetControlsToolStripMenuItem.Name = "exportASPNetControlsToolStripMenuItem";
            this.exportASPNetControlsToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.exportASPNetControlsToolStripMenuItem.Text = "Export ASP .Net Controls";
            this.exportASPNetControlsToolStripMenuItem.Click += new System.EventHandler(this.ExportASPNetControlsToolStripMenuItem_Click);
            // 
            // exportPagesToolStripMenuItem
            // 
            this.exportPagesToolStripMenuItem.Name = "exportPagesToolStripMenuItem";
            this.exportPagesToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.exportPagesToolStripMenuItem.Text = "Export Pages";
            this.exportPagesToolStripMenuItem.Click += new System.EventHandler(this.ExportPagesToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(208, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(12, 24);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tab1);
            this.TabControl.Controls.Add(this.tab2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 28);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.ShowToolTips = true;
            this.TabControl.Size = new System.Drawing.Size(1780, 622);
            this.TabControl.TabIndex = 2;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.GridViewControl);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1772, 593);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "ASP.Net Controls";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.GridViewPage);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(1772, 593);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "ASPX Pages";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // GridViewPage
            // 
            this.GridViewPage.AllowUserToAddRows = false;
            this.GridViewPage.AllowUserToDeleteRows = false;
            this.GridViewPage.AllowUserToOrderColumns = true;
            this.GridViewPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectPage,
            this.AlertPage,
            this.ASPXPage,
            this.DirectoryPage});
            this.GridViewPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPage.Location = new System.Drawing.Point(3, 3);
            this.GridViewPage.Name = "GridViewPage";
            this.GridViewPage.ReadOnly = true;
            this.GridViewPage.RowHeadersVisible = false;
            this.GridViewPage.RowTemplate.Height = 24;
            this.GridViewPage.Size = new System.Drawing.Size(1766, 587);
            this.GridViewPage.TabIndex = 0;
            this.GridViewPage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewPage_CellClick);
            // 
            // SelectPage
            // 
            this.SelectPage.HeaderText = "Select";
            this.SelectPage.Image = global::GUI508.Properties.Resources.select_text;
            this.SelectPage.Name = "SelectPage";
            this.SelectPage.ReadOnly = true;
            this.SelectPage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectPage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelectPage.ToolTipText = "Select to see details";
            // 
            // AlertPage
            // 
            this.AlertPage.HeaderText = "Alert";
            this.AlertPage.Name = "AlertPage";
            this.AlertPage.ReadOnly = true;
            this.AlertPage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AlertPage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ASPXPage
            // 
            this.ASPXPage.HeaderText = "Page";
            this.ASPXPage.Name = "ASPXPage";
            this.ASPXPage.ReadOnly = true;
            this.ASPXPage.Width = 525;
            // 
            // DirectoryPage
            // 
            this.DirectoryPage.HeaderText = "Directory";
            this.DirectoryPage.Name = "DirectoryPage";
            this.DirectoryPage.ReadOnly = true;
            this.DirectoryPage.Width = 1000;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CreatePrompt = true;
            this.saveFileDialog.Filter = "CSV only | *.csv";
            this.saveFileDialog.Title = "Export Data to CSV";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1780, 650);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "GUI";
            this.Text = "508 Scranner GUI";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewControl)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewControl;
        private System.Windows.Forms.MenuStrip Menu = new System.Windows.Forms.MenuStrip();
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.DataGridView GridViewPage;
        private System.Windows.Forms.DataGridViewImageColumn SelectPage;
        private System.Windows.Forms.DataGridViewImageColumn AlertPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASPXPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectoryPage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exportASPNetControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPagesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.DataGridViewImageColumn ASPXAlert;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControlType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControlString;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeBehind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dictionaryKey;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
    }
}
