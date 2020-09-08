namespace CursosAlumno.View
{
    partial class rAlumno
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
            this.dgv_mostrarC = new System.Windows.Forms.DataGridView();
            this.b_mostrar = new System.Windows.Forms.Button();
            this.b_salir = new System.Windows.Forms.Button();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.b_modificar = new System.Windows.Forms.Button();
            this.b_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_idA = new System.Windows.Forms.TextBox();
            this.tb_nombreA = new System.Windows.Forms.TextBox();
            this.tb_appatA = new System.Windows.Forms.TextBox();
            this.tb_apmatA = new System.Windows.Forms.TextBox();
            this.tb_rutA = new System.Windows.Forms.TextBox();
            this.cb_curso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrarC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_mostrarC
            // 
            this.dgv_mostrarC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrarC.Location = new System.Drawing.Point(3, 288);
            this.dgv_mostrarC.Name = "dgv_mostrarC";
            this.dgv_mostrarC.Size = new System.Drawing.Size(484, 150);
            this.dgv_mostrarC.TabIndex = 20;
            this.dgv_mostrarC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mostrarC_CellContentClick);
            // 
            // b_mostrar
            // 
            this.b_mostrar.Location = new System.Drawing.Point(12, 259);
            this.b_mostrar.Name = "b_mostrar";
            this.b_mostrar.Size = new System.Drawing.Size(127, 23);
            this.b_mostrar.TabIndex = 19;
            this.b_mostrar.Text = "Mostrar datos";
            this.b_mostrar.UseVisualStyleBackColor = true;
            this.b_mostrar.Click += new System.EventHandler(this.b_mostrar_Click);
            // 
            // b_salir
            // 
            this.b_salir.Location = new System.Drawing.Point(412, 187);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(75, 23);
            this.b_salir.TabIndex = 18;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // b_reset
            // 
            this.b_reset.Location = new System.Drawing.Point(412, 158);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(75, 23);
            this.b_reset.TabIndex = 17;
            this.b_reset.Text = "Reset";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // b_eliminar
            // 
            this.b_eliminar.Enabled = false;
            this.b_eliminar.Location = new System.Drawing.Point(412, 129);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(75, 23);
            this.b_eliminar.TabIndex = 16;
            this.b_eliminar.Text = "Eliminar";
            this.b_eliminar.UseVisualStyleBackColor = true;
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // b_modificar
            // 
            this.b_modificar.Enabled = false;
            this.b_modificar.Location = new System.Drawing.Point(412, 100);
            this.b_modificar.Name = "b_modificar";
            this.b_modificar.Size = new System.Drawing.Size(75, 23);
            this.b_modificar.TabIndex = 15;
            this.b_modificar.Text = "Modificar";
            this.b_modificar.UseVisualStyleBackColor = true;
            this.b_modificar.Click += new System.EventHandler(this.b_modificar_Click);
            // 
            // b_agregar
            // 
            this.b_agregar.Location = new System.Drawing.Point(412, 71);
            this.b_agregar.Name = "b_agregar";
            this.b_agregar.Size = new System.Drawing.Size(75, 23);
            this.b_agregar.TabIndex = 14;
            this.b_agregar.Text = "Agregar";
            this.b_agregar.UseVisualStyleBackColor = true;
            this.b_agregar.Click += new System.EventHandler(this.b_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Administrador de Alumnos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Apellido Materno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "RUT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Curso:";
            // 
            // tb_idA
            // 
            this.tb_idA.Location = new System.Drawing.Point(167, 71);
            this.tb_idA.Name = "tb_idA";
            this.tb_idA.Size = new System.Drawing.Size(223, 20);
            this.tb_idA.TabIndex = 26;
            // 
            // tb_nombreA
            // 
            this.tb_nombreA.Location = new System.Drawing.Point(167, 97);
            this.tb_nombreA.Name = "tb_nombreA";
            this.tb_nombreA.Size = new System.Drawing.Size(223, 20);
            this.tb_nombreA.TabIndex = 27;
            // 
            // tb_appatA
            // 
            this.tb_appatA.Location = new System.Drawing.Point(166, 122);
            this.tb_appatA.Name = "tb_appatA";
            this.tb_appatA.Size = new System.Drawing.Size(223, 20);
            this.tb_appatA.TabIndex = 28;
            // 
            // tb_apmatA
            // 
            this.tb_apmatA.Location = new System.Drawing.Point(166, 154);
            this.tb_apmatA.Name = "tb_apmatA";
            this.tb_apmatA.Size = new System.Drawing.Size(223, 20);
            this.tb_apmatA.TabIndex = 29;
            // 
            // tb_rutA
            // 
            this.tb_rutA.Location = new System.Drawing.Point(167, 185);
            this.tb_rutA.Name = "tb_rutA";
            this.tb_rutA.Size = new System.Drawing.Size(223, 20);
            this.tb_rutA.TabIndex = 30;
            // 
            // cb_curso
            // 
            this.cb_curso.FormattingEnabled = true;
            this.cb_curso.Location = new System.Drawing.Point(166, 214);
            this.cb_curso.Name = "cb_curso";
            this.cb_curso.Size = new System.Drawing.Size(223, 21);
            this.cb_curso.TabIndex = 31;
            // 
            // rAlumno
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.cb_curso);
            this.Controls.Add(this.tb_rutA);
            this.Controls.Add(this.tb_apmatA);
            this.Controls.Add(this.tb_appatA);
            this.Controls.Add(this.tb_nombreA);
            this.Controls.Add(this.tb_idA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_mostrarC);
            this.Controls.Add(this.b_mostrar);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.b_eliminar);
            this.Controls.Add(this.b_modificar);
            this.Controls.Add(this.b_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(517, 489);
            this.MinimumSize = new System.Drawing.Size(517, 489);
            this.Name = "rAlumno";
            this.Text = "Administrador de Alumnos";
            this.Load += new System.EventHandler(this.rAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_mostrarC;
        private System.Windows.Forms.Button b_mostrar;
        private System.Windows.Forms.Button b_salir;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.Button b_modificar;
        private System.Windows.Forms.Button b_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_idA;
        private System.Windows.Forms.TextBox tb_nombreA;
        private System.Windows.Forms.TextBox tb_appatA;
        private System.Windows.Forms.TextBox tb_apmatA;
        private System.Windows.Forms.TextBox tb_rutA;
        private System.Windows.Forms.ComboBox cb_curso;
    }
}