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

        bool editando = false;
        string id;

        public NuevoCliente()
        {
            InitializeComponent();
            checkBox_Empresa.Checked = true;
        }

        public NuevoCliente(string ID)
        {
            InitializeComponent();

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN ccen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN();
            InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN cliente = ccen.LeerPorOID(ID.ToString());

            id = ID;
            editando = true;

            textBox_ID.Text = cliente.Id;
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
            if (textBox_ID.Text == "" || textBox_Nombre.Text == "" || textBox_Telefono.Text == "" || textBox_Email.Text == "")
            {
                MessageBox.Show(this, "Todos los campos son obligatorios");
            }
            else
            {
                MessageBoxButtons mbb = new MessageBoxButtons();
                MessageBox.Show(this, "Se creará/modificará el cliente", "Continuar?", mbb);

                try
                {

                    if (!editando)
                    {
                        if (checkBox_Empresa.Checked)
                        {
                            int nCuenta = 0;
                            try { nCuenta = Convert.ToInt32(textBox_NumCuenta.Text); }
                            catch (Exception ex) { };
                            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN ceCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN();
                            ceCEN.ClienteEmpresa(textBox_ID.Text,
                                                    textBox_Direccion.Text,
                                                    Convert.ToInt32(textBox_Telefono.Text),
                                                    textBox_Email.Text,
                                                    textBox_Nombre.Text,
                                                    nCuenta);
                        }
                        else
                        {
                            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteParticularCEN cpCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteParticularCEN();
                            cpCEN.ClienteParticular(textBox_ID.Text,
                                                    textBox_Direccion.Text,
                                                    Convert.ToInt32(textBox_Telefono.Text),
                                                    textBox_Email.Text,
                                                    textBox_Nombre.Text);
                        }
                    }
                    else
                    {
                        InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN cCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN();
                        cCEN.SetNombre(id, textBox_Nombre.Text);
                        cCEN.SetDireccion(id, textBox_Direccion.Text);
                        cCEN.SetEmail(id, textBox_Email.Text);
                        cCEN.SetTelefono(id, Convert.ToInt32(textBox_Telefono.Text));

                        if(checkBox_Empresa.Checked)
                        {
                            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN ceCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN();
                            ceCEN.SetNumeroCuenta(id,Convert.ToInt32(textBox_NumCuenta.Text));
                        
                        }
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Revise los campos" );
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Empresa.Checked)
                textBox_NumCuenta.Enabled = false;
            else
                textBox_NumCuenta.Enabled = true;
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
