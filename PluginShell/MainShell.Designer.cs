namespace PluginShell
{
    partial class MainShell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainShell));
            this.tstripBottom = new System.Windows.Forms.ToolStrip();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitConMain = new System.Windows.Forms.SplitContainer();
            this.lvMain = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlMainInfo = new System.Windows.Forms.Panel();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitConMain)).BeginInit();
            this.splitConMain.Panel1.SuspendLayout();
            this.splitConMain.Panel2.SuspendLayout();
            this.splitConMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstripBottom
            // 
            this.tstripBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstripBottom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tstripBottom.Location = new System.Drawing.Point(0, 668);
            this.tstripBottom.Name = "tstripBottom";
            this.tstripBottom.Size = new System.Drawing.Size(818, 25);
            this.tstripBottom.TabIndex = 0;
            this.tstripBottom.Text = "toolStrip1";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(818, 668);
            this.tcMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitConMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitConMain
            // 
            this.splitConMain.BackColor = System.Drawing.Color.DimGray;
            this.splitConMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitConMain.Location = new System.Drawing.Point(3, 3);
            this.splitConMain.Name = "splitConMain";
            // 
            // splitConMain.Panel1
            // 
            this.splitConMain.Panel1.Controls.Add(this.lvMain);
            // 
            // splitConMain.Panel2
            // 
            this.splitConMain.Panel2.Controls.Add(this.pnlMainInfo);
            this.splitConMain.Size = new System.Drawing.Size(804, 633);
            this.splitConMain.SplitterDistance = 225;
            this.splitConMain.SplitterWidth = 10;
            this.splitConMain.TabIndex = 0;
            // 
            // lvMain
            // 
            this.lvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMain.Location = new System.Drawing.Point(0, 0);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(225, 633);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlMainInfo
            // 
            this.pnlMainInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMainInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlMainInfo.Name = "pnlMainInfo";
            this.pnlMainInfo.Size = new System.Drawing.Size(569, 633);
            this.pnlMainInfo.TabIndex = 0;
            // 
            // MainShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 693);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.tstripBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainShell";
            this.Text = "Plugins United";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainShell_FormClosing);
            this.Load += new System.EventHandler(this.MainShell_Load);
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitConMain.Panel1.ResumeLayout(false);
            this.splitConMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitConMain)).EndInit();
            this.splitConMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstripBottom;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitConMain;
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.Panel pnlMainInfo;
    }
}

