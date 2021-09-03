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
    public partial class Alumnos_Inscripciones : Form
    {
        public Alumnos_Inscripciones()
        {
            InitializeComponent();
            this.dvgAlumnos_Inscripciones.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            try
            {
                Alumnos_InscripcionesLogic alins = new Alumnos_InscripcionesLogic();
                this.dvgAlumnos_Inscripciones.DataSource = alins.GetAll();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista de materias");
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de usuarios", fe);
                throw ExcepcionManejada;
            }
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void toolStripContainer1_TopToolStripPanel_Click_1(object sender, EventArgs e)
        {

        }

        private void Alumnos_Inscripciones_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Alumnos_InscripcionesDesktop alinsc = new Alumnos_InscripcionesDesktop(ModoForm.Alta);
            alinsc.ShowDialog();
            this.Listar();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Alumnos_Inscripciones)this.dvgAlumnos_Inscripciones.SelectedRows[0].DataBoundItem).ID;
            Alumnos_InscripcionesDesktop alinsc = new Alumnos_InscripcionesDesktop(id, ModoForm.Modicacion);
            alinsc.ShowDialog();
            this.Listar();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Alumnos_Inscripciones)this.dvgAlumnos_Inscripciones.SelectedRows[0].DataBoundItem).ID;
            Alumnos_InscripcionesDesktop alinsc = new Alumnos_InscripcionesDesktop(id, ModoForm.Baja);
            alinsc.ShowDialog();
            this.Listar();
        }
    }
}
