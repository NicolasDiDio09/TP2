
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
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.cbDocente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIDDictado = new System.Windows.Forms.TextBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlDocenteCursoDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlDocenteCursoDesktop
            // 
            this.tlDocenteCursoDesktop.ColumnCount = 2;
            this.tlDocenteCursoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.60692F));
            this.tlDocenteCursoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.39307F));
            this.tlDocenteCursoDesktop.Controls.Add(this.tbCargo, 1, 3);
            this.tlDocenteCursoDesktop.Controls.Add(this.cbDocente, 1, 2);
            this.tlDocenteCursoDesktop.Controls.Add(this.label2, 0, 1);
            this.tlDocenteCursoDesktop.Controls.Add(this.label3, 0, 2);
            this.tlDocenteCursoDesktop.Controls.Add(this.label4, 0, 3);
            this.tlDocenteCursoDesktop.Controls.Add(this.tbIDDictado, 1, 0);
            this.tlDocenteCursoDesktop.Controls.Add(this.cbCurso, 1, 1);
            this.tlDocenteCursoDesktop.Controls.Add(this.label1, 0, 0);
            this.tlDocenteCursoDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDocenteCursoDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlDocenteCursoDesktop.Name = "tlDocenteCursoDesktop";
            this.tlDocenteCursoDesktop.RowCount = 4;
            this.tlDocenteCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlDocenteCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlDocenteCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlDocenteCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlDocenteCursoDesktop.Size = new System.Drawing.Size(485, 205);
            this.tlDocenteCursoDesktop.TabIndex = 0;
            // 
            // tbCargo
            // 
            this.tbCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCargo.Location = new System.Drawing.Point(112, 159);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(370, 23);
            this.tbCargo.TabIndex = 7;
            // 
            // cbDocente
            // 
            this.cbDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDocente.FormattingEnabled = true;
            this.cbDocente.Location = new System.Drawing.Point(112, 97);
            this.cbDocente.Name = "cbDocente";
            this.cbDocente.Size = new System.Drawing.Size(370, 23);
            this.cbDocente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Docente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // tbIDDictado
            // 
            this.tbIDDictado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIDDictado.Location = new System.Drawing.Point(112, 3);
            this.tbIDDictado.Name = "tbIDDictado";
            this.tbIDDictado.Size = new System.Drawing.Size(370, 23);
            this.tbIDDictado.TabIndex = 4;
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(112, 50);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(370, 23);
            this.cbCurso.TabIndex = 5;
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
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 205);
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
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.ComboBox cbDocente;
        private System.Windows.Forms.TextBox tbIDDictado;
        private System.Windows.Forms.ComboBox cbCurso;
    }
}