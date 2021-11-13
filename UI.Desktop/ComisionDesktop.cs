﻿using System;
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
        public Comision ComisionActual { get; set; }
        public ComisionDesktop()
        {
            InitializeComponent();
            cbxAnioEspecialidad.DataSource = Enum.GetValues(typeof(Business.Entities.Comision.Anios));
            Business.Logic.PlanLogic pl = new PlanLogic();
            cbxPlan.DataSource = pl.GetAll();
            cbxPlan.DisplayMember = "DescPlan";
            cbxPlan.ValueMember = "ID";
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

        public override void MapearDeDatos()
        {
            this.txtIdComision.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcionComision.Text = this.ComisionActual.DescComision.ToString();
            cbxAnioEspecialidad.SelectedItem = this.ComisionActual.AnioEspecialidad;
            cbxPlan.SelectedItem = this.ComisionActual.IdPlan;

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
                    this.ComisionActual.AnioEspecialidad = (Comision.Anios)(this.cbxAnioEspecialidad.SelectedValue); ;
                    this.ComisionActual.IdPlan= int.Parse(cbxPlan.SelectedValue.ToString());
                    ComisionActual.State = Business.Entities.Comision.States.New;
                    break;

                case ModoForm.Modicacion:
                    this.btnAceptar.Text = "Guardar";
                    Comision comi = new Comision();
                    ComisionActual = comi;

                    this.ComisionActual.DescComision = this.txtDescripcionComision.Text;
                    this.ComisionActual.AnioEspecialidad = (Comision.Anios)(this.cbxAnioEspecialidad.SelectedValue); ;
                    this.ComisionActual.IdPlan = int.Parse(cbxPlan.SelectedValue.ToString());
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
            if(Modo == ModoForm.Baja)
            {
                List<Curso> cursos = comi.BuscarCursos(ComisionActual.ID);
                if (cursos.Count != 0)
                {
                    this.Notificar("Debe eliminar los cursos que se dan en esta comision", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    comi.Save(ComisionActual);
                }
            }
            else
            {
                comi.Save(ComisionActual);
            }
            
        }
        public override bool Validar()
        {

            bool a2 = string.IsNullOrEmpty(this.txtDescripcionComision.Text);
            

            if ( a2 == false)
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
