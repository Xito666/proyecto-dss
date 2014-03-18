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
    }
}
