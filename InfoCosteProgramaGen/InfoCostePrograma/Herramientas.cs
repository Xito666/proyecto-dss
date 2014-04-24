using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InfoCostePrograma
{
    public partial class Herramientas : Form
    {
        public Herramientas()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CredencialesAdministrador ca = new CredencialesAdministrador();
            ca.Show();

            //CredencialesAdministrador.DefInstance.MdiParent = this;
            //CredencialesAdministrador.DefInstance.Show();
        }
    }
}
