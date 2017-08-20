namespace GUI508
{
    partial class ASPXServerSideControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ASPXServerSideControl));
            this.aspxPageFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codeBehindFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineNumber = new System.Windows.Forms.Label();
            this.lblMesages = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtfAspxControl = new System.Windows.Forms.RichTextBox();
            this.rtfMessages = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aspxPageFolder
            // 
            this.aspxPageFolder.Location = new System.Drawing.Point(197, 20);
            this.aspxPageFolder.Name = "aspxPageFolder";
            this.aspxPageFolder.Size = new System.Drawing.Size(547, 22);
            this.aspxPageFolder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ASPX Page .aspx";
            // 
            // codeBehindFolder
            // 
            this.codeBehindFolder.Location = new System.Drawing.Point(197, 62);
            this.codeBehindFolder.Name = "codeBehindFolder";
            this.codeBehindFolder.Size = new System.Drawing.Size(547, 22);
            this.codeBehindFolder.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code behind .cs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "ASP.Net ServerSide Control \r\nDeclarative Syntax";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1706, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // lineNumber
            // 
            this.lineNumber.AutoSize = true;
            this.lineNumber.Location = new System.Drawing.Point(8, 169);
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.Size = new System.Drawing.Size(93, 17);
            this.lineNumber.TabIndex = 7;
            this.lineNumber.Text = "Line Number:";
            // 
            // lblMesages
            // 
            this.lblMesages.AutoSize = true;
            this.lblMesages.Location = new System.Drawing.Point(22, 367);
            this.lblMesages.Name = "lblMesages";
            this.lblMesages.Size = new System.Drawing.Size(0, 17);
            this.lblMesages.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Messages";
            // 
            // rtfAspxControl
            // 
            this.rtfAspxControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfAspxControl.Location = new System.Drawing.Point(197, 169);
            this.rtfAspxControl.Name = "rtfAspxControl";
            this.rtfAspxControl.ReadOnly = true;
            this.rtfAspxControl.Size = new System.Drawing.Size(846, 248);
            this.rtfAspxControl.TabIndex = 13;
            this.rtfAspxControl.Text = "";
            // 
            // rtfMessages
            // 
            this.rtfMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfMessages.Location = new System.Drawing.Point(197, 463);
            this.rtfMessages.Name = "rtfMessages";
            this.rtfMessages.ReadOnly = true;
            this.rtfMessages.Size = new System.Drawing.Size(1422, 196);
            this.rtfMessages.TabIndex = 10;
            this.rtfMessages.Text = "";
            // 
            // ASPXServerSideControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 724);
            this.Controls.Add(this.rtfMessages);
            this.Controls.Add(this.rtfAspxControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMesages);
            this.Controls.Add(this.lineNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeBehindFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aspxPageFolder);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ASPXServerSideControl";
            this.Text = "ASPX Server-Side Control";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aspxPageFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeBehindFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Label lineNumber;
        private System.Windows.Forms.Label lblMesages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtfAspxControl;
        private System.Windows.Forms.RichTextBox rtfMessages;
    }
}