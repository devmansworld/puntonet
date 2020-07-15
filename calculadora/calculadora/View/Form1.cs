using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculadora.Controller;
using calculadora.Model;

namespace calculadora
{
    public partial class F_calculadora : Form
    {
        public F_calculadora()
        {
            InitializeComponent();
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_limpiar_Click(object sender, EventArgs e)
        {
            tb_n1.Text = "";
            tb_n2.Text = "";
            rb_suma.Checked = false;
            rb_resta.Checked = false;
            rb_multiplicacion.Checked = false;
            rb_division.Checked = false;
            l_resultado.Text = "Resultado:";
        }

        private void b_calcular_Click(object sender, EventArgs e)
        {
            //recibo datos
            string num1 = tb_n1.Text;
            string num2 = tb_n2.Text;
            bool su = rb_suma.Checked;
            bool re = rb_resta.Checked;
            bool mu = rb_multiplicacion.Checked;
            bool di = rb_division.Checked;
            validacion v = new validacion();
            if (v.cVacia(num1)==false || v.cVacia(num2)==false)
            {
                MessageBox.Show("Falta ingresar, al menos, un número");
            }
            else
            {
                if (v.vNumero(num1) == false || v.vNumero(num2) == false)
                {
                    MessageBox.Show("Un valor ingresado no es un número");
                }
                else
                {
                    bool re1 = re;
                    if (su == false && re1 == false && mu == false && di == false)
                    {
                        MessageBox.Show("No se ha seleccionado la operación");
                    }
                    else
                    {
                        //aplican metodos
                        controlador c = new controlador();
                        numeros n = new numeros();
                        n.N1 = Convert.ToDecimal(num1);
                        n.N2 = Convert.ToDecimal(num2);
                        decimal r;
                        int oper;
                        if (su == true)
                        {
                            r = c.suma(n.N1, n.N2);
                            oper = 1;
                        }
                        else if (re == true)
                        {
                            r = c.resta(n.N1, n.N2);
                            oper = 2;
                        }
                        else if (mu == true)
                        {
                            r = c.multiplicacion(n.N1, n.N2);
                            oper = 3;
                        }
                        else if (di == true)
                        {
                            if (di == true && n.N2 == 0)
                            {
                                r = 0;
                                oper = 5;
                            }
                            else
                            {
                                r = c.division(n.N1, n.N2);
                                oper = 4;
                            }
                            
                        }
                        else
                        {
                            r = 0;
                            oper = 5;
                        }
                        if (di == true && n.N2 == 0)
                        {
                            l_resultado.Text = "Error matemático";
                        }
                        else
                        {
                            l_resultado.Text = "Resultado: \n" + c.formato(oper,r, n.N1, n.N2);
                        }
                    }
                }
            }
        }
    }
}
