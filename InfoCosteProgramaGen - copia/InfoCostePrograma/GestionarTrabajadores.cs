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
            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN tcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
            IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN> listaTrabajadores =  tcen.LeerTodos(0,100);

            foreach(InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN t in listaTrabajadores)
            {
                dataGridView_GestionarTrabajadores.Rows.Add(t.Id, t.Nombre, t.Password);
            }

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
            DataGridViewRow current = dataGridView_GestionarTrabajadores.CurrentRow;

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN tcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
            InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN ten = tcen.LeerPorOID(Convert.ToInt32(current.Cells[0]));
            tcen.

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow current = dataGridView_GestionarTrabajadores.CurrentRow;

            NuevoTrabajador nt = new NuevoTrabajador(Convert.ToInt32(current.Cells[0].Value));
            nt.Show();
        }

    }
}
