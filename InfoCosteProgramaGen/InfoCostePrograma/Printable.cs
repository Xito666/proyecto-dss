using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoCosteProgramaGenNHibernate.CEN.InfoCoste;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CP;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

namespace InfoCostePrograma
{
    public class Printable
    {
        int idDocumento;
        ClienteEN cliente;
        DateTime fecha;
        List<List<String>> lineasPedido;
        String plantilla;
        String documento;
        
        public Printable(PedidoClienteEN pedido)
        {
            LineaPedidoCP cp = new LineaPedidoCP();

            this.idDocumento = pedido.Id;
            cp = new LineaPedidoCP();
            this.cliente = cp.getClienteDePedido(pedido.Id);
            this.fecha = DateTime.Parse(pedido.Fecha.ToString());
            cp = new LineaPedidoCP();
            lineasPedido = cp.getLineasPedidoPorId(pedido.Id);
            plantilla = new StreamReader("plantillaDoc.txt").ReadToEnd();
            documento = parseDoc();

        }

        public String parseDoc()
        {
            documento = plantilla;

            documento = documento.Replace("{clienteNombre}", cliente.NombreCompleto);
            documento = documento.Replace("{clienteCif}", cliente.Id);
            documento = documento.Replace("{ClienteTelf}", cliente.Telefono.ToString());
            documento = documento.Replace("{clienteDireccion}", cliente.Direccion.ToString());
            documento = documento.Replace("{clienteEmail}", cliente.Email.ToString());
            documento = documento.Replace("{idDocumento}", idDocumento.ToString());

            String l = "";

            foreach(List<String> linea in lineasPedido)
            {
                l += linea[0] + "\t" + (linea[2]+"                ").Substring(0,15) + "\t\t" + linea[1] + "\t" + linea[3] + "\t" + linea[4] + "\t" + linea[5] + "\r\n";
            }

            documento = documento.Replace("{linea}", l);

            return documento;
        }

        public String ToString()
        {
            return documento;
        }

        public void Print()
        {
            StreamWriter file = new StreamWriter("docu.txt");
            file.Write(ToString());
            file.Close();

            System.Diagnostics.ProcessStartInfo proceso = new System.Diagnostics.ProcessStartInfo("notepad.exe", "docu.txt");
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(proceso);
        }
    }
}
