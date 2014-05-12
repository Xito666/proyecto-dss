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
    public partial class NuevoCliente : Form
    {
        bool editando = false;
        String id;

        public NuevoCliente()
        {
            InitializeComponent();

            textBox_NumCuenta.Enabled = false;
        }

        public NuevoCliente(string ID)
        {
            InitializeComponent();

            editando = true;
            id = ID;

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN ccen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN();
            InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN cliente = ccen.LeerPorOID(id);

            textBox_ID.Text = cliente.Id;
            textBox_ID.Enabled = false;
            textBox_Nombre.Text = cliente.NombreCompleto;
            textBox_Telefono.Text = cliente.Telefono.ToString();
            textBox_Direccion.Text = cliente.Direccion;
            textBox_Telefono.Text = cliente.Telefono.ToString();
            textBox_Email.Text = cliente.Email;

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN ceCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN();
            InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEmpresaEN ceEN = ceCEN.LeerPorOID(ID.ToString());

            if (ceEN == null)
            {
                checkBox_Empresa.Checked = false;
                textBox_NumCuenta.Enabled = false;
            }
            else
                checkBox_Empresa.Checked = true;
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {

        }

        // NUEVO
        private void button_CrearUsuario_Click(object sender, EventArgs e)
        {
            if (es_dni(textBox_ID) == true)
            {
                if (!seRepite(textBox_ID))
                {
                    if (es_telefono(textBox_Telefono) == true && es_email(textBox_Email) == true)
                    {
                        if (!editando)
                        {
                            if (checkBox_Empresa.Checked)
                            {
                                if (es_numCuenta(textBox_NumCuenta) == true)
                                {
                                    String nCuenta = "";
                                    nCuenta = textBox_NumCuenta.Text;

                                    InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN ceCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN();
                                    ceCEN.ClienteEmpresa(textBox_ID.Text,
                                                            textBox_Direccion.Text,
                                                            Convert.ToInt32(textBox_Telefono.Text),
                                                            textBox_Email.Text,
                                                            textBox_Nombre.Text,
                                                            nCuenta);

                                    MessageBox.Show(this, "Cliente creado");
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                            else
                            {
                                InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteParticularCEN cpCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteParticularCEN();
                                cpCEN.ClienteParticular(textBox_ID.Text,
                                                        textBox_Direccion.Text,
                                                        Convert.ToInt32(textBox_Telefono.Text),
                                                        textBox_Email.Text,
                                                        textBox_Nombre.Text);

                                MessageBox.Show(this, "Cliente creado");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        else
                        {
                            if (checkBox_Empresa.Checked)
                            {
                                if (es_numCuenta(textBox_NumCuenta) == true)
                                {
                                    InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN cCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN();
                                    cCEN.SetNombre(id, textBox_Nombre.Text);
                                    cCEN.SetDireccion(id, textBox_Direccion.Text);
                                    cCEN.SetEmail(id, textBox_Email.Text);
                                    cCEN.SetTelefono(id, Convert.ToInt32(textBox_Telefono.Text));

                                    InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN ceCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN();
                                    ceCEN.SetNumeroCuenta(id, textBox_NumCuenta.Text);

                                    MessageBox.Show(this, "Cliente modificado");
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                            else
                            {
                                InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN cCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN();
                                cCEN.SetNombre(id, textBox_Nombre.Text);
                                cCEN.SetDireccion(id, textBox_Direccion.Text);
                                cCEN.SetEmail(id, textBox_Email.Text);
                                cCEN.SetTelefono(id, Convert.ToInt32(textBox_Telefono.Text));

                                MessageBox.Show(this, "Cliente modificado");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con este DNI");
                }
            }
        }

        private bool seRepite(Control mitextbox)
        {
            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN cCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN();

            if (cCEN.LeerPorOID(mitextbox.Text) == null)
                return false;
            else
                return true;
        }

        // CAMBIO TIPO CLIENTE
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Empresa.Checked)
                textBox_NumCuenta.Enabled = false;
            else
                textBox_NumCuenta.Enabled = true;
        }


        /********* COMPROBACIONES ***********/

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

        private bool es_telefono(Control mitextbox)
        {
            Regex regex = new Regex(@"^([0-9]{9})$");

            if (regex.IsMatch(mitextbox.Text))
            {
                errorProvider.SetError(textBox_Telefono, String.Empty);
                textBox_Telefono.BackColor = Color.White;

                return true;
            }
            else
            {
                errorProvider.SetError(textBox_Telefono, "Formato: 123456789");
                textBox_Telefono.BackColor = Color.MistyRose;

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

        private bool es_numCuenta(Control mitextbox)
        {
            Regex regex = new Regex(@"^([0-9]{20})$");

            if (regex.IsMatch(mitextbox.Text))
            {
                errorProvider.SetError(textBox_NumCuenta, String.Empty);
                textBox_NumCuenta.BackColor = Color.White;

                return true;
            }
            else
            {
                errorProvider.SetError(textBox_NumCuenta, "Debe contener 20 numeros");
                textBox_NumCuenta.BackColor = Color.MistyRose;

                return false;
            }
        }
    }
}
