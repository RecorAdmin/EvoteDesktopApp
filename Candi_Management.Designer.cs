namespace WindowsFormsApp1
{
    partial class Candi_Management
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
            this.gvCandidates = new System.Windows.Forms.DataGridView();
            this.EvotesLogo = new System.Windows.Forms.Label();
            this.btncEdit = new System.Windows.Forms.Button();
            this.btncDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCandidates)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCandidates
            // 
            this.gvCandidates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCandidates.Location = new System.Drawing.Point(12, 88);
            this.gvCandidates.Name = "gvCandidates";
            this.gvCandidates.Size = new System.Drawing.Size(842, 273);
            this.gvCandidates.TabIndex = 0;
            // 
            // EvotesLogo
            // 
            this.EvotesLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EvotesLogo.AutoSize = true;
            this.EvotesLogo.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvotesLogo.Location = new System.Drawing.Point(12, 9);
            this.EvotesLogo.Name = "EvotesLogo";
            this.EvotesLogo.Size = new System.Drawing.Size(595, 61);
            this.EvotesLogo.TabIndex = 29;
            this.EvotesLogo.Text = "Candidate List Management";
            // 
            // btncEdit
            // 
            this.btncEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncEdit.Location = new System.Drawing.Point(699, 378);
            this.btncEdit.Name = "btncEdit";
            this.btncEdit.Size = new System.Drawing.Size(75, 23);
            this.btncEdit.TabIndex = 30;
            this.btncEdit.Text = "Edit";
            this.btncEdit.UseVisualStyleBackColor = true;
            this.btncEdit.Click += new System.EventHandler(this.btncEdit_Click);
            // 
            // btncDelete
            // 
            this.btncDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncDelete.Location = new System.Drawing.Point(780, 378);
            this.btncDelete.Name = "btncDelete";
            this.btncDelete.Size = new System.Drawing.Size(75, 23);
            this.btncDelete.TabIndex = 31;
            this.btncDelete.Text = "Delete";
            this.btncDelete.UseVisualStyleBackColor = true;
            this.btncDelete.Click += new System.EventHandler(this.btncDelete_Click);
            // 
            // Candi_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 425);
            this.Controls.Add(this.btncDelete);
            this.Controls.Add(this.btncEdit);
            this.Controls.Add(this.EvotesLogo);
            this.Controls.Add(this.gvCandidates);
            this.Name = "Candi_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Candi_Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Candi_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCandidates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvCandidates;
        private System.Windows.Forms.Label EvotesLogo;
        private System.Windows.Forms.Button btncEdit;
        private System.Windows.Forms.Button btncDelete;
    }
}