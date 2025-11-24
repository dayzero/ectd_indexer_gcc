//eCTD indexer (EU Module 1)
//Copyright 2007-2017 Ymir Vesteinsson, ymir@ectd.is

//This file is part of eCTD-indexer.

//eCTD-indexer is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//eCTD-indexer is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with eCTD-indexer.  If not, see <http://www.gnu.org/licenses/>.

namespace WindowsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxAppNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProcType = new System.Windows.Forms.ComboBox();
            this.comboBoxSubmUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSubmType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSubmDescr = new System.Windows.Forms.TextBox();
            this.labelSubmissionUnit = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMD5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNewMD5 = new System.Windows.Forms.TextBox();
            this.textBoxSeqDir = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBoxAE = new System.Windows.Forms.CheckBox();
            this.checkBoxBH = new System.Windows.Forms.CheckBox();
            this.checkBoxKW = new System.Windows.Forms.CheckBox();
            this.checkBoxOM = new System.Windows.Forms.CheckBox();
            this.checkBoxQA = new System.Windows.Forms.CheckBox();
            this.checkBoxSA = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxAE = new System.Windows.Forms.TextBox();
            this.checkBoxYE = new System.Windows.Forms.CheckBox();
            this.textBoxBH = new System.Windows.Forms.TextBox();
            this.textBoxKW = new System.Windows.Forms.TextBox();
            this.textBoxOM = new System.Windows.Forms.TextBox();
            this.textBoxQA = new System.Windows.Forms.TextBox();
            this.textBoxSA = new System.Windows.Forms.TextBox();
            this.textBoxYE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQAApp = new System.Windows.Forms.TextBox();
            this.textBoxOMApp = new System.Windows.Forms.TextBox();
            this.textBoxKWApp = new System.Windows.Forms.TextBox();
            this.textBoxBHApp = new System.Windows.Forms.TextBox();
            this.textBoxAEApp = new System.Windows.Forms.TextBox();
            this.textBoxYEApp = new System.Windows.Forms.TextBox();
            this.textBoxSAApp = new System.Windows.Forms.TextBox();
            this.folderButton2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.fileButton1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRelSeq = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.currentDossierButton = new System.Windows.Forms.Button();
            this.copyEnvelopeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxATC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAppNo
            // 
            this.textBoxAppNo.AcceptsReturn = true;
            this.textBoxAppNo.Location = new System.Drawing.Point(103, 29);
            this.textBoxAppNo.Name = "textBoxAppNo";
            this.textBoxAppNo.Size = new System.Drawing.Size(212, 20);
            this.textBoxAppNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application no.";
            // 
            // comboBoxProcType
            // 
            this.comboBoxProcType.FormattingEnabled = true;
            this.comboBoxProcType.Items.AddRange(new object[] {
            "gcc",
            "national"});
            this.comboBoxProcType.Location = new System.Drawing.Point(103, 52);
            this.comboBoxProcType.Name = "comboBoxProcType";
            this.comboBoxProcType.Size = new System.Drawing.Size(212, 21);
            this.comboBoxProcType.TabIndex = 1;
            // 
            // comboBoxSubmUnit
            // 
            this.comboBoxSubmUnit.FormattingEnabled = true;
            this.comboBoxSubmUnit.Items.AddRange(new object[] {
            "additional-info",
            "closing",
            "correction",
            "initial",
            "reformat",
            "response"});
            this.comboBoxSubmUnit.Location = new System.Drawing.Point(102, 104);
            this.comboBoxSubmUnit.Name = "comboBoxSubmUnit";
            this.comboBoxSubmUnit.Size = new System.Drawing.Size(212, 21);
            this.comboBoxSubmUnit.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Procedure type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Submission type";
            // 
            // comboBoxSubmType
            // 
            this.comboBoxSubmType.FormattingEnabled = true;
            this.comboBoxSubmType.Items.AddRange(new object[] {
            "asmf",
            "extension",
            "new-bio",
            "new-gen",
            "new-nce",
            "new-rad",
            "none",
            "pmf",
            "psur",
            "psusa",
            "renewal",
            "rmp",
            "transfer-ma",
            "usr",
            "var-type1",
            "var-type2",
            "withdrawal",
            "additional-info",
            "closing",
            "correction",
            "initial",
            "reformat",
            "response"});
            this.comboBoxSubmType.Location = new System.Drawing.Point(103, 78);
            this.comboBoxSubmType.Name = "comboBoxSubmType";
            this.comboBoxSubmType.Size = new System.Drawing.Size(212, 21);
            this.comboBoxSubmType.TabIndex = 2;
            this.comboBoxSubmType.Tag = "7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 111;
            this.button1.Text = "gc-regional";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "GC envelope information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(335, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "INN";
            // 
            // textBoxINN
            // 
            this.textBoxINN.Location = new System.Drawing.Point(426, 29);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(212, 20);
            this.textBoxINN.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Subm. descr.";
            // 
            // textBoxSubmDescr
            // 
            this.textBoxSubmDescr.Location = new System.Drawing.Point(426, 104);
            this.textBoxSubmDescr.Name = "textBoxSubmDescr";
            this.textBoxSubmDescr.Size = new System.Drawing.Size(212, 20);
            this.textBoxSubmDescr.TabIndex = 7;
            // 
            // labelSubmissionUnit
            // 
            this.labelSubmissionUnit.AutoSize = true;
            this.labelSubmissionUnit.Location = new System.Drawing.Point(12, 107);
            this.labelSubmissionUnit.Name = "labelSubmissionUnit";
            this.labelSubmissionUnit.Size = new System.Drawing.Size(80, 13);
            this.labelSubmissionUnit.TabIndex = 87;
            this.labelSubmissionUnit.Text = "Submission unit";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(377, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Calculate MD5 checksum for single file";
            // 
            // textBoxMD5
            // 
            this.textBoxMD5.Location = new System.Drawing.Point(379, 313);
            this.textBoxMD5.Name = "textBoxMD5";
            this.textBoxMD5.Size = new System.Drawing.Size(226, 20);
            this.textBoxMD5.TabIndex = 115;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 117;
            this.button2.Text = "MD5";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxNewMD5
            // 
            this.textBoxNewMD5.Location = new System.Drawing.Point(436, 338);
            this.textBoxNewMD5.Name = "textBoxNewMD5";
            this.textBoxNewMD5.Size = new System.Drawing.Size(149, 20);
            this.textBoxNewMD5.TabIndex = 118;
            // 
            // textBoxSeqDir
            // 
            this.textBoxSeqDir.Location = new System.Drawing.Point(13, 313);
            this.textBoxSeqDir.Name = "textBoxSeqDir";
            this.textBoxSeqDir.Size = new System.Drawing.Size(311, 20);
            this.textBoxSeqDir.TabIndex = 108;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 284);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Indexer";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Path to sequence directory (e.g. 0000):";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 112;
            this.button3.Text = "index.xml";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 113;
            this.button4.Text = "delete empty";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Country/Agency";
            // 
            // checkBoxAE
            // 
            this.checkBoxAE.AutoSize = true;
            this.checkBoxAE.Location = new System.Drawing.Point(14, 178);
            this.checkBoxAE.Name = "checkBoxAE";
            this.checkBoxAE.Size = new System.Drawing.Size(68, 17);
            this.checkBoxAE.TabIndex = 9;
            this.checkBoxAE.Tag = "AE";
            this.checkBoxAE.Text = "AE-MOH";
            this.checkBoxAE.UseVisualStyleBackColor = true;
            this.checkBoxAE.CheckedChanged += new System.EventHandler(this.checkBoxAE_CheckedChanged);
            // 
            // checkBoxBH
            // 
            this.checkBoxBH.AutoSize = true;
            this.checkBoxBH.Location = new System.Drawing.Point(14, 201);
            this.checkBoxBH.Name = "checkBoxBH";
            this.checkBoxBH.Size = new System.Drawing.Size(69, 17);
            this.checkBoxBH.TabIndex = 12;
            this.checkBoxBH.Tag = "BH";
            this.checkBoxBH.Text = "BH-MOH";
            this.checkBoxBH.UseVisualStyleBackColor = true;
            this.checkBoxBH.CheckedChanged += new System.EventHandler(this.checkBoxBH_CheckedChanged);
            // 
            // checkBoxKW
            // 
            this.checkBoxKW.AutoSize = true;
            this.checkBoxKW.Location = new System.Drawing.Point(14, 224);
            this.checkBoxKW.Name = "checkBoxKW";
            this.checkBoxKW.Size = new System.Drawing.Size(72, 17);
            this.checkBoxKW.TabIndex = 15;
            this.checkBoxKW.Tag = "KW";
            this.checkBoxKW.Text = "KW-MOH";
            this.checkBoxKW.UseVisualStyleBackColor = true;
            this.checkBoxKW.CheckedChanged += new System.EventHandler(this.checkBoxKW_CheckedChanged);
            // 
            // checkBoxOM
            // 
            this.checkBoxOM.AutoSize = true;
            this.checkBoxOM.Location = new System.Drawing.Point(14, 247);
            this.checkBoxOM.Name = "checkBoxOM";
            this.checkBoxOM.Size = new System.Drawing.Size(71, 17);
            this.checkBoxOM.TabIndex = 18;
            this.checkBoxOM.Tag = "OM";
            this.checkBoxOM.Text = "OM-MOH";
            this.checkBoxOM.UseVisualStyleBackColor = true;
            this.checkBoxOM.CheckedChanged += new System.EventHandler(this.checkBoxOM_CheckedChanged);
            // 
            // checkBoxQA
            // 
            this.checkBoxQA.AutoSize = true;
            this.checkBoxQA.Location = new System.Drawing.Point(338, 178);
            this.checkBoxQA.Name = "checkBoxQA";
            this.checkBoxQA.Size = new System.Drawing.Size(67, 17);
            this.checkBoxQA.TabIndex = 60;
            this.checkBoxQA.Tag = "QA";
            this.checkBoxQA.Text = "QA-NHA";
            this.checkBoxQA.UseVisualStyleBackColor = true;
            this.checkBoxQA.CheckedChanged += new System.EventHandler(this.checkBoxQA_CheckedChanged);
            // 
            // checkBoxSA
            // 
            this.checkBoxSA.AutoSize = true;
            this.checkBoxSA.Location = new System.Drawing.Point(338, 201);
            this.checkBoxSA.Name = "checkBoxSA";
            this.checkBoxSA.Size = new System.Drawing.Size(71, 17);
            this.checkBoxSA.TabIndex = 63;
            this.checkBoxSA.Tag = "SA";
            this.checkBoxSA.Text = "SA-SFDA";
            this.checkBoxSA.UseVisualStyleBackColor = true;
            this.checkBoxSA.CheckedChanged += new System.EventHandler(this.checkBoxSA_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(106, 161);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Invented name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(429, 161);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "Invented name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(335, 161);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 57;
            this.label22.Text = "Country/Agency";
            // 
            // textBoxAE
            // 
            this.textBoxAE.Enabled = false;
            this.textBoxAE.Location = new System.Drawing.Point(110, 179);
            this.textBoxAE.Name = "textBoxAE";
            this.textBoxAE.Size = new System.Drawing.Size(100, 20);
            this.textBoxAE.TabIndex = 10;
            this.textBoxAE.Tag = "AE";
            // 
            // checkBoxYE
            // 
            this.checkBoxYE.AutoSize = true;
            this.checkBoxYE.Location = new System.Drawing.Point(338, 224);
            this.checkBoxYE.Name = "checkBoxYE";
            this.checkBoxYE.Size = new System.Drawing.Size(82, 17);
            this.checkBoxYE.TabIndex = 66;
            this.checkBoxYE.Tag = "YE";
            this.checkBoxYE.Text = "YE-MOPHP";
            this.checkBoxYE.UseVisualStyleBackColor = true;
            this.checkBoxYE.CheckedChanged += new System.EventHandler(this.checkBoxYE_CheckedChanged);
            // 
            // textBoxBH
            // 
            this.textBoxBH.Enabled = false;
            this.textBoxBH.Location = new System.Drawing.Point(110, 201);
            this.textBoxBH.Name = "textBoxBH";
            this.textBoxBH.Size = new System.Drawing.Size(100, 20);
            this.textBoxBH.TabIndex = 13;
            this.textBoxBH.Tag = "BH";
            // 
            // textBoxKW
            // 
            this.textBoxKW.Enabled = false;
            this.textBoxKW.Location = new System.Drawing.Point(110, 224);
            this.textBoxKW.Name = "textBoxKW";
            this.textBoxKW.Size = new System.Drawing.Size(100, 20);
            this.textBoxKW.TabIndex = 16;
            this.textBoxKW.Tag = "KW";
            // 
            // textBoxOM
            // 
            this.textBoxOM.Enabled = false;
            this.textBoxOM.Location = new System.Drawing.Point(110, 247);
            this.textBoxOM.Name = "textBoxOM";
            this.textBoxOM.Size = new System.Drawing.Size(100, 20);
            this.textBoxOM.TabIndex = 19;
            this.textBoxOM.Tag = "OM";
            // 
            // textBoxQA
            // 
            this.textBoxQA.Enabled = false;
            this.textBoxQA.Location = new System.Drawing.Point(432, 178);
            this.textBoxQA.Name = "textBoxQA";
            this.textBoxQA.Size = new System.Drawing.Size(100, 20);
            this.textBoxQA.TabIndex = 61;
            this.textBoxQA.Tag = "QA";
            // 
            // textBoxSA
            // 
            this.textBoxSA.Enabled = false;
            this.textBoxSA.Location = new System.Drawing.Point(432, 201);
            this.textBoxSA.Name = "textBoxSA";
            this.textBoxSA.Size = new System.Drawing.Size(100, 20);
            this.textBoxSA.TabIndex = 64;
            this.textBoxSA.Tag = "SA";
            // 
            // textBoxYE
            // 
            this.textBoxYE.Enabled = false;
            this.textBoxYE.Location = new System.Drawing.Point(432, 224);
            this.textBoxYE.Name = "textBoxYE";
            this.textBoxYE.Size = new System.Drawing.Size(100, 20);
            this.textBoxYE.TabIndex = 67;
            this.textBoxYE.Tag = "YE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Applicant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Applicant";
            // 
            // textBoxQAApp
            // 
            this.textBoxQAApp.Enabled = false;
            this.textBoxQAApp.Location = new System.Drawing.Point(538, 177);
            this.textBoxQAApp.Name = "textBoxQAApp";
            this.textBoxQAApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxQAApp.TabIndex = 62;
            this.textBoxQAApp.Tag = "QA";
            // 
            // textBoxOMApp
            // 
            this.textBoxOMApp.Enabled = false;
            this.textBoxOMApp.Location = new System.Drawing.Point(216, 247);
            this.textBoxOMApp.Name = "textBoxOMApp";
            this.textBoxOMApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxOMApp.TabIndex = 20;
            this.textBoxOMApp.Tag = "OM";
            // 
            // textBoxKWApp
            // 
            this.textBoxKWApp.Enabled = false;
            this.textBoxKWApp.Location = new System.Drawing.Point(216, 224);
            this.textBoxKWApp.Name = "textBoxKWApp";
            this.textBoxKWApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxKWApp.TabIndex = 17;
            this.textBoxKWApp.Tag = "KW";
            // 
            // textBoxBHApp
            // 
            this.textBoxBHApp.Enabled = false;
            this.textBoxBHApp.Location = new System.Drawing.Point(216, 201);
            this.textBoxBHApp.Name = "textBoxBHApp";
            this.textBoxBHApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxBHApp.TabIndex = 14;
            this.textBoxBHApp.Tag = "BH";
            // 
            // textBoxAEApp
            // 
            this.textBoxAEApp.Enabled = false;
            this.textBoxAEApp.Location = new System.Drawing.Point(216, 178);
            this.textBoxAEApp.Name = "textBoxAEApp";
            this.textBoxAEApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxAEApp.TabIndex = 11;
            this.textBoxAEApp.Tag = "AE";
            // 
            // textBoxYEApp
            // 
            this.textBoxYEApp.Enabled = false;
            this.textBoxYEApp.Location = new System.Drawing.Point(538, 224);
            this.textBoxYEApp.Name = "textBoxYEApp";
            this.textBoxYEApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxYEApp.TabIndex = 68;
            this.textBoxYEApp.Tag = "YE";
            // 
            // textBoxSAApp
            // 
            this.textBoxSAApp.Enabled = false;
            this.textBoxSAApp.Location = new System.Drawing.Point(538, 201);
            this.textBoxSAApp.Name = "textBoxSAApp";
            this.textBoxSAApp.Size = new System.Drawing.Size(100, 20);
            this.textBoxSAApp.TabIndex = 65;
            this.textBoxSAApp.Tag = "SA";
            // 
            // folderButton2
            // 
            this.folderButton2.Location = new System.Drawing.Point(330, 311);
            this.folderButton2.Name = "folderButton2";
            this.folderButton2.Size = new System.Drawing.Size(24, 23);
            this.folderButton2.TabIndex = 109;
            this.folderButton2.Text = "...";
            this.folderButton2.UseVisualStyleBackColor = true;
            this.folderButton2.Click += new System.EventHandler(this.folderButton2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 110;
            this.button5.Text = "eCTD folder tree";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // fileButton1
            // 
            this.fileButton1.Location = new System.Drawing.Point(611, 310);
            this.fileButton1.Name = "fileButton1";
            this.fileButton1.Size = new System.Drawing.Size(26, 23);
            this.fileButton1.TabIndex = 116;
            this.fileButton1.Text = "...";
            this.fileButton1.UseVisualStyleBackColor = true;
            this.fileButton1.Click += new System.EventHandler(this.fileButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Rel. Sequence";
            // 
            // textBoxRelSeq
            // 
            this.textBoxRelSeq.Location = new System.Drawing.Point(426, 78);
            this.textBoxRelSeq.Name = "textBoxRelSeq";
            this.textBoxRelSeq.Size = new System.Drawing.Size(212, 20);
            this.textBoxRelSeq.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(591, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 23);
            this.button6.TabIndex = 119;
            this.button6.Text = "save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // currentDossierButton
            // 
            this.currentDossierButton.Location = new System.Drawing.Point(14, 367);
            this.currentDossierButton.Name = "currentDossierButton";
            this.currentDossierButton.Size = new System.Drawing.Size(158, 23);
            this.currentDossierButton.TabIndex = 114;
            this.currentDossierButton.Text = "Assemble current dossier";
            this.currentDossierButton.UseVisualStyleBackColor = true;
            this.currentDossierButton.Click += new System.EventHandler(this.currentDossierButton_Click);
            // 
            // copyEnvelopeButton
            // 
            this.copyEnvelopeButton.Location = new System.Drawing.Point(528, 367);
            this.copyEnvelopeButton.Name = "copyEnvelopeButton";
            this.copyEnvelopeButton.Size = new System.Drawing.Size(109, 23);
            this.copyEnvelopeButton.TabIndex = 8;
            this.copyEnvelopeButton.Text = "copy old envelope";
            this.copyEnvelopeButton.UseVisualStyleBackColor = true;
            this.copyEnvelopeButton.Click += new System.EventHandler(this.copyEnvelopeButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 121;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 115;
            this.label10.Text = "ATC";
            // 
            // textBoxATC
            // 
            this.textBoxATC.AcceptsReturn = true;
            this.textBoxATC.Location = new System.Drawing.Point(426, 52);
            this.textBoxATC.Name = "textBoxATC";
            this.textBoxATC.Size = new System.Drawing.Size(212, 20);
            this.textBoxATC.TabIndex = 122;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 407);
            this.Controls.Add(this.textBoxATC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxSubmUnit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.copyEnvelopeButton);
            this.Controls.Add(this.currentDossierButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBoxRelSeq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileButton1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.folderButton2);
            this.Controls.Add(this.textBoxYEApp);
            this.Controls.Add(this.textBoxSAApp);
            this.Controls.Add(this.textBoxQAApp);
            this.Controls.Add(this.textBoxOMApp);
            this.Controls.Add(this.textBoxKWApp);
            this.Controls.Add(this.textBoxBHApp);
            this.Controls.Add(this.textBoxAEApp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYE);
            this.Controls.Add(this.textBoxSA);
            this.Controls.Add(this.textBoxQA);
            this.Controls.Add(this.textBoxOM);
            this.Controls.Add(this.textBoxKW);
            this.Controls.Add(this.textBoxBH);
            this.Controls.Add(this.checkBoxYE);
            this.Controls.Add(this.textBoxAE);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.checkBoxSA);
            this.Controls.Add(this.checkBoxQA);
            this.Controls.Add(this.checkBoxOM);
            this.Controls.Add(this.checkBoxKW);
            this.Controls.Add(this.checkBoxBH);
            this.Controls.Add(this.checkBoxAE);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxSeqDir);
            this.Controls.Add(this.textBoxNewMD5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxMD5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxSubmDescr);
            this.Controls.Add(this.labelSubmissionUnit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxINN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSubmType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProcType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAppNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Tag = "6";
            this.Text = "eCTD indexer 2018-02 GC M1 v.1.1, eCTD v.3.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAppNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProcType;
		private System.Windows.Forms.ComboBox comboBoxSubmUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSubmType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSubmDescr;
		private System.Windows.Forms.Label labelSubmissionUnit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMD5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxNewMD5;
        private System.Windows.Forms.TextBox textBoxSeqDir;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBoxAE;
        private System.Windows.Forms.CheckBox checkBoxBH;
        private System.Windows.Forms.CheckBox checkBoxKW;
        private System.Windows.Forms.CheckBox checkBoxOM;
        private System.Windows.Forms.CheckBox checkBoxQA;
        private System.Windows.Forms.CheckBox checkBoxSA;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxAE;
        private System.Windows.Forms.CheckBox checkBoxYE;
        private System.Windows.Forms.TextBox textBoxBH;
        private System.Windows.Forms.TextBox textBoxKW;
        private System.Windows.Forms.TextBox textBoxOM;
        private System.Windows.Forms.TextBox textBoxQA;
        private System.Windows.Forms.TextBox textBoxSA;
        private System.Windows.Forms.TextBox textBoxYE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQAApp;
        private System.Windows.Forms.TextBox textBoxOMApp;
        private System.Windows.Forms.TextBox textBoxKWApp;
        private System.Windows.Forms.TextBox textBoxBHApp;
        private System.Windows.Forms.TextBox textBoxAEApp;
        private System.Windows.Forms.TextBox textBoxYEApp;
        private System.Windows.Forms.TextBox textBoxSAApp;
        private System.Windows.Forms.Button folderButton2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button fileButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRelSeq;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button currentDossierButton;
        private System.Windows.Forms.Button copyEnvelopeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxATC;
    }
}
