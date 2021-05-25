
namespace No_Man_Sky_Save_Management
{
    partial class frmMain
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
            this.FSW = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.cmdEnable = new System.Windows.Forms.Button();
            this.cmdDisable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.cmdBrowseDest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.FSW)).BeginInit();
            this.SuspendLayout();
            // 
            // FSW
            // 
            this.FSW.EnableRaisingEvents = true;
            this.FSW.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NMS Folder (Ex: C:\\Users\\username\\AppData\\Roaming\\HelloGames\\NMS\\st_1234567890)";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 25);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(540, 20);
            this.txtPath.TabIndex = 1;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(558, 22);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(26, 23);
            this.cmdBrowse.TabIndex = 2;
            this.cmdBrowse.Text = "...";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delay after change (Seconds)";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(12, 64);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(42, 20);
            this.txtDelay.TabIndex = 4;
            this.txtDelay.Text = "1";
            // 
            // cmdEnable
            // 
            this.cmdEnable.Location = new System.Drawing.Point(12, 127);
            this.cmdEnable.Name = "cmdEnable";
            this.cmdEnable.Size = new System.Drawing.Size(103, 23);
            this.cmdEnable.TabIndex = 5;
            this.cmdEnable.Text = "Enable Monitoring";
            this.cmdEnable.UseVisualStyleBackColor = true;
            this.cmdEnable.Click += new System.EventHandler(this.cmdEnable_Click);
            // 
            // cmdDisable
            // 
            this.cmdDisable.Enabled = false;
            this.cmdDisable.Location = new System.Drawing.Point(121, 127);
            this.cmdDisable.Name = "cmdDisable";
            this.cmdDisable.Size = new System.Drawing.Size(103, 23);
            this.cmdDisable.TabIndex = 6;
            this.cmdDisable.Text = "Disable Monitoring";
            this.cmdDisable.UseVisualStyleBackColor = true;
            this.cmdDisable.Click += new System.EventHandler(this.cmdDisable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destination Folder";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(12, 103);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(540, 20);
            this.txtDestination.TabIndex = 8;
            // 
            // cmdBrowseDest
            // 
            this.cmdBrowseDest.Location = new System.Drawing.Point(558, 100);
            this.cmdBrowseDest.Name = "cmdBrowseDest";
            this.cmdBrowseDest.Size = new System.Drawing.Size(26, 23);
            this.cmdBrowseDest.TabIndex = 9;
            this.cmdBrowseDest.Text = "...";
            this.cmdBrowseDest.UseVisualStyleBackColor = true;
            this.cmdBrowseDest.Click += new System.EventHandler(this.cmdBrowseDest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 169);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(572, 218);
            this.txtLog.TabIndex = 11;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(230, 133);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(107, 17);
            this.chkRemember.TabIndex = 12;
            this.chkRemember.Text = "Remember Paths";
            this.chkRemember.UseVisualStyleBackColor = true;
            this.chkRemember.Click += new System.EventHandler(this.chkRemember_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 398);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdBrowseDest);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdDisable);
            this.Controls.Add(this.cmdEnable);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No Man Sky Backup Savegame";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FSW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher FSW;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdDisable;
        private System.Windows.Forms.Button cmdEnable;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdBrowseDest;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkRemember;
    }
}

