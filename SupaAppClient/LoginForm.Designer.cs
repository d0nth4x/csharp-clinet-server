namespace SupaAppClient
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
            this.TbLogin = new MetroFramework.Controls.MetroTextBox();
            this.TbPassword = new MetroFramework.Controls.MetroTextBox();
            this.BtnZaloguj = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TbLogin
            // 
            // 
            // 
            // 
            this.TbLogin.CustomButton.Image = null;
            this.TbLogin.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.TbLogin.CustomButton.Name = "";
            this.TbLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbLogin.CustomButton.TabIndex = 1;
            this.TbLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbLogin.CustomButton.UseSelectable = true;
            this.TbLogin.CustomButton.Visible = false;
            this.TbLogin.Lines = new string[] {
        "admin"};
            this.TbLogin.Location = new System.Drawing.Point(80, 120);
            this.TbLogin.MaxLength = 32767;
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.PasswordChar = '\0';
            this.TbLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbLogin.SelectedText = "";
            this.TbLogin.SelectionLength = 0;
            this.TbLogin.SelectionStart = 0;
            this.TbLogin.ShortcutsEnabled = true;
            this.TbLogin.Size = new System.Drawing.Size(216, 23);
            this.TbLogin.TabIndex = 0;
            this.TbLogin.Text = "admin";
            this.TbLogin.UseSelectable = true;
            this.TbLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbPassword
            // 
            // 
            // 
            // 
            this.TbPassword.CustomButton.Image = null;
            this.TbPassword.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.TbPassword.CustomButton.Name = "";
            this.TbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbPassword.CustomButton.TabIndex = 1;
            this.TbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbPassword.CustomButton.UseSelectable = true;
            this.TbPassword.CustomButton.Visible = false;
            this.TbPassword.Lines = new string[] {
        "admin1"};
            this.TbPassword.Location = new System.Drawing.Point(80, 149);
            this.TbPassword.MaxLength = 32767;
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '\0';
            this.TbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbPassword.SelectedText = "";
            this.TbPassword.SelectionLength = 0;
            this.TbPassword.SelectionStart = 0;
            this.TbPassword.ShortcutsEnabled = true;
            this.TbPassword.Size = new System.Drawing.Size(216, 23);
            this.TbPassword.TabIndex = 1;
            this.TbPassword.Text = "admin1";
            this.TbPassword.UseSelectable = true;
            this.TbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnZaloguj
            // 
            this.BtnZaloguj.Location = new System.Drawing.Point(80, 178);
            this.BtnZaloguj.Name = "BtnZaloguj";
            this.BtnZaloguj.Size = new System.Drawing.Size(216, 23);
            this.BtnZaloguj.TabIndex = 2;
            this.BtnZaloguj.Text = "Zaloguj";
            this.BtnZaloguj.UseMnemonic = false;
            this.BtnZaloguj.UseSelectable = true;
            this.BtnZaloguj.Click += new System.EventHandler(this.BtnZaloguj_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 318);
            this.Controls.Add(this.BtnZaloguj);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbLogin);
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Logowanie";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TbLogin;
        private MetroFramework.Controls.MetroTextBox TbPassword;
        private MetroFramework.Controls.MetroButton BtnZaloguj;
    }
}