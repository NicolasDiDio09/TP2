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
    public partial class DocenteCursoDesktop : ApplicationForm
    {
        public DocenteCursoDesktop()
        {
            InitializeComponent();
            Mostrardatos();
        }

        private void Mostrardatos()
        {

            

            Business.Logic.ComisionLogic comision = new ComisionLogic();
            cbxComision.DataSource = comision.GetAll();
            cbxComision.DisplayMember = "desc_comision";
            cbxComision.ValueMember = "id_comision";
        }

        public DocenteCursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public Business.Entities.DocenteCurso DocenteCursoActual { get; set; }

        public DocenteCursoDesktop(int id, ModoForm modo) : this()
        {
            DocenteCursoLogic dc = new DocenteCursoLogic();
            Modo = modo;

            DocenteCursoActual = dc.GetOne(id);
            this.MapearDeDatos();
        }

        
        public override void MapearDeDatos()
        {
            this.txtIDDictado.Text = this.DocenteCursoActual.ID.ToString();
            Business.Logic.MateriaLogic materia = new MateriaLogic();
            cbxMateria.DataSource = materia.GetAll();
            cbxMateria.DisplayMember = "desc_materia";
            cbxMateria.ValueMember = "id_materia";

            int idMateria = (int)cbxMateria.SelectedValue;

            DocenteCursoLogic dcl = new DocenteCursoLogic();
            dcl.BuscarComision(idMateria);
            //Continuar...
        }
        
    }
}
