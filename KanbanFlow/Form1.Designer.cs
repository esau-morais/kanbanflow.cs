namespace KanbanFlow
{
    partial class formAuthentication
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSignup = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSwitchToLoginPage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblSwitchToSignIn = new System.Windows.Forms.Label();
            this.lblEmailSignup = new System.Windows.Forms.Label();
            this.textBoxPasswordSignUp = new System.Windows.Forms.TextBox();
            this.textBoxEmailSignUp = new System.Windows.Forms.TextBox();
            this.lblPasswordSignup = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnSwitchToSignUpPage = new System.Windows.Forms.Button();
            this.checkBoxPasswordVisibility = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblSwitchToRegister = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panelSignup.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSignup
            // 
            this.panelSignup.AutoSize = true;
            this.panelSignup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSignup.Controls.Add(this.lblName);
            this.panelSignup.Controls.Add(this.btnSwitchToLoginPage);
            this.panelSignup.Controls.Add(this.label5);
            this.panelSignup.Controls.Add(this.textBoxName);
            this.panelSignup.Controls.Add(this.btnRegister);
            this.panelSignup.Controls.Add(this.lblSwitchToSignIn);
            this.panelSignup.Controls.Add(this.lblEmailSignup);
            this.panelSignup.Controls.Add(this.textBoxPasswordSignUp);
            this.panelSignup.Controls.Add(this.textBoxEmailSignUp);
            this.panelSignup.Controls.Add(this.lblPasswordSignup);
            this.panelSignup.Location = new System.Drawing.Point(119, 118);
            this.panelSignup.Margin = new System.Windows.Forms.Padding(0);
            this.panelSignup.MinimumSize = new System.Drawing.Size(256, 280);
            this.panelSignup.Name = "panelSignup";
            this.panelSignup.Size = new System.Drawing.Size(256, 281);
            this.panelSignup.TabIndex = 14;
            this.panelSignup.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(34, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Nome";
            // 
            // btnSwitchToLoginPage
            // 
            this.btnSwitchToLoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSwitchToLoginPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchToLoginPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnSwitchToLoginPage.FlatAppearance.BorderSize = 0;
            this.btnSwitchToLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchToLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchToLoginPage.ForeColor = System.Drawing.Color.White;
            this.btnSwitchToLoginPage.Location = new System.Drawing.Point(152, 253);
            this.btnSwitchToLoginPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwitchToLoginPage.Name = "btnSwitchToLoginPage";
            this.btnSwitchToLoginPage.Size = new System.Drawing.Size(84, 28);
            this.btnSwitchToLoginPage.TabIndex = 9;
            this.btnSwitchToLoginPage.Text = "Entre aqui";
            this.btnSwitchToLoginPage.UseVisualStyleBackColor = false;
            this.btnSwitchToLoginPage.Click += new System.EventHandler(this.btnSwitchToLoginPage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(34, -15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxName.Location = new System.Drawing.Point(37, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(182, 25);
            this.textBoxName.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(76, 196);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(108, 28);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Registrar-se";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblSwitchToSignIn
            // 
            this.lblSwitchToSignIn.AutoSize = true;
            this.lblSwitchToSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitchToSignIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSwitchToSignIn.Location = new System.Drawing.Point(29, 260);
            this.lblSwitchToSignIn.Name = "lblSwitchToSignIn";
            this.lblSwitchToSignIn.Size = new System.Drawing.Size(127, 15);
            this.lblSwitchToSignIn.TabIndex = 4;
            this.lblSwitchToSignIn.Text = "Já possui uma conta?";
            // 
            // lblEmailSignup
            // 
            this.lblEmailSignup.AutoSize = true;
            this.lblEmailSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSignup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmailSignup.Location = new System.Drawing.Point(34, 78);
            this.lblEmailSignup.Name = "lblEmailSignup";
            this.lblEmailSignup.Size = new System.Drawing.Size(39, 15);
            this.lblEmailSignup.TabIndex = 0;
            this.lblEmailSignup.Text = "Email";
            // 
            // textBoxPasswordSignUp
            // 
            this.textBoxPasswordSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.textBoxPasswordSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPasswordSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordSignUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPasswordSignUp.Location = new System.Drawing.Point(37, 153);
            this.textBoxPasswordSignUp.Name = "textBoxPasswordSignUp";
            this.textBoxPasswordSignUp.PasswordChar = '*';
            this.textBoxPasswordSignUp.Size = new System.Drawing.Size(182, 25);
            this.textBoxPasswordSignUp.TabIndex = 3;
            // 
            // textBoxEmailSignUp
            // 
            this.textBoxEmailSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.textBoxEmailSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmailSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailSignUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEmailSignUp.Location = new System.Drawing.Point(37, 96);
            this.textBoxEmailSignUp.Name = "textBoxEmailSignUp";
            this.textBoxEmailSignUp.Size = new System.Drawing.Size(182, 25);
            this.textBoxEmailSignUp.TabIndex = 1;
            // 
            // lblPasswordSignup
            // 
            this.lblPasswordSignup.AutoSize = true;
            this.lblPasswordSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSignup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPasswordSignup.Location = new System.Drawing.Point(34, 135);
            this.lblPasswordSignup.Name = "lblPasswordSignup";
            this.lblPasswordSignup.Size = new System.Drawing.Size(43, 15);
            this.lblPasswordSignup.TabIndex = 2;
            this.lblPasswordSignup.Text = "Senha";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(170, 89);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(165, 20);
            this.lblSubTitle.TabIndex = 16;
            this.lblSubTitle.Text = "Seja Bem-Vindo(a)!";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(324, 51);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 29);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "KanbanFlow";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogin
            // 
            this.panelLogin.AutoSize = true;
            this.panelLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLogin.Controls.Add(this.btnSwitchToSignUpPage);
            this.panelLogin.Controls.Add(this.checkBoxPasswordVisibility);
            this.panelLogin.Controls.Add(this.btnSignIn);
            this.panelLogin.Controls.Add(this.lblSwitchToRegister);
            this.panelLogin.Controls.Add(this.lblEmail);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxEmail);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Location = new System.Drawing.Point(425, 118);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 64);
            this.panelLogin.MinimumSize = new System.Drawing.Size(256, 230);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(256, 230);
            this.panelLogin.TabIndex = 13;
            // 
            // btnSwitchToSignUpPage
            // 
            this.btnSwitchToSignUpPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSwitchToSignUpPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchToSignUpPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnSwitchToSignUpPage.FlatAppearance.BorderSize = 0;
            this.btnSwitchToSignUpPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchToSignUpPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchToSignUpPage.ForeColor = System.Drawing.Color.White;
            this.btnSwitchToSignUpPage.Location = new System.Drawing.Point(172, 197);
            this.btnSwitchToSignUpPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwitchToSignUpPage.Name = "btnSwitchToSignUpPage";
            this.btnSwitchToSignUpPage.Size = new System.Drawing.Size(84, 28);
            this.btnSwitchToSignUpPage.TabIndex = 7;
            this.btnSwitchToSignUpPage.Text = "Registre-se";
            this.btnSwitchToSignUpPage.UseVisualStyleBackColor = false;
            this.btnSwitchToSignUpPage.Click += new System.EventHandler(this.btnSwitchToSignUpPage_Click);
            // 
            // checkBoxPasswordVisibility
            // 
            this.checkBoxPasswordVisibility.AutoSize = true;
            this.checkBoxPasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPasswordVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPasswordVisibility.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxPasswordVisibility.Location = new System.Drawing.Point(128, 93);
            this.checkBoxPasswordVisibility.Name = "checkBoxPasswordVisibility";
            this.checkBoxPasswordVisibility.Size = new System.Drawing.Size(90, 17);
            this.checkBoxPasswordVisibility.TabIndex = 6;
            this.checkBoxPasswordVisibility.Text = "Mostrar senha";
            this.checkBoxPasswordVisibility.UseVisualStyleBackColor = true;
            this.checkBoxPasswordVisibility.CheckedChanged += new System.EventHandler(this.checkBoxPasswordVisibility_CheckedChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Location = new System.Drawing.Point(85, 156);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(79, 28);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Entrar";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblSwitchToRegister
            // 
            this.lblSwitchToRegister.AutoSize = true;
            this.lblSwitchToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitchToRegister.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSwitchToRegister.Location = new System.Drawing.Point(5, 204);
            this.lblSwitchToRegister.Name = "lblSwitchToRegister";
            this.lblSwitchToRegister.Size = new System.Drawing.Size(169, 15);
            this.lblSwitchToRegister.TabIndex = 4;
            this.lblSwitchToRegister.Text = "Ainda não possui uma conta?";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Location = new System.Drawing.Point(34, 37);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPassword.Location = new System.Drawing.Point(37, 112);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(182, 25);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEmail.Location = new System.Drawing.Point(37, 55);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(182, 25);
            this.textBoxEmail.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPassword.Location = new System.Drawing.Point(34, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(43, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Senha";
            // 
            // formAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSignup);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelLogin);
            this.Name = "formAuthentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KanbanFlow";
            this.Load += new System.EventHandler(this.formAuthentication_Load);
            this.panelSignup.ResumeLayout(false);
            this.panelSignup.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSignup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSwitchToLoginPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblSwitchToSignIn;
        private System.Windows.Forms.Label lblEmailSignup;
        private System.Windows.Forms.TextBox textBoxPasswordSignUp;
        private System.Windows.Forms.TextBox textBoxEmailSignUp;
        private System.Windows.Forms.Label lblPasswordSignup;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnSwitchToSignUpPage;
        private System.Windows.Forms.CheckBox checkBoxPasswordVisibility;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblSwitchToRegister;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblPassword;
    }
}

