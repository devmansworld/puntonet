namespace CursosAlumno
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_Curso = new System.Windows.Forms.Button();
            this.b_Alumno = new System.Windows.Forms.Button();
            this.b_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Curso
            // 
            this.b_Curso.Location = new System.Drawing.Point(68, 40);
            this.b_Curso.Name = "b_Curso";
            this.b_Curso.Size = new System.Drawing.Size(158, 82);
            this.b_Curso.TabIndex = 0;
            this.b_Curso.Text = "Agregar Curso";
            this.b_Curso.UseVisualStyleBackColor = true;
            this.b_Curso.Click += new System.EventHandler(this.b_Curso_Click);
            // 
            // b_Alumno
            // 
            this.b_Alumno.Location = new System.Drawing.Point(68, 143);
            this.b_Alumno.Name = "b_Alumno";
            this.b_Alumno.Size = new System.Drawing.Size(158, 82);
            this.b_Alumno.TabIndex = 1;
            this.b_Alumno.Text = "Agregar Alumno";
            this.b_Alumno.UseVisualStyleBackColor = true;
            this.b_Alumno.Click += new System.EventHandler(this.b_Alumno_Click);
            // 
            // b_salir
            // 
            this.b_salir.Location = new System.Drawing.Point(102, 272);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(75, 23);
            this.b_salir.TabIndex = 2;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(298, 342);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_Alumno);
            this.Controls.Add(this.b_Curso);
            this.MaximumSize = new System.Drawing.Size(314, 381);
            this.MinimumSize = new System.Drawing.Size(314, 381);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Registro de Alumnos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Curso;
        private System.Windows.Forms.Button b_Alumno;
        private System.Windows.Forms.Button b_salir;
    }
}

