﻿
namespace UI.Desktop
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.IDCursos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tsCursos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.tsCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCursos,
            this.AnioCalendario,
            this.cupo,
            this.IdMateria,
            this.IdComision});
            this.dgvCursos.Enabled = false;
            this.dgvCursos.Location = new System.Drawing.Point(0, 28);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowTemplate.Height = 25;
            this.dgvCursos.Size = new System.Drawing.Size(543, 273);
            this.dgvCursos.TabIndex = 2;
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDCursos
            // 
            this.IDCursos.DataPropertyName = "idCursos";
            this.IDCursos.HeaderText = "ID";
            this.IDCursos.Name = "IDCursos";
            this.IDCursos.ReadOnly = true;
            // 
            // AnioCalendario
            // 
            this.AnioCalendario.DataPropertyName = "anioCalendario";
            this.AnioCalendario.HeaderText = "Año Calendario";
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.ReadOnly = true;
            // 
            // cupo
            // 
            this.cupo.DataPropertyName = "cupo";
            this.cupo.HeaderText = "Cupo";
            this.cupo.Name = "cupo";
            this.cupo.ReadOnly = true;
            // 
            // IdMateria
            // 
            this.IdMateria.DataPropertyName = "idMateria";
            this.IdMateria.HeaderText = "ID Materia";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            // 
            // IdComision
            // 
            this.IdComision.DataPropertyName = "idComision";
            this.IdComision.HeaderText = "ID Comision";
            this.IdComision.Name = "IdComision";
            this.IdComision.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(427, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(301, 307);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(107, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tsCursos
            // 
            this.tsCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsCursos.Location = new System.Drawing.Point(0, 0);
            this.tsCursos.Name = "tsCursos";
            this.tsCursos.Size = new System.Drawing.Size(546, 25);
            this.tsCursos.TabIndex = 5;
            this.tsCursos.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "tsbNuevo";
            this.tsbNuevo.ToolTipText = "Nuevo";
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "tsbEditar";
            this.tsbEditar.ToolTipText = "Editar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "tsbEliminar";
            this.tsbEliminar.ToolTipText = "Eliminar";
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 339);
            this.Controls.Add(this.tsCursos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvCursos);
            this.Name = "Cursos";
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.tsCursos.ResumeLayout(false);
            this.tsCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComision;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolStrip tsCursos;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}