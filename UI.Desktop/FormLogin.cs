using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Database;
using Data;
using System.Data.SqlClient;
using System.Configuration;

namespace UI.Desktop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            const string consKeyDefaultCnnString = "ConnStringExpress";
            UsuarioAdapter user = new UsuarioAdapter();
            string connstr = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            user.sqlConn = new SqlConnection(connstr);
            

            try
            {
                user.sqlConn.Open();
                SqlCommand cmdUser = new SqlCommand("Select clave from usuarios where nombre_usuario=@nombre_usuario", user.sqlConn);
                cmdUser.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = this.txtUsuario.Text.ToString();
                string pass = cmdUser.ExecuteScalar().ToString();
                if (this.txtPass.Text == pass )
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(NullReferenceException nre)
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                user.sqlConn.Close();
            }
        }
    }
}
