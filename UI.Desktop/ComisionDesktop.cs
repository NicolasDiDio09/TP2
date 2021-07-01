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
    public partial class ComisionDesktop : ApplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();
        }
        public ComisionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public ComisionDesktop(int ID, ModoForm modo) : this()
        {
            ComisionLogic comi = new ComisionLogic();

            Modo = modo;

            ComisionActual = comi.GetOne(ID);
            MapearDeDatos();
        }
        public Business.Entities.Comision ComisionActual { get; set; } //prop
        public override void MapearDeDatos()
        {
            this.txtIdComision.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcionComision.Text = this.ComisionActual.DescComision.ToString();
            this.txtAnioEspecialidad.Text = this.ComisionActual.AnioEspecialidad.ToString();
            this.txtIdPlan.Text = this.ComisionActual.IdPlan.ToString();

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
                    Comision com = new Comision();
                    ComisionActual = com;
                    int id = 0;
                    this.ComisionActual.ID = id;
                    this.ComisionActual.DescComision = this.txtDescripcionComision.Text;
                    this.ComisionActual.AnioEspecialidad = int.Parse(this.txtAnioEspecialidad.Text);
                    this.ComisionActual.IdPlan= int.Parse(this.txtIdPlan.Text);
                    ComisionActual.State = Business.Entities.Comision.States.New;
                    break;

                case ModoForm.Modicacion:
                    this.btnAceptar.Text = "Guardar";
                    Comision comi = new Comision();
                    ComisionActual = comi;

                    this.ComisionActual.ID = int.Parse(this.txtIdComision.Text);
                    this.ComisionActual.DescComision = this.txtDescripcionComision.Text;
                    this.ComisionActual.AnioEspecialidad = int.Parse(this.txtAnioEspecialidad.Text);
                    this.ComisionActual.IdPlan = int.Parse(this.txtAnioEspecialidad.Text);
                    ComisionActual.State = Business.Entities.Comision.States.Modified;
                    break;

                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    ComisionActual.State = BusinessEntity.States.Deleted;
                    break;

                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    ComisionActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionLogic comi = new ComisionLogic();
            comi.Save(ComisionActual);
        }
        public override bool Validar()
        {
            bool a1 = string.IsNullOrEmpty(this.txtAnioEspecialidad.Text.ToString());

            bool a2 = string.IsNullOrEmpty(this.txtDescripcionComision.Text);
            

            if (a1 == false && a1 == false)
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

  

        private void btnAceptar_Click_1(object sender, EventArgs e)
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
