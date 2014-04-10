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

        private void button_CrearUsuario_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mbb = new MessageBoxButtons();
            MessageBox.Show(this, "Se creará/modificará el usuario", "Continuar?", mbb);
            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN tcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
             
            if (!editando)
            {
                tcen.Trabajador(Convert.ToInt32(textBox_ID.Text), textBox_Password.Text, textBox_Nombre.Text);
            }
            else
            {
                InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN ten = tcen.LeerPorOID(id);
                tcen.SetNombre(id, textBox_Nombre.Text);
                tcen.SetPassword(id, textBox_Password.Text);
               
            }

            this.Close();
        }

        private void NuevoTrabajador_Load(object sender, EventArgs e)
        {

        }
    }
}
