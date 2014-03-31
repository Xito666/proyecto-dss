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
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        public NuevoCliente(InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEmpresaEN cliente)
        {
            InitializeComponent();
            textBox_Nombre.Text = cliente.NombreCompleto;
            textBox_Telefono.Text = cliente.Telefono.ToString();
            textBox_Direccion.Text = cliente.Direccion;
            textBox_Telefono.Text = cliente.Telefono.ToString();
            textBox_Email.Text = cliente.Email;
            checkBox_Empresa.Checked = true;
            textBox_NumCuenta.Text = cliente.NumeroCuenta.ToString();
        }

        public NuevoCliente(InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteParticularEN cliente)
        {
            InitializeComponent();
            textBox_Nombre.Text = cliente.NombreCompleto;
            textBox_Telefono.Text = cliente.Telefono.ToString();
            textBox_Direccion.Text = cliente.Direccion;
            textBox_Telefono.Text = cliente.Telefono.ToString();
            textBox_Email.Text = cliente.Email;
            checkBox_Empresa.Checked = false;
            textBox_NumCuenta.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_CrearUsuario_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mbb = new MessageBoxButtons();
            MessageBox.Show(this, "Se creará/modificará el cliente","Continuar?",mbb);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
