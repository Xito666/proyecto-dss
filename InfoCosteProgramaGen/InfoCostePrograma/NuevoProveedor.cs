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
    public partial class NuevoProveedor : Form
    {
        string id;
        bool editando = false;

        //constructor sin parametros
        public NuevoProveedor()
        {
            InitializeComponent();
        }

        //constructor con 1 parametro
        public NuevoProveedor(string ID)
        {
            InitializeComponent();
            editando = true;

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN pcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();
            InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN proveedor = pcen.LeerPorOID(ID.ToString());
            id = ID;
            textBox_ID.Text = proveedor.Id;
            textBox_Nombre.Text = proveedor.Nombre;
            textBox_Direccion.Text = proveedor.Direccion;
            textBox_Email.Text = proveedor.Email;

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN proCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();
            InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN proEN = proCEN.LeerPorOID(ID.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_CrearUsuario_Click_1(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "" || textBox_Nombre.Text == "" || textBox_Direccion.Text == "" || textBox_Email.Text == "")
            {
                MessageBox.Show(this, "Todos los campos son obligatorios");
            }
            else
            {
                MessageBoxButtons mbb = new MessageBoxButtons();
                MessageBox.Show(this, "Se creará/modificará el proveedor", "Continuar?", mbb);

                try
                {
                    if (!editando)
                    {
                        InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN provCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();
                        provCEN.Proveedor(textBox_ID.Text, textBox_Nombre.Text, textBox_Direccion.Text, textBox_Email.Text);
                    }
                    else
                    {
                        InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN pCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();
                        pCEN.SetNombre(id, textBox_Nombre.Text);
                        pCEN.SetDireccion(id, textBox_Direccion.Text);
                        pCEN.SetEmail(id, textBox_Email.Text);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Revise los campos");
                }
            }
        }
    }
}