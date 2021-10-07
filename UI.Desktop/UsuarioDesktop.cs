﻿using System;
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
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public Business.Entities.Usuario UsuarioActual { get; set; }

        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            UsuarioLogic user = new UsuarioLogic();
            
            Modo = modo;

            UsuarioActual = user.GetOne(ID);
            MapearDeDatos();
        }

        

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre.ToString();
            this.txtApellido.Text = this.UsuarioActual.Apellido.ToString();
            this.txtEmail.Text = this.UsuarioActual.Email.ToString();
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario.ToString();
            this.txtClave.Text = this.UsuarioActual.Clave.ToString();
            this.txtConfirmarClave.Text = this.txtClave.Text;
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
                    Usuario Us = new Usuario();
                    UsuarioActual = Us;
                    int id = 0; 
                    this.UsuarioActual.ID = id;
                    this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    this.UsuarioActual.Nombre = this.txtNombre.Text;
                    this.UsuarioActual.Apellido = this.txtApellido.Text;
                    this.UsuarioActual.Email = this.txtEmail.Text;
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    this.UsuarioActual.Clave = this.txtClave.Text;
                    UsuarioActual.State = BusinessEntity.States.New;
                    break;

                case ModoForm.Modicacion:
                    this.btnAceptar.Text = "Guardar";
                    Usuario Uss = new Usuario();
                    UsuarioActual = Uss;
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    this.UsuarioActual.Nombre = this.txtNombre.Text;
                    this.UsuarioActual.Apellido = this.txtApellido.Text;
                    this.UsuarioActual.Email = this.txtEmail.Text;
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    this.UsuarioActual.Clave = this.txtClave.Text;
                    UsuarioActual.State = BusinessEntity.States.Modified;
                    break;

                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    UsuarioActual.State = BusinessEntity.States.Deleted;
                    break;

                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    UsuarioActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic us = new UsuarioLogic();
            us.Save(UsuarioActual);
        }

        public override bool Validar()
        {
             
            bool b2 = string.IsNullOrEmpty(this.txtNombre.Text);
            bool b3 = string.IsNullOrEmpty(this.txtApellido.Text);
            bool b4 = string.IsNullOrEmpty(this.txtEmail.Text);
            bool b5 = string.IsNullOrEmpty(this.txtUsuario.Text);
            bool b6 = string.IsNullOrEmpty(this.txtClave.Text);
            bool b7 = string.IsNullOrEmpty(this.txtConfirmarClave.Text);

            if(b2==false && b3 == false && b4 == false && b5 == false && b6 == false && b7 == false)
            {
                if(txtClave.Text != txtConfirmarClave.Text)
                {
                    this.Notificar("Claves distintas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if(this.txtClave.Text.Length < 8)
                {
                    this.Notificar("La clave tiene menos de 8 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    return true;
                }
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
