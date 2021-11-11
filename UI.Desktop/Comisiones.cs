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
        public int UsuarioId { get; set; }
        public Comisiones()
        {
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false;
        }

        public Comisiones(int id)
        {
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false;
            UsuarioId = id;
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            Lista();
        }

        private void Lista()
        {
            UsuarioLogic ul = new UsuarioLogic();
            Persona per = ul.BuscaPersona(UsuarioId);
            if (per.TipoPersona.ToString() == "Admin")
            {
                this.Listar();
            }
            else
            {
                tsbNuevo.Visible = false;
                tsbEditar.Visible = false;
                tsbEliminar.Visible = false;
                ListarComisionesUsuario(UsuarioId);
            }
        }

        public void ListarComisionesUsuario(int id)
        {
            try
            {
                ComisionLogic comi = new ComisionLogic();
                this.dgvComisiones.DataSource = comi.BuscarComisionesxUsuario(id);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista de Comisiones");
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Comisiones", fe);
                throw ExcepcionManejada;
            }
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
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Lista();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el form actual, osea el "Comisiones"
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ComisionDesktop cd = new ComisionDesktop();
            cd.ShowDialog();
            Lista();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionDesktop us = new ComisionDesktop(id, ModoForm.Modicacion);
            us.ShowDialog();
            Lista();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionDesktop us = new ComisionDesktop(id, ModoForm.Baja);
            us.ShowDialog();
            Lista();
        }


    }
}
