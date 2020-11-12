namespace NoteBookApp
{
    partial class UserInterfaceControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterfaceControl));
            this.MainMenu = new System.Windows.Forms.ToolStrip();
            this.ButtonToAddNote = new System.Windows.Forms.ToolStripButton();
            this.ButtonToExit = new System.Windows.Forms.ToolStripButton();
            this.LabelName = new System.Windows.Forms.ToolStripLabel();
            this.ButtonToSortByDate = new System.Windows.Forms.ToolStripDropDownButton();
            this.SortByDateOldFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.NotesPanel = new System.Windows.Forms.Panel();
            this.LinkToFill = new System.Windows.Forms.LinkLabel();
            this.LinkToDeleteNotes = new System.Windows.Forms.LinkLabel();
            this.LeftMenu = new System.Windows.Forms.MenuStrip();
            this.AllNotesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyNotesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FavoriteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecycleBinItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.LeftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = false;
            this.MainMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonToAddNote,
            this.ButtonToExit,
            this.LabelName,
            this.ButtonToSortByDate});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MainMenu.Size = new System.Drawing.Size(600, 35);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // ButtonToAddNote
            // 
            this.ButtonToAddNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonToAddNote.Image = ((System.Drawing.Image)(resources.GetObject("ButtonToAddNote.Image")));
            this.ButtonToAddNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonToAddNote.Name = "ButtonToAddNote";
            this.ButtonToAddNote.Size = new System.Drawing.Size(23, 32);
            this.ButtonToAddNote.Text = "Add Note";
            this.ButtonToAddNote.ToolTipText = "Add Note";
            this.ButtonToAddNote.Click += new System.EventHandler(this.ButtonToAddNote_Click);
            // 
            // ButtonToExit
            // 
            this.ButtonToExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ButtonToExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonToExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonToExit.Image")));
            this.ButtonToExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonToExit.Name = "ButtonToExit";
            this.ButtonToExit.Size = new System.Drawing.Size(23, 32);
            this.ButtonToExit.Text = "Exit";
            this.ButtonToExit.Click += new System.EventHandler(this.ButtonToExit_Click);
            // 
            // LabelName
            // 
            this.LabelName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LabelName.IsLink = true;
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(39, 32);
            this.LabelName.Text = "Name";
            this.LabelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // ButtonToSortByDate
            // 
            this.ButtonToSortByDate.AutoToolTip = false;
            this.ButtonToSortByDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonToSortByDate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortByDateOldFirst});
            this.ButtonToSortByDate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonToSortByDate.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.ButtonToSortByDate.Name = "ButtonToSortByDate";
            this.ButtonToSortByDate.Size = new System.Drawing.Size(83, 32);
            this.ButtonToSortByDate.Text = "Sort by date";
            // 
            // SortByDateOldFirst
            // 
            this.SortByDateOldFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SortByDateOldFirst.Name = "SortByDateOldFirst";
            this.SortByDateOldFirst.Size = new System.Drawing.Size(116, 22);
            this.SortByDateOldFirst.Text = "Old first";
            this.SortByDateOldFirst.Click += new System.EventHandler(this.SortByDateOldFirst_Click);
            // 
            // NotesPanel
            // 
            this.NotesPanel.AutoScroll = true;
            this.NotesPanel.Location = new System.Drawing.Point(137, 52);
            this.NotesPanel.Name = "NotesPanel";
            this.NotesPanel.Size = new System.Drawing.Size(447, 266);
            this.NotesPanel.TabIndex = 1;
            // 
            // LinkToFill
            // 
            this.LinkToFill.AutoSize = true;
            this.LinkToFill.Location = new System.Drawing.Point(536, 336);
            this.LinkToFill.Name = "LinkToFill";
            this.LinkToFill.Size = new System.Drawing.Size(35, 15);
            this.LinkToFill.TabIndex = 2;
            this.LinkToFill.TabStop = true;
            this.LinkToFill.Text = "Fill in";
            this.LinkToFill.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToFill_LinkClicked);
            // 
            // LinkToDeleteNotes
            // 
            this.LinkToDeleteNotes.AutoSize = true;
            this.LinkToDeleteNotes.Location = new System.Drawing.Point(464, 336);
            this.LinkToDeleteNotes.Name = "LinkToDeleteNotes";
            this.LinkToDeleteNotes.Size = new System.Drawing.Size(57, 15);
            this.LinkToDeleteNotes.TabIndex = 3;
            this.LinkToDeleteNotes.TabStop = true;
            this.LinkToDeleteNotes.Text = "Delete All";
            this.LinkToDeleteNotes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToDeleteNotes_LinkClicked);
            // 
            // LeftMenu
            // 
            this.LeftMenu.AutoSize = false;
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.LeftMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllNotesItem,
            this.MyNotesItem,
            this.FavoriteItem,
            this.RecycleBinItem});
            this.LeftMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.LeftMenu.Location = new System.Drawing.Point(12, 52);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(112, 266);
            this.LeftMenu.TabIndex = 4;
            this.LeftMenu.Text = "menuStrip1";
            // 
            // AllNotesItem
            // 
            this.AllNotesItem.AutoSize = false;
            this.AllNotesItem.Name = "AllNotesItem";
            this.AllNotesItem.Size = new System.Drawing.Size(105, 29);
            this.AllNotesItem.Text = "All notes";
            this.AllNotesItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllNotesItem.Click += new System.EventHandler(this.AllNotesItem_Click);
            // 
            // MyNotesItem
            // 
            this.MyNotesItem.AutoSize = false;
            this.MyNotesItem.Name = "MyNotesItem";
            this.MyNotesItem.Size = new System.Drawing.Size(105, 29);
            this.MyNotesItem.Text = "My notes";
            this.MyNotesItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyNotesItem.Click += new System.EventHandler(this.MyNotesItem_Click);
            // 
            // FavoriteItem
            // 
            this.FavoriteItem.AutoSize = false;
            this.FavoriteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FavoriteItem.Name = "FavoriteItem";
            this.FavoriteItem.Size = new System.Drawing.Size(105, 29);
            this.FavoriteItem.Text = "Favorites";
            this.FavoriteItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavoriteItem.Click += new System.EventHandler(this.FavoriteItem_Click);
            // 
            // RecycleBinItem
            // 
            this.RecycleBinItem.AutoSize = false;
            this.RecycleBinItem.Name = "RecycleBinItem";
            this.RecycleBinItem.Size = new System.Drawing.Size(105, 29);
            this.RecycleBinItem.Text = "Recycle bin";
            this.RecycleBinItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecycleBinItem.Click += new System.EventHandler(this.RecycleBinItem_Click);
            // 
            // UserInterfaceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LinkToDeleteNotes);
            this.Controls.Add(this.LinkToFill);
            this.Controls.Add(this.NotesPanel);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.LeftMenu);
            this.Name = "UserInterfaceControl";
            this.Size = new System.Drawing.Size(600, 370);
            this.Load += new System.EventHandler(this.UserInterfaceControl_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.LeftMenu.ResumeLayout(false);
            this.LeftMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainMenu;
        private System.Windows.Forms.ToolStripButton ButtonToAddNote;
        private System.Windows.Forms.ToolStripButton ButtonToExit;
        private System.Windows.Forms.ToolStripLabel LabelName;
        private System.Windows.Forms.Panel NotesPanel;
        private System.Windows.Forms.LinkLabel LinkToFill;
        private System.Windows.Forms.LinkLabel LinkToDeleteNotes;
        private System.Windows.Forms.MenuStrip LeftMenu;
        private System.Windows.Forms.ToolStripMenuItem FavoriteItem;
        private System.Windows.Forms.ToolStripMenuItem AllNotesItem;
        private System.Windows.Forms.ToolStripMenuItem MyNotesItem;
        private System.Windows.Forms.ToolStripMenuItem RecycleBinItem;
        private System.Windows.Forms.ToolStripDropDownButton ButtonToSortByDate;
        private System.Windows.Forms.ToolStripMenuItem SortByDateOldFirst;
    }
}
