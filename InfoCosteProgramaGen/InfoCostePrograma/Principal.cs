using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfoCosteProgramaGenNHibernate;
using System.Runtime.InteropServices;

namespace InfoCostePrograma
{
    public partial class Principal : Form
    {
        int usuario;

        public Principal(int user)
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            usuario = user;

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN tcen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.TrabajadorCEN();
            InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN trabajador = tcen.LeerPorOID(usuario);
            label_Identificado.Text = trabajador.Nombre;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void Principal_Load(object sender, EventArgs e)
        {
            flecha.Location = new Point(62, 112);
            flecha.Visible = false;
        }

        // Método para añadir form al panel central
        private void AddFormInPanel(Object formHijo)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }

        // Boton TRABAJADORES
        private void button6_Click(object sender, EventArgs e)
        {
            // Mover flecha
            flecha.Location = new Point(62, 112);
            flecha.Visible = true;

            // Añadir panel
            AddFormInPanel(new GestionarTrabajadores());
        }

        // Boton CLIENTES
        private void button7_Click(object sender, EventArgs e)
        {
            // Mover flecha
            flecha.Location = new Point(171, 112);
            flecha.Visible = true;

            // Añadir panel
            AddFormInPanel(new GestionarClientes());
        }

        // Boton PROVEEDORES
        private void button4_Click(object sender, EventArgs e)
        {
            // Mover flecha
            flecha.Location = new Point(279, 112);
            flecha.Visible = true;

            // Añadir panel
            AddFormInPanel(new GestionarProveedores());
        }

        // Boton PRODUCTOS
        private void button8_Click(object sender, EventArgs e)
        {
            // Mover flecha
            flecha.Location = new Point(390, 112);
            flecha.Visible = true;

            // Añadir panel
            AddFormInPanel(new GestionarProductos());
        }

        // Boton VENTAS
        private void button5_Click(object sender, EventArgs e)
        {
            // Mover flecha
            flecha.Location = new Point(500, 112);
            flecha.Visible = true;

            // Añadir panel
            AddFormInPanel(new GestionarVentas());
        }

        // Boton COMPRAS
        private void button2_Click(object sender, EventArgs e)
        {
            // Mover flecha
            flecha.Location = new Point(610, 112);
            flecha.Visible = true;

            // Añadir panel
            AddFormInPanel(new GestionarCompras());
        }

        // Boton PARTES
        private void button3_Click(object sender, EventArgs e)
        {
            // Mover flecha
            flecha.Location = new Point(715, 112);
            flecha.Visible = true;

            // Añadir panel
            AddFormInPanel(new GestionarPartes());
        }

        // Boton HERRAMIENTAS
        private void boton_Herramientas_Click(object sender, EventArgs e)
        {
            flecha.Visible = false;

            // Añadir panel
            AddFormInPanel(new Herramientas(usuario));
        }

        // Boton para minimizar la ventana
        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Boton para cerrar la ventana
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        // Label para cerrar sesion
        private void linkLabel_CerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Método para poder mover el form
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
    }
}
