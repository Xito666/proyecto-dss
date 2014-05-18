using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfoCosteProgramaGenNHibernate.CEN.InfoCoste;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CP;

namespace InfoCostePrograma
{
    public partial class NuevoParte : Form
    {
        bool edit = false;
        int id;
        ClienteEN c;
        public NuevoParte()
        {

            InitializeComponent();

            TrabajadorCEN tCEN = new TrabajadorCEN();
            IList<TrabajadorEN> listaTrab = tCEN.LeerTodos(0,1000);
            foreach(TrabajadorEN t in listaTrab)
            {
                textboxresponsable2.Items.Add(t.Nombre);
            }

        }

        public NuevoParte(int idparte)
        {
            id=idparte;
            edit = true;
            InitializeComponent();

            TrabajadorCEN tCEN = new TrabajadorCEN();
            IList<TrabajadorEN> listaTrab = tCEN.LeerTodos(0, 1000);
            foreach (TrabajadorEN t in listaTrab)
            {
                textboxresponsable2.Items.Add(t.Nombre);
            }

            textboxresponsable2.Enabled = false;
            textboxcliente.Enabled = false;


            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN parte = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN();
            InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN pen = parte.LeerPorOID(id);

            textboxequipo.Text = pen.DatosPc;
            textboxdescripcion.Text = pen.AccionesRealizadas;
            tCEN = new TrabajadorCEN();
            textboxresponsable2.Text = tCEN.LeerPorOID(pen.Trabajador.Id).Nombre;

            ClienteCEN cCEN = new ClienteCEN();
            ClienteEN cEN = cCEN.LeerPorOID(pen.Cliente.Id);
            textboxcliente.Text = cEN.NombreCompleto;
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                if (textboxcliente.Text == "" || textboxresponsable2.Text == "" || textboxequipo.Text == "" || textboxdescripcion.Text == "")
                {
                    MessageBox.Show(this, "Todos los campos son obligatorios");
                }
                else
                {
                    InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN parte = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN();
                    IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> listaPartes = parte.LeerTodos(0, 40);
                    
                    int parteID = 0;
                    //if (listaPartes != null) parteID = listaPartes.Last().Id + 1;
                    if (listaPartes.Count != 0) parteID = listaPartes.Last().Id + 1;
                   /** try
                    {
                        parteID = listaPartes.Last().Id + 1;
                    }
                    catch (Exception ex) { MessageBox.Show(this, "Error al calcular ultimo id"); }**/
                    try
                    {
                        TrabajadorCEN tCEN = new TrabajadorCEN();
                        TrabajadorEN tEN = tCEN.LeerPorNombre( textboxresponsable2.SelectedItem.ToString())[0];
                        int id = tEN.Id;
                        InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN partecen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN();
                        partecen.ParteIntervencion(parteID,
                                                DateTime.Now,
                                                textboxequipo.Text,
                                                textboxdescripcion.Text,
                                              Convert.ToInt32(id),
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
                try
                {

                    TrabajadorCEN tCEN = new TrabajadorCEN();
                    TrabajadorEN tEN = tCEN.LeerPorNombre(textboxresponsable2.SelectedItem.ToString())[0];
                    //int id = tEN.Id;

                    InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN parte = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN();
                    InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN ppen = parte.LeerPorOID(id);

                    InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN responsable = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
                    InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN trab = responsable.LeerPorNombre(textboxresponsable2.SelectedItem.ToString())[0];

                    ppen.Trabajador = trab;

                    //parte.SetTrabajador(id, trab);
                    parte.SetDatosPc(id, textboxequipo.Text);
                    parte.SetAccionesRealizadas(id, textboxdescripcion.Text);

                    MessageBox.Show(this, "Parte modificada con éxito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Revisa los campos");
                }
            
            
            }
        }

        private void buscarcliente_Click(object sender, EventArgs e)
        {
            SeleccionaCliente sc = new SeleccionaCliente();
            if (sc.ShowDialog() == DialogResult.OK)
            {
                c = sc.clienteSeleccionado;
                textboxcliente.Text = c.Id;
                textboxcliente.Enabled = false;
            }
        }
    }
}
