using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfoCosteProgramaGenNHibernate;

namespace InfoCostePrograma
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            GestionarTrabajadores gt = new GestionarTrabajadores();
            gt.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GestionarClientes gc = new GestionarClientes();
            gc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionarProveedores gp = new GestionarProveedores();
            gp.Show();
        }
    }
}
