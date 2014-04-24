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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Carga del form
        private void Login_Load(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
            label3.Visible = false;
        }

        // Boton para comprobar credenciales
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label3.Text = "El usuario no puede estar vacío";
                label3.Visible = true;
            }
            else if (textBox2.Text == "")
            {
                label3.Text = "La contraseña no puede estar vacía";
                label3.Visible = true;
            }
            else
            {
                // Comprobar autenticacion
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    Principal p = new Principal();
                    this.Hide();
                    p.ShowDialog();
                    this.Close();
                }
                else
                {
                    label3.Text = "No se ha podido autenticar";
                    label3.Visible = true;
                }
            }
        }

        // Boton para cerrar el form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para poder mover el form
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
    }
}
