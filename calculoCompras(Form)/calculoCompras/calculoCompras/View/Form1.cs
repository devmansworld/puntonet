using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculoCompras.Controller;
using calculoCompras.Model;

namespace calculoCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_producto.Text = "";
            tb_monto.Text = "";
            tb_tProductos.Text = "";
            tb_precio.Text = "";
            cb_cant.Text = "";
            l_info.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tomar variables de form
            string prod = tb_producto.Text;
            string prec = tb_precio.Text;
            string cant = cb_cant.Text;
            string tprd = tb_tProductos.Text;
            string tprc = tb_monto.Text;
            //validaciones
            Validacion v = new Validacion();
            if (v.cVacio(prod) == false || v.cVacio(prec) == false || v.cVacio(cant) == false)
            {
                MessageBox.Show("Uno de los campos no ha sido completado");
                tb_producto.Focus();
            }
            else
            {
                if (v.vInt(prec) == false || v.vInt(cant) == false)
                {
                    MessageBox.Show("No se ha ingresado el monto o la cantidad");
                    tb_monto.Focus();
                }
                else 
                {
                    //carga de datos
                    productos p = new productos();
                    p.Nombre = prod;
                    p.Precio = Convert.ToInt32(prec);
                    int montoTotal = Convert.ToInt32(tprc);
                    int cuentatotal = Convert.ToInt32(tprd);
                    int pdto = Convert.ToInt32(prec);
                    int cantd = Convert.ToInt32(cant);
                    //ejecucion del sistema
                    Controlador c = new Controlador();
                    tb_monto.Text = (montoTotal + c.total(pdto, cantd)).ToString();
                    tb_tProductos.Text = (cuentatotal + cantd).ToString();
                    l_info.Text = "Se ha agregado el producto " + p.Nombre;
                    tb_producto.Text = "";
                    tb_precio.Text = "";
                    cb_cant.Text = "";
                }
            }
        }
    }
}
