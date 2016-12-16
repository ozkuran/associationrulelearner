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
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExportToCsv = new System.Windows.Forms.Button();
            this.textBoxMinimumSupport = new System.Windows.Forms.TextBox();
            this.labelMinimumSupport = new System.Windows.Forms.Label();
            this.comboBoxTestDataSet = new System.Windows.Forms.ComboBox();
            this.labelTestDataSet = new System.Windows.Forms.Label();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.runToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.runToolStripMenuItem.Text = "Run Tests";
            // 
            // aprioriAlgorithmToolStripMenuItem
            // 
            this.aprioriAlgorithmToolStripMenuItem.Name = "aprioriAlgorithmToolStripMenuItem";
            this.aprioriAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aprioriAlgorithmToolStripMenuItem.Text = "Apriori Algorithm";
            this.aprioriAlgorithmToolStripMenuItem.Click += new System.EventHandler(this.aprioriAlgorithmToolStripMenuItem_Click);
            // 
            // eCLATAlgorithmToolStripMenuItem
            // 
            this.eCLATAlgorithmToolStripMenuItem.Name = "eCLATAlgorithmToolStripMenuItem";
            this.eCLATAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.eCLATAlgorithmToolStripMenuItem.Text = "ECLAT Algorithm";
            this.eCLATAlgorithmToolStripMenuItem.Click += new System.EventHandler(this.eCLATAlgorithmToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // performanceTestToolStripMenuItem
            // 
            this.performanceTestToolStripMenuItem.Name = "performanceTestToolStripMenuItem";
            this.performanceTestToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.performanceTestToolStripMenuItem.Text = "Performance Test";
            this.performanceTestToolStripMenuItem.Click += new System.EventHandler(this.performanceTestToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxOutput);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 636);
            this.panel1.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(0, 162);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(977, 474);
            this.textBoxOutput.TabIndex = 1;
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 162);
            this.panel2.TabIndex = 2;
            // 
            // buttonExportToCsv
            // 
            this.buttonExportToCsv.Location = new System.Drawing.Point(11, 80);
            this.buttonExportToCsv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExportToCsv.Name = "buttonExportToCsv";
            this.buttonExportToCsv.Size = new System.Drawing.Size(86, 31);
            this.buttonExportToCsv.TabIndex = 4;
            this.buttonExportToCsv.Text = "Export To CSV";
            this.buttonExportToCsv.UseVisualStyleBackColor = true;
            this.buttonExportToCsv.Click += new System.EventHandler(this.buttonExportToCsv_Click);
            // 
            // textBoxMinimumSupport
            // 
            this.textBoxMinimumSupport.Location = new System.Drawing.Point(117, 44);
            this.textBoxMinimumSupport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMinimumSupport.Name = "textBoxMinimumSupport";
            this.textBoxMinimumSupport.Size = new System.Drawing.Size(126, 20);
            this.textBoxMinimumSupport.TabIndex = 3;
            this.textBoxMinimumSupport.Text = "0.1";
            // 
            // labelMinimumSupport
            // 
            this.labelMinimumSupport.AutoSize = true;
            this.labelMinimumSupport.Location = new System.Drawing.Point(8, 46);
            this.labelMinimumSupport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinimumSupport.Name = "labelMinimumSupport";
            this.labelMinimumSupport.Size = new System.Drawing.Size(88, 13);
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
            this.comboBoxTestDataSet.Location = new System.Drawing.Point(117, 13);
            this.comboBoxTestDataSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTestDataSet.Name = "comboBoxTestDataSet";
            this.comboBoxTestDataSet.Size = new System.Drawing.Size(126, 21);
            this.comboBoxTestDataSet.TabIndex = 1;
            this.comboBoxTestDataSet.Text = "groceries.csv";
            // 
            // labelTestDataSet
            // 
            this.labelTestDataSet.AutoSize = true;
            this.labelTestDataSet.Location = new System.Drawing.Point(8, 15);
            this.labelTestDataSet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTestDataSet.Name = "labelTestDataSet";
            this.labelTestDataSet.Size = new System.Drawing.Size(70, 13);
            this.labelTestDataSet.TabIndex = 0;
            this.labelTestDataSet.Text = "Test DataSet";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox textBoxOutput;
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
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

