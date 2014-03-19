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
            if (e.ColumnIndex == 3)
            {

            }
            else if (e.ColumnIndex == 4)
            {
                InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN t = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN();
                t.Id =Convert.ToInt32( dataGridView_GestionarTrabajadores.Rows[e.RowIndex].Cells[0].Value.ToString());
                t.Password = dataGridView_GestionarTrabajadores.Rows[e.RowIndex].Cells[1].Value.ToString();
                t.Nombre = dataGridView_GestionarTrabajadores.Rows[e.RowIndex].Cells[2].Value.ToString();

                NuevoTrabajador nt = new NuevoTrabajador(t);
                nt.Show();
            }
        }

        private void GestionarTrabajadores_Load(object sender, EventArgs e)
        {
            dataGridView_GestionarTrabajadores.Rows.Add(53244622,"pass1","Ragnar Lodbrok","Eliminar","Editar");
        }
    }
}
