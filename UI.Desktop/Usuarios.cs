using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Usuarios : Form
    {
        public int UsuarioID { get; set; }

        public Usuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
        }

        public Usuarios(int id)
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
            UsuarioID = id;
        }

        public void Listar()
        {
            try
            {
                UsuarioLogic ul = new UsuarioLogic();
                this.dgvUsuarios.DataSource = ul.GetAll();
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista de usuarios");
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de usuarios", fe);
                throw ExcepcionManejada;
            }
        }

        public void ListarUsuario()
        {
            try
            {
                tsbNuevo.Visible = false;
                tsbEliminar.Visible = false;
                UsuarioLogic ul = new UsuarioLogic();
                List<Usuario> usuario = new List<Usuario>();
                usuario.Add(ul.GetOne(UsuarioID));
                this.dgvUsuarios.DataSource = usuario;
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista de usuarios");
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de usuarios", fe);
                throw ExcepcionManejada;
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Lista();
        }

        private void Lista()
        {
            UsuarioLogic ul = new UsuarioLogic();
            Persona perso = ul.BuscaPersona(UsuarioID);

            if (perso.TipoPersona.ToString() == "Admin")
            {
                this.Listar();
            }
            else
            {
                this.ListarUsuario();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Lista();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop ud = new UsuarioDesktop(ModoForm.Alta);
            ud.ShowDialog();
            Lista();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            UsuarioDesktop us = new UsuarioDesktop(id, ModoForm.Modicacion);
            us.ShowDialog();
            Lista();

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            UsuarioDesktop us = new UsuarioDesktop(id, ModoForm.Baja);
            us.ShowDialog();
            Lista();
        }

    }
}
