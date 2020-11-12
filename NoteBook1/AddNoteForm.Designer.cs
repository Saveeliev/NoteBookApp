namespace NoteBookApp
{
    partial class AddNoteForm
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
            this.ButtonToAddNote = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.EnterText = new System.Windows.Forms.TextBox();
            this.CheckBoxIsPrivate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonToAddNote
            // 
            this.ButtonToAddNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonToAddNote.Location = new System.Drawing.Point(242, 273);
            this.ButtonToAddNote.Name = "ButtonToAddNote";
            this.ButtonToAddNote.Size = new System.Drawing.Size(84, 26);
            this.ButtonToAddNote.TabIndex = 0;
            this.ButtonToAddNote.Text = "Add";
            this.ButtonToAddNote.UseVisualStyleBackColor = true;
            this.ButtonToAddNote.Click += new System.EventHandler(this.ButtonToAddNote_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(36, 61);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(73, 20);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "New note";
            // 
            // EnterText
            // 
            this.EnterText.Location = new System.Drawing.Point(48, 98);
            this.EnterText.Multiline = true;
            this.EnterText.Name = "EnterText";
            this.EnterText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EnterText.Size = new System.Drawing.Size(481, 122);
            this.EnterText.TabIndex = 2;
            // 
            // CheckBoxIsPrivate
            // 
            this.CheckBoxIsPrivate.AutoSize = true;
            this.CheckBoxIsPrivate.Location = new System.Drawing.Point(111, 242);
            this.CheckBoxIsPrivate.Name = "CheckBoxIsPrivate";
            this.CheckBoxIsPrivate.Size = new System.Drawing.Size(62, 19);
            this.CheckBoxIsPrivate.TabIndex = 3;
            this.CheckBoxIsPrivate.Text = "Private";
            this.CheckBoxIsPrivate.UseVisualStyleBackColor = true;
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.Controls.Add(this.CheckBoxIsPrivate);
            this.Controls.Add(this.EnterText);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonToAddNote);
            this.Name = "AddNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new note";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNoteForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonToAddNote;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox EnterText;
        private System.Windows.Forms.CheckBox CheckBoxIsPrivate;
    }
}