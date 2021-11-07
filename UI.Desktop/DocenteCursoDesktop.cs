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
    public partial class DocenteCursoDesktop : ApplicationForm
    {
        public DocenteCursoDesktop()
        {
            InitializeComponent();
            Mostrardatos();
        }

        private void Mostrardatos()
        {

            Business.Logic.PersonaLogic perso = new PersonaLogic();
            cbxDocente.DataSource = perso.RecuperarPorfesores();
            cbxDocente.DisplayMember = "Nombre";
            cbxDocente.ValueMember = "ID";

            Business.Logic.MateriaLogic materia = new MateriaLogic();
            cbxMateria.DataSource = materia.GetAll();
            cbxMateria.DisplayMember = "DescMateria";
            cbxMateria.ValueMember = "ID";

            /*
            List<Comision>comisiones = materia.BuscarComisiones((int)cbxMateria.SelectedValue);
            */
            Business.Logic.ComisionLogic comision = new ComisionLogic();
            cbxComision.DataSource = comision.GetAll();
            cbxComision.DisplayMember = "DescComision";
            cbxComision.ValueMember = "ID";

            cbxCargo.DataSource = Enum.GetValues(typeof(Business.Entities.DocenteCurso.cargos));
        }

        public DocenteCursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public Business.Entities.DocenteCurso DocenteCursoActual { get; set; }

        public DocenteCursoDesktop(int id, ModoForm modo) : this()
        {
            DocenteCursoLogic dc = new DocenteCursoLogic();
            Modo = modo;

            DocenteCursoActual = dc.GetOne(id);
            this.MapearDeDatos();
        }

        
        public override void MapearDeDatos()
        {
            //mapeando el id

            this.txtIDDictado.Text = this.DocenteCursoActual.ID.ToString();

            this.cbxDocente.SelectedItem = this.DocenteCursoActual.IDDocente;

            CursoLogic cursoData = new CursoLogic();
            Curso curso = cursoData.GetOne(DocenteCursoActual.IDCurso);

            this.cbxMateria.SelectedValue = curso.IDMateria;
            this.cbxComision.SelectedValue = curso.IDComision;

            

            /*
            //mapareando la materia
            Business.Logic.MateriaLogic materia = new MateriaLogic();
            cbxMateria.DataSource = materia.GetAll();
            cbxMateria.DisplayMember = "desc_materia";
            cbxMateria.ValueMember = "id_materia";

            //mapeando el curso en base a la materia seleccionada
            int idMateria = (int)cbxMateria.SelectedValue;

            DocenteCursoLogic dcl = new DocenteCursoLogic();
            cbxComision.DataSource = dcl.BuscarComisiones(idMateria);
            cbxComision.DisplayMember = "desc_comision";
            cbxComision.ValueMember = "id_comision";
            */

            //Mapeando el cargo
            cbxCargo.SelectedItem = this.DocenteCursoActual.Cargo;
            
            
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
                    Business.Entities.DocenteCurso dc = new Business.Entities.DocenteCurso();
                    DocenteCursoActual = dc;
                    int id = 0;
                    this.DocenteCursoActual.ID = id;
                    this.DocenteCursoActual.IDDocente = int.Parse(cbxDocente.SelectedValue.ToString());
                    
                    
                    //guardo la info del los combo
                    int idMateria = (int)cbxMateria.SelectedValue;
                    int idComision = (int)cbxComision.SelectedValue;


                    DocenteCursoLogic dcl = new DocenteCursoLogic();
                    //busco en la tabla por la info obtenida de los combos
                    this.DocenteCursoActual.IDCurso = dcl.BuscarCurso(idMateria, idComision).ID;

                    this.DocenteCursoActual.Cargo = (Business.Entities.DocenteCurso.cargos)(this.cbxCargo.SelectedValue);
                    DocenteCursoActual.State = BusinessEntity.States.New;
                    break;

                case ModoForm.Modicacion:
                    this.btnAceptar.Text = "Guardar";
                    Business.Entities.DocenteCurso doceC = new Business.Entities.DocenteCurso();
                    DocenteCursoActual = doceC;
                    DocenteCursoActual.ID = int.Parse(txtIDDictado.Text);
                    DocenteCursoActual.IDDocente = int.Parse(cbxDocente.SelectedValue.ToString());

                    int idMateria1 = (int)cbxMateria.SelectedValue;
                    int idComision1 = (int)cbxComision.SelectedValue;


                    DocenteCursoLogic dcl1 = new DocenteCursoLogic();
                    //busco en la tabla por la info obtenida de los combos
                    this.DocenteCursoActual.IDCurso = dcl1.BuscarCurso(idMateria1, idComision1).ID;

                    this.DocenteCursoActual.Cargo = (Business.Entities.DocenteCurso.cargos)(this.cbxCargo.SelectedValue);
                    DocenteCursoActual.State = BusinessEntity.States.Modified;
                    break;

                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    DocenteCursoActual.State = BusinessEntity.States.Deleted;
                    break;

                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    DocenteCursoActual.State = BusinessEntity.States.Unmodified;
                    break;

            }

        }

        public void GuardarCambios()
        {
            MapearADatos();
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            dcl.Save(DocenteCursoActual);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
