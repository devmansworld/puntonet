namespace CursosAlumno.View
{
    partial class rCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_idC = new System.Windows.Forms.TextBox();
            this.tb_nombreC = new System.Windows.Forms.TextBox();
            this.b_agregar = new System.Windows.Forms.Button();
            this.b_modificar = new System.Windows.Forms.Button();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_salir = new System.Windows.Forms.Button();
            this.b_mostrar = new System.Windows.Forms.Button();
            this.dgv_mostrarC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrarC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso:";
            // 
            // tb_idC
            // 
            this.tb_idC.Location = new System.Drawing.Point(130, 95);
            this.tb_idC.Name = "tb_idC";
            this.tb_idC.Size = new System.Drawing.Size(202, 20);
            this.tb_idC.TabIndex = 3;
            // 
            // tb_nombreC
            // 
            this.tb_nombreC.Location = new System.Drawing.Point(130, 138);
            this.tb_nombreC.Name = "tb_nombreC";
            this.tb_nombreC.Size = new System.Drawing.Size(202, 20);
            this.tb_nombreC.TabIndex = 4;
            // 
            // b_agregar
            // 
            this.b_agregar.Location = new System.Drawing.Point(379, 74);
            this.b_agregar.Name = "b_agregar";
            this.b_agregar.Size = new System.Drawing.Size(75, 23);
            this.b_agregar.TabIndex = 5;
            this.b_agregar.Text = "Agregar";
            this.b_agregar.UseVisualStyleBackColor = true;
            this.b_agregar.Click += new System.EventHandler(this.b_agregar_Click);
            // 
            // b_modificar
            // 
            this.b_modificar.Enabled = false;
            this.b_modificar.Location = new System.Drawing.Point(379, 103);
            this.b_modificar.Name = "b_modificar";
            this.b_modificar.Size = new System.Drawing.Size(75, 23);
            this.b_modificar.TabIndex = 6;
            this.b_modificar.Text = "Modificar";
            this.b_modificar.UseVisualStyleBackColor = true;
            this.b_modificar.Click += new System.EventHandler(this.b_modificar_Click);
            // 
            // b_eliminar
            // 
            this.b_eliminar.Enabled = false;
            this.b_eliminar.Location = new System.Drawing.Point(379, 132);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(75, 23);
            this.b_eliminar.TabIndex = 7;
            this.b_eliminar.Text = "Eliminar";
            this.b_eliminar.UseVisualStyleBackColor = true;
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // b_reset
            // 
            this.b_reset.Location = new System.Drawing.Point(379, 161);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(75, 23);
            this.b_reset.TabIndex = 8;
            this.b_reset.Text = "Reset";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // b_salir
            // 
            this.b_salir.Location = new System.Drawing.Point(379, 190);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(75, 23);
            this.b_salir.TabIndex = 9;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // b_mostrar
            // 
            this.b_mostrar.Location = new System.Drawing.Point(77, 205);
            this.b_mostrar.Name = "b_mostrar";
            this.b_mostrar.Size = new System.Drawing.Size(127, 23);
            this.b_mostrar.TabIndex = 10;
            this.b_mostrar.Text = "Mostrar datos";
            this.b_mostrar.UseVisualStyleBackColor = true;
            this.b_mostrar.Click += new System.EventHandler(this.b_mostrar_Click);
            // 
            // dgv_mostrarC
            // 
            this.dgv_mostrarC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrarC.Location = new System.Drawing.Point(77, 234);
            this.dgv_mostrarC.Name = "dgv_mostrarC";
            this.dgv_mostrarC.Size = new System.Drawing.Size(310, 150);
            this.dgv_mostrarC.TabIndex = 11;
            this.dgv_mostrarC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mostrarC_CellContentClick);
            // 
            // rCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(484, 401);
            this.Controls.Add(this.dgv_mostrarC);
            this.Controls.Add(this.b_mostrar);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.b_eliminar);
            this.Controls.Add(this.b_modificar);
            this.Controls.Add(this.b_agregar);
            this.Controls.Add(this.tb_nombreC);
            this.Controls.Add(this.tb_idC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 440);
            this.MinimumSize = new System.Drawing.Size(500, 440);
            this.Name = "rCurso";
            this.Text = "Administrador de Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_idC;
        private System.Windows.Forms.TextBox tb_nombreC;
        private System.Windows.Forms.Button b_agregar;
        private System.Windows.Forms.Button b_modificar;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Button b_salir;
        private System.Windows.Forms.Button b_mostrar;
        private System.Windows.Forms.DataGridView dgv_mostrarC;
    }
}