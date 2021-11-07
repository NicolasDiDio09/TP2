
namespace UI.Desktop
{
    partial class DocenteCursoDesktop
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
            this.tlDocenteCursoDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.txtIDDictado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDocente = new System.Windows.Forms.ComboBox();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.cbxComision = new System.Windows.Forms.ComboBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tlDocenteCursoDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlDocenteCursoDesktop
            // 
            this.tlDocenteCursoDesktop.ColumnCount = 3;
            this.tlDocenteCursoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlDocenteCursoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlDocenteCursoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlDocenteCursoDesktop.Controls.Add(this.txtIDDictado, 1, 0);
            this.tlDocenteCursoDesktop.Controls.Add(this.label1, 0, 0);
            this.tlDocenteCursoDesktop.Controls.Add(this.label3, 0, 1);
            this.tlDocenteCursoDesktop.Controls.Add(this.label2, 0, 2);
            this.tlDocenteCursoDesktop.Controls.Add(this.label5, 0, 4);
            this.tlDocenteCursoDesktop.Controls.Add(this.label4, 0, 5);
            this.tlDocenteCursoDesktop.Controls.Add(this.cbxDocente, 1, 1);
            this.tlDocenteCursoDesktop.Controls.Add(this.cbxMateria, 1, 2);
            this.tlDocenteCursoDesktop.Controls.Add(this.cbxComision, 1, 4);
            this.tlDocenteCursoDesktop.Controls.Add(this.cbxCargo, 1, 5);
            this.tlDocenteCursoDesktop.Controls.Add(this.btnCancelar, 2, 6);
            this.tlDocenteCursoDesktop.Controls.Add(this.btnAceptar, 1, 6);
            this.tlDocenteCursoDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDocenteCursoDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlDocenteCursoDesktop.Name = "tlDocenteCursoDesktop";
            this.tlDocenteCursoDesktop.RowCount = 7;
            this.tlDocenteCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlDocenteCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.84713F));
            this.tlDocenteCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.03185F));
            this.tlDocenteCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlDocenteCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlDocenteCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlDocenteCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlDocenteCursoDesktop.Size = new System.Drawing.Size(578, 278);
            this.tlDocenteCursoDesktop.TabIndex = 0;
            // 
            // txtIDDictado
            // 
            this.txtIDDictado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIDDictado.Location = new System.Drawing.Point(136, 3);
            this.txtIDDictado.Name = "txtIDDictado";
            this.txtIDDictado.ReadOnly = true;
            this.txtIDDictado.Size = new System.Drawing.Size(305, 23);
            this.txtIDDictado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID dictado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Docente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Comision";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // cbxDocente
            // 
            this.cbxDocente.FormattingEnabled = true;
            this.cbxDocente.Location = new System.Drawing.Point(136, 55);
            this.cbxDocente.Name = "cbxDocente";
            this.cbxDocente.Size = new System.Drawing.Size(305, 23);
            this.cbxDocente.TabIndex = 12;
            // 
            // cbxMateria
            // 
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Location = new System.Drawing.Point(136, 105);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(305, 23);
            this.cbxMateria.TabIndex = 13;
            // 
            // cbxComision
            // 
            this.cbxComision.FormattingEnabled = true;
            this.cbxComision.Location = new System.Drawing.Point(136, 160);
            this.cbxComision.Name = "cbxComision";
            this.cbxComision.Size = new System.Drawing.Size(305, 23);
            this.cbxComision.TabIndex = 14;
            // 
            // cbxCargo
            // 
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Location = new System.Drawing.Point(136, 197);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(305, 23);
            this.cbxCargo.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(447, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(136, 229);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 278);
            this.Controls.Add(this.tlDocenteCursoDesktop);
            this.Name = "DocenteCursoDesktop";
            this.Text = "DocenteCursoDesktop";
            this.tlDocenteCursoDesktop.ResumeLayout(false);
            this.tlDocenteCursoDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlDocenteCursoDesktop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDDictado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxDocente;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.ComboBox cbxComision;
        private System.Windows.Forms.ComboBox cbxCargo;
    }
}