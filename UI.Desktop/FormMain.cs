﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI.Desktop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            Personas persona = new Personas();
            persona.ShowDialog();
            
            /*
            FormLogin appLogin = new FormLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
            */
        }

        private void btnAbmMaterias_Click(object sender, EventArgs e)
        {
            Materias mate = new Materias();
            mate.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAbmComisiones_Click(object sender, EventArgs e)
        {
            Comisiones comi = new Comisiones();
            comi.ShowDialog();
        }

        private void btnAbmPlanes_Click(object sender, EventArgs e)
        {
            Planes p = new Planes();
            p.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulos m = new Modulos();
            m.ShowDialog();
        }
    }
}
