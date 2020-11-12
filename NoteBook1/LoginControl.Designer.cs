namespace NoteBookApp
{
    partial class LoginControl
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelLogin = new System.Windows.Forms.Label();
            this.EnterLogin = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.EnterPassword = new System.Windows.Forms.TextBox();
            this.ButtonToLogin = new System.Windows.Forms.Button();
            this.LinkToRegister = new System.Windows.Forms.LinkLabel();
            this.LabelToNick = new System.Windows.Forms.LinkLabel();
            this.LabelToBob = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(227, 91);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(37, 15);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Login";
            // 
            // EnterLogin
            // 
            this.EnterLogin.Location = new System.Drawing.Point(227, 108);
            this.EnterLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EnterLogin.Name = "EnterLogin";
            this.EnterLogin.Size = new System.Drawing.Size(140, 23);
            this.EnterLogin.TabIndex = 1;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(227, 147);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(57, 15);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "Password";
            // 
            // EnterPassword
            // 
            this.EnterPassword.Location = new System.Drawing.Point(227, 165);
            this.EnterPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EnterPassword.Name = "EnterPassword";
            this.EnterPassword.Size = new System.Drawing.Size(140, 23);
            this.EnterPassword.TabIndex = 3;
            this.EnterPassword.UseSystemPasswordChar = true;
            // 
            // ButtonToLogin
            // 
            this.ButtonToLogin.Location = new System.Drawing.Point(227, 219);
            this.ButtonToLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonToLogin.Name = "ButtonToLogin";
            this.ButtonToLogin.Size = new System.Drawing.Size(77, 23);
            this.ButtonToLogin.TabIndex = 4;
            this.ButtonToLogin.Text = "Enter";
            this.ButtonToLogin.UseVisualStyleBackColor = true;
            this.ButtonToLogin.Click += new System.EventHandler(this.ButtonToLogin_Click);
            // 
            // LinkToRegister
            // 
            this.LinkToRegister.AutoSize = true;
            this.LinkToRegister.Location = new System.Drawing.Point(308, 223);
            this.LinkToRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkToRegister.Name = "LinkToRegister";
            this.LinkToRegister.Size = new System.Drawing.Size(49, 15);
            this.LinkToRegister.TabIndex = 5;
            this.LinkToRegister.TabStop = true;
            this.LinkToRegister.Text = "Register";
            this.LinkToRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToRegister_LinkClicked);
            // 
            // LabelToNick
            // 
            this.LabelToNick.AutoSize = true;
            this.LabelToNick.Location = new System.Drawing.Point(28, 335);
            this.LabelToNick.Name = "LabelToNick";
            this.LabelToNick.Size = new System.Drawing.Size(31, 15);
            this.LabelToNick.TabIndex = 6;
            this.LabelToNick.TabStop = true;
            this.LabelToNick.Text = "Nick";
            this.LabelToNick.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelToNick_LinkClicked);
            // 
            // LabelToBob
            // 
            this.LabelToBob.AutoSize = true;
            this.LabelToBob.Location = new System.Drawing.Point(75, 335);
            this.LabelToBob.Name = "LabelToBob";
            this.LabelToBob.Size = new System.Drawing.Size(28, 15);
            this.LabelToBob.TabIndex = 7;
            this.LabelToBob.TabStop = true;
            this.LabelToBob.Text = "Bob";
            this.LabelToBob.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelToBob_LinkClicked);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelToBob);
            this.Controls.Add(this.LabelToNick);
            this.Controls.Add(this.LinkToRegister);
            this.Controls.Add(this.ButtonToLogin);
            this.Controls.Add(this.EnterPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.EnterLogin);
            this.Controls.Add(this.LabelLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(600, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox EnterLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox EnterPassword;
        private System.Windows.Forms.Button ButtonToLogin;
        private System.Windows.Forms.LinkLabel LinkToRegister;
        private System.Windows.Forms.LinkLabel LabelToNick;
        private System.Windows.Forms.LinkLabel LabelToBob;
    }
}
