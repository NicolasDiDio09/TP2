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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public int UsuarioID { get; set; }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            FormLogin appLogin = new FormLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
            UsuarioID = appLogin.UsurioID;
            UsuarioLogic ul = new UsuarioLogic();
            Persona per = ul.BuscaPersona(UsuarioID);
            if(per.TipoPersona.ToString() != "Admin")
            {
                tsmDocentesCursos.Visible = false;
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void tsmUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios(UsuarioID);
            user.ShowDialog();
        }

        private void tsmMaterias_Click(object sender, EventArgs e)
        {
            Materias mat = new Materias(UsuarioID);
            mat.ShowDialog();
        }

        private void tsmDocentesCursos_Click(object sender, EventArgs e)
        {
            DocenteCurso docenteCurso = new DocenteCurso(UsuarioID);
            docenteCurso.ShowDialog();
        }

        private void tsmComisiones_Click(object sender, EventArgs e)
        {
            Comisiones com = new Comisiones(UsuarioID);
            com.ShowDialog();
        }

        private void tsmPersonas_Click(object sender, EventArgs e)
        {
            Personas per = new Personas(UsuarioID);
            per.ShowDialog();
        }

        private void tsmCursos_Click(object sender, EventArgs e)
        {
            Cursos cur = new Cursos(UsuarioID);
            cur.ShowDialog();
        }
    }
}
