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

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoTrabajador nt = new NuevoTrabajador();
            nt.Show();
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarTrabajadores gt = new GestionarTrabajadores();
            gt.Show();
        }


    }
}
