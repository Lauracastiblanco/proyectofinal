using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frProducto : Form
    {
        public frProducto()
        {
            InitializeComponent();
        }

        private void rbRegitrar_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabControlPrincipal.TabPages[0];
        }
        private void rbActualizar_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabControlPrincipal.TabPages[1];
        }
        private void rbConsultar_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabControlPrincipal.TabPages[2];
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabControlPrincipal.TabPages[3];
        }

    }
}
