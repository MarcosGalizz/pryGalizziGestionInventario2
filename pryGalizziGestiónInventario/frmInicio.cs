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

        private void resetearCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cboCategorias.SelectedIndex = -1;
        }
        private void frmInicio_Load_1(object sender, EventArgs e)
        {
            pryGalizziGestionInventario.clsConexionBD clsConexionBD = new pryGalizziGestionInventario.clsConexionBD();
            clsConexionBD.ConectarBD();
            clsConexionBD.cargarNombres(cboCategorias);

            clsConexionBDv3 conexionSQL = new clsConexionBDv3();
            conexionSQL.ConectarBD();

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pryGalizziGestionInventario.clsConexionBD clsConexionBD = new pryGalizziGestionInventario.clsConexionBD();
            clsConexionBD.buscarProductos(Convert.ToInt32(txtCodigo.Text), txtNombre, txtDescripcion, txtPrecio, txtStock, cboCategorias);
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            pryGalizziGestionInventario.clsConexionBD clsConexionBD = new pryGalizziGestionInventario.clsConexionBD();
            clsConexionBD.agregarProductos(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtStock.Text), Convert.ToInt32(cboCategorias.Text));
            resetearCampos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            pryGalizziGestionInventario.clsConexionBD clsConexionBD = new pryGalizziGestionInventario.clsConexionBD();
            clsConexionBD.modificarProductos(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtStock.Text), Convert.ToInt32(cboCategorias.Text));
            resetearCampos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pryGalizziGestionInventario.clsConexionBD clsConexionBD = new pryGalizziGestionInventario.clsConexionBD();
            clsConexionBD.eliminarProductos(Convert.ToInt32(txtCodigo.Text));
            resetearCampos();
        }
        private void matBtnBuscar_Click(object sender, EventArgs e)
        {
            dgvBuscar.Rows.Clear();
            pryGalizziGestionInventario.clsConexionBD clsConexionBD = new pryGalizziGestionInventario.clsConexionBD();
            clsConexionBD.buscarPorCategoria(matCboCategorias.Text, matTxtCategorias.Text, dgvBuscar);

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            pryGalizziGestionInventario.clsConexionBD clsConexionBD = new pryGalizziGestionInventario.clsConexionBD();
            clsConexionBD.modificarProductos(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtStock.Text), Convert.ToInt32(cboCategorias.Text));
            resetearCampos();
        }

        private void matBtnDestVentas_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas();
            frmVentas.ShowDialog();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            pryGalizziGestionInventario.clsConexionBD clsConexionBD = new pryGalizziGestionInventario.clsConexionBD();
            clsConexionBD.eliminarProductos(Convert.ToInt32(txtCodigo.Text));
            resetearCampos();
        }
    }
}
