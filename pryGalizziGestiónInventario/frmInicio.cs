using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryGalizziGestionInventario;

namespace pryGalizziGestiónInventario
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.ConectarBD();
        }
    }
}
