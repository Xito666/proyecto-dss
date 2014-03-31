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

        private void AddFormInPanel(Object formHijo)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new GestionarTrabajadores());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new GestionarClientes());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new GestionarProveedores());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new GestionarProductos());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new GestionarVentas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new GestionarCompras());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Herramientas());
        }
    }
}
