namespace InfoBox.Test
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Threading;

    public class InformationBoxDesigner : Form
    {
		#region Autogenerated

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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txbText = new System.Windows.Forms.TextBox();
			this.txbTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdbUser1User2 = new System.Windows.Forms.RadioButton();
			this.rdbOKCancelUser1 = new System.Windows.Forms.RadioButton();
			this.rdbYesNoUser1 = new System.Windows.Forms.RadioButton();
			this.rdbYesNoCancel = new System.Windows.Forms.RadioButton();
			this.rdbYesNo = new System.Windows.Forms.RadioButton();
			this.rdbRetryCancel = new System.Windows.Forms.RadioButton();
			this.rdbOKCancel = new System.Windows.Forms.RadioButton();
			this.rdbOK = new System.Windows.Forms.RadioButton();
			this.rdbAbortRetryIgnore = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rdbSuccess = new System.Windows.Forms.RadioButton();
			this.rdbWarning = new System.Windows.Forms.RadioButton();
			this.rdbStop = new System.Windows.Forms.RadioButton();
			this.rdbQuestion = new System.Windows.Forms.RadioButton();
			this.rdbNone = new System.Windows.Forms.RadioButton();
			this.rdbInformation = new System.Windows.Forms.RadioButton();
			this.rdbHand = new System.Windows.Forms.RadioButton();
			this.rdbExclamation = new System.Windows.Forms.RadioButton();
			this.rdbError = new System.Windows.Forms.RadioButton();
			this.rdbAsterisk = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txbUser2 = new System.Windows.Forms.TextBox();
			this.txbUser1 = new System.Windows.Forms.TextBox();
			this.btnShow = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.rdbButton3 = new System.Windows.Forms.RadioButton();
			this.rdbButton2 = new System.Windows.Forms.RadioButton();
			this.rdbButton1 = new System.Windows.Forms.RadioButton();
			this.txbCode = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.btnIcon = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txbIcon = new System.Windows.Forms.TextBox();
			this.ofdIcon = new System.Windows.Forms.OpenFileDialog();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.rdbLayoutSeparate = new System.Windows.Forms.RadioButton();
			this.rdbLayoutGroupMiddle = new System.Windows.Forms.RadioButton();
			this.rdbLayoutGroupRight = new System.Windows.Forms.RadioButton();
			this.rdbLayoutGroupLeft = new System.Windows.Forms.RadioButton();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.ddlLanguage = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.rdbAutoSizeNone = new System.Windows.Forms.RadioButton();
			this.rdbAutoSizeMinimumHeight = new System.Windows.Forms.RadioButton();
			this.rdbAutoSizeMinimumWidth = new System.Windows.Forms.RadioButton();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.rdbPositionCenterOnScreen = new System.Windows.Forms.RadioButton();
			this.rdbPositionCenterOnParent = new System.Windows.Forms.RadioButton();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.chbShowHelp = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txbText);
			this.groupBox1.Controls.Add(this.txbTitle);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 148);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Labels";
			// 
			// txbText
			// 
			this.txbText.Location = new System.Drawing.Point(51, 44);
			this.txbText.Multiline = true;
			this.txbText.Name = "txbText";
			this.txbText.Size = new System.Drawing.Size(196, 92);
			this.txbText.TabIndex = 2;
			this.txbText.Text = "";
			// 
			// txbTitle
			// 
			this.txbTitle.Location = new System.Drawing.Point(51, 18);
			this.txbTitle.Name = "txbTitle";
			this.txbTitle.Size = new System.Drawing.Size(196, 20);
			this.txbTitle.TabIndex = 1;
			this.txbTitle.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Text";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdbUser1User2);
			this.groupBox2.Controls.Add(this.rdbOKCancelUser1);
			this.groupBox2.Controls.Add(this.rdbYesNoUser1);
			this.groupBox2.Controls.Add(this.rdbYesNoCancel);
			this.groupBox2.Controls.Add(this.rdbYesNo);
			this.groupBox2.Controls.Add(this.rdbRetryCancel);
			this.groupBox2.Controls.Add(this.rdbOKCancel);
			this.groupBox2.Controls.Add(this.rdbOK);
			this.groupBox2.Controls.Add(this.rdbAbortRetryIgnore);
			this.groupBox2.Location = new System.Drawing.Point(294, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 122);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Buttons";
			// 
			// rdbUser1User2
			// 
			this.rdbUser1User2.Location = new System.Drawing.Point(147, 79);
			this.rdbUser1User2.Name = "rdbUser1User2";
			this.rdbUser1User2.Size = new System.Drawing.Size(101, 17);
			this.rdbUser1User2.TabIndex = 8;
			this.rdbUser1User2.Text = "User1User2";
			// 
			// rdbOKCancelUser1
			// 
			this.rdbOKCancelUser1.Location = new System.Drawing.Point(147, 59);
			this.rdbOKCancelUser1.Name = "rdbOKCancelUser1";
			this.rdbOKCancelUser1.Size = new System.Drawing.Size(101, 17);
			this.rdbOKCancelUser1.TabIndex = 7;
			this.rdbOKCancelUser1.Text = "OKCancelUser1";
			// 
			// rdbYesNoUser1
			// 
			this.rdbYesNoUser1.Location = new System.Drawing.Point(147, 39);
			this.rdbYesNoUser1.Name = "rdbYesNoUser1";
			this.rdbYesNoUser1.Size = new System.Drawing.Size(101, 17);
			this.rdbYesNoUser1.TabIndex = 6;
			this.rdbYesNoUser1.Text = "YesNoUser1";
			// 
			// rdbYesNoCancel
			// 
			this.rdbYesNoCancel.Location = new System.Drawing.Point(147, 19);
			this.rdbYesNoCancel.Name = "rdbYesNoCancel";
			this.rdbYesNoCancel.Size = new System.Drawing.Size(101, 17);
			this.rdbYesNoCancel.TabIndex = 5;
			this.rdbYesNoCancel.Text = "YesNoCancel";
			// 
			// rdbYesNo
			// 
			this.rdbYesNo.Location = new System.Drawing.Point(17, 99);
			this.rdbYesNo.Name = "rdbYesNo";
			this.rdbYesNo.Size = new System.Drawing.Size(119, 17);
			this.rdbYesNo.TabIndex = 4;
			this.rdbYesNo.Text = "YesNo";
			// 
			// rdbRetryCancel
			// 
			this.rdbRetryCancel.Location = new System.Drawing.Point(17, 79);
			this.rdbRetryCancel.Name = "rdbRetryCancel";
			this.rdbRetryCancel.Size = new System.Drawing.Size(119, 17);
			this.rdbRetryCancel.TabIndex = 3;
			this.rdbRetryCancel.Text = "RetryCancel";
			// 
			// rdbOKCancel
			// 
			this.rdbOKCancel.Location = new System.Drawing.Point(17, 59);
			this.rdbOKCancel.Name = "rdbOKCancel";
			this.rdbOKCancel.Size = new System.Drawing.Size(119, 17);
			this.rdbOKCancel.TabIndex = 2;
			this.rdbOKCancel.Text = "OKCancel";
			// 
			// rdbOK
			// 
			this.rdbOK.Checked = true;
			this.rdbOK.Location = new System.Drawing.Point(17, 39);
			this.rdbOK.Name = "rdbOK";
			this.rdbOK.Size = new System.Drawing.Size(119, 17);
			this.rdbOK.TabIndex = 1;
			this.rdbOK.TabStop = true;
			this.rdbOK.Text = "OK";
			// 
			// rdbAbortRetryIgnore
			// 
			this.rdbAbortRetryIgnore.Location = new System.Drawing.Point(17, 19);
			this.rdbAbortRetryIgnore.Name = "rdbAbortRetryIgnore";
			this.rdbAbortRetryIgnore.Size = new System.Drawing.Size(119, 17);
			this.rdbAbortRetryIgnore.TabIndex = 0;
			this.rdbAbortRetryIgnore.Text = "AbortRetryIgnore";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rdbSuccess);
			this.groupBox3.Controls.Add(this.rdbWarning);
			this.groupBox3.Controls.Add(this.rdbStop);
			this.groupBox3.Controls.Add(this.rdbQuestion);
			this.groupBox3.Controls.Add(this.rdbNone);
			this.groupBox3.Controls.Add(this.rdbInformation);
			this.groupBox3.Controls.Add(this.rdbHand);
			this.groupBox3.Controls.Add(this.rdbExclamation);
			this.groupBox3.Controls.Add(this.rdbError);
			this.groupBox3.Controls.Add(this.rdbAsterisk);
			this.groupBox3.Location = new System.Drawing.Point(12, 166);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(264, 125);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Icon";
			// 
			// rdbSuccess
			// 
			this.rdbSuccess.Location = new System.Drawing.Point(147, 99);
			this.rdbSuccess.Name = "rdbSuccess";
			this.rdbSuccess.Size = new System.Drawing.Size(77, 17);
			this.rdbSuccess.TabIndex = 9;
			this.rdbSuccess.Text = "Success";
			// 
			// rdbWarning
			// 
			this.rdbWarning.Location = new System.Drawing.Point(147, 79);
			this.rdbWarning.Name = "rdbWarning";
			this.rdbWarning.Size = new System.Drawing.Size(77, 17);
			this.rdbWarning.TabIndex = 8;
			this.rdbWarning.Text = "Warning";
			// 
			// rdbStop
			// 
			this.rdbStop.Location = new System.Drawing.Point(147, 59);
			this.rdbStop.Name = "rdbStop";
			this.rdbStop.Size = new System.Drawing.Size(77, 17);
			this.rdbStop.TabIndex = 7;
			this.rdbStop.Text = "Stop";
			// 
			// rdbQuestion
			// 
			this.rdbQuestion.Location = new System.Drawing.Point(147, 39);
			this.rdbQuestion.Name = "rdbQuestion";
			this.rdbQuestion.Size = new System.Drawing.Size(77, 17);
			this.rdbQuestion.TabIndex = 6;
			this.rdbQuestion.Text = "Question";
			// 
			// rdbNone
			// 
			this.rdbNone.Checked = true;
			this.rdbNone.Location = new System.Drawing.Point(147, 19);
			this.rdbNone.Name = "rdbNone";
			this.rdbNone.Size = new System.Drawing.Size(77, 17);
			this.rdbNone.TabIndex = 5;
			this.rdbNone.TabStop = true;
			this.rdbNone.Text = "None";
			// 
			// rdbInformation
			// 
			this.rdbInformation.Location = new System.Drawing.Point(17, 99);
			this.rdbInformation.Name = "rdbInformation";
			this.rdbInformation.Size = new System.Drawing.Size(95, 17);
			this.rdbInformation.TabIndex = 4;
			this.rdbInformation.Text = "Information";
			// 
			// rdbHand
			// 
			this.rdbHand.Location = new System.Drawing.Point(17, 79);
			this.rdbHand.Name = "rdbHand";
			this.rdbHand.Size = new System.Drawing.Size(95, 17);
			this.rdbHand.TabIndex = 3;
			this.rdbHand.Text = "Hand";
			// 
			// rdbExclamation
			// 
			this.rdbExclamation.Location = new System.Drawing.Point(17, 59);
			this.rdbExclamation.Name = "rdbExclamation";
			this.rdbExclamation.Size = new System.Drawing.Size(95, 17);
			this.rdbExclamation.TabIndex = 2;
			this.rdbExclamation.Text = "Exclamation";
			// 
			// rdbError
			// 
			this.rdbError.Location = new System.Drawing.Point(17, 39);
			this.rdbError.Name = "rdbError";
			this.rdbError.Size = new System.Drawing.Size(95, 17);
			this.rdbError.TabIndex = 1;
			this.rdbError.Text = "Error";
			// 
			// rdbAsterisk
			// 
			this.rdbAsterisk.Location = new System.Drawing.Point(17, 19);
			this.rdbAsterisk.Name = "rdbAsterisk";
			this.rdbAsterisk.Size = new System.Drawing.Size(95, 17);
			this.rdbAsterisk.TabIndex = 0;
			this.rdbAsterisk.Text = "Asterisk";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txbUser2);
			this.groupBox4.Controls.Add(this.txbUser1);
			this.groupBox4.Location = new System.Drawing.Point(294, 140);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(264, 50);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Custom buttons";
			// 
			// txbUser2
			// 
			this.txbUser2.Location = new System.Drawing.Point(137, 23);
			this.txbUser2.Name = "txbUser2";
			this.txbUser2.Size = new System.Drawing.Size(110, 20);
			this.txbUser2.TabIndex = 1;
			this.txbUser2.Text = "User2";
			// 
			// txbUser1
			// 
			this.txbUser1.Location = new System.Drawing.Point(17, 23);
			this.txbUser1.Name = "txbUser1";
			this.txbUser1.Size = new System.Drawing.Size(110, 20);
			this.txbUser1.TabIndex = 0;
			this.txbUser1.Text = "User1";
			// 
			// btnShow
			// 
			this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnShow.Location = new System.Drawing.Point(324, 490);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(183, 27);
			this.btnShow.TabIndex = 7;
			this.btnShow.Text = "Show";
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.rdbButton3);
			this.groupBox5.Controls.Add(this.rdbButton2);
			this.groupBox5.Controls.Add(this.rdbButton1);
			this.groupBox5.Location = new System.Drawing.Point(294, 196);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(264, 45);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Default button";
			// 
			// rdbButton3
			// 
			this.rdbButton3.Location = new System.Drawing.Point(167, 19);
			this.rdbButton3.Name = "rdbButton3";
			this.rdbButton3.Size = new System.Drawing.Size(62, 17);
			this.rdbButton3.TabIndex = 2;
			this.rdbButton3.Text = "Button3";
			// 
			// rdbButton2
			// 
			this.rdbButton2.Location = new System.Drawing.Point(103, 19);
			this.rdbButton2.Name = "rdbButton2";
			this.rdbButton2.Size = new System.Drawing.Size(62, 17);
			this.rdbButton2.TabIndex = 1;
			this.rdbButton2.Text = "Button2";
			// 
			// rdbButton1
			// 
			this.rdbButton1.Checked = true;
			this.rdbButton1.Location = new System.Drawing.Point(35, 19);
			this.rdbButton1.Name = "rdbButton1";
			this.rdbButton1.Size = new System.Drawing.Size(62, 17);
			this.rdbButton1.TabIndex = 0;
			this.rdbButton1.TabStop = true;
			this.rdbButton1.Text = "Button1";
			// 
			// txbCode
			// 
			this.txbCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txbCode.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txbCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbCode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txbCode.Location = new System.Drawing.Point(12, 527);
			this.txbCode.Multiline = true;
			this.txbCode.Name = "txbCode";
			this.txbCode.ReadOnly = true;
			this.txbCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txbCode.Size = new System.Drawing.Size(546, 67);
			this.txbCode.TabIndex = 8;
			this.txbCode.Text = "";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnGenerate.Location = new System.Drawing.Point(61, 490);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(183, 27);
			this.btnGenerate.TabIndex = 6;
			this.btnGenerate.Text = "Generate code";
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.btnIcon);
			this.groupBox6.Controls.Add(this.label3);
			this.groupBox6.Controls.Add(this.txbIcon);
			this.groupBox6.Location = new System.Drawing.Point(12, 297);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(264, 50);
			this.groupBox6.TabIndex = 9;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Custom icon";
			// 
			// btnIcon
			// 
			this.btnIcon.Location = new System.Drawing.Point(214, 18);
			this.btnIcon.Name = "btnIcon";
			this.btnIcon.Size = new System.Drawing.Size(33, 22);
			this.btnIcon.TabIndex = 2;
			this.btnIcon.Text = "...";
			this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Icon file";
			// 
			// txbIcon
			// 
			this.txbIcon.Location = new System.Drawing.Point(51, 19);
			this.txbIcon.Name = "txbIcon";
			this.txbIcon.Size = new System.Drawing.Size(157, 20);
			this.txbIcon.TabIndex = 0;
			this.txbIcon.Text = "";
			// 
			// ofdIcon
			// 
			this.ofdIcon.Filter = "Icon file|*.ico";
			this.ofdIcon.Title = "Choose an icon file";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.rdbLayoutSeparate);
			this.groupBox7.Controls.Add(this.rdbLayoutGroupMiddle);
			this.groupBox7.Controls.Add(this.rdbLayoutGroupRight);
			this.groupBox7.Controls.Add(this.rdbLayoutGroupLeft);
			this.groupBox7.Location = new System.Drawing.Point(294, 247);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(264, 65);
			this.groupBox7.TabIndex = 10;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Buttons layout";
			// 
			// rdbLayoutSeparate
			// 
			this.rdbLayoutSeparate.Location = new System.Drawing.Point(147, 37);
			this.rdbLayoutSeparate.Name = "rdbLayoutSeparate";
			this.rdbLayoutSeparate.Size = new System.Drawing.Size(101, 17);
			this.rdbLayoutSeparate.TabIndex = 3;
			this.rdbLayoutSeparate.Text = "Separate";
			// 
			// rdbLayoutGroupMiddle
			// 
			this.rdbLayoutGroupMiddle.Checked = true;
			this.rdbLayoutGroupMiddle.Location = new System.Drawing.Point(147, 17);
			this.rdbLayoutGroupMiddle.Name = "rdbLayoutGroupMiddle";
			this.rdbLayoutGroupMiddle.Size = new System.Drawing.Size(101, 17);
			this.rdbLayoutGroupMiddle.TabIndex = 2;
			this.rdbLayoutGroupMiddle.TabStop = true;
			this.rdbLayoutGroupMiddle.Text = "GroupMiddle";
			// 
			// rdbLayoutGroupRight
			// 
			this.rdbLayoutGroupRight.Location = new System.Drawing.Point(17, 37);
			this.rdbLayoutGroupRight.Name = "rdbLayoutGroupRight";
			this.rdbLayoutGroupRight.Size = new System.Drawing.Size(103, 17);
			this.rdbLayoutGroupRight.TabIndex = 1;
			this.rdbLayoutGroupRight.Text = "GroupRight";
			// 
			// rdbLayoutGroupLeft
			// 
			this.rdbLayoutGroupLeft.Location = new System.Drawing.Point(17, 17);
			this.rdbLayoutGroupLeft.Name = "rdbLayoutGroupLeft";
			this.rdbLayoutGroupLeft.Size = new System.Drawing.Size(103, 17);
			this.rdbLayoutGroupLeft.TabIndex = 0;
			this.rdbLayoutGroupLeft.Text = "GroupLeft";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.ddlLanguage);
			this.groupBox8.Controls.Add(this.label4);
			this.groupBox8.Location = new System.Drawing.Point(294, 318);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(264, 50);
			this.groupBox8.TabIndex = 11;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Language";
			// 
			// ddlLanguage
			// 
			this.ddlLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlLanguage.Items.AddRange(new object[] {
															 "en - English",
															 "fr - Fran�ais"});
			this.ddlLanguage.Location = new System.Drawing.Point(72, 19);
			this.ddlLanguage.Name = "ddlLanguage";
			this.ddlLanguage.Size = new System.Drawing.Size(165, 21);
			this.ddlLanguage.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Language";
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.rdbAutoSizeNone);
			this.groupBox9.Controls.Add(this.rdbAutoSizeMinimumHeight);
			this.groupBox9.Controls.Add(this.rdbAutoSizeMinimumWidth);
			this.groupBox9.Location = new System.Drawing.Point(12, 353);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(264, 64);
			this.groupBox9.TabIndex = 12;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "AutoSize";
			// 
			// rdbAutoSizeNone
			// 
			this.rdbAutoSizeNone.Checked = true;
			this.rdbAutoSizeNone.Location = new System.Drawing.Point(147, 20);
			this.rdbAutoSizeNone.Name = "rdbAutoSizeNone";
			this.rdbAutoSizeNone.Size = new System.Drawing.Size(109, 17);
			this.rdbAutoSizeNone.TabIndex = 2;
			this.rdbAutoSizeNone.TabStop = true;
			this.rdbAutoSizeNone.Text = "None";
			// 
			// rdbAutoSizeMinimumHeight
			// 
			this.rdbAutoSizeMinimumHeight.Location = new System.Drawing.Point(17, 40);
			this.rdbAutoSizeMinimumHeight.Name = "rdbAutoSizeMinimumHeight";
			this.rdbAutoSizeMinimumHeight.Size = new System.Drawing.Size(111, 17);
			this.rdbAutoSizeMinimumHeight.TabIndex = 1;
			this.rdbAutoSizeMinimumHeight.Text = "MinimumHeight";
			// 
			// rdbAutoSizeMinimumWidth
			// 
			this.rdbAutoSizeMinimumWidth.Location = new System.Drawing.Point(17, 20);
			this.rdbAutoSizeMinimumWidth.Name = "rdbAutoSizeMinimumWidth";
			this.rdbAutoSizeMinimumWidth.Size = new System.Drawing.Size(111, 17);
			this.rdbAutoSizeMinimumWidth.TabIndex = 0;
			this.rdbAutoSizeMinimumWidth.TabStop = true;
			this.rdbAutoSizeMinimumWidth.Text = "MinimumWidth";
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.rdbPositionCenterOnScreen);
			this.groupBox10.Controls.Add(this.rdbPositionCenterOnParent);
			this.groupBox10.Location = new System.Drawing.Point(294, 374);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(264, 43);
			this.groupBox10.TabIndex = 13;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Position";
			// 
			// rdbPositionCenterOnScreen
			// 
			this.rdbPositionCenterOnScreen.Location = new System.Drawing.Point(9, 19);
			this.rdbPositionCenterOnScreen.Name = "rdbPositionCenterOnScreen";
			this.rdbPositionCenterOnScreen.Size = new System.Drawing.Size(111, 17);
			this.rdbPositionCenterOnScreen.TabIndex = 6;
			this.rdbPositionCenterOnScreen.Text = "CenterOnScreen";
			// 
			// rdbPositionCenterOnParent
			// 
			this.rdbPositionCenterOnParent.Checked = true;
			this.rdbPositionCenterOnParent.Location = new System.Drawing.Point(149, 19);
			this.rdbPositionCenterOnParent.Name = "rdbPositionCenterOnParent";
			this.rdbPositionCenterOnParent.Size = new System.Drawing.Size(107, 17);
			this.rdbPositionCenterOnParent.TabIndex = 4;
			this.rdbPositionCenterOnParent.TabStop = true;
			this.rdbPositionCenterOnParent.Text = "CenterOnParent";
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.chbShowHelp);
			this.groupBox11.Location = new System.Drawing.Point(12, 424);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(264, 48);
			this.groupBox11.TabIndex = 14;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Help";
			// 
			// chbShowHelp
			// 
			this.chbShowHelp.Location = new System.Drawing.Point(16, 16);
			this.chbShowHelp.Name = "chbShowHelp";
			this.chbShowHelp.Size = new System.Drawing.Size(120, 24);
			this.chbShowHelp.TabIndex = 0;
			this.chbShowHelp.Text = "Show Help button";
			// 
			// InformationBoxDesigner
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(568, 606);
			this.Controls.Add(this.groupBox11);
			this.Controls.Add(this.groupBox10);
			this.Controls.Add(this.groupBox9);
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txbCode);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "InformationBoxDesigner";
			this.Text = "InformationBox Designer";
			this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.InformationBoxDesigner_HelpRequested);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox11.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txbText;
		private System.Windows.Forms.TextBox txbTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdbUser1User2;
		private System.Windows.Forms.RadioButton rdbOKCancelUser1;
		private System.Windows.Forms.RadioButton rdbYesNoUser1;
		private System.Windows.Forms.RadioButton rdbYesNoCancel;
		private System.Windows.Forms.RadioButton rdbYesNo;
		private System.Windows.Forms.RadioButton rdbRetryCancel;
		private System.Windows.Forms.RadioButton rdbOKCancel;
		private System.Windows.Forms.RadioButton rdbOK;
		private System.Windows.Forms.RadioButton rdbAbortRetryIgnore;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rdbSuccess;
		private System.Windows.Forms.RadioButton rdbWarning;
		private System.Windows.Forms.RadioButton rdbStop;
		private System.Windows.Forms.RadioButton rdbQuestion;
		private System.Windows.Forms.RadioButton rdbNone;
		private System.Windows.Forms.RadioButton rdbInformation;
		private System.Windows.Forms.RadioButton rdbHand;
		private System.Windows.Forms.RadioButton rdbExclamation;
		private System.Windows.Forms.RadioButton rdbError;
		private System.Windows.Forms.RadioButton rdbAsterisk;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txbUser2;
		private System.Windows.Forms.TextBox txbUser1;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton rdbButton3;
		private System.Windows.Forms.RadioButton rdbButton2;
		private System.Windows.Forms.RadioButton rdbButton1;
		private System.Windows.Forms.TextBox txbCode;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button btnIcon;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txbIcon;
		private System.Windows.Forms.OpenFileDialog ofdIcon;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.RadioButton rdbLayoutSeparate;
		private System.Windows.Forms.RadioButton rdbLayoutGroupMiddle;
		private System.Windows.Forms.RadioButton rdbLayoutGroupRight;
		private System.Windows.Forms.RadioButton rdbLayoutGroupLeft;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.ComboBox ddlLanguage;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.RadioButton rdbAutoSizeNone;
		private System.Windows.Forms.RadioButton rdbAutoSizeMinimumHeight;
		private System.Windows.Forms.RadioButton rdbAutoSizeMinimumWidth;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.RadioButton rdbPositionCenterOnScreen;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.CheckBox chbShowHelp;
		private System.Windows.Forms.RadioButton rdbPositionCenterOnParent;

		#endregion Autogenerated

        public InformationBoxDesigner()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <returns></returns>
        private InformationBoxButtons GetButtons()
        {
            if (rdbAbortRetryIgnore.Checked) return InformationBoxButtons.AbortRetryIgnore;
            if (rdbOK.Checked) return InformationBoxButtons.OK;
            if (rdbOKCancel.Checked) return InformationBoxButtons.OKCancel;
            if (rdbRetryCancel.Checked) return InformationBoxButtons.RetryCancel;
            if (rdbYesNo.Checked) return InformationBoxButtons.YesNo;
            if (rdbYesNoCancel.Checked) return InformationBoxButtons.YesNoCancel;
            if (rdbYesNoUser1.Checked) return InformationBoxButtons.YesNoUser1;
            if (rdbOKCancelUser1.Checked) return InformationBoxButtons.OKCancelUser1;
            if (rdbUser1User2.Checked) return InformationBoxButtons.User1User2;
            return InformationBoxButtons.OK;
        }

        /// <summary>
        /// Gets the icon.
        /// </summary>
        /// <returns></returns>
        private InformationBoxIcon GetIcon()
        {
            if (rdbAsterisk.Checked) return InformationBoxIcon.Asterisk;
            if (rdbError.Checked) return InformationBoxIcon.Error;
            if (rdbExclamation.Checked) return InformationBoxIcon.Exclamation;
            if (rdbHand.Checked) return InformationBoxIcon.Hand;
            if (rdbInformation.Checked) return InformationBoxIcon.Information;
            if (rdbNone.Checked) return InformationBoxIcon.None;
            if (rdbQuestion.Checked) return InformationBoxIcon.Question;
            if (rdbStop.Checked) return InformationBoxIcon.Stop;
            if (rdbWarning.Checked) return InformationBoxIcon.Warning;
            if (rdbSuccess.Checked) return InformationBoxIcon.Success;
            return InformationBoxIcon.None;
        }

        /// <summary>
        /// Gets the default button.
        /// </summary>
        /// <returns></returns>
        private InformationBoxDefaultButton GetDefaultButton()
        {
            if (rdbButton1.Checked) return InformationBoxDefaultButton.Button1;
            if (rdbButton2.Checked) return InformationBoxDefaultButton.Button2;
            if (rdbButton3.Checked) return InformationBoxDefaultButton.Button3;
            return InformationBoxDefaultButton.Button1;
        }

        /// <summary>
        /// Gets the buttons layout.
        /// </summary>
        /// <returns></returns>
        private InformationBoxButtonsLayout GetButtonsLayout()
        {
            if (rdbLayoutGroupLeft.Checked) return InformationBoxButtonsLayout.GroupLeft;
            if (rdbLayoutGroupRight.Checked) return InformationBoxButtonsLayout.GroupRight;
            if (rdbLayoutGroupMiddle.Checked) return InformationBoxButtonsLayout.GroupMiddle;
            if (rdbLayoutSeparate.Checked) return InformationBoxButtonsLayout.Separate;
            return InformationBoxButtonsLayout.GroupMiddle;
        }

        /// <summary>
        /// Gets the auto size mode.
        /// </summary>
        /// <returns></returns>
        private InformationBoxAutoSizeMode GetAutoSize()
        {
            if (rdbAutoSizeMinimumHeight.Checked) return InformationBoxAutoSizeMode.MinimumHeight;
            if (rdbAutoSizeMinimumWidth.Checked) return InformationBoxAutoSizeMode.MinimumWidth;
            return InformationBoxAutoSizeMode.None;
        }

        /// <summary>
        /// Gets the position.
        /// </summary>
        /// <returns></returns>
        private InformationBoxPosition GetPosition()
        {
            if (rdbPositionCenterOnParent.Checked) return InformationBoxPosition.CenterOnParent;
            if (rdbPositionCenterOnScreen.Checked) return InformationBoxPosition.CenterOnScreen;
            return InformationBoxPosition.CenterOnParent;
        }

        /// <summary>
        /// Generates the code.
        /// </summary>
        private void GenerateCode()
        {
            InformationBoxButtons buttons = GetButtons();
            InformationBoxIcon icon = GetIcon();
            String iconFileName = txbIcon.Text;
            InformationBoxDefaultButton defaultButton = GetDefaultButton();
            InformationBoxButtonsLayout buttonsLayout = GetButtonsLayout();
            InformationBoxAutoSizeMode autoSize = GetAutoSize();
            InformationBoxPosition position = GetPosition();

			if (String.Empty.Equals(iconFileName))
			{
				txbCode.Text = String.Format(
					    "InformationBox.Show(\"{0}\", \"{1}\", InformationBoxButtons.{2}, new string[] {{ \"{3}\", \"{4}\" }}, InformationBoxIcon.{5}, InformationBoxDefaultButton.{6}, InformationBoxButtonsLayout.{7}, InformationBoxAutoSizeMode.{8}, InformationBoxPosition.{9}, {10});",
						txbText.Text.Replace(Environment.NewLine, "\\n"), txbTitle.Text, buttons, txbUser1.Text,
						txbUser2.Text, icon, defaultButton, buttonsLayout, autoSize, position, chbShowHelp.Checked).Replace("\"\"", "String.Empty");
			}
			else
			{
				txbCode.Text = String.Format(
						"InformationBox.Show(\"{0}\", \"{1}\", InformationBoxButtons.{2}, new string[] {{ \"{3}\", \"{4}\" }}, new System.Drawing.Icon(@\"{5}\"), InformationBoxDefaultButton.{6}, InformationBoxButtonsLayout.{7}, InformationBoxAutoSizeMode.{8}, InformationBoxPosition.{9}, {10});",
						txbText.Text.Replace(Environment.NewLine, "\\n"), txbTitle.Text, buttons, txbUser1.Text,
						txbUser2.Text, iconFileName, defaultButton, buttonsLayout, autoSize, position, chbShowHelp.Checked).Replace("\"\"", "String.Empty");
			}
        }

        /// <summary>
        /// Handles the Click event of the btnShow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (null != ddlLanguage.SelectedItem)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(ddlLanguage.SelectedItem.ToString().Substring(0, 2));
            }

            InformationBoxButtons buttons = GetButtons();
            InformationBoxIcon icon = GetIcon();
            String iconFileName = txbIcon.Text;
            InformationBoxDefaultButton defaultButton = GetDefaultButton();
            InformationBoxButtonsLayout buttonsLayout = GetButtonsLayout();
            InformationBoxAutoSizeMode autoSize = GetAutoSize();
            InformationBoxPosition position = GetPosition();

			if (String.Empty.Equals(iconFileName))
			{
				InformationBox.Show(txbText.Text, txbTitle.Text, buttons, new string[] { txbUser1.Text, txbUser2.Text }, icon, defaultButton, buttonsLayout, autoSize, position, chbShowHelp.Checked);
			}
			else
			{
				InformationBox.Show(txbText.Text, txbTitle.Text, buttons, new string[] { txbUser1.Text, txbUser2.Text }, new Icon(iconFileName), defaultButton, buttonsLayout, autoSize, position, chbShowHelp.Checked);
			}
        }

        /// <summary>
        /// Handles the Click event of the btnGenerate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateCode();
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            if (ofdIcon.ShowDialog() != DialogResult.OK)
            {
                txbIcon.Text = String.Empty;
            }

            txbIcon.Text = ofdIcon.FileName;
        }

		private void InformationBoxDesigner_HelpRequested(object sender, System.Windows.Forms.HelpEventArgs hlpevent)
		{
			InformationBox.Show("Help has been requested somewhere", "Help", InformationBoxButtons.OK, InformationBoxIcon.Question);
		}

    }
}