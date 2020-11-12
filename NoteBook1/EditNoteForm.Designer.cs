namespace NoteBookApp
{
    partial class EditNoteForm
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
            this.ButtonToUpdate = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NoteText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonToUpdate
            // 
            this.ButtonToUpdate.Location = new System.Drawing.Point(242, 279);
            this.ButtonToUpdate.Name = "ButtonToUpdate";
            this.ButtonToUpdate.Size = new System.Drawing.Size(84, 26);
            this.ButtonToUpdate.TabIndex = 0;
            this.ButtonToUpdate.Text = "Update";
            this.ButtonToUpdate.UseVisualStyleBackColor = true;
            this.ButtonToUpdate.Click += new System.EventHandler(this.ButtonToUpdate_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(41, 49);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(69, 20);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Edit note";
            // 
            // NoteText
            // 
            this.NoteText.Location = new System.Drawing.Point(51, 91);
            this.NoteText.Multiline = true;
            this.NoteText.Name = "NoteText";
            this.NoteText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteText.Size = new System.Drawing.Size(473, 165);
            this.NoteText.TabIndex = 2;
            // 
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.Controls.Add(this.NoteText);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ButtonToUpdate);
            this.Name = "EditNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editing note";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditNoteFrom_FormClosing);
            this.Load += new System.EventHandler(this.EditNoteFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonToUpdate;
        private System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.TextBox NoteText;
    }
}