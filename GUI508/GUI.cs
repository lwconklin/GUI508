﻿// <copyright file="GUI.cs" company="Air Osprey">
//     MIT License (MIT). All rights reserved
// </copyright>
// <author>Larry Conklin</author>
// <summary>This is the User Interface class.</summary>
namespace GUI508 
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Diagnostics;

    /// <summary>
    /// Controls main shell of the winform UI.
    /// </summary>
    public partial class GUI : Form 
    {
        private Image nullImage = new Bitmap(1, 1);

        /// <summary>
        /// Initializes a new instance of the <see cref="GUI"/> class.
        /// </summary>
        public GUI() 
        {
            this.InitializeComponent();
            StartUpInitialization startUp = new StartUpInitialization();
            startUp.Initalization();
            if (Debugger.IsAttached.Equals(true))
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.Save();
            }
            
        }

        /// <summary>
        /// Fill ASP.NET Controls data grid control.
        /// </summary>
        public void FillGridViewControl() 
        {
            if (GridViewControl.RowCount > 0)
            {
                GridViewControl.Rows.Clear();
                GridViewControl.Refresh();
            }
            foreach (KeyValuePair<string, Scanner.ASPXControlProperties> kvp in Scanner.AspxControlsSorted) 
            {
                if (!kvp.Value.ControlType.Equals("HeaderTags"))
                {
                   if((Resources.UserPreferences.Default.DisplayErrors.Equals(true)) && (kvp.Value.ErrorStatus.Equals(true)))
                    {
                        var index = GridViewControlCommon(kvp);
                        GridViewControl.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
                        GridViewControl.Rows[index].Cells["ASPXAlert"].Value = Properties.Resources.Warning24;
                    }

                   if ((Resources.UserPreferences.Default.DisplayNoComplaince.Equals(true)) && (kvp.Value.NoComplainanceStatus.Equals(true)))
                   {
                       var index = GridViewControlCommon(kvp);
                       GridViewControl.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
                   }

                   if ((Resources.UserPreferences.Default.DisplayNoErrors.Equals(true)) && (kvp.Value.ErrorStatus.Equals(false)))
                   {
                       var index = GridViewControlCommon(kvp);
                   }
                   if (Resources.UserPreferences.Default.DisplayAll.Equals(true)) 
                   {
                       var index = GridViewControlCommon(kvp);
                       if (kvp.Value.ErrorStatus.Equals(true)) {
                           GridViewControl.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
                           GridViewControl.Rows[index].Cells["ASPXAlert"].Value = Properties.Resources.Warning24;
                       }
                       if (kvp.Value.NoComplainanceStatus.Equals(true))
                       {
                           GridViewControl.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
                       }
                   }
                }
            }
        }

        private int GridViewControlCommon(KeyValuePair<string, Scanner.ASPXControlProperties> kvp)
        {
            var index = GridViewControl.Rows.Add();
            GridViewControl.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            GridViewControl.Rows[index].Cells["ControlType"].Value = kvp.Value.ControlType;
            GridViewControl.Rows[index].Cells["Line"].Value = kvp.Value.LineNumber;
            GridViewControl.Rows[index].Cells["ControlString"].Value = kvp.Value.AspxControl;
            GridViewControl.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GridViewControl.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            GridViewControl.Rows[index].Cells["CodeBehind"].Value = kvp.Value.CodeBehind;
            GridViewControl.Rows[index].Cells["Directory"].Value = kvp.Value.Path;
            GridViewControl.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GridViewControl.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            GridViewControl.Rows[index].Cells["DictionaryKey"].Value = kvp.Key;
            GridViewControl.Rows[index].Cells["ASPXAlert"].Value = nullImage;
            GridViewControl.Rows[index].DefaultCellStyle.BackColor = Color.White;
            return index;
        }

        /// <summary>
        /// Fill ASPX Page data grid control.
        /// </summary>
        public void FillGridViewPage()
        {
            Image nullImage = new Bitmap(1, 1);
            int index = 0;
            foreach (KeyValuePair<string, Scanner.ASPXPageProperties> kvp in Scanner.AspxPages)
            {
                GridViewPage.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                index = GridViewPage.Rows.Add();
                GridViewPage.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
                GridViewPage.Rows[index].Cells["AlertPage"].Value = Properties.Resources.Warning16;
                GridViewPage.Rows[index].Cells["ASPXPage"].Value = kvp.Value.FileName;
                GridViewPage.Rows[index].Cells["DirectoryPage"].Value = kvp.Value.Path;
                GridViewPage.Rows[index].Cells["ASPXPage"].Value = kvp.Value.FileName;
                GridViewPage.Rows[index].Cells["DirectoryPage"].Value = kvp.Value.Path;
                //GridViewPage.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
                //GridViewPage.Rows[index].Cells["AlertPage"].Value = Properties.Resources.Warning16;
                GridViewPage.Rows[index].Cells["AlertPage"].Value = nullImage;

            }
        }

        /// <summary>
        /// Sort columns in GridView.
        /// </summary>
        /// <param name="sender">Object GridView.</param>
        /// <param name="e">Event Arguments.</param>
        private void SortButton_Click(object sender, System.EventArgs e)
        {
            DataGridViewColumn newColumn = GridViewControl.Columns.GetColumnCount(DataGridViewElementStates.Selected) == 1 ? GridViewControl.SelectedColumns[0] : null;
            DataGridViewColumn oldColumn = GridViewControl.SortedColumn;
            ListSortDirection direction;
            if (oldColumn != null)
            {
                if (oldColumn == newColumn && GridViewControl.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            if (newColumn == null)
            {
                MessageBox.Show("Select a single column and try again.", "Error: Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GridViewControl.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
            }
        }

        /// <summary>
        /// Menu option to call Folder Browser Dialog.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">System EventArgs.</param>
        private void MnuFileOpen_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the folder that you want to use.";
            dialog.ShowNewFolderButton = false;
            dialog.RootFolder = System.Environment.SpecialFolder.MyComputer;

            DialogResult selectedPathDialogResult = new DialogResult();
            selectedPathDialogResult = dialog.ShowDialog();
            if (selectedPathDialogResult.Equals(DialogResult.OK))
            {
                mnuExport.Enabled = false;
                GuideLineMessages messages = new GuideLineMessages(); 
                Scanner scanner = new Scanner();
                scanner.DirectorySearch(dialog.SelectedPath); 
                scanner.ASPXScan();
                this.FillGridViewControl();
                this.FillGridViewPage();
                mnuExport.Enabled = true;
            }
         }

        /// <summary>
        /// Exit application.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void MnuExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Export data view grid to csv file.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void MnuExport_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveCVS = new SaveFileDialog();
            saveCVS.Filter = "CSV files (*.csv)";
            if (saveCVS.ShowDialog() == DialogResult.OK)
            {
                Export exportdata = new Export();
                exportdata.ExportASP_NetControlsToCVS(saveCVS.FileName);
            }
        }

        /// <summary>
        /// Display about form.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void AboutToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
            if (about.DialogResult == DialogResult.OK)
            {
                about.Dispose();
            }
        }

        /// <summary>
        /// Displays details of selected row in GridViewPage.
        /// </summary>
        /// <param name="sender"> Object GridView.</param>  
        /// <param name="e">Data Grid View Cell Event Args.</param>
        private void GridViewPage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = GridViewPage.Rows[e.RowIndex];
                if (row.Cells["SelectPage"].Selected.Equals(true))
                {
                    Scanner.ASPXPageProperties aspxPageProperties = new Scanner.ASPXPageProperties();
                    aspxPageProperties.PageMessages = new List<string>();
                    aspxPageProperties = Scanner.AspxPages[row.Cells["ASPXPage"].Value.ToString()];
                    ASPXPage aspxPage = new ASPXPage();
                    aspxPage.FillForm(aspxPageProperties);
                    aspxPage.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Displays details of selected row in GridViewControl.
        /// </summary>
        /// <param name="sender"> Object GridView.</param>  
        /// <param name="e">Data Grid View Cell Event Args.</param>
        private void GridViewControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = GridViewControl.Rows[e.RowIndex];
                if (row.Cells["Select"].Selected.Equals(true))
                {
                    Scanner.ASPXControlProperties aspxControlProperties = new Scanner.ASPXControlProperties();
                    aspxControlProperties.ControlMessages = new List<string>();
                    aspxControlProperties = Scanner.AspxControlsSorted[row.Cells["DictionaryKey"].Value.ToString()];
                    ASPXServerSideControl aspxDetails = new ASPXServerSideControl();
                    aspxDetails.FillForm(aspxControlProperties);
                    aspxDetails.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Export ASP Net controls data view grid to csv file.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void ExportASPNetControlsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveCVS = new SaveFileDialog();
            saveCVS.Filter = "CSV Files | *.csv";
            saveCVS.DefaultExt = "csv";
            if (saveCVS.ShowDialog() == DialogResult.OK)
            {
                Export exportdata = new Export();
                exportdata.ExportASP_NetControlsToCVS(saveCVS.FileName);
            }
        }

        /// <summary>
        /// Export ASP Pages data view grid to csv file.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event argument.</param>
        private void ExportPagesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveCSV = new SaveFileDialog();
            saveCSV.Filter = "CSV Files | *.csv";
            saveCSV.DefaultExt = "csv";
            if (saveCSV.ShowDialog() == DialogResult.OK)
            {
                Export exportdata = new Export();
                exportdata.ExportPagesToCSV(saveCSV.FileName);
            }
        }

        private void GridViewControl_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void GridViewControl_Sorted(object sender, System.EventArgs e)
        {

        }

        private void preferencesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Preferences preferences = new Preferences();
            preferences.Show();
        }
     } // end of class
} // end of namespace
