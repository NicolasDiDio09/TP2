
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
            this.altaUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbmMaterias = new System.Windows.Forms.Button();
            this.btnAbmComisiones = new System.Windows.Forms.Button();
            this.btnAbmPlanes = new System.Windows.Forms.Button();
            this.btnAbmModulos = new System.Windows.Forms.Button();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.altaUsuariosToolStripMenuItem});
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
            // altaUsuariosToolStripMenuItem
            //
            this.altaUsuariosToolStripMenuItem.Name = "altaUsuariosToolStripMenuItem";
            this.altaUsuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.altaUsuariosToolStripMenuItem.Text = "Usuarios";
            //this.altaUsuariosToolStripMenuItem.Click += new System.EventHandler(this.altaUsuariosToolStripMenuItem_Click);
            // 
            // btnAbmMaterias
            // 
            this.btnAbmMaterias.Location = new System.Drawing.Point(0, 57);
            this.btnAbmMaterias.Name = "btnAbmMaterias";
            this.btnAbmMaterias.Size = new System.Drawing.Size(800, 23);
            this.btnAbmMaterias.TabIndex = 3;
            this.btnAbmMaterias.Text = "abm materias";
            this.btnAbmMaterias.UseVisualStyleBackColor = true;
            this.btnAbmMaterias.Click += new System.EventHandler(this.btnAbmMaterias_Click);
            // 
            // btnAbmComisiones
            // 
            this.btnAbmComisiones.Location = new System.Drawing.Point(0, 151);
            this.btnAbmComisiones.Name = "btnAbmComisiones";
            this.btnAbmComisiones.Size = new System.Drawing.Size(800, 23);
            this.btnAbmComisiones.TabIndex = 5;
            this.btnAbmComisiones.Text = "abm comisiones";
            this.btnAbmComisiones.UseVisualStyleBackColor = true;
            this.btnAbmComisiones.Click += new System.EventHandler(this.btnAbmComisiones_Click);
            // 
            // btnAbmPlanes
            // 
            this.btnAbmPlanes.Location = new System.Drawing.Point(0, 244);
            this.btnAbmPlanes.Name = "btnAbmPlanes";
            this.btnAbmPlanes.Size = new System.Drawing.Size(800, 23);
            this.btnAbmPlanes.TabIndex = 7;
            this.btnAbmPlanes.Text = "abm planes";
            this.btnAbmPlanes.UseVisualStyleBackColor = true;
            this.btnAbmPlanes.Click += new System.EventHandler(this.btnAbmPlanes_Click);
            // 
            // btnAbmModulos
            // 
            this.btnAbmModulos.Location = new System.Drawing.Point(0, 332);
            this.btnAbmModulos.Name = "btnAbmModulos";
            this.btnAbmModulos.Size = new System.Drawing.Size(800, 23);
            this.btnAbmModulos.TabIndex = 9;
            this.btnAbmModulos.Text = "abm Modulos";
            this.btnAbmModulos.UseVisualStyleBackColor = true;
            this.btnAbmModulos.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbmModulos);
            this.Controls.Add(this.btnAbmPlanes);
            this.Controls.Add(this.btnAbmComisiones);
            this.Controls.Add(this.btnAbmMaterias);
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
        private System.Windows.Forms.Button btnAbmMaterias;
        private System.Windows.Forms.Button btnAbmComisiones;
        private System.Windows.Forms.ToolStripMenuItem altaUsuariosToolStripMenuItem;
        private System.Windows.Forms.Button btnAbmPlanes;
        private System.Windows.Forms.Button btnAbmModulos;
    }
}