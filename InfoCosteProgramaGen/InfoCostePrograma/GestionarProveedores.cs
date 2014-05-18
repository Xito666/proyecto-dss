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
    public partial class GestionarProveedores : Form
    {
        public GestionarProveedores()
        {
            InitializeComponent();
        }

        // CARGAR
        private void GestionarProveedores_Load(object sender, EventArgs e)
        {
            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN pcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();
            IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN> listaClientes = pcen.LeerTodos(0, 100);
            dataGridView_GestionarProveedores.Rows.Clear();

            foreach (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN p in listaClientes)
            {
                InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN proCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();
                
                try
                {
                    InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN proEN = proCEN.LeerPorOID(p.Id);
                }
                catch (Exception ex) {  }

                dataGridView_GestionarProveedores.Rows.Add(p.Id, p.Nombre, p.Direccion, p.Email);
            }
        }

        // NUEVO
        private void button1_Click(object sender, EventArgs e)
        {
            NuevoProveedor nc = new NuevoProveedor();
            if (nc.ShowDialog() == DialogResult.OK)
                GestionarProveedores_Load(null, null);
        }

        // EDITAR
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow current = dataGridView_GestionarProveedores.CurrentRow;
            NuevoProveedor p = new NuevoProveedor(current.Cells[0].Value.ToString());

            if (p.ShowDialog() == DialogResult.OK)
                GestionarProveedores_Load(null, null);
        }

        // BORRAR
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea eliminar este proveedor?", "Proveedores", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataGridViewRow current = dataGridView_GestionarProveedores.CurrentRow;
                InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN pcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();

                pcen.Borrar(current.Cells[0].Value.ToString());
                GestionarProveedores_Load(null, null);
            }
        }

        // BUSCAR
        private void button4_Click_2(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nombre del proveedor?");
            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN pcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();
            IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN> lp = pcen.LeerPorNombre(input);

            dataGridView_GestionarProveedores.Rows.Clear();
            foreach (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN i in lp)
            {
                InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN provCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();
                
                try
                {
                    InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN pEN = provCEN.LeerPorOID(i.Id);
                }
                catch (Exception ex) { }

                dataGridView_GestionarProveedores.Rows.Add(i.Id, i.Nombre, i.Direccion, i.Email);
            }
        }
    }
}
