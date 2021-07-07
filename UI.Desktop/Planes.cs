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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            this.dgvPlanes.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            try
            {
                PlanLogic pla = new PlanLogic();
                this.dgvPlanes.DataSource = pla.GetAll();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista de planes");
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de planes", fe);
                throw ExcepcionManejada;
            }
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop pla = new PlanDesktop(ModoForm.Alta);
            pla.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop pla = new PlanDesktop(id, ModoForm.Modicacion);
            pla.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop pla = new PlanDesktop(id, ModoForm.Baja);
            pla.ShowDialog();
            this.Listar();
        }

        private void tsPlanes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPlanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualiza_Click_1(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            PlanDesktop pla = new PlanDesktop(ModoForm.Alta);
            pla.ShowDialog();
            this.Listar();
        }
    }
}
