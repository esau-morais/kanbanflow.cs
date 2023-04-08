using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KanbanFlow
{
    public partial class formAuthentication : Form
    {
        public formAuthentication()
        {
            InitializeComponent();
        }
        private string IsValidEmail(string email)
        {
            // Define a regular expression for email addresses.
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);

            // Test the input string against the regular expression.
            if (!regex.IsMatch(email))
            {
                return "Email address is not valid.";
            }

            // Return null if the email address is valid.
            return null;
        }

        private void formAuthentication_Load(object sender, EventArgs e)
        {
            this.panelSignup.Visible = false;
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            lblSubTitle.Left = (this.ClientSize.Width - lblSubTitle.Width) / 2;
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelSignup.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
        }

        private void checkBoxPasswordVisibility_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = checkBoxPasswordVisibility.Checked ? '\0' : '*';
        }

        private void btnSwitchToLoginPage_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = false;
            panelLogin.Visible = true;
        }

        private void btnSwitchToSignUpPage_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = true;
            panelLogin.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string errorMessage = IsValidEmail(textBoxEmail.Text);
            if (errorMessage != null) MessageBox.Show(errorMessage);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string errorMessage = IsValidEmail(textBoxEmailSignUp.Text);
            if (errorMessage != null) MessageBox.Show(errorMessage);
        }
    }
}
