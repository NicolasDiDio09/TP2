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
    public partial class Cursos : Form
    {
        public int UsuarioID { get; set; }

        public Cursos()
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
        }

        public Cursos(int id)
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
            UsuarioID = id;
        }

        private void Lista()
        {
            UsuarioLogic ul = new UsuarioLogic();
            Persona per = ul.BuscaPersona(UsuarioID);
            if (per.TipoPersona.ToString() == "Admin")
            {
                this.Listar();
            }
            else 
            {
                tsbNuevo.Visible = false;
                tsbEditar.Visible = false;
                tsbEliminar.Visible = false;
                this.Listar();
            }
        }

        public void Listar()
        {
            try
            {
                CursoLogic ul = new CursoLogic();
                this.dgvCursos.DataSource = ul.GetAll();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error al recuperar la lista de cursos");
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de cursos", fe);
                throw ExcepcionManejada;
            }
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            this.Lista();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Lista();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop ud = new CursoDesktop(ModoForm.Alta);
            ud.ShowDialog();
            this.Lista();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
            CursoDesktop us = new CursoDesktop(id, ModoForm.Modicacion);
            us.ShowDialog();
            this.Lista();

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
            CursoDesktop us = new CursoDesktop(id, ModoForm.Baja);
            us.ShowDialog();
            this.Lista();
        }

        private void Cursos_Load_1(object sender, EventArgs e)
        {
            this.Lista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
