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
    public partial class Credenciales : Form
    {
        int usuario;
        InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN tcen;
        InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN trabajador;

        public Credenciales(int user)
        {
            InitializeComponent();

            textBox_Pass.PasswordChar = '·';
            textBox_PassNueva.PasswordChar = '·';
            textBox_Repeat.PasswordChar = '·';

            usuario = user;
        }

        private void CredencialesAdministrador_Load(object sender, EventArgs e)
        {
            tcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
            trabajador = tcen.LeerPorOID(usuario);

            textBox_Nombre.Text = trabajador.Nombre;
            textBox_Nombre.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorPass.SetError(textBox_Pass, String.Empty);
            errorPass.SetError(textBox_Repeat, String.Empty);

            if(trabajador.Password == textBox_Pass.Text)
            {
                if (textBox_PassNueva.Text == textBox_Repeat.Text)
                {
                    tcen.SetPassword(trabajador.Id, textBox_PassNueva.Text);
                    this.Close();
                }
                else
                    errorPass.SetError(textBox_Repeat, "Las contraseñas no coinciden");
            }
            else
            {
                errorPass.SetError(textBox_Pass, "La contraseña no es correcta");
            }
        }
    }
}
