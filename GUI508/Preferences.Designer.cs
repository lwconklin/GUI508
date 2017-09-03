namespace GUI508
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.mnuPreferences = new System.Windows.Forms.MenuStrip();
            this.mnuPreferencesSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPreferencesExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBxDisplay = new System.Windows.Forms.GroupBox();
            this.radBtnDisplayAll = new System.Windows.Forms.RadioButton();
            this.radBtnDisplayNoCompliance = new System.Windows.Forms.RadioButton();
            this.radBtnDisplayNoErrors = new System.Windows.Forms.RadioButton();
            this.radBtnDisplayErrors = new System.Windows.Forms.RadioButton();
            this.grpBxPrint = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grpBXASPX = new System.Windows.Forms.GroupBox();
            this.chkBxImageButton = new System.Windows.Forms.CheckBox();
            this.chkBxLink = new System.Windows.Forms.CheckBox();
            this.chkBxButton = new System.Windows.Forms.CheckBox();
            this.chkBxImage = new System.Windows.Forms.CheckBox();
            this.mnuPreferences.SuspendLayout();
            this.grpBxDisplay.SuspendLayout();
            this.grpBxPrint.SuspendLayout();
            this.grpBXASPX.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPreferences
            // 
            this.mnuPreferences.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPreferencesSave,
            this.mnuPreferencesExit});
            this.mnuPreferences.Location = new System.Drawing.Point(0, 0);
            this.mnuPreferences.Name = "mnuPreferences";
            this.mnuPreferences.Size = new System.Drawing.Size(1817, 28);
            this.mnuPreferences.TabIndex = 0;
            this.mnuPreferences.Text = "Save";
            // 
            // mnuPreferencesSave
            // 
            this.mnuPreferencesSave.Name = "mnuPreferencesSave";
            this.mnuPreferencesSave.Size = new System.Drawing.Size(52, 24);
            this.mnuPreferencesSave.Text = "Save";
            this.mnuPreferencesSave.Click += new System.EventHandler(this.mnuPreferencesSave_Click);
            // 
            // mnuPreferencesExit
            // 
            this.mnuPreferencesExit.Name = "mnuPreferencesExit";
            this.mnuPreferencesExit.Size = new System.Drawing.Size(45, 24);
            this.mnuPreferencesExit.Text = "Exit";
            this.mnuPreferencesExit.Click += new System.EventHandler(this.mnuPreferencesExit_Click);
            // 
            // grpBxDisplay
            // 
            this.grpBxDisplay.AccessibleDescription = "Display User Preferences";
            this.grpBxDisplay.AccessibleName = "grpBxDisplay";
            this.grpBxDisplay.Controls.Add(this.radBtnDisplayAll);
            this.grpBxDisplay.Controls.Add(this.radBtnDisplayNoCompliance);
            this.grpBxDisplay.Controls.Add(this.radBtnDisplayNoErrors);
            this.grpBxDisplay.Controls.Add(this.radBtnDisplayErrors);
            this.grpBxDisplay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBxDisplay.Location = new System.Drawing.Point(30, 87);
            this.grpBxDisplay.Name = "grpBxDisplay";
            this.grpBxDisplay.Size = new System.Drawing.Size(361, 147);
            this.grpBxDisplay.TabIndex = 1;
            this.grpBxDisplay.TabStop = false;
            this.grpBxDisplay.Text = "Display preferences.";
            // 
            // radBtnDisplayAll
            // 
            this.radBtnDisplayAll.AutoSize = true;
            this.radBtnDisplayAll.Location = new System.Drawing.Point(7, 21);
            this.radBtnDisplayAll.Name = "radBtnDisplayAll";
            this.radBtnDisplayAll.Size = new System.Drawing.Size(82, 21);
            this.radBtnDisplayAll.TabIndex = 3;
            this.radBtnDisplayAll.TabStop = true;
            this.radBtnDisplayAll.Text = "Show All";
            this.radBtnDisplayAll.UseVisualStyleBackColor = true;
            this.radBtnDisplayAll.CheckedChanged += new System.EventHandler(this.radBtnDisplayAll_CheckedChanged);
            // 
            // radBtnDisplayNoCompliance
            // 
            this.radBtnDisplayNoCompliance.AutoSize = true;
            this.radBtnDisplayNoCompliance.Location = new System.Drawing.Point(7, 104);
            this.radBtnDisplayNoCompliance.Name = "radBtnDisplayNoCompliance";
            this.radBtnDisplayNoCompliance.Size = new System.Drawing.Size(307, 21);
            this.radBtnDisplayNoCompliance.TabIndex = 2;
            this.radBtnDisplayNoCompliance.TabStop = true;
            this.radBtnDisplayNoCompliance.Text = "Show only aspx controls with no compliance.";
            this.radBtnDisplayNoCompliance.UseVisualStyleBackColor = true;
            this.radBtnDisplayNoCompliance.CheckedChanged += new System.EventHandler(this.radBtnNoCompliance_CheckedChanged);
            // 
            // radBtnDisplayNoErrors
            // 
            this.radBtnDisplayNoErrors.AutoSize = true;
            this.radBtnDisplayNoErrors.Location = new System.Drawing.Point(7, 76);
            this.radBtnDisplayNoErrors.Name = "radBtnDisplayNoErrors";
            this.radBtnDisplayNoErrors.Size = new System.Drawing.Size(270, 21);
            this.radBtnDisplayNoErrors.TabIndex = 1;
            this.radBtnDisplayNoErrors.TabStop = true;
            this.radBtnDisplayNoErrors.Text = "Show only aspx controls with no errors";
            this.radBtnDisplayNoErrors.UseVisualStyleBackColor = true;
            this.radBtnDisplayNoErrors.CheckedChanged += new System.EventHandler(this.radBtnDisplayNoErrors_CheckedChanged);
            // 
            // radBtnDisplayErrors
            // 
            this.radBtnDisplayErrors.AutoSize = true;
            this.radBtnDisplayErrors.Location = new System.Drawing.Point(6, 48);
            this.radBtnDisplayErrors.Name = "radBtnDisplayErrors";
            this.radBtnDisplayErrors.Size = new System.Drawing.Size(139, 21);
            this.radBtnDisplayErrors.TabIndex = 0;
            this.radBtnDisplayErrors.TabStop = true;
            this.radBtnDisplayErrors.Text = "Show only errors.";
            this.radBtnDisplayErrors.UseVisualStyleBackColor = true;
            this.radBtnDisplayErrors.CheckedChanged += new System.EventHandler(this.radBtnDisplayErrors_CheckedChanged);
            // 
            // grpBxPrint
            // 
            this.grpBxPrint.Controls.Add(this.radioButton1);
            this.grpBxPrint.Location = new System.Drawing.Point(30, 266);
            this.grpBxPrint.Name = "grpBxPrint";
            this.grpBxPrint.Size = new System.Drawing.Size(361, 55);
            this.grpBxPrint.TabIndex = 2;
            this.grpBxPrint.TabStop = false;
            this.grpBxPrint.Text = "Print (default is to print all)";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(182, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Export to csv only errors";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // grpBXASPX
            // 
            this.grpBXASPX.Controls.Add(this.chkBxImageButton);
            this.grpBXASPX.Controls.Add(this.chkBxLink);
            this.grpBXASPX.Controls.Add(this.chkBxButton);
            this.grpBXASPX.Controls.Add(this.chkBxImage);
            this.grpBXASPX.Location = new System.Drawing.Point(516, 96);
            this.grpBXASPX.Name = "grpBXASPX";
            this.grpBXASPX.Size = new System.Drawing.Size(444, 263);
            this.grpBXASPX.TabIndex = 3;
            this.grpBXASPX.TabStop = false;
            this.grpBXASPX.Text = "Display and Export individual aspx controls";
            this.grpBXASPX.Enter += new System.EventHandler(this.grpBXASPX_Enter);
            // 
            // chkBxImageButton
            // 
            this.chkBxImageButton.AutoSize = true;
            this.chkBxImageButton.Location = new System.Drawing.Point(8, 105);
            this.chkBxImageButton.Name = "chkBxImageButton";
            this.chkBxImageButton.Size = new System.Drawing.Size(137, 21);
            this.chkBxImageButton.TabIndex = 3;
            this.chkBxImageButton.Text = "Asp:ImageButton";
            this.chkBxImageButton.UseVisualStyleBackColor = true;
            this.chkBxImageButton.CheckedChanged += new System.EventHandler(this.chkBxImageButton_CheckedChanged);
            // 
            // chkBxLink
            // 
            this.chkBxLink.AutoSize = true;
            this.chkBxLink.Location = new System.Drawing.Point(7, 78);
            this.chkBxLink.Name = "chkBxLink";
            this.chkBxLink.Size = new System.Drawing.Size(56, 21);
            this.chkBxLink.TabIndex = 2;
            this.chkBxLink.Text = "Link";
            this.chkBxLink.UseVisualStyleBackColor = true;
            this.chkBxLink.CheckedChanged += new System.EventHandler(this.chkBxLink_CheckedChanged);
            // 
            // chkBxButton
            // 
            this.chkBxButton.AutoSize = true;
            this.chkBxButton.Location = new System.Drawing.Point(7, 50);
            this.chkBxButton.Name = "chkBxButton";
            this.chkBxButton.Size = new System.Drawing.Size(99, 21);
            this.chkBxButton.TabIndex = 1;
            this.chkBxButton.Text = "Asp:Button";
            this.chkBxButton.UseVisualStyleBackColor = true;
            this.chkBxButton.CheckedChanged += new System.EventHandler(this.chkBxButton_CheckedChanged);
            // 
            // chkBxImage
            // 
            this.chkBxImage.AutoSize = true;
            this.chkBxImage.Location = new System.Drawing.Point(7, 22);
            this.chkBxImage.Name = "chkBxImage";
            this.chkBxImage.Size = new System.Drawing.Size(96, 21);
            this.chkBxImage.TabIndex = 0;
            this.chkBxImage.Text = "Asp:Image";
            this.chkBxImage.UseVisualStyleBackColor = true;
            this.chkBxImage.CheckedChanged += new System.EventHandler(this.chkBxImage_CheckedChanged);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 778);
            this.Controls.Add(this.grpBXASPX);
            this.Controls.Add(this.grpBxPrint);
            this.Controls.Add(this.grpBxDisplay);
            this.Controls.Add(this.mnuPreferences);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuPreferences;
            this.Name = "Preferences";
            this.Text = "508 Scranner GUI Preferences";
            this.mnuPreferences.ResumeLayout(false);
            this.mnuPreferences.PerformLayout();
            this.grpBxDisplay.ResumeLayout(false);
            this.grpBxDisplay.PerformLayout();
            this.grpBxPrint.ResumeLayout(false);
            this.grpBxPrint.PerformLayout();
            this.grpBXASPX.ResumeLayout(false);
            this.grpBXASPX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPreferences;
        private System.Windows.Forms.GroupBox grpBxDisplay;
        private System.Windows.Forms.RadioButton radBtnDisplayNoCompliance;
        private System.Windows.Forms.RadioButton radBtnDisplayNoErrors;
        private System.Windows.Forms.RadioButton radBtnDisplayErrors;
        private System.Windows.Forms.GroupBox grpBxPrint;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpBXASPX;
        private System.Windows.Forms.CheckBox chkBxImageButton;
        private System.Windows.Forms.CheckBox chkBxLink;
        private System.Windows.Forms.CheckBox chkBxButton;
        private System.Windows.Forms.CheckBox chkBxImage;
        private System.Windows.Forms.ToolStripMenuItem mnuPreferencesSave;
        private System.Windows.Forms.ToolStripMenuItem mnuPreferencesExit;
        private System.Windows.Forms.RadioButton radBtnDisplayAll;
    }
}