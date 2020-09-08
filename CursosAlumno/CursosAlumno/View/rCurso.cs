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

namespace CursosAlumno.View
{
    public partial class rCurso : Form
    {
        controlador c = new controlador();
        validacion v = new validacion();
        public rCurso()
        {
            InitializeComponent();
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            tb_idC.Text = string.Empty;
            tb_nombreC.Text = string.Empty;
            dgv_mostrarC.DataSource = null;
            b_agregar.Enabled = true;
            b_modificar.Enabled = false;
            b_eliminar.Enabled = false;
            tb_idC.Enabled = true;
        }

        private void b_mostrar_Click(object sender, EventArgs e)
        {
            c.cargaGrillaC(dgv_mostrarC);
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            string idTexto = tb_idC.Text;
            string nombre = tb_nombreC.Text;
            if (v.vCampo(idTexto) == false || v.vINT(idTexto) == false)
            {
                MessageBox.Show("El campo de ID ha sido mal ingresado. \n Verifique la información");
                tb_idC.Focus();
            }
            else if (v.vCampo(nombre) == false || v.vINT(nombre) == true)
            {
                MessageBox.Show("El campo de nombre ha sido mal ingresado. \n Verifique la información");
                tb_nombreC.Focus();
            }
            else 
            {
                int id = Convert.ToInt32(idTexto);
                if (c.vidCurso(id)==false || c.vNombreC(nombre)== false)
                {
                    MessageBox.Show("El sistema tiene en uso el ID o el nombre ya está registrado");
                    b_mostrar.PerformClick();
                }
                else
                {
                    bool agr = c.addCurso(id, nombre);
                    if (agr == false)
                    {
                        MessageBox.Show("Ha ocurrido un error, reintente");
                    }
                    else
                    {
                        b_reset.PerformClick();
                        b_mostrar.PerformClick();
                    }
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
                    tb_idC.Text = dgv_mostrarC.CurrentRow.Cells[0].Value.ToString();
                    tb_nombreC.Text = dgv_mostrarC.CurrentRow.Cells[1].Value.ToString();
                    b_agregar.Enabled = false;
                    b_modificar.Enabled = true;
                    b_eliminar.Enabled = true;
                    tb_idC.Enabled = false;
                }
            }
        }

        private void b_modificar_Click(object sender, EventArgs e)
        {
            string idTexto = tb_idC.Text;
            string nombre = tb_nombreC.Text;
            if (v.vCampo(idTexto) == false || v.vINT(idTexto) == false)
            {
                MessageBox.Show("El campo de ID ha sido mal ingresado. \n Verifique la información");
                tb_idC.Focus();
            }
            else if (v.vCampo(nombre) == false || v.vINT(nombre) == true)
            {
                MessageBox.Show("El campo de nombre ha sido mal ingresado. \n Verifique la información");
                tb_nombreC.Focus();
            }
            else if (c.vNombreC(nombre) == false)
            {
                MessageBox.Show("Este curso ya existe.");
                tb_nombreC.Focus();
            }
            else 
            {
                int id = Convert.ToInt32(idTexto);
                bool up = c.updateCurso(id, nombre);
                if (up == false)
                {
                    MessageBox.Show("Ha ocurrido un error, reintente");
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
            string idTexto = tb_idC.Text;
            if (v.vCampo(idTexto) == false || v.vINT(idTexto) == false)
            {
                MessageBox.Show("El ID no es valido");
            }
            else
            {
                int id = Convert.ToInt32(idTexto);
                if (MessageBox.Show("¿Está seguro de eliminar el registro? \n Una vez eliminado no se podrá recuperar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == System.Windows.Forms.DialogResult.Yes)
                {
                    bool elim = c.deleteCurso(id);
                    if (elim == false)
                    {
                        MessageBox.Show("Ha ocurrido un error, verifique e intentelo nuevamente");
                    }
                    else
                    {
                        MessageBox.Show("Regristro Eliminado");
                        b_reset.PerformClick();
                        b_mostrar.PerformClick();
                    }
                }
            }
        }
    }
}
