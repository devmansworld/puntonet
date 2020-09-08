namespace calculadora
{
    partial class F_calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_resultado = new System.Windows.Forms.Label();
            this.tb_n1 = new System.Windows.Forms.TextBox();
            this.tb_n2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_suma = new System.Windows.Forms.RadioButton();
            this.rb_resta = new System.Windows.Forms.RadioButton();
            this.rb_multiplicacion = new System.Windows.Forms.RadioButton();
            this.rb_division = new System.Windows.Forms.RadioButton();
            this.b_calcular = new System.Windows.Forms.Button();
            this.b_limpiar = new System.Windows.Forms.Button();
            this.b_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Básica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Operación:";
            // 
            // l_resultado
            // 
            this.l_resultado.AutoSize = true;
            this.l_resultado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_resultado.Location = new System.Drawing.Point(42, 344);
            this.l_resultado.Name = "l_resultado";
            this.l_resultado.Size = new System.Drawing.Size(84, 19);
            this.l_resultado.TabIndex = 4;
            this.l_resultado.Text = "Resultado:";
            // 
            // tb_n1
            // 
            this.tb_n1.Location = new System.Drawing.Point(164, 82);
            this.tb_n1.Name = "tb_n1";
            this.tb_n1.Size = new System.Drawing.Size(100, 20);
            this.tb_n1.TabIndex = 5;
            // 
            // tb_n2
            // 
            this.tb_n2.Location = new System.Drawing.Point(164, 135);
            this.tb_n2.Name = "tb_n2";
            this.tb_n2.Size = new System.Drawing.Size(100, 20);
            this.tb_n2.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_division);
            this.groupBox1.Controls.Add(this.rb_multiplicacion);
            this.groupBox1.Controls.Add(this.rb_resta);
            this.groupBox1.Controls.Add(this.rb_suma);
            this.groupBox1.Location = new System.Drawing.Point(50, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rb_suma
            // 
            this.rb_suma.AutoSize = true;
            this.rb_suma.Location = new System.Drawing.Point(10, 32);
            this.rb_suma.Name = "rb_suma";
            this.rb_suma.Size = new System.Drawing.Size(52, 17);
            this.rb_suma.TabIndex = 0;
            this.rb_suma.TabStop = true;
            this.rb_suma.Text = "Suma";
            this.rb_suma.UseVisualStyleBackColor = true;
            // 
            // rb_resta
            // 
            this.rb_resta.AutoSize = true;
            this.rb_resta.Location = new System.Drawing.Point(78, 32);
            this.rb_resta.Name = "rb_resta";
            this.rb_resta.Size = new System.Drawing.Size(53, 17);
            this.rb_resta.TabIndex = 1;
            this.rb_resta.TabStop = true;
            this.rb_resta.Text = "Resta";
            this.rb_resta.UseVisualStyleBackColor = true;
            // 
            // rb_multiplicacion
            // 
            this.rb_multiplicacion.AutoSize = true;
            this.rb_multiplicacion.Location = new System.Drawing.Point(137, 32);
            this.rb_multiplicacion.Name = "rb_multiplicacion";
            this.rb_multiplicacion.Size = new System.Drawing.Size(89, 17);
            this.rb_multiplicacion.TabIndex = 2;
            this.rb_multiplicacion.TabStop = true;
            this.rb_multiplicacion.Text = "Multiplicación";
            this.rb_multiplicacion.UseVisualStyleBackColor = true;
            // 
            // rb_division
            // 
            this.rb_division.AutoSize = true;
            this.rb_division.Location = new System.Drawing.Point(232, 32);
            this.rb_division.Name = "rb_division";
            this.rb_division.Size = new System.Drawing.Size(62, 17);
            this.rb_division.TabIndex = 3;
            this.rb_division.TabStop = true;
            this.rb_division.Text = "División";
            this.rb_division.UseVisualStyleBackColor = true;
            // 
            // b_calcular
            // 
            this.b_calcular.Location = new System.Drawing.Point(51, 300);
            this.b_calcular.Name = "b_calcular";
            this.b_calcular.Size = new System.Drawing.Size(75, 23);
            this.b_calcular.TabIndex = 8;
            this.b_calcular.Text = "Calcular";
            this.b_calcular.UseVisualStyleBackColor = true;
            this.b_calcular.Click += new System.EventHandler(this.b_calcular_Click);
            // 
            // b_limpiar
            // 
            this.b_limpiar.Location = new System.Drawing.Point(155, 300);
            this.b_limpiar.Name = "b_limpiar";
            this.b_limpiar.Size = new System.Drawing.Size(75, 23);
            this.b_limpiar.TabIndex = 9;
            this.b_limpiar.Text = "Limpiar";
            this.b_limpiar.UseVisualStyleBackColor = true;
            this.b_limpiar.Click += new System.EventHandler(this.b_limpiar_Click);
            // 
            // b_salir
            // 
            this.b_salir.Location = new System.Drawing.Point(269, 300);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(75, 23);
            this.b_salir.TabIndex = 10;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // F_calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(395, 449);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_limpiar);
            this.Controls.Add(this.b_calcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_n2);
            this.Controls.Add(this.tb_n1);
            this.Controls.Add(this.l_resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "F_calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_resultado;
        private System.Windows.Forms.TextBox tb_n1;
        private System.Windows.Forms.TextBox tb_n2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_division;
        private System.Windows.Forms.RadioButton rb_multiplicacion;
        private System.Windows.Forms.RadioButton rb_resta;
        private System.Windows.Forms.RadioButton rb_suma;
        private System.Windows.Forms.Button b_calcular;
        private System.Windows.Forms.Button b_limpiar;
        private System.Windows.Forms.Button b_salir;
    }
}

