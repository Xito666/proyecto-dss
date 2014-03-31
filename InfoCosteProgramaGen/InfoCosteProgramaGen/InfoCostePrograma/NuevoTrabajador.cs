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
    public partial class NuevoTrabajador : Form
    {
        public NuevoTrabajador()
        {
            InitializeComponent();
        }

        public NuevoTrabajador(InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN trabajador)
        {
            InitializeComponent();
            textBox_ID.Text = trabajador.Id.ToString();
            textBox_Password.Text = trabajador.Password;
            textBox_Nombre.Text = trabajador.Nombre;
        }

        private void button_CrearUsuario_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mbb = new MessageBoxButtons();
            MessageBox.Show(this, "Se creará/modificará el usuario", "Continuar?", mbb);
        }
    }
}
