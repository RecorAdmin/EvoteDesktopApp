﻿namespace WindowsFormsApp1
{
    partial class RegisterForm
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
            this.gboxRegis = new System.Windows.Forms.GroupBox();
            this.MailBoxlabel = new System.Windows.Forms.Label();
            this.Communitylabel = new System.Windows.Forms.Label();
            this.Parishlabel = new System.Windows.Forms.Label();
            this.ParishcomboBox = new System.Windows.Forms.ComboBox();
            this.TitlecomboBox = new System.Windows.Forms.ComboBox();
            this.btnSighnUp = new System.Windows.Forms.Button();
            this.CPasslabel = new System.Windows.Forms.Label();
            this.tbRgCPass = new System.Windows.Forms.TextBox();
            this.Passlabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.tbRgPass = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.DOBdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DOBlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.OtherradioButton = new System.Windows.Forms.RadioButton();
            this.FemaleradioButton = new System.Windows.Forms.RadioButton();
            this.MaleradioButton = new System.Windows.Forms.RadioButton();
            this.Genderlabel = new System.Windows.Forms.Label();
            this.tbMailBox = new System.Windows.Forms.TextBox();
            this.tbCommunity = new System.Windows.Forms.TextBox();
            this.Lnamelabel = new System.Windows.Forms.Label();
            this.MidNamelabel = new System.Windows.Forms.Label();
            this.fnamelabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbMname = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.EvotesLogo = new System.Windows.Forms.Label();
            this.gboxRegis.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxRegis
            // 
            this.gboxRegis.Controls.Add(this.MailBoxlabel);
            this.gboxRegis.Controls.Add(this.Communitylabel);
            this.gboxRegis.Controls.Add(this.Parishlabel);
            this.gboxRegis.Controls.Add(this.ParishcomboBox);
            this.gboxRegis.Controls.Add(this.TitlecomboBox);
            this.gboxRegis.Controls.Add(this.btnSighnUp);
            this.gboxRegis.Controls.Add(this.CPasslabel);
            this.gboxRegis.Controls.Add(this.tbRgCPass);
            this.gboxRegis.Controls.Add(this.Passlabel);
            this.gboxRegis.Controls.Add(this.emaillabel);
            this.gboxRegis.Controls.Add(this.tbRgPass);
            this.gboxRegis.Controls.Add(this.tbEmail);
            this.gboxRegis.Controls.Add(this.DOBdateTimePicker);
            this.gboxRegis.Controls.Add(this.DOBlabel);
            this.gboxRegis.Controls.Add(this.Namelabel);
            this.gboxRegis.Controls.Add(this.Addresslabel);
            this.gboxRegis.Controls.Add(this.OtherradioButton);
            this.gboxRegis.Controls.Add(this.FemaleradioButton);
            this.gboxRegis.Controls.Add(this.MaleradioButton);
            this.gboxRegis.Controls.Add(this.Genderlabel);
            this.gboxRegis.Controls.Add(this.tbMailBox);
            this.gboxRegis.Controls.Add(this.tbCommunity);
            this.gboxRegis.Controls.Add(this.Lnamelabel);
            this.gboxRegis.Controls.Add(this.MidNamelabel);
            this.gboxRegis.Controls.Add(this.fnamelabel);
            this.gboxRegis.Controls.Add(this.title);
            this.gboxRegis.Controls.Add(this.tbLname);
            this.gboxRegis.Controls.Add(this.tbMname);
            this.gboxRegis.Controls.Add(this.tbFname);
            this.gboxRegis.Location = new System.Drawing.Point(129, 64);
            this.gboxRegis.Name = "gboxRegis";
            this.gboxRegis.Size = new System.Drawing.Size(542, 387);
            this.gboxRegis.TabIndex = 29;
            this.gboxRegis.TabStop = false;
            this.gboxRegis.Text = "Registration ";
            // 
            // MailBoxlabel
            // 
            this.MailBoxlabel.AutoSize = true;
            this.MailBoxlabel.Location = new System.Drawing.Point(283, 242);
            this.MailBoxlabel.Name = "MailBoxlabel";
            this.MailBoxlabel.Size = new System.Drawing.Size(49, 13);
            this.MailBoxlabel.TabIndex = 31;
            this.MailBoxlabel.Text = "P.O. Box";
            // 
            // Communitylabel
            // 
            this.Communitylabel.AutoSize = true;
            this.Communitylabel.Location = new System.Drawing.Point(153, 242);
            this.Communitylabel.Name = "Communitylabel";
            this.Communitylabel.Size = new System.Drawing.Size(58, 13);
            this.Communitylabel.TabIndex = 30;
            this.Communitylabel.Text = "Community";
            // 
            // Parishlabel
            // 
            this.Parishlabel.AutoSize = true;
            this.Parishlabel.Location = new System.Drawing.Point(66, 242);
            this.Parishlabel.Name = "Parishlabel";
            this.Parishlabel.Size = new System.Drawing.Size(36, 13);
            this.Parishlabel.TabIndex = 29;
            this.Parishlabel.Text = "Parish";
            // 
            // ParishcomboBox
            // 
            this.ParishcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParishcomboBox.FormattingEnabled = true;
            this.ParishcomboBox.Items.AddRange(new object[] {
            "Hanover",
            "St. Elizabeth",
            "St. James",
            "Trelawny",
            "Westmoreland",
            "Clarendon",
            "Manchester",
            "St. Ann",
            "St. Catherine",
            "St. Mary",
            "Kingston ",
            "Portland",
            "St. Andrew",
            "St. Thomas"});
            this.ParishcomboBox.Location = new System.Drawing.Point(69, 218);
            this.ParishcomboBox.Name = "ParishcomboBox";
            this.ParishcomboBox.Size = new System.Drawing.Size(81, 21);
            this.ParishcomboBox.TabIndex = 28;
            // 
            // TitlecomboBox
            // 
            this.TitlecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TitlecomboBox.FormattingEnabled = true;
            this.TitlecomboBox.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss"});
            this.TitlecomboBox.Location = new System.Drawing.Point(69, 51);
            this.TitlecomboBox.Name = "TitlecomboBox";
            this.TitlecomboBox.Size = new System.Drawing.Size(40, 21);
            this.TitlecomboBox.TabIndex = 27;
            // 
            // btnSighnUp
            // 
            this.btnSighnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSighnUp.Location = new System.Drawing.Point(424, 340);
            this.btnSighnUp.Name = "btnSighnUp";
            this.btnSighnUp.Size = new System.Drawing.Size(75, 23);
            this.btnSighnUp.TabIndex = 26;
            this.btnSighnUp.Text = "Sign Up";
            this.btnSighnUp.UseVisualStyleBackColor = true;
            // 
            // CPasslabel
            // 
            this.CPasslabel.AutoSize = true;
            this.CPasslabel.Location = new System.Drawing.Point(66, 350);
            this.CPasslabel.Name = "CPasslabel";
            this.CPasslabel.Size = new System.Drawing.Size(91, 13);
            this.CPasslabel.TabIndex = 25;
            this.CPasslabel.Text = "Confirm Password";
            // 
            // tbRgCPass
            // 
            this.tbRgCPass.Location = new System.Drawing.Point(68, 327);
            this.tbRgCPass.Name = "tbRgCPass";
            this.tbRgCPass.Size = new System.Drawing.Size(124, 20);
            this.tbRgCPass.TabIndex = 24;
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Location = new System.Drawing.Point(196, 300);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(53, 13);
            this.Passlabel.TabIndex = 23;
            this.Passlabel.Text = "Password";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(65, 300);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(32, 13);
            this.emaillabel.TabIndex = 22;
            this.emaillabel.Text = "Email";
            // 
            // tbRgPass
            // 
            this.tbRgPass.Location = new System.Drawing.Point(198, 277);
            this.tbRgPass.Name = "tbRgPass";
            this.tbRgPass.Size = new System.Drawing.Size(124, 20);
            this.tbRgPass.TabIndex = 21;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(68, 277);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(124, 20);
            this.tbEmail.TabIndex = 20;
            // 
            // DOBdateTimePicker
            // 
            this.DOBdateTimePicker.Location = new System.Drawing.Point(115, 171);
            this.DOBdateTimePicker.Name = "DOBdateTimePicker";
            this.DOBdateTimePicker.Size = new System.Drawing.Size(214, 20);
            this.DOBdateTimePicker.TabIndex = 19;
            // 
            // DOBlabel
            // 
            this.DOBlabel.AutoSize = true;
            this.DOBlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlabel.Location = new System.Drawing.Point(65, 153);
            this.DOBlabel.Name = "DOBlabel";
            this.DOBlabel.Size = new System.Drawing.Size(83, 13);
            this.DOBlabel.TabIndex = 18;
            this.DOBlabel.Text = "Date of Birth:";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(65, 33);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(82, 13);
            this.Namelabel.TabIndex = 17;
            this.Namelabel.Text = "Name / Title:";
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslabel.Location = new System.Drawing.Point(65, 201);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(56, 13);
            this.Addresslabel.TabIndex = 16;
            this.Addresslabel.Text = "Address:";
            // 
            // OtherradioButton
            // 
            this.OtherradioButton.AutoSize = true;
            this.OtherradioButton.Location = new System.Drawing.Point(234, 117);
            this.OtherradioButton.Name = "OtherradioButton";
            this.OtherradioButton.Size = new System.Drawing.Size(51, 17);
            this.OtherradioButton.TabIndex = 15;
            this.OtherradioButton.TabStop = true;
            this.OtherradioButton.Text = "Other";
            this.OtherradioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleradioButton
            // 
            this.FemaleradioButton.AutoSize = true;
            this.FemaleradioButton.Location = new System.Drawing.Point(169, 117);
            this.FemaleradioButton.Name = "FemaleradioButton";
            this.FemaleradioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleradioButton.TabIndex = 14;
            this.FemaleradioButton.TabStop = true;
            this.FemaleradioButton.Text = "Female";
            this.FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            this.MaleradioButton.AutoSize = true;
            this.MaleradioButton.Location = new System.Drawing.Point(115, 117);
            this.MaleradioButton.Name = "MaleradioButton";
            this.MaleradioButton.Size = new System.Drawing.Size(48, 17);
            this.MaleradioButton.TabIndex = 13;
            this.MaleradioButton.TabStop = true;
            this.MaleradioButton.Text = "Male";
            this.MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // Genderlabel
            // 
            this.Genderlabel.AutoSize = true;
            this.Genderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlabel.Location = new System.Drawing.Point(65, 99);
            this.Genderlabel.Name = "Genderlabel";
            this.Genderlabel.Size = new System.Drawing.Size(52, 13);
            this.Genderlabel.TabIndex = 12;
            this.Genderlabel.Text = "Gender:";
            // 
            // tbMailBox
            // 
            this.tbMailBox.Location = new System.Drawing.Point(286, 219);
            this.tbMailBox.Name = "tbMailBox";
            this.tbMailBox.Size = new System.Drawing.Size(124, 20);
            this.tbMailBox.TabIndex = 11;
            // 
            // tbCommunity
            // 
            this.tbCommunity.Location = new System.Drawing.Point(156, 219);
            this.tbCommunity.Name = "tbCommunity";
            this.tbCommunity.Size = new System.Drawing.Size(124, 20);
            this.tbCommunity.TabIndex = 10;
            // 
            // Lnamelabel
            // 
            this.Lnamelabel.AutoSize = true;
            this.Lnamelabel.Location = new System.Drawing.Point(372, 74);
            this.Lnamelabel.Name = "Lnamelabel";
            this.Lnamelabel.Size = new System.Drawing.Size(58, 13);
            this.Lnamelabel.TabIndex = 8;
            this.Lnamelabel.Text = "Last Name";
            // 
            // MidNamelabel
            // 
            this.MidNamelabel.AutoSize = true;
            this.MidNamelabel.Location = new System.Drawing.Point(242, 74);
            this.MidNamelabel.Name = "MidNamelabel";
            this.MidNamelabel.Size = new System.Drawing.Size(69, 13);
            this.MidNamelabel.TabIndex = 7;
            this.MidNamelabel.Text = "Middle Name";
            // 
            // fnamelabel
            // 
            this.fnamelabel.AutoSize = true;
            this.fnamelabel.Location = new System.Drawing.Point(112, 74);
            this.fnamelabel.Name = "fnamelabel";
            this.fnamelabel.Size = new System.Drawing.Size(57, 13);
            this.fnamelabel.TabIndex = 6;
            this.fnamelabel.Text = "First Name";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(65, 74);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(27, 13);
            this.title.TabIndex = 5;
            this.title.Text = "Title";
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(375, 51);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(124, 20);
            this.tbLname.TabIndex = 4;
            // 
            // tbMname
            // 
            this.tbMname.Location = new System.Drawing.Point(245, 51);
            this.tbMname.Name = "tbMname";
            this.tbMname.Size = new System.Drawing.Size(124, 20);
            this.tbMname.TabIndex = 3;
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(115, 51);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(124, 20);
            this.tbFname.TabIndex = 2;
            // 
            // EvotesLogo
            // 
            this.EvotesLogo.AutoSize = true;
            this.EvotesLogo.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvotesLogo.Location = new System.Drawing.Point(348, 0);
            this.EvotesLogo.Name = "EvotesLogo";
            this.EvotesLogo.Size = new System.Drawing.Size(157, 61);
            this.EvotesLogo.TabIndex = 28;
            this.EvotesLogo.Text = "Evotes";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.gboxRegis);
            this.Controls.Add(this.EvotesLogo);
            this.Name = "Form2";
            this.Text = "RegisterForm";
            this.gboxRegis.ResumeLayout(false);
            this.gboxRegis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxRegis;
        private System.Windows.Forms.Label MailBoxlabel;
        private System.Windows.Forms.Label Communitylabel;
        private System.Windows.Forms.Label Parishlabel;
        private System.Windows.Forms.ComboBox ParishcomboBox;
        private System.Windows.Forms.ComboBox TitlecomboBox;
        private System.Windows.Forms.Button btnSighnUp;
        private System.Windows.Forms.Label CPasslabel;
        private System.Windows.Forms.TextBox tbRgCPass;
        private System.Windows.Forms.Label Passlabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox tbRgPass;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker DOBdateTimePicker;
        private System.Windows.Forms.Label DOBlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.RadioButton OtherradioButton;
        private System.Windows.Forms.RadioButton FemaleradioButton;
        private System.Windows.Forms.RadioButton MaleradioButton;
        private System.Windows.Forms.Label Genderlabel;
        private System.Windows.Forms.TextBox tbMailBox;
        private System.Windows.Forms.TextBox tbCommunity;
        private System.Windows.Forms.Label Lnamelabel;
        private System.Windows.Forms.Label MidNamelabel;
        private System.Windows.Forms.Label fnamelabel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbMname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Label EvotesLogo;
    }
}