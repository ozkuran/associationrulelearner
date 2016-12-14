using System;

namespace GUI
{
    partial class MainForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprioriAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eCLATAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.performanceTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxAssociations = new System.Windows.Forms.TextBox();
            this.textBoxTransactions = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExportToCsv = new System.Windows.Forms.Button();
            this.textBoxMinimumSupport = new System.Windows.Forms.TextBox();
            this.labelMinimumSupport = new System.Windows.Forms.Label();
            this.comboBoxTestDataSet = new System.Windows.Forms.ComboBox();
            this.labelTestDataSet = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1466, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprioriAlgorithmToolStripMenuItem,
            this.eCLATAlgorithmToolStripMenuItem,
            this.toolStripMenuItem1,
            this.performanceTestToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.runToolStripMenuItem.Text = "Run Tests";
            // 
            // aprioriAlgorithmToolStripMenuItem
            // 
            this.aprioriAlgorithmToolStripMenuItem.Name = "aprioriAlgorithmToolStripMenuItem";
            this.aprioriAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.aprioriAlgorithmToolStripMenuItem.Text = "Apriori Algorithm";
            this.aprioriAlgorithmToolStripMenuItem.Click += new System.EventHandler(this.aprioriAlgorithmToolStripMenuItem_Click);
            // 
            // eCLATAlgorithmToolStripMenuItem
            // 
            this.eCLATAlgorithmToolStripMenuItem.Name = "eCLATAlgorithmToolStripMenuItem";
            this.eCLATAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.eCLATAlgorithmToolStripMenuItem.Text = "ECLAT Algorithm";
            this.eCLATAlgorithmToolStripMenuItem.Click += new System.EventHandler(this.eCLATAlgorithmToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(233, 6);
            // 
            // performanceTestToolStripMenuItem
            // 
            this.performanceTestToolStripMenuItem.Name = "performanceTestToolStripMenuItem";
            this.performanceTestToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.performanceTestToolStripMenuItem.Text = "Performance Test";
            this.performanceTestToolStripMenuItem.Click += new System.EventHandler(this.performanceTestToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxAssociations);
            this.panel1.Controls.Add(this.textBoxTransactions);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1466, 982);
            this.panel1.TabIndex = 1;
            // 
            // textBoxAssociations
            // 
            this.textBoxAssociations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAssociations.Location = new System.Drawing.Point(774, 249);
            this.textBoxAssociations.Multiline = true;
            this.textBoxAssociations.Name = "textBoxAssociations";
            this.textBoxAssociations.Size = new System.Drawing.Size(692, 733);
            this.textBoxAssociations.TabIndex = 1;
            // 
            // textBoxTransactions
            // 
            this.textBoxTransactions.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxTransactions.Location = new System.Drawing.Point(0, 249);
            this.textBoxTransactions.Multiline = true;
            this.textBoxTransactions.Name = "textBoxTransactions";
            this.textBoxTransactions.Size = new System.Drawing.Size(774, 733);
            this.textBoxTransactions.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonExportToCsv);
            this.panel2.Controls.Add(this.textBoxMinimumSupport);
            this.panel2.Controls.Add(this.labelMinimumSupport);
            this.panel2.Controls.Add(this.comboBoxTestDataSet);
            this.panel2.Controls.Add(this.labelTestDataSet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1466, 249);
            this.panel2.TabIndex = 2;
            // 
            // buttonExportToCsv
            // 
            this.buttonExportToCsv.Location = new System.Drawing.Point(16, 123);
            this.buttonExportToCsv.Name = "buttonExportToCsv";
            this.buttonExportToCsv.Size = new System.Drawing.Size(129, 48);
            this.buttonExportToCsv.TabIndex = 4;
            this.buttonExportToCsv.Text = "Export To CSV";
            this.buttonExportToCsv.UseVisualStyleBackColor = true;
            this.buttonExportToCsv.Click += new System.EventHandler(this.buttonExportToCsv_Click);
            // 
            // textBoxMinimumSupport
            // 
            this.textBoxMinimumSupport.Location = new System.Drawing.Point(176, 68);
            this.textBoxMinimumSupport.Name = "textBoxMinimumSupport";
            this.textBoxMinimumSupport.Size = new System.Drawing.Size(187, 26);
            this.textBoxMinimumSupport.TabIndex = 3;
            this.textBoxMinimumSupport.Text = "0.1";
            // 
            // labelMinimumSupport
            // 
            this.labelMinimumSupport.AutoSize = true;
            this.labelMinimumSupport.Location = new System.Drawing.Point(12, 71);
            this.labelMinimumSupport.Name = "labelMinimumSupport";
            this.labelMinimumSupport.Size = new System.Drawing.Size(133, 20);
            this.labelMinimumSupport.TabIndex = 2;
            this.labelMinimumSupport.Text = "Minimum Support";
            // 
            // comboBoxTestDataSet
            // 
            this.comboBoxTestDataSet.FormattingEnabled = true;
            this.comboBoxTestDataSet.Items.AddRange(new object[] {
            "sample.txt",
            "small.txt",
            "groceries.csv",
            "retail.dat"});
            this.comboBoxTestDataSet.Location = new System.Drawing.Point(176, 20);
            this.comboBoxTestDataSet.Name = "comboBoxTestDataSet";
            this.comboBoxTestDataSet.Size = new System.Drawing.Size(187, 28);
            this.comboBoxTestDataSet.TabIndex = 1;
            this.comboBoxTestDataSet.Text = "groceries.csv";
            // 
            // labelTestDataSet
            // 
            this.labelTestDataSet.AutoSize = true;
            this.labelTestDataSet.Location = new System.Drawing.Point(12, 23);
            this.labelTestDataSet.Name = "labelTestDataSet";
            this.labelTestDataSet.Size = new System.Drawing.Size(104, 20);
            this.labelTestDataSet.TabIndex = 0;
            this.labelTestDataSet.Text = "Test DataSet";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 1015);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Association Rule Learner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprioriAlgorithmToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxAssociations;
        private System.Windows.Forms.TextBox textBoxTransactions;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eCLATAlgorithmToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTestDataSet;
        private System.Windows.Forms.ComboBox comboBoxTestDataSet;
        private System.Windows.Forms.Label labelMinimumSupport;
        private System.Windows.Forms.TextBox textBoxMinimumSupport;
        private String csvString;
        private System.Windows.Forms.Button buttonExportToCsv;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem performanceTestToolStripMenuItem;
    }
}

