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
            //mapeando el id
            this.txtIDDictado.Text = this.DocenteCursoActual.ID.ToString();

            //mapareando la materia
            Business.Logic.MateriaLogic materia = new MateriaLogic();
            cbxMateria.DataSource = materia.GetAll();
            cbxMateria.DisplayMember = "desc_materia";
            cbxMateria.ValueMember = "id_materia";

            //mapeando el curso en base a la materia seleccionada
            int idMateria = (int)cbxMateria.SelectedValue;

            DocenteCursoLogic dcl = new DocenteCursoLogic();
            cbxComision.DataSource = dcl.BuscarComisiones(idMateria);
            cbxComision.DisplayMember = "desc_comision";
            cbxComision.ValueMember = "id_comision";                 

            //Mapeando el cargo
            cbxCargo.DataSource = DocenteCursoActual.cargo;

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Modicacion:
                    this.btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;

                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }

        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    Business.Entities.DocenteCurso dc = new Business.Entities.DocenteCurso();
                    DocenteCursoActual = dc;
                    int id = 0;
                    this.DocenteCursoActual.ID = id;
                    int idMateria = (int)cbxMateria.SelectedValue;
                    int idComision = (int)cbxComision.SelectedValue;

                    DocenteCursoLogic dcl = new DocenteCursoLogic();
                    this.DocenteCursoActual.IDCurso = dcl.BuscarCurso(idMateria, idComision).ID;
                    break;
            }
        }


    }
}
