
namespace UI.Desktop
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDocentesCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.tsmUsuarios,
            this.tsmMaterias,
            this.tsmComisiones,
            this.tsmDocentesCursos,
            this.tsmCursos,
            this.tsmPersonas});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnsPrincipal.TabIndex = 1;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(96, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // tsmUsuarios
            // 
            this.tsmUsuarios.Name = "tsmUsuarios";
            this.tsmUsuarios.Size = new System.Drawing.Size(64, 20);
            this.tsmUsuarios.Text = "Usuarios";
            this.tsmUsuarios.Click += new System.EventHandler(this.tsmUsuarios_Click);
            // 
            // tsmMaterias
            // 
            this.tsmMaterias.Name = "tsmMaterias";
            this.tsmMaterias.Size = new System.Drawing.Size(64, 20);
            this.tsmMaterias.Text = "Materias";
            this.tsmMaterias.Click += new System.EventHandler(this.tsmMaterias_Click);
            // 
            // tsmComisiones
            // 
            this.tsmComisiones.Name = "tsmComisiones";
            this.tsmComisiones.Size = new System.Drawing.Size(81, 20);
            this.tsmComisiones.Text = "Comisiones";
            this.tsmComisiones.Click += new System.EventHandler(this.tsmComisiones_Click);
            // 
            // tsmDocentesCursos
            // 
            this.tsmDocentesCursos.Name = "tsmDocentesCursos";
            this.tsmDocentesCursos.Size = new System.Drawing.Size(104, 20);
            this.tsmDocentesCursos.Text = "DocentesCursos";
            this.tsmDocentesCursos.Click += new System.EventHandler(this.tsmDocentesCursos_Click);
            // 
            // tsmCursos
            // 
            this.tsmCursos.Name = "tsmCursos";
            this.tsmCursos.Size = new System.Drawing.Size(55, 20);
            this.tsmCursos.Text = "Cursos";
            this.tsmCursos.Click += new System.EventHandler(this.tsmCursos_Click);
            // 
            // tsmPersonas
            // 
            this.tsmPersonas.Name = "tsmPersonas";
            this.tsmPersonas.Size = new System.Drawing.Size(66, 20);
            this.tsmPersonas.Text = "Personas";
            this.tsmPersonas.Click += new System.EventHandler(this.tsmPersonas_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Academia";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmMaterias;
        private System.Windows.Forms.ToolStripMenuItem tsmComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsmDocentesCursos;
        private System.Windows.Forms.ToolStripMenuItem tsmCursos;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonas;
    }
}