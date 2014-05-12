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
        bool editando = false;
        int id;

        public NuevoTrabajador()
        {
            InitializeComponent();

            textBox_ID.Enabled = false;

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN tcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
            IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN> listaTrabajadores = tcen.LeerTodos(0, 100);
            textBox_ID.Text = (Convert.ToInt32(listaTrabajadores.ElementAt(listaTrabajadores.Count-1).Id.ToString())+1).ToString();
        }

        public NuevoTrabajador(int ID)
        {
            InitializeComponent();

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN tcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
            InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN ten = tcen.LeerPorOID(ID);

            id = ID;
            editando = true;

            textBox_ID.Enabled = false;
            textBox_ID.Text = ten.Id.ToString();
            textBox_Password.Text = ten.Password;
            textBox_Nombre.Text = ten.Nombre;
        }

        private void NuevoTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void button_CrearUsuario_Click(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text == "" || textBox_Password.Text == "")
            {
                MessageBox.Show(this, "Todos los campos son obligatorios");
            }
            else
            {
                bool repetido = false;
                InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN tcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
                IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN> lista = tcen.LeerTodos(0, 100);

                foreach (InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN t in lista)
                {
                    if (t.Nombre == textBox_Nombre.Text)
                    {
                        repetido = true;
                    }
                }

                if (!repetido)
                {
                    if (!editando)
                    {
                        MessageBox.Show(this, "Se creará el usuario");
                        tcen.Trabajador(Convert.ToInt32(textBox_ID.Text), textBox_Nombre.Text, textBox_Password.Text);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Se modificará el usuario");
                        tcen.SetNombre(id, textBox_Nombre.Text);
                        tcen.SetPassword(id, textBox_Password.Text);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                    MessageBox.Show(this, "Ya existe un trabajador con ese nombre");
            }
        }
    }
}
