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

            this.idDocumento = cp.getPedidoId(pedido.Id);
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
            documento = documento.Replace("{ClienteDireccion}", cliente.Telefono.ToString());
            documento = documento.Replace("{ClienteEmail}", cliente.Telefono.ToString());
            documento = documento.Replace("{idDocumento}", idDocumento.ToString());

            return documento;
        }

        public String ToString()
        {
            return documento;
        }

        public void Print()
        {

        }
    }
}
