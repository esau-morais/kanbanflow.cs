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

using MySql.Data.MySqlClient;
using System.Windows.Input;
using KanbanFlow.Helpers;
using System.Security.Cryptography;

namespace KanbanFlow
{
    public partial class formAuthentication : Form
    {

        
        dbs connectionString = new dbs();
        MySqlConnection connectionBD = null;
        MySqlCommand cmdSelectUsuario = null;
        MySqlCommand cmdInsertUsuario = null;


        public formAuthentication()
        {
            InitializeComponent();
        }
        private string IsValidEmail(string email)
        {

            // Define a expressão regular para email.
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);

            // Testa a string de input contra a expressão regular.
            if (!regex.IsMatch(email))
            {
                return "Email inválido ou faltando!.";

            }

            // Return null if the email address is valid.
            return null;
        }

        private string IsValidPassword(string password)
        {
            string passwordPattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";
            Regex regex = new Regex(passwordPattern);

            if (!regex.IsMatch(password)){
                return "Senha Inválida ou faltando";
            }

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

            string errorPassword = IsValidPassword(textBoxPassword.Text);

            if (errorMessage != null && errorPassword != null) {
                MessageBox.Show(errorMessage);
                MessageBox.Show(errorPassword);
                
            } 
            else if (errorMessage != null)
            {
                MessageBox.Show(errorMessage);

            }

            else if (errorPassword != null)
            {

                MessageBox.Show(errorPassword);
            }
            else
            {
                string usu_email = textBoxEmail.Text;
                string usu_pwd = textBoxPassword.Text;
                try
                {
                    connectionBD = new MySqlConnection(connectionString.getConnectionString());
                    connectionBD.Open();

                    cmdSelectUsuario = new MySqlCommand("SELECT email,password FROM user " +
                                                        "WHERE email = @usu_email AND password = @usu_pwd ", connectionBD);

                    cmdSelectUsuario.Parameters.AddWithValue("usu_email", usu_email);
                    cmdSelectUsuario.Parameters.AddWithValue("usu_pwd", usu_pwd);

                    MySqlDataReader reader = cmdSelectUsuario.ExecuteReader();

                    //Verifica se há registros retornados pela querry,
                    //--> substituir o "MessageBox" de "Email econtrado" pela abertura do form de board!!!<--
                    if (reader.HasRows)
                    {
                        //-->AQUI<--
                        MessageBox.Show("Email encontrado!!");
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha estão incorretos, ou não cadastrados!!");
                    }

                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Database Error:" + erro);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("ERRO:" + erro);
                }
                finally
                {
                    if (cmdSelectUsuario != null) { cmdSelectUsuario.Dispose(); }

                    connectionBD.Close();
                }
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string errorEmail = IsValidEmail(textBoxEmailSignUp.Text);
            string errorPassword = IsValidPassword(textBoxPasswordSignUp.Text);

            if (errorEmail != null) {

                MessageBox.Show(errorEmail);

            } else if (errorPassword != null) {

                MessageBox.Show(errorPassword);

            }else{
                string usu_nome = textBoxName.Text;
                string usu_email = textBoxEmailSignUp.Text;
                string usu_pwd = textBoxPasswordSignUp.Text;
                try
                {
                    connectionBD = new MySqlConnection(connectionString.getConnectionString());
                    connectionBD.Open();

                    cmdInsertUsuario = new MySqlCommand("INSERT INTO user(name,email,password,role_ID) VALUES(@usu_nome,@usu_email,@usu_pwd,2)", connectionBD);

                    cmdInsertUsuario.Parameters.AddWithValue("usu_nome",usu_nome);
                    cmdInsertUsuario.Parameters.AddWithValue("usu_email",usu_email);
                    cmdInsertUsuario.Parameters.AddWithValue("usu_pwd", usu_pwd);

                    int RowAffected = cmdInsertUsuario.ExecuteNonQuery();

                    if (RowAffected!=0)
                    {
                        MessageBox.Show("Registrado com Sucesso!!");

                        panelSignup.Visible = false;
                        panelLogin.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Verifique se os campos foram preenchidos corretamente!","Warning!");
                        
                    }


                }
                catch(MySqlException erro)
                {
                    MessageBox.Show("Error:"+erro.Message+"\nType:"+erro.GetType());
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Error:" + erro);
                }
                finally
                {
                    if (cmdInsertUsuario != null) { cmdInsertUsuario.Dispose(); }
                    connectionBD.Close();
                }
            }
        }
    }
}
