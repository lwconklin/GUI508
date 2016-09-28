namespace GUI508
{
    partial class ASPXPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ASPXPageName = new System.Windows.Forms.Label();
            this.listMessages = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Directory = new System.Windows.Forms.Label();
            this.listASPX = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1693, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // ASPXPageName
            // 
            this.ASPXPageName.AutoSize = true;
            this.ASPXPageName.Location = new System.Drawing.Point(53, 44);
            this.ASPXPageName.Name = "ASPXPageName";
            this.ASPXPageName.Size = new System.Drawing.Size(94, 17);
            this.ASPXPageName.TabIndex = 8;
            this.ASPXPageName.Text = "ASPX Page - ";
            // 
            // listMessages
            // 
            this.listMessages.FormattingEnabled = true;
            this.listMessages.HorizontalScrollbar = true;
            this.listMessages.ItemHeight = 16;
            this.listMessages.Location = new System.Drawing.Point(53, 452);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(1422, 196);
            this.listMessages.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Messages";
            // 
            // Directory
            // 
            this.Directory.AutoSize = true;
            this.Directory.Location = new System.Drawing.Point(50, 79);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(78, 17);
            this.Directory.TabIndex = 13;
            this.Directory.Text = "Directory - ";
            // 
            // listASPX
            // 
            this.listASPX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listASPX.FormattingEnabled = true;
            this.listASPX.IntegralHeight = false;
            this.listASPX.ItemHeight = 16;
            this.listASPX.Location = new System.Drawing.Point(53, 148);
            this.listASPX.Name = "listASPX";
            this.listASPX.Size = new System.Drawing.Size(846, 246);
            this.listASPX.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Page Summary";
            // 
            // ASPXPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listASPX);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listMessages);
            this.Controls.Add(this.ASPXPageName);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ASPXPage";
            this.Text = "ASPXPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Label ASPXPageName;
        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Directory;
        private System.Windows.Forms.ListBox listASPX;
        private System.Windows.Forms.Label label1;
    }
}