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
        public Personas()
        {
            InitializeComponent();
            dgvPersonas.AutoGenerateColumns = false;
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            this.Listar();
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


        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Listar();
        }

        

        private void tsbAlta_Click(object sender, EventArgs e)
        {
            PersonaDesktop pd = new PersonaDesktop(ModoForm.Alta);
            pd.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop pd = new PersonaDesktop(id, ModoForm.Modicacion);
            pd.ShowDialog();
            this.Listar();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Usuario)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop pd = new PersonaDesktop(id, ModoForm.Baja);
            pd.ShowDialog();
            this.Listar();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
