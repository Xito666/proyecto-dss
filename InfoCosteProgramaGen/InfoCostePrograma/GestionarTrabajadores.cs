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

            dataGridView_GestionarTrabajadores.Rows.Clear();
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
            MessageBox.Show("Se va a eliminar el trabajador", "Trabajadores", MessageBoxButtons.OK);
            DataGridViewRow current = dataGridView_GestionarTrabajadores.CurrentRow;

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN tcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
            tcen.Borrar(Convert.ToInt32(current.Cells[0].Value));

            GestionarTrabajadores_Load(null, null);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow current = dataGridView_GestionarTrabajadores.CurrentRow;

            NuevoTrabajador nt = new NuevoTrabajador(Convert.ToInt32(current.Cells[0].Value));
            nt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nombre del trabajador?");
            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN tcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
            IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN> lt = tcen.LeerPorNombre(input);

            dataGridView_GestionarTrabajadores.Rows.Clear();
            foreach (InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN t in lt)
            {
                dataGridView_GestionarTrabajadores.Rows.Add(t.Id, t.Nombre, t.Password);
            }

        }

    }
}
