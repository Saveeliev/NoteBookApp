namespace NoteBookApp
{
    partial class RegisterControl
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
            this.LabelName = new System.Windows.Forms.Label();
            this.EnterName = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.EnterLogin = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.EnterPassword = new System.Windows.Forms.TextBox();
            this.LabelPassConfirm = new System.Windows.Forms.Label();
            this.EnterConfPassword = new System.Windows.Forms.TextBox();
            this.ButtonToRegister = new System.Windows.Forms.Button();
            this.LinkToBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(215, 58);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(39, 15);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name";
            // 
            // EnterName
            // 
            this.EnterName.Location = new System.Drawing.Point(215, 76);
            this.EnterName.Name = "EnterName";
            this.EnterName.Size = new System.Drawing.Size(185, 23);
            this.EnterName.TabIndex = 1;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(217, 111);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(37, 15);
            this.LabelLogin.TabIndex = 2;
            this.LabelLogin.Text = "Login";
            // 
            // EnterLogin
            // 
            this.EnterLogin.Location = new System.Drawing.Point(215, 129);
            this.EnterLogin.Name = "EnterLogin";
            this.EnterLogin.Size = new System.Drawing.Size(185, 23);
            this.EnterLogin.TabIndex = 3;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(217, 164);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(57, 15);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Password";
            // 
            // EnterPassword
            // 
            this.EnterPassword.Location = new System.Drawing.Point(215, 182);
            this.EnterPassword.Name = "EnterPassword";
            this.EnterPassword.Size = new System.Drawing.Size(185, 23);
            this.EnterPassword.TabIndex = 5;
            this.EnterPassword.UseSystemPasswordChar = true;
            // 
            // LabelPassConfirm
            // 
            this.LabelPassConfirm.AutoSize = true;
            this.LabelPassConfirm.Location = new System.Drawing.Point(217, 218);
            this.LabelPassConfirm.Name = "LabelPassConfirm";
            this.LabelPassConfirm.Size = new System.Drawing.Size(104, 15);
            this.LabelPassConfirm.TabIndex = 6;
            this.LabelPassConfirm.Text = "Confirm Password";
            // 
            // EnterConfPassword
            // 
            this.EnterConfPassword.Location = new System.Drawing.Point(217, 237);
            this.EnterConfPassword.Name = "EnterConfPassword";
            this.EnterConfPassword.Size = new System.Drawing.Size(183, 23);
            this.EnterConfPassword.TabIndex = 7;
            this.EnterConfPassword.UseSystemPasswordChar = true;
            // 
            // ButtonToRegister
            // 
            this.ButtonToRegister.Location = new System.Drawing.Point(215, 276);
            this.ButtonToRegister.Name = "ButtonToRegister";
            this.ButtonToRegister.Size = new System.Drawing.Size(106, 23);
            this.ButtonToRegister.TabIndex = 8;
            this.ButtonToRegister.Text = "Enter";
            this.ButtonToRegister.UseVisualStyleBackColor = true;
            this.ButtonToRegister.Click += new System.EventHandler(this.ButtonToRegister_Click);
            // 
            // LinkToBack
            // 
            this.LinkToBack.AutoSize = true;
            this.LinkToBack.Location = new System.Drawing.Point(340, 280);
            this.LinkToBack.Name = "LinkToBack";
            this.LinkToBack.Size = new System.Drawing.Size(43, 15);
            this.LinkToBack.TabIndex = 9;
            this.LinkToBack.TabStop = true;
            this.LinkToBack.Text = "Cancel";
            this.LinkToBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToBack_LinkClicked);
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LinkToBack);
            this.Controls.Add(this.ButtonToRegister);
            this.Controls.Add(this.EnterConfPassword);
            this.Controls.Add(this.LabelPassConfirm);
            this.Controls.Add(this.EnterPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.EnterLogin);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.EnterName);
            this.Controls.Add(this.LabelName);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(600, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox EnterName;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox EnterLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox EnterPassword;
        private System.Windows.Forms.Label LabelPassConfirm;
        private System.Windows.Forms.TextBox EnterConfPassword;
        private System.Windows.Forms.Button ButtonToRegister;
        private System.Windows.Forms.LinkLabel LinkToBack;
    }
}
