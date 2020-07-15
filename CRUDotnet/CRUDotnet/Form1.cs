using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prodBLL;

namespace CRUDotnet
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();

        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            MuestraProductos();
        }

        public void MuestraProductos()
        {
            dataGridView1.DataSource = objetoCN.MostrarProd();
        }
    }
}
