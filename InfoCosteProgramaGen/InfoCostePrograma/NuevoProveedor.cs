using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            textBox_ID.Enabled = false;
            textBox_Nombre.Text = proveedor.Nombre;
            textBox_Direccion.Text = proveedor.Direccion;
            textBox_Email.Text = proveedor.Email;

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN proCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();
            InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN proEN = proCEN.LeerPorOID(ID.ToString());
        }

        // VALIDAR
        private void button_CrearUsuario_Click_1(object sender, EventArgs e)
        {
            if (es_dni(textBox_ID) == true && textBox_Nombre.Text != "" && es_email(textBox_Email) == true && textBox_Direccion.Text != "")
            {
                try
                {
                    if (!editando)
                    {
                        InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN provCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();
                        provCEN.Proveedor(textBox_ID.Text, textBox_Nombre.Text, textBox_Direccion.Text, textBox_Email.Text);

                        MessageBox.Show(this, "Proveedor creado");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN pCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ProveedorCEN();
                        pCEN.SetNombre(id, textBox_Nombre.Text);
                        pCEN.SetDireccion(id, textBox_Direccion.Text);
                        pCEN.SetEmail(id, textBox_Email.Text);

                        MessageBox.Show(this, "Proveedor modificado");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Revise los campos");
                }
            }
        }

        /********** COMPROBACIONES *************/

        private bool es_dni(Control mitextbox)
        {
            Regex regex = new Regex(@"^([0-9]{8})([a-zA-Z ]{1})$");

            if (regex.IsMatch(mitextbox.Text))
            {
                errorProvider.SetError(textBox_ID, String.Empty);
                textBox_ID.BackColor = Color.White;

                return true;
            }
            else
            {
                errorProvider.SetError(textBox_ID, "Formato: 12345678A");
                textBox_ID.BackColor = Color.MistyRose;

                return false;
            }
        }

        private bool es_email(Control mitextbox)
        {
            Regex regex = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");

            // Resultado: 
            //       Valid: david.jones@proseware.com 
            //       Valid: d.j@server1.proseware.com 
            //       Valid: jones@ms1.proseware.com 
            //       Invalid: j.@server1.proseware.com 
            //       Invalid: j@proseware.com9 
            //       Valid: js#internal@proseware.com 
            //       Valid: j_9@[129.126.118.1] 
            //       Invalid: j..s@proseware.com 
            //       Invalid: js*@proseware.com 
            //       Invalid: js@proseware..com 
            //       Invalid: js@proseware.com9 
            //       Valid: j.s@server1.proseware.com

            if (regex.IsMatch(mitextbox.Text))
            {
                errorProvider.SetError(textBox_Email, String.Empty);
                textBox_Email.BackColor = Color.White;

                return true;
            }
            else
            {
                errorProvider.SetError(textBox_Email, "ejemplo@ejemplo.com");
                textBox_Email.BackColor = Color.MistyRose;

                return false;
            }
        }
    }
}