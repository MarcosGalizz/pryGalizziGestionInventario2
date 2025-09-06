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


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pryGalizziGestionInventario.clsConexionBD clsConexionBD = new pryGalizziGestionInventario.clsConexionBD();
            clsConexionBD.ConectarBD();
            clsConexionBD.agregarProductos(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtStock.Text), cboCategorias.Text);
        }

        private void frmInicio_Load_1(object sender, EventArgs e)
        {
            pryGalizziGestionInventario.clsConexionBD clsConexionBD = new pryGalizziGestionInventario.clsConexionBD();
            clsConexionBD.ConectarBD();
            clsConexionBD.cargarNombres(cboCategorias);
        }
    }
}
