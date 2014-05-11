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
    public partial class NuevoParte : Form
    {
        public NuevoParte()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textboxid.Text == "" || textboxcliente.Text == "" || textboxresponsable.Text == "" || textboxequipo.Text == "" || textboxdescripcion.Text == "")
            {
                MessageBox.Show(this, "Todos los campos son obligatorios");
            }
            else 
           {
                try
                {
                            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN parte = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN();
                            parte.ParteIntervencion(Convert.ToInt32(textboxid.Text),
                                                    DateTime.Now,
                                                    textboxequipo.Text,
                                                    textboxdescripcion.Text,
                                                  Convert.ToInt32(textboxresponsable.Text),
                                                    textboxcliente.Text);
                        
                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error al insertar");
                }
            
            }
        }
    }
}
