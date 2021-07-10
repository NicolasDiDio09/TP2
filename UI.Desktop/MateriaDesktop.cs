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
    public partial class MateriaDesktop : ApplicationForm
    {
        public Materia MateriaActual { get; set; }
        public MateriaDesktop()
        {
            InitializeComponent();
            Business.Logic.PlanLogic pl = new PlanLogic();
            cbxPlan.DataSource = pl.GetAll();
            cbxPlan.DisplayMember = "DescPlan";
            cbxPlan.ValueMember = "ID";
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            MateriaLogic mate = new MateriaLogic();

            Modo = modo;

            MateriaActual = mate.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.MateriaActual.ID.ToString();
            this.txtDescripcion.Text= this.MateriaActual.DescMateria.ToString();
            this.txtHSSemanales.Text = this.MateriaActual.HSSemanales.ToString();
            this.txtHSTotales.Text = this.MateriaActual.HSTotales.ToString();
            this.txtIDPlan.Text = this.MateriaActual.IDPlan.ToString();
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
                    Materia mat = new Materia();
                    MateriaActual = mat;
                    int id = 0;
                    this.MateriaActual.ID = id;
                    this.MateriaActual.DescMateria = this.txtDescripcion.Text;
                    this.MateriaActual.HSSemanales = int.Parse(this.txtHSSemanales.Text);
                    this.MateriaActual.HSTotales = int.Parse(this.txtHSTotales.Text);
                    this.MateriaActual.IDPlan = int.Parse(this.txtIDPlan.Text);
                    MateriaActual.State = BusinessEntity.States.New;
                    break;

                case ModoForm.Modicacion:
                    this.btnAceptar.Text = "Guardar";
                    Materia mate = new Materia();
                    MateriaActual = mate;
                    this.MateriaActual.ID = int.Parse(this.txtID.Text);
                    this.MateriaActual.DescMateria = this.txtDescripcion.Text;
                    this.MateriaActual.HSSemanales = int.Parse(this.txtHSSemanales.Text);
                    this.MateriaActual.HSTotales = int.Parse(this.txtHSTotales.Text);
                    this.MateriaActual.IDPlan = int.Parse(this.txtIDPlan.Text);
                    MateriaActual.State = BusinessEntity.States.Modified;
                    break;

                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    MateriaActual.State = BusinessEntity.States.Deleted;
                    break;

                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    MateriaActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic mt = new MateriaLogic();
            mt.Save(MateriaActual);
        }

        public override bool Validar()
        {

            bool b1 = string.IsNullOrEmpty(this.txtDescripcion.Text);
            bool b2 = string.IsNullOrEmpty(this.txtHSSemanales.Text);
            bool b3 = string.IsNullOrEmpty(this.txtHSTotales.Text);
            bool b4 = string.IsNullOrEmpty(this.txtIDPlan.Text);

            if (b1 == false && b2 == false && b3 == false && b4==false)
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
