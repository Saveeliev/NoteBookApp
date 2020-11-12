namespace NoteBookApp
{
    partial class AccountForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LinkToEdit = new System.Windows.Forms.LinkLabel();
            this.LinkToEditUser = new System.Windows.Forms.LinkLabel();
            this.LabelUserLogin = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.LinkToEdit);
            this.MainPanel.Controls.Add(this.LinkToEditUser);
            this.MainPanel.Controls.Add(this.LabelUserLogin);
            this.MainPanel.Controls.Add(this.LabelUserName);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(560, 340);
            this.MainPanel.TabIndex = 0;
            // 
            // LinkToEdit
            // 
            this.LinkToEdit.AutoSize = true;
            this.LinkToEdit.LinkColor = System.Drawing.Color.Red;
            this.LinkToEdit.Location = new System.Drawing.Point(241, 177);
            this.LinkToEdit.Name = "LinkToEdit";
            this.LinkToEdit.Size = new System.Drawing.Size(65, 15);
            this.LinkToEdit.TabIndex = 2;
            this.LinkToEdit.TabStop = true;
            this.LinkToEdit.Text = "Delete user";
            this.LinkToEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LinkToEditUser
            // 
            this.LinkToEditUser.AutoSize = true;
            this.LinkToEditUser.Location = new System.Drawing.Point(241, 177);
            this.LinkToEditUser.Name = "LinkToEditUser";
            this.LinkToEditUser.Size = new System.Drawing.Size(52, 15);
            this.LinkToEditUser.TabIndex = 2;
            this.LinkToEditUser.TabStop = true;
            this.LinkToEditUser.Text = "Edit user";
            // 
            // LabelUserLogin
            // 
            this.LabelUserLogin.AutoSize = true;
            this.LabelUserLogin.Location = new System.Drawing.Point(256, 140);
            this.LabelUserLogin.Name = "LabelUserLogin";
            this.LabelUserLogin.Size = new System.Drawing.Size(37, 15);
            this.LabelUserLogin.TabIndex = 1;
            this.LabelUserLogin.Text = "Login";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelUserName.Location = new System.Drawing.Point(241, 110);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(69, 30);
            this.LabelUserName.TabIndex = 0;
            this.LabelUserName.Text = "Name";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.Controls.Add(this.MainPanel);
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.LinkLabel LinkToEditUser;
        private System.Windows.Forms.LinkLabel LinkToEdit;
        private System.Windows.Forms.Label LabelUserLogin;
        private System.Windows.Forms.Label LabelUserName;
    }
}