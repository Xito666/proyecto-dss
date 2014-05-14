using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CEN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CAD.InfoCoste;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace InfoCostePrograma
{
    public partial class Herramientas : Form
    {
        int usuario;

        public Herramientas(int user)
        {
            InitializeComponent();

            usuario = user;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Credenciales ca = new Credenciales(usuario);
            ca.Show();
        }

        private void Herramientas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");
            SqlCommand command = new SqlCommand();

            command.CommandText = "backup database [InfoCosteProgramaGenNHibernate]to disk =" + "'" + @"C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\copia.bak'";
            command.CommandType = CommandType.Text;
            command.Connection = cnn;

            cnn.Open();
            command.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
