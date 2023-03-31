namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbloginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gboxLogin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linklabRegis = new System.Windows.Forms.LinkLabel();
            this.linkRegis = new System.Windows.Forms.LinkLabel();
            this.gboxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evotes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(131, 38);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(214, 20);
            this.tbUsername.TabIndex = 3;
            // 
            // tbloginPassword
            // 
            this.tbloginPassword.Location = new System.Drawing.Point(131, 64);
            this.tbloginPassword.Name = "tbloginPassword";
            this.tbloginPassword.Size = new System.Drawing.Size(214, 20);
            this.tbloginPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(270, 90);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 27);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gboxLogin
            // 
            this.gboxLogin.Controls.Add(this.btnLogin);
            this.gboxLogin.Controls.Add(this.tbloginPassword);
            this.gboxLogin.Controls.Add(this.tbUsername);
            this.gboxLogin.Controls.Add(this.label3);
            this.gboxLogin.Controls.Add(this.label2);
            this.gboxLogin.Location = new System.Drawing.Point(153, 148);
            this.gboxLogin.Name = "gboxLogin";
            this.gboxLogin.Size = new System.Drawing.Size(400, 143);
            this.gboxLogin.TabIndex = 6;
            this.gboxLogin.TabStop = false;
            this.gboxLogin.Text = "User Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Need an Account?";
            // 
            // linklabRegis
            // 
            this.linklabRegis.AutoSize = true;
            this.linklabRegis.Location = new System.Drawing.Point(365, 294);
            this.linklabRegis.Name = "linklabRegis";
            this.linklabRegis.Size = new System.Drawing.Size(0, 13);
            this.linklabRegis.TabIndex = 8;
            this.linklabRegis.TabStop = true;
            // 
            // linkRegis
            // 
            this.linkRegis.AutoSize = true;
            this.linkRegis.Location = new System.Drawing.Point(368, 294);
            this.linkRegis.Name = "linkRegis";
            this.linkRegis.Size = new System.Drawing.Size(74, 13);
            this.linkRegis.TabIndex = 9;
            this.linkRegis.TabStop = true;
            this.linkRegis.Text = "Register Now!";
            this.linkRegis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegis_LinkClicked);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(668, 438);
            this.Controls.Add(this.linkRegis);
            this.Controls.Add(this.linklabRegis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gboxLogin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "LoginForm";
            this.gboxLogin.ResumeLayout(false);
            this.gboxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbloginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox gboxLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linklabRegis;
        private System.Windows.Forms.LinkLabel linkRegis;
    }
}

