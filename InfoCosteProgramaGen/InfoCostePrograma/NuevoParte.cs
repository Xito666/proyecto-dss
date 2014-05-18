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
        bool edit = false;
        int id;
        public NuevoParte()
        {
            InitializeComponent();
        }
        public NuevoParte(int idparte){
        id=idparte;
        edit = true;
        InitializeComponent();

        InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN parte = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN();
        InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN pen = parte.LeerPorOID(id);




        textboxequipo.Text = pen.DatosPc;
        textboxdescripcion.Text = pen.AccionesRealizadas;
        textboxresponsable.Text = pen.Trabajador.ToString();
        textboxcliente.Text = pen.Cliente.ToString();
        
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                if (textboxcliente.Text == "" || textboxresponsable.Text == "" || textboxequipo.Text == "" || textboxdescripcion.Text == "")
                {
                    MessageBox.Show(this, "Todos los campos son obligatorios");
                }
                else
                {
                    InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN parte = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN();
                    IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> listaPartes = parte.LeerTodos(0, 40);

                    int parteID = 0;
                    try
                    {
                        parteID = listaPartes.Last().Id + 1;
                    }
                    catch (Exception ex) { }
                    try
                    {
                        InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN partecen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN();
                        partecen.ParteIntervencion(parteID,
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
            else {

                InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN parte = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN();
               
                InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN responsable = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
                InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN trab = responsable.LeerPorOID(id);

                parte.SetTrabajador(id, trab);
                parte.SetDatosPc(id, textboxequipo.Text);
                parte.SetAccionesRealizadas(id, textboxdescripcion.Text);

                MessageBox.Show(this, "Parte modificada con éxito");
                this.DialogResult = DialogResult.OK;
                this.Close();
            
            
            }
        }
    }
}
