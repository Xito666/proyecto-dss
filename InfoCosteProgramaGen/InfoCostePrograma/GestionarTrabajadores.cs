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
    public partial class GestionarTrabajadores : Form
    {
        public GestionarTrabajadores()
        {
            InitializeComponent();
        }

        private void dataGridView_GestionarTrabajadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionarTrabajadores_Load(object sender, EventArgs e)
        {
            /*
            dataGridView_GestionarTrabajadores.Rows.Add(1, "Fran", "passfran");
            dataGridView_GestionarTrabajadores.Rows.Add(2, "Jaro", "passjaro");
            dataGridView_GestionarTrabajadores.Rows.Add(3, "Leo", "passleo");
            dataGridView_GestionarTrabajadores.Rows.Add(3, "Dani", "passdani");
            dataGridView_GestionarTrabajadores.Rows.Add(3, "Joaquin", "passjoaquin");
            */

            this.trabajadorTableAdapter.Fill(this.infoCosteProgramaGenNHibernateDataSet.Trabajador);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NuevoTrabajador nt = new NuevoTrabajador();
            nt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro desea eliminar este trabajador?", "Trabajadores", MessageBoxButtons.OKCancel);
        }

    }
}
