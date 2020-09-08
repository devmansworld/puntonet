using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursosAlumno.View;
using CursosAlumno.Controller;

namespace CursosAlumno
{
    public partial class Form1 : Form
    {
        controlador c = new controlador();
        public Form1()
        {
            InitializeComponent();
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void b_Curso_Click(object sender, EventArgs e)
        {
            rCurso rc = new rCurso();
            rc.ShowDialog();
        }

        private void b_Alumno_Click(object sender, EventArgs e)
        {
            rAlumno ra = new rAlumno();
            ra.ShowDialog();
        }
    }
}
