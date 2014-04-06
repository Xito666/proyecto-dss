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
    public partial class CredencialesAdministrador : Form
    {
        private static CredencialesAdministrador instance;

        public CredencialesAdministrador()
        {
            InitializeComponent();
        }

        public static CredencialesAdministrador DefInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new CredencialesAdministrador();

                return instance;
            }

            set
            {
                instance = value;
            }
        }

        private void CredencialesAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
