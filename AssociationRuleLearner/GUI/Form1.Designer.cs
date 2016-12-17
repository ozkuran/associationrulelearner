using System;
using System.Collections.Generic;
using System.Configuration;

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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.textBoxCommandTerminal = new System.Windows.Forms.TextBox();
            this.buttonExportToCsv = new System.Windows.Forms.Button();
            this.textBoxMinimumSupport = new System.Windows.Forms.TextBox();
            this.labelMinimumSupport = new System.Windows.Forms.Label();
            this.comboBoxTestDataSet = new System.Windows.Forms.ComboBox();
            this.labelTestDataSet = new System.Windows.Forms.Label();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.editToolStripMenuItem,
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
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.panel1.Controls.Add(this.textBoxOutput);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1466, 982);
            this.panel1.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(0, 254);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(1466, 728);
            this.textBoxOutput.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxCommandTerminal);
            this.panel2.Controls.Add(this.buttonExportToCsv);
            this.panel2.Controls.Add(this.textBoxMinimumSupport);
            this.panel2.Controls.Add(this.labelMinimumSupport);
            this.panel2.Controls.Add(this.comboBoxTestDataSet);
            this.panel2.Controls.Add(this.labelTestDataSet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1466, 254);
            this.panel2.TabIndex = 2;
            // 
            // textBoxCommandTerminal
            // 
            this.textBoxCommandTerminal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxCommandTerminal.Location = new System.Drawing.Point(0, 228);
            this.textBoxCommandTerminal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCommandTerminal.Name = "textBoxCommandTerminal";
            this.textBoxCommandTerminal.Size = new System.Drawing.Size(1466, 26);
            this.textBoxCommandTerminal.TabIndex = 5;
            this.textBoxCommandTerminal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCommandTerminal_KeyPress);
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
            var dataFiles = new List<string>(ConfigurationManager.AppSettings["datafiles"].Split(new char[] { ';' }));
            foreach (string dataFile in dataFiles)
            {
                this.comboBoxTestDataSet.Items.Add(dataFile);
            }
            this.comboBoxTestDataSet.FormattingEnabled = true;
            //this.comboBoxTestDataSet.Items.AddRange(new object[] {
            //"sample.txt",
            //"small.txt",
            //"groceries.csv",
            //"retail.dat"});
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(208, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
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
        private System.Windows.Forms.TextBox textBoxCommandTerminal;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

