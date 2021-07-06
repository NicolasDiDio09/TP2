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
    public partial class CursoDesktop : ApplicationForm
    {
        public CursoDesktop()
        {
            InitializeComponent();
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public CursoDesktop(int ID, ModoForm modo) : this()
        {
            CursoLogic cur = new CursoLogic();

            Modo = modo;

            CursoActual = cur.GetOne(ID);
            MapearDeDatos();
        }
        public Business.Entities.Curso CursoActual { get; set; }

        public override void MapearDeDatos()
        {
            this.txtIdCurso.Text = this.CursoActual.ID.ToString();
            this.txtAnio.Text = this.CursoActual.AnioCalendario.ToString();
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();
            this.txtidMateria.Text = this.CursoActual.IDMateria.ToString();
            this.txtIdComision.Text = this.CursoActual.IDComision.ToString();
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
                    Curso Us = new Curso();
                    CursoActual = Us;
                    int id = 0;
                    this.CursoActual.ID = id;
                    this.CursoActual.AnioCalendario = this.txtAnio.Text;
                    this.CursoActual.Cupo = int.Parse(this.txtCupo.Text);
                    this.CursoActual.IDComision = int.Parse(this.txtIdComision.Text);
                    this.CursoActual.IDMateria = int.Parse(this.txtidMateria.Text);
                    CursoActual.State = BusinessEntity.States.New;
                    break;

                case ModoForm.Modicacion:
                    this.btnAceptar.Text = "Guardar";
                    Curso Uss = new Curso();
                    CursoActual = Uss;
                    this.CursoActual.ID = int.Parse(this.txtIdCurso.Text);
                    this.CursoActual.Cupo = int.Parse(this.txtCupo.Text);
                    this.CursoActual.AnioCalendario = this.txtAnio.Text;
                    this.CursoActual.IDComision = int.Parse(this.txtIdComision.Text);
                    this.CursoActual.IDMateria = int.Parse(this.txtidMateria.Text);
                    CursoActual.State = BusinessEntity.States.Modified;
                    break;

                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    CursoActual.State = BusinessEntity.States.Deleted;
                    break;

                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    CursoActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            CursoLogic cu = new CursoLogic();
            cu.Save(CursoActual);
        }

        public override bool Validar()
        {

            bool b2 = string.IsNullOrEmpty(this.txtIdCurso.Text);
            bool b3 = string.IsNullOrEmpty(this.txtAnio.Text);
            bool b4 = string.IsNullOrEmpty(this.txtCupo.Text);
            bool b5 = string.IsNullOrEmpty(this.txtIdComision.Text);
            bool b6 = string.IsNullOrEmpty(this.txtidMateria.Text);

            if (b2 == false && b3 == false && b4 == false && b5 == false && b6 == false)
            {
                return true;
            }
            else
            {
                this.Notificar("Por favor, rellenar los campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool b = this.Validar();
            if (b == true)
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
