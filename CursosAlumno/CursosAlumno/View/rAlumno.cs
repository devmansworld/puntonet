using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursosAlumno.Controller;
using CursosAlumno.Model;

namespace CursosAlumno.View
{
    public partial class rAlumno : Form
    {
        controlador c = new controlador();
        validacion v = new validacion();
        public rAlumno()
        {
            InitializeComponent();
        }

        private void rAlumno_Load(object sender, EventArgs e)
        {
            cb_curso.DropDownStyle = ComboBoxStyle.DropDownList;
            c.cargaCBAlumno(cb_curso);
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            tb_idA.Text = string.Empty;
            tb_nombreA.Text = string.Empty;
            tb_appatA.Text = string.Empty;
            tb_apmatA.Text = string.Empty;
            tb_rutA.Text = string.Empty;
            cb_curso.SelectedValue = 0;
            dgv_mostrarC.Rows.Clear();
            dgv_mostrarC.Columns.Clear();
            b_agregar.Enabled = true;
            b_modificar.Enabled = false;
            b_eliminar.Enabled = false;
            tb_idA.Enabled = true;
            tb_idA.Focus();
        }

        private void b_mostrar_Click(object sender, EventArgs e)
        {
            c.cargaGrillaA(dgv_mostrarC);
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            string idATexto = tb_idA.Text;
            string nombre = tb_nombreA.Text;
            string appat = tb_appatA.Text;
            string apmat = tb_apmatA.Text;
            string rut = tb_rutA.Text;
            string idCTexto = cb_curso.SelectedValue.ToString();
            if (v.vCampo(idATexto) == false || v.vINT(idATexto) == false)
            {
                MessageBox.Show("Verifique la ID, esta no corresponde");
                tb_idA.Focus();
            }
            else if (v.vCampo(nombre) == false)
            {
                MessageBox.Show("Ingrese un nombre de usuario");
                tb_nombreA.Focus();
            }
            else if (v.vCampo(appat) == false)
            {
                MessageBox.Show("No se ha ingresado un apedillo paterno");
                tb_appatA.Focus();
            }
            else if (v.vCampo(rut) == false)
            {
                MessageBox.Show("No se ha ingresado un rut");
                tb_rutA.Focus();
            }
            else if (idCTexto == "0")
            {
                MessageBox.Show("Debe seleccionar un curso");
            }
            else
            {
                int idA = Convert.ToInt32(idATexto);
                int idC = Convert.ToInt32(idCTexto);
                bool adAl = c.addAlumno(idA, nombre, appat, apmat, rut, idA);
                if (adAl == false)
                {
                    MessageBox.Show("Ha ocurrido un error, intente nuevamente");
                }
                else
                {
                    b_reset.PerformClick();
                    b_mostrar.PerformClick();
                }

            }
        }

        private void dgv_mostrarC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 gril = dgv_mostrarC.GetCellCount(DataGridViewElementStates.Selected);
            if (gril > 0)
            {
                if (dgv_mostrarC.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Se han seleccionado todos los elementos");
                }
                else
                {
                    tb_idA.Text = dgv_mostrarC.CurrentRow.Cells[0].Value.ToString();
                    tb_nombreA.Text = dgv_mostrarC.CurrentRow.Cells[1].Value.ToString();
                    tb_appatA.Text = dgv_mostrarC.CurrentRow.Cells[2].Value.ToString();
                    tb_apmatA.Text = dgv_mostrarC.CurrentRow.Cells[3].Value.ToString();
                    tb_rutA.Text = dgv_mostrarC.CurrentRow.Cells[4].Value.ToString();
                    string backCurso = dgv_mostrarC.CurrentRow.Cells[5].Value.ToString();
                    int idCB = c.ridCurso(backCurso);
                    cb_curso.SelectedValue = idCB;
                    b_agregar.Enabled = false;
                    b_modificar.Enabled = true;
                    b_eliminar.Enabled = true;
                    tb_idA.Enabled = false;
                }
            }
        }

        private void b_modificar_Click(object sender, EventArgs e)
        {
            string idATexto = tb_idA.Text;
            string nombre = tb_nombreA.Text;
            string appat = tb_appatA.Text;
            string apmat = tb_apmatA.Text;
            string rut = tb_rutA.Text;
            string idCTexto = cb_curso.SelectedValue.ToString();
            if (v.vCampo(idATexto) == false || v.vINT(idATexto) == false)
            {
                MessageBox.Show("Verifique la ID, esta no corresponde");
                tb_idA.Focus();
            }
            else if (v.vCampo(nombre) == false)
            {
                MessageBox.Show("Ingrese un nombre de usuario");
                tb_nombreA.Focus();
            }
            else if (v.vCampo(appat) == false)
            {
                MessageBox.Show("No se ha ingresado un apedillo paterno");
                tb_appatA.Focus();
            }
            else if (v.vCampo(rut) == false)
            {
                MessageBox.Show("No se ha ingresado un rut");
                tb_rutA.Focus();
            }
            else if (idCTexto == "0")
            {
                MessageBox.Show("Debe seleccionar un curso");
            }
            else
            {
                int idA = Convert.ToInt32(idATexto);
                int idC = Convert.ToInt32(idCTexto);
                bool updateal = c.updateAlumno(idA, nombre, appat, apmat, rut, idC);
                if (updateal == false)
                {
                    MessageBox.Show("Ha ocurrido un error, intente nuevamente");
                }
                else
                {
                    b_reset.PerformClick();
                    b_mostrar.PerformClick();
                }
            }
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            string idATexto = tb_idA.Text;
            if (v.vCampo(idATexto) == false || v.vINT(idATexto) == false)
            {
                MessageBox.Show("El ID registrado no corresponde. \n Intente nuevamente");
            }
            else
            {
                int id = Convert.ToInt32(idATexto);
                if (MessageBox.Show("¿Desea eliminar este registro?", "Adventencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == System.Windows.Forms.DialogResult.Yes)
                {
                    bool deleteAlumno = c.deleteAlumno(id);
                    if (deleteAlumno == false)
                    {
                        MessageBox.Show("Error al eliminar al usuario, valide y reintente");
                    }
                    else
                    {
                        string sal = "el registro de "+tb_nombreA.Text+" "+tb_appatA.Text+" "+ tb_apmatA.Text +", has sido eliminado";
                        MessageBox.Show(sal);
                        b_reset.PerformClick();
                        b_mostrar.PerformClick();
                    }
                }
            }
        }
    }
}
