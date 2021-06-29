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
    public partial class Comisiones : Form
    {
        public Comisiones()
        {
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            try
            {
                ComisionLogic comi = new ComisionLogic();
                this.dgvComisiones.DataSource = comi.GetAll();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista de Comisiones");
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Comisiones", fe);
                throw ExcepcionManejada;
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el form actual, osea el "Comisiones"
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ComisionDesktop cd = new ComisionDesktop();
            cd.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionDesktop us = new ComisionDesktop(id, ModoForm.Modicacion);
            us.ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionDesktop us = new ComisionDesktop(id, ModoForm.Baja);
            us.ShowDialog();
            Listar();
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
