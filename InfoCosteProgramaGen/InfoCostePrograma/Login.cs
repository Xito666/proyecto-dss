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

            label_Errores.ForeColor = Color.Red;
            label_Errores.Visible = false;

            textBox_Pass.PasswordChar = '·';
        }

        // LOGIN
        private void boton_Login_Click(object sender, EventArgs e)
        {
            bool registrado = false, acceder = false;
            int usuario;
            int i;

            i = usuario = 0;

            if (textBox_Nombre.Text == "")
            {
                label_Errores.Text = "El usuario no puede estar vacío";
                label_Errores.Visible = true;
            }
            else if (textBox_Pass.Text == "")
            {
                label_Errores.Text = "La contraseña no puede estar vacía";
                label_Errores.Visible = true;
            }
            else
            {
                InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN tcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
                IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN> listaTrabajadores = tcen.LeerTodos(0, 10);
                
                while(!registrado && i < listaTrabajadores.Count())
                {
                    InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN trabajador = listaTrabajadores[i];

                    if (trabajador.Nombre.Equals(textBox_Nombre.Text))
                        registrado = true;

                    if(registrado)
                    {
                        if (trabajador.Password.Equals(textBox_Pass.Text))
                        {
                            usuario = trabajador.Id;
                            acceder = true;
                        }
                    }

                    i++;
                }
                    
                
                // Comprobar autenticacion
                if (acceder)
                {
                    DialogResult dr = new DialogResult();
                    Principal p = new Principal(usuario);
                    this.Hide();
                    dr = p.ShowDialog();
                    
                    if (dr == DialogResult.OK)
                        this.Close();
                    else if (dr == DialogResult.Cancel)
                    {
                        this.Visible = true;

                        // Restaurar campos
                        textBox_Pass.Text = "";
                        label_Errores.Visible = false;
                    }
                }
                else
                {
                    if (registrado)
                    {
                        label_Errores.Text = "La contraseña no es correcta";
                        label_Errores.Visible = true;
                    }
                    else
                    {
                        label_Errores.Text = "El usuario no esta registrado";
                        label_Errores.Visible = true;
                    }
                }
            }
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

        // Boton para cerrar el form
        private void boton_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
