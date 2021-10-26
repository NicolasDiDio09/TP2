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
    public partial class PersonaDesktop : ApplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();
            PlanLogic pl = new PlanLogic();
            cbxPlan.DataSource = pl.GetAll();
            cbxPlan.DisplayMember = "DescPlan";
            cbxPlan.ValueMember = "ID";

            cbxTipoPersona.DataSource = Enum.GetValues(typeof(Business.Entities.Persona.Tipo_personas));

        }
        public PersonaDesktop(ModoForm modo) : this()  //constructor con sobrecarga
        {
            Modo = modo;
        }
        public Business.Entities.Persona PersonaActual { get; set; }
        public PersonaDesktop (int ID,ModoForm modo) : this()    //constructor con sobrecarga
        {
            Modo = modo;
            PersonaLogic user = new PersonaLogic();
            PersonaActual = user.GetOne(ID); //a la prop PersonaActual (de tipo Business.Entities.Persona) le asignamos la persona traida con el getOne que es de tipo business.Entities.Persona
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = PersonaActual.ID.ToString();
            this.txtNombre.Text = this.PersonaActual.Nombre;
            this.txtApellido.Text = this.PersonaActual.Apellido;
            this.txtDireccion.Text = this.PersonaActual.Direccion;
            this.txtEmail.Text = this.PersonaActual.Email.ToString();
            this.txtTelefono.Text = this.PersonaActual.Telefono.ToString();
            this.txtFecha_Nac.Text = this.PersonaActual.Fecha_nac.ToString();
            this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();
            this.cbxTipoPersona.SelectedItem = this.PersonaActual.Tipo_persona;
            this.cbxPlan.SelectedValue = this.PersonaActual.IDPlan;

            //tipo e idplan ya estan seleccionados por el combo box;
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
                    Persona per = new Persona(); // osea de tipo Business.Entities.Persona es "per"
                    PersonaActual = per; //a la prop PersonaActual (de tipo Business.Entities.Persona) le asigno una persona.
                    int id = 0;
                    this.PersonaActual.ID = id;
                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    this.PersonaActual.Email = this.txtEmail.Text;
                    this.PersonaActual.Telefono = this.txtTelefono.Text;
                    DateTime fecha = new DateTime(); //ya que no podia pasar derecho de string a DateTime
                    fecha = DateTime.Parse(this.txtFecha_Nac.Text);
                    this.PersonaActual.Fecha_nac = fecha;
                    this.PersonaActual.Tipo_persona = (Business.Entities.Persona.Tipo_personas)(this.cbxTipoPersona.SelectedValue);
                    this.PersonaActual.Legajo =int.Parse(this.txtLegajo.Text);
                    this.PersonaActual.IDPlan = int.Parse(this.cbxPlan.SelectedValue.ToString());
                    PersonaActual.State = BusinessEntity.States.New;
                    
                    break;

                case ModoForm.Modicacion:
                    this.btnAceptar.Text = "Guardar";
                    Persona pers = new Persona(); // osea de tipo Business.Entities.Persona es "pers"
                    PersonaActual = pers; //a la prop PersonaActual (de tipo Business.Entities.Persona) le asigno una persona.
                    this.PersonaActual.ID = int.Parse(this.txtID.Text);
                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    this.PersonaActual.Email = this.txtEmail.Text;
                    this.PersonaActual.Telefono = this.txtTelefono.Text;

                    DateTime fechita = new DateTime(); //ya que no podia pasar derecho de string a DateTime
                    fechita = DateTime.Parse(this.txtFecha_Nac.Text);
                    this.PersonaActual.Fecha_nac = fechita;

                    this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                    this.PersonaActual.Tipo_persona = (Business.Entities.Persona.Tipo_personas)(this.cbxTipoPersona.SelectedValue);
                    this.PersonaActual.IDPlan = int.Parse(cbxPlan.SelectedValue.ToString());
                    PersonaActual.State = BusinessEntity.States.Modified;
                    break;

                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    PersonaActual.State = BusinessEntity.States.Deleted;
                    break;

                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    PersonaActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }
        public override bool Validar()
        {

            bool b2 = string.IsNullOrEmpty(this.txtNombre.Text);
            bool b3 = string.IsNullOrEmpty(this.txtApellido.Text);
            bool b4 = string.IsNullOrEmpty(this.txtEmail.Text);
            bool b5 = string.IsNullOrEmpty(this.txtTelefono.Text);
            bool b6 = string.IsNullOrEmpty(this.txtDireccion.Text);
            bool b7 = string.IsNullOrEmpty(this.txtFecha_Nac.Text);
            bool b8 = string.IsNullOrEmpty(this.txtLegajo.Text.ToString());
            //bool b9 = string.IsNullOrEmpty(this.txtTipo_Persona.Text.ToString());

            if (b2 == false && b3 == false && b4 == false && b5 == false && b6 == false && b7 == false)
            {
                return true;   
            }
            else
            {
                this.Notificar("Por favor, rellenar los campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

        }

        public void GuardarCambios()
        {
            MapearADatos();
            PersonaLogic datosPersonas = new PersonaLogic();
            datosPersonas.Save(PersonaActual);
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
