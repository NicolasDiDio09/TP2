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
    public partial class Alumnos_InscripcionesDesktop : ApplicationForm
    {
        public Alumnos_InscripcionesDesktop()
        {
            InitializeComponent();
        }

        public Alumnos_InscripcionesDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public Alumnos_InscripcionesDesktop(int ID, ModoForm modo) : this()
        {
            Alumnos_InscripcionesLogic ali = new Alumnos_InscripcionesLogic();

            Modo = modo;

            AlIActual = ali.GetOne(ID);
            MapearDeDatos();
        }

        public Business.Entities.Alumnos_Inscripciones AlIActual { get; set; }

        public override void MapearDeDatos()
        {
            this.txtId_Inscripcion.Text = this.AlIActual.ID.ToString();
            this.txtId_Alumno.Text = this.AlIActual.Id_alumno.ToString();
            this.txtId_Curso.Text = this.AlIActual.Id_curso.ToString();
            this.txtCondicion.Text = this.AlIActual.Condicion.ToString();
            this.txtNota.Text = this.AlIActual.Nota.ToString();
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
                    Business.Entities.Alumnos_Inscripciones Ali = new Business.Entities.Alumnos_Inscripciones();
                    AlIActual = Ali;
                    this.AlIActual.Id_inscripcion = int.Parse(this.txtId_Inscripcion.Text);
                    this.AlIActual.Id_alumno = int.Parse(this.txtId_Alumno.Text);
                    this.AlIActual.Id_curso = int.Parse(this.txtId_Curso.Text);
                    this.AlIActual.Condicion = this.txtCondicion.Text;
                    this.AlIActual.Nota = int.Parse(this.txtNota.Text);
                    AlIActual.State = BusinessEntity.States.New;
                    break;

                case ModoForm.Modicacion:
                    this.btnAceptar.Text = "Guardar";
                    Business.Entities.Alumnos_Inscripciones Uss = new Business.Entities.Alumnos_Inscripciones();
                    AlIActual = Uss;
                    this.AlIActual.Id_inscripcion= int.Parse(this.txtId_Inscripcion.Text);
                    this.AlIActual.Id_alumno= int.Parse(this.txtId_Alumno.Text);
                    this.AlIActual.Id_curso = int.Parse(this.txtId_Curso.Text);
                    this.AlIActual.Nota = int.Parse(this.txtNota.Text);
                    this.AlIActual.Condicion = this.txtCondicion.Text;
                    AlIActual.State = BusinessEntity.States.Modified;
                    break;

                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    AlIActual.State = BusinessEntity.States.Deleted;
                    break;

                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    AlIActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            Alumnos_InscripcionesLogic us = new Alumnos_InscripcionesLogic();
            us.Save(AlIActual);
        }

        public override bool Validar()
        {

            bool b2 = string.IsNullOrEmpty(this.txtId_Inscripcion.Text);
            bool b3 = string.IsNullOrEmpty(this.txtId_Alumno.Text);
            bool b4 = string.IsNullOrEmpty(this.txtId_Curso.Text);
            bool b5 = string.IsNullOrEmpty(this.txtCondicion.Text);
            bool b6 = string.IsNullOrEmpty(this.txtNota.Text);

            if (b2 == true || b3 == true || b4 == true || b5 == true || b6 == true)
            {
                this.Notificar("Por favor, rellenar los campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            else
            {
                return true;
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
