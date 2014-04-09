using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CAD.InfoCoste;

namespace InfoCostePrograma
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            checkBox_Empresa.Checked = false;
            textBox_NumCuenta.Enabled = false;
        }

        // Guardar cliente nuevo
        private void button_CrearUsuario_Click(object sender, EventArgs e)
        {
            // EMPRESA
            if(checkBox_Empresa.Checked == true)
            {
                if (es_cadena(textBox_Nombre) == true && es_cadena(textBox_Direccion) == true &&
                es_telefono(textBox_Telefono) == true && es_email(textBox_Email) == true && es_numero(textBox_NumCuenta) == true)
                {
                    IList<ClienteEmpresaEN> clientes;
                    ClienteEmpresaCAD clienteCAD = new ClienteEmpresaCAD();
                    clientes = clienteCAD.LeerTodos(0, 100);

                    int cantidad = clientes.Count();

                    ClienteEmpresaEN cliente = new ClienteEmpresaEN();
                    cliente.Id = (cantidad + 1).ToString();
                    cliente.NombreCompleto = textBox_Nombre.Text;
                    cliente.Telefono = Convert.ToInt32(textBox_Telefono.Text);
                    cliente.Direccion = textBox_Direccion.Text;
                    cliente.Email = textBox_Email.Text;
                    cliente.NumeroCuenta = Convert.ToInt32(textBox_NumCuenta.Text);

                    clienteCAD.ClienteEmpresa(cliente);
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }
            // PARTICULAR
            else
            {
                if (es_cadena(textBox_Nombre) == true && es_cadena(textBox_Direccion) == true &&
                es_telefono(textBox_Telefono) == true && es_email(textBox_Email) == true)
                {
                    IList<ClienteParticularEN> clientes;
                    ClienteParticularCAD clienteCAD = new ClienteParticularCAD();
                    clientes = clienteCAD.LeerTodos(0, 100);

                    int cantidad = clientes.Count();

                    ClienteParticularEN cliente = new ClienteParticularEN();
                    cliente.Id = (cantidad + 1).ToString();
                    cliente.NombreCompleto = textBox_Nombre.Text;
                    cliente.Telefono = Convert.ToInt32(textBox_Telefono.Text);
                    cliente.Direccion = textBox_Direccion.Text;
                    cliente.Email = textBox_Email.Text;

                    clienteCAD.ClienteParticular(cliente);
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }
        }

        // Cerrar aplicacion
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Activar y desactivar casillas de Empresa
        private void checkBox_Empresa_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_NumCuenta.Enabled == true)
                textBox_NumCuenta.Enabled = false;
            else
                textBox_NumCuenta.Enabled = true;
        }

        // VALIDACIONES ACTIVAS
        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (es_cadena(textBox_Nombre))
            {
                errorProvider1.SetError(textBox_Nombre, String.Empty);
                textBox_Nombre.BackColor = Color.White;
            }
            else
            {
                errorProvider1.SetError(textBox_Nombre, "Solo letras");
                textBox_Nombre.BackColor = Color.MistyRose;
            }
        }

        private void textBox_Direccion_TextChanged(object sender, EventArgs e)
        {
            // Admite todo
        }

        private void textBox_Telefono_TextChanged(object sender, EventArgs e)
        {
            if (es_telefono(textBox_Telefono))
            {
                errorProvider1.SetError(textBox_Telefono, String.Empty);
                textBox_Telefono.BackColor = Color.White;
            }
            else
            {
                errorProvider1.SetError(textBox_Telefono, "Formato: 999999999");
                textBox_Telefono.BackColor = Color.MistyRose;
            }
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            if (es_email(textBox_Email))
            {
                errorProvider1.SetError(textBox_Email, String.Empty);
                textBox_Email.BackColor = Color.White;
            }
            else
            {
                errorProvider1.SetError(textBox_Email, "ejemplo@ejemplo.com");
                textBox_Email.BackColor = Color.MistyRose;
            }
        }

        private void textBox_NumCuenta_TextChanged(object sender, EventArgs e)
        {
            if (es_numero(textBox_NumCuenta))
            {
                errorProvider1.SetError(textBox_NumCuenta, String.Empty);
                textBox_NumCuenta.BackColor = Color.White;
            }
            else
            {
                errorProvider1.SetError(textBox_NumCuenta, "20 números");
                textBox_NumCuenta.BackColor = Color.MistyRose;
            }
        }


        // VALIDACIONES
        private static bool es_numero(Control mitextbox)
        {
            Regex regex = new Regex(@"^[0-9]{20}$");
            return regex.IsMatch(mitextbox.Text);
        }

        private static bool es_cadena(Control mitextbox)
        {
            Regex regex = new Regex(@"^[^ ][a-zA-Z ]+[^ ]$");
            return regex.IsMatch(mitextbox.Text);
        }

        private static bool es_telefono(Control mitextbox)
        {
            Regex regex = new Regex(@"^([0-9]{9})$");
            return regex.IsMatch(mitextbox.Text);
        }

        private static bool es_email(Control mitextbox)
        {
            Regex regex = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");

            return regex.IsMatch(mitextbox.Text);
        }
    }
}
