using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI508
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void grpBXASPX_Enter(object sender, EventArgs e)
        {

        }

        private void radBtnDisplayAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radBtnDisplayAll.Checked.Equals(true))
            {
                Resources.UserPreferences.Default.DisplayAll = true;
                Resources.UserPreferences.Default.DisplayErrors = false;
                Resources.UserPreferences.Default.DisplayNoComplaince = false;
                Resources.UserPreferences.Default.DisplayNoErrors = false;
            }
        }

        private void radBtnDisplayErrors_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radBtnDisplayErrors.Checked.Equals(true))
            {
                Resources.UserPreferences.Default.DisplayErrors = true;
                Resources.UserPreferences.Default.DisplayAll = false;
                Resources.UserPreferences.Default.DisplayNoComplaince = false;
                Resources.UserPreferences.Default.DisplayNoErrors = false;
            }
        }

        private void radBtnDisplayNoErrors_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radBtnDisplayNoErrors.Checked.Equals(true))
            {
                Resources.UserPreferences.Default.DisplayNoErrors = true;
                Resources.UserPreferences.Default.DisplayAll = false;
                Resources.UserPreferences.Default.DisplayNoComplaince = false;
                Resources.UserPreferences.Default.DisplayErrors = false;
            }
        }

        private void radBtnNoCompliance_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radBtnDisplayNoCompliance.Checked.Equals(true))
            {
                Resources.UserPreferences.Default.DisplayNoComplaince = true;
                Resources.UserPreferences.Default.DisplayAll = false;
                Resources.UserPreferences.Default.DisplayNoErrors = false;
                Resources.UserPreferences.Default.DisplayErrors = false;
            }

        }

        private void chkBxImage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBxButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBxLink_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBxImageButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void mnuPreferencesExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuPreferencesSave_Click(object sender, EventArgs e)
        {
            Resources.UserPreferences.Default.Save();
            Resources.UserPreferences.Default.Reload();
        }



    }
}
