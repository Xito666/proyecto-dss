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
                // pasarle el trabajador para rellenar los datos en los recuadros correspondientes
                NuevoTrabajador nt = new NuevoTrabajador();
                nt.Show();
            }
        }

        private void GestionarTrabajadores_Load(object sender, EventArgs e)
        {
            dataGridView_GestionarTrabajadores.Rows.Add(53244622,"pass1","Ragnar Lodbrok","Eliminar","Editar");
        }
    }
}
