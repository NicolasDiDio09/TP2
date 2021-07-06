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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            try
            {
                CursoLogic ul = new CursoLogic();
                this.dgvCursos.DataSource = ul.GetAll();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista de cursos");
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de cursos", fe);
                throw ExcepcionManejada;
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsCursos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop ud = new UsuarioDesktop(ModoForm.Alta);
            ud.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Usuario)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
            CursoDesktop us = new CursoDesktop(id, ModoForm.Modicacion);
            us.ShowDialog();
            Listar();

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
            CursoDesktop us = new CursoDesktop(id, ModoForm.Baja);
            us.ShowDialog();
            Listar();
        }
    }
}
