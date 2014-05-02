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
    public partial class GraficoVentas : Form
    {
        public GraficoVentas()
        {
            InitializeComponent();

            // xvars contiene fechas
            // yvars ventas de cada fecha

            List<String> xvars = new List<String>() { "1","2","3","4","5","6","7","8","9","10","11","12" };
            List<Double> yvars = new List<Double>();

            IList<PedidoClienteEN> listaPedidos = new PedidoClienteCEN().LeerTodos(0,10000);

            int mes = Convert.ToInt32(listaPedidos[0].Fecha.ToString().Split('/')[1]);

            for (int i = 0; i < mes-1; i++)
                yvars.Add(0.0f);

            double total = 0;
            for(int i = 0; i < listaPedidos.Count; i++)
            {

                LineaPedidoCP lpCP = new LineaPedidoCP();
                List<List<String>> filas = lpCP.getLineasPedidoPorId(listaPedidos[i].Id);

                
                foreach (List<String> fila in filas)
                {
                    total += Double.Parse(fila[5]);
                }

                try{
                    if (mes != Convert.ToInt32(listaPedidos[i+1].Fecha.ToString().Split('/')[1]))
                    {
                        yvars.Add(total);
                        total = 0;
                        mes = Convert.ToInt32(listaPedidos[i+1].Fecha.ToString().Split('/')[1]);
                    
                    }
                }
                catch (Exception ex) { yvars.Add(total); }
            }

            for (int i = yvars.Count; i < 12; i++)
                yvars.Add(0.0f);

            chart1.Series["Series1"].Points.DataBindXY(xvars, yvars);

            chart1.Invalidate();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
