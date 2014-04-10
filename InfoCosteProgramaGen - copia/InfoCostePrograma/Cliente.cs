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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        public void rellenar(DataGridViewRow row)
        {
            textBox_Nombre.Text = row.Cells["Nombre"].Value.ToString();
            textBox_Direccion.Text = row.Cells["Direccion"].Value.ToString();
            textBox_Telefono.Text = row.Cells["Telefono"].Value.ToString();
            textBox_Email.Text = row.Cells["Email"].Value.ToString();
            //textBox_NumCuenta
            if (row.Cells["Empresa"].Value.ToString() == "True")
                checkBox_Empresa.Checked = true;
        }
    }
}
