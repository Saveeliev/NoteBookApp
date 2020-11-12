namespace NoteBookApp
{
    partial class NoteControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteControl));
            this.ButtonToDelete = new System.Windows.Forms.Button();
            this.ButtonToUpdate = new System.Windows.Forms.Button();
            this.ButtonToLike = new System.Windows.Forms.Button();
            this.LabelLikesCount = new System.Windows.Forms.Label();
            this.ButtonToChangeModifier = new System.Windows.Forms.Button();
            this.LabelDateAndUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonToFavorite = new System.Windows.Forms.Button();
            this.ButtonToRestore = new System.Windows.Forms.Button();
            this.LinkToOpen = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonToDelete
            // 
            this.ButtonToDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonToDelete.BackgroundImage")));
            this.ButtonToDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonToDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonToDelete.Location = new System.Drawing.Point(9, 0);
            this.ButtonToDelete.Name = "ButtonToDelete";
            this.ButtonToDelete.Size = new System.Drawing.Size(25, 23);
            this.ButtonToDelete.TabIndex = 1;
            this.ButtonToDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonToUpdate
            // 
            this.ButtonToUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonToUpdate.BackgroundImage")));
            this.ButtonToUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonToUpdate.Location = new System.Drawing.Point(40, 0);
            this.ButtonToUpdate.Name = "ButtonToUpdate";
            this.ButtonToUpdate.Size = new System.Drawing.Size(25, 23);
            this.ButtonToUpdate.TabIndex = 2;
            this.ButtonToUpdate.UseVisualStyleBackColor = true;
            // 
            // ButtonToLike
            // 
            this.ButtonToLike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonToLike.BackgroundImage")));
            this.ButtonToLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonToLike.Location = new System.Drawing.Point(364, 13);
            this.ButtonToLike.Name = "ButtonToLike";
            this.ButtonToLike.Size = new System.Drawing.Size(24, 23);
            this.ButtonToLike.TabIndex = 3;
            this.ButtonToLike.UseVisualStyleBackColor = true;
            // 
            // LabelLikesCount
            // 
            this.LabelLikesCount.AutoSize = true;
            this.LabelLikesCount.Location = new System.Drawing.Point(394, 17);
            this.LabelLikesCount.Name = "LabelLikesCount";
            this.LabelLikesCount.Size = new System.Drawing.Size(13, 15);
            this.LabelLikesCount.TabIndex = 4;
            this.LabelLikesCount.Text = "0";
            // 
            // ButtonToChangeModifier
            // 
            this.ButtonToChangeModifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonToChangeModifier.BackgroundImage")));
            this.ButtonToChangeModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonToChangeModifier.Location = new System.Drawing.Point(71, 0);
            this.ButtonToChangeModifier.Name = "ButtonToChangeModifier";
            this.ButtonToChangeModifier.Size = new System.Drawing.Size(23, 23);
            this.ButtonToChangeModifier.TabIndex = 5;
            this.ButtonToChangeModifier.UseVisualStyleBackColor = true;
            // 
            // LabelDateAndUser
            // 
            this.LabelDateAndUser.AutoSize = true;
            this.LabelDateAndUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelDateAndUser.Location = new System.Drawing.Point(8, 0);
            this.LabelDateAndUser.Name = "LabelDateAndUser";
            this.LabelDateAndUser.Size = new System.Drawing.Size(79, 15);
            this.LabelDateAndUser.TabIndex = 6;
            this.LabelDateAndUser.Text = "Date and user";
            this.LabelDateAndUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonToDelete);
            this.panel1.Controls.Add(this.ButtonToUpdate);
            this.panel1.Controls.Add(this.ButtonToChangeModifier);
            this.panel1.Location = new System.Drawing.Point(141, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 23);
            this.panel1.TabIndex = 7;
            // 
            // ButtonToFavorite
            // 
            this.ButtonToFavorite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonToFavorite.BackgroundImage")));
            this.ButtonToFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonToFavorite.Location = new System.Drawing.Point(241, 13);
            this.ButtonToFavorite.Name = "ButtonToFavorite";
            this.ButtonToFavorite.Size = new System.Drawing.Size(24, 23);
            this.ButtonToFavorite.TabIndex = 10;
            this.ButtonToFavorite.UseVisualStyleBackColor = true;
            // 
            // ButtonToRestore
            // 
            this.ButtonToRestore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonToRestore.BackgroundImage")));
            this.ButtonToRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonToRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonToRestore.Location = new System.Drawing.Point(121, 13);
            this.ButtonToRestore.Name = "ButtonToRestore";
            this.ButtonToRestore.Size = new System.Drawing.Size(23, 23);
            this.ButtonToRestore.TabIndex = 11;
            this.ButtonToRestore.UseVisualStyleBackColor = true;
            // 
            // LinkToOpen
            // 
            this.LinkToOpen.AutoSize = true;
            this.LinkToOpen.Location = new System.Drawing.Point(17, 17);
            this.LinkToOpen.Name = "LinkToOpen";
            this.LinkToOpen.Size = new System.Drawing.Size(0, 15);
            this.LinkToOpen.TabIndex = 12;
            this.LinkToOpen.Click += new System.EventHandler(this.LinkToOpen_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.LabelDateAndUser);
            this.panel2.Location = new System.Drawing.Point(271, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 19);
            this.panel2.TabIndex = 13;
            // 
            // NoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LinkToOpen);
            this.Controls.Add(this.ButtonToRestore);
            this.Controls.Add(this.ButtonToFavorite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelLikesCount);
            this.Controls.Add(this.ButtonToLike);
            this.Name = "NoteControl";
            this.Size = new System.Drawing.Size(424, 50);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button ButtonToDelete;
        public System.Windows.Forms.Button ButtonToUpdate;
        public System.Windows.Forms.Button ButtonToLike;
        public System.Windows.Forms.Label LabelLikesCount;
        public System.Windows.Forms.Button ButtonToChangeModifier;
        public System.Windows.Forms.Button ButtonToFavorite;
        public System.Windows.Forms.Button ButtonToRestore;
        private System.Windows.Forms.LinkLabel LinkToOpen;
        private System.Windows.Forms.Label LabelDateAndUser;
        private System.Windows.Forms.Panel panel2;
    }
}
