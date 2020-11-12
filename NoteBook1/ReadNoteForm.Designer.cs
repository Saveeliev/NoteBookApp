namespace NoteBookApp
{
    partial class ReadNoteForm
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
            this.NoteText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NoteText
            // 
            this.NoteText.Location = new System.Drawing.Point(48, 66);
            this.NoteText.Multiline = true;
            this.NoteText.Name = "NoteText";
            this.NoteText.ReadOnly = true;
            this.NoteText.Size = new System.Drawing.Size(480, 210);
            this.NoteText.TabIndex = 0;
            // 
            // ReadNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.Controls.Add(this.NoteText);
            this.Name = "ReadNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoteText;
    }
}