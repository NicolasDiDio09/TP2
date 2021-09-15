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
    public partial class DocenteCurso : Form
    {
        public DocenteCurso()
        {
            InitializeComponent();
            this.dgvDocenteCurso.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            try
            {
                DocenteCursoLogic dc = new DocenteCursoLogic();
                this.dgvDocenteCurso.DataSource = dc.GetAll();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista DocentesCursos");
                Exception exepcionManejada = new Exception("Error al recuperar la lista de DocentesCursos");
                throw exepcionManejada;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void DocenteCurso_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            DocenteCursoDesktop dc = new DocenteCursoDesktop(ModoForm.Alta);
            dc.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.DocenteCurso)this.dgvDocenteCurso.SelectedRows[0].DataBoundItem).ID;
            DocenteCursoDesktop dc = new DocenteCursoDesktop(id, ModoForm.Modicacion);
            dc.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.DocenteCurso)this.dgvDocenteCurso.SelectedRows[0].DataBoundItem).ID;
            DocenteCursoDesktop dc = new DocenteCursoDesktop(id, ModoForm.Baja);
            dc.ShowDialog();
            this.Listar();
        }
    }
}
