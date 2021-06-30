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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            try
            {
                MateriaLogic mat = new MateriaLogic();
                this.dgvMaterias.DataSource = mat.GetAll();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista de materias");
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de usuarios", fe);
                throw ExcepcionManejada;
            }
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MateriaDesktop mat = new MateriaDesktop(ModoForm.Alta);
            mat.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop mat = new MateriaDesktop(id, ModoForm.Modicacion);
            mat.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop mat = new MateriaDesktop(id, ModoForm.Baja);
            mat.ShowDialog();
            this.Listar();
        }
    }
}
