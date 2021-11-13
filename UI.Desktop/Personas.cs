using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class Personas : Form
    {
        public int UsuarioID { get; set; }
        
        public Personas()
        {
            InitializeComponent();
            dgvPersonas.AutoGenerateColumns = false;
        }

        public Personas(int id)
        {
            InitializeComponent();
            dgvPersonas.AutoGenerateColumns = false;
            UsuarioID = id;
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            this.Lista();
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

        public void Listar()
        {
            try
            {
                PersonaLogic ul = new PersonaLogic();
                this.dgvPersonas.DataSource = ul.GetAll();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista de Personas");
                Exception ExceptionManejada = new Exception("Error al recuperar lista de Personas", fe);
                throw ExceptionManejada;

            }
        }

        public void ListarUsuario()
        {
            try
            {
                tsbAlta.Visible = false;
                tsbBorrar.Visible = false;
                UsuarioLogic pl = new UsuarioLogic();
                List<Persona> persona = new List<Persona>();
                persona.Add(pl.BuscaPersona(UsuarioID));
                this.dgvPersonas.DataSource = persona;
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista de personas");
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de usuarios", fe);
                throw ExcepcionManejada;
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Lista();
        }

        

        private void tsbAlta_Click(object sender, EventArgs e)
        {
            PersonaDesktop pd = new PersonaDesktop(ModoForm.Alta);
            pd.ShowDialog();
            this.Lista();
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop pd = new PersonaDesktop(id, ModoForm.Modicacion);
            pd.ShowDialog();
            this.Lista();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop pd = new PersonaDesktop(id, ModoForm.Baja);
            pd.ShowDialog();
            this.Lista();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
