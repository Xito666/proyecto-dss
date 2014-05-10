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
        String tipoDoc;
        
        public Printable(PedidoClienteEN pedido)
        {
            this.idDocumento = pedido.Id;
            LineaPedidoCP cp = new LineaPedidoCP();
            this.cliente = cp.getClienteDePedido(pedido.Id);
            this.fecha = DateTime.Parse(pedido.Fecha.ToString());
            cp = new LineaPedidoCP();
            lineasPedido = cp.getLineasPedidoPorId(pedido.Id);
            plantilla = new StreamReader("plantillaDoc.txt").ReadToEnd();
            tipoDoc = NuevaVenta.obtenerFacturaTipada(pedido.Id).GetType().ToString()
                        .Replace("InfoCosteProgramaGenNHibernate.EN.InfoCoste.", "");
            tipoDoc = tipoDoc.Substring(0, tipoDoc.Length-2);
             
            documento = parseDoc();

        }

        String parseDoc()
        {
            documento = plantilla;

            documento = documento.Replace("{clienteNombre}", cliente.NombreCompleto);
            documento = documento.Replace("{clienteCif}", cliente.Id);
            documento = documento.Replace("{clienteTelf}", cliente.Telefono.ToString());
            documento = documento.Replace("{clienteDireccion}", cliente.Direccion.ToString());
            documento = documento.Replace("{clienteEmail}", cliente.Email.ToString());
            documento = documento.Replace("{idDocumento}", idDocumento.ToString());
            documento = documento.Replace("{tipoDoc}", tipoDoc);

            String l = "";

            foreach(List<String> linea in lineasPedido)
            {
                l += linea[0] + "\t" + (linea[2]+"                ").Substring(0,15) + "\t\t" + linea[1] + "\t" + linea[3] + "\t" + linea[4] + "\t" + linea[5] + "\r\n";
            }

            documento = documento.Replace("{linea}", l);

            double total = new LineaPedidoCP().getTotalPedido(idDocumento);
            documento = documento.Replace("{total}", total.ToString());

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
