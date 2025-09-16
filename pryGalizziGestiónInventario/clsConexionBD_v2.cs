using System;
using System.Collections;
using System.Collections.Generic;
//para conexion de ACcess
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryGalizziGestionInventario
{
    internal class clsConexionBD
    {
        //cadena de conexion
        //sql - string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../dbGestionInventario2.accdb";
        //conector
        //SqlConnection coneccionBaseDatos;
        OleDbConnection coneccionBaseDatos;
        //comando
        //SqlCommand comandoBaseDatos;
        OleDbCommand comandoBaseDatos;
        OleDbDataReader lectorDataReader;
        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                //coneccionBaseDatos = new SqlConnection(cadenaConexion);
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);


                nombreBaseDeDatos = Path.GetFileName(coneccionBaseDatos.DataSource);
                coneccionBaseDatos.Open();
                
                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }     

        }
        public void cargarNombres(ComboBox cboListaNombres)
        {
            comandoBaseDatos = new OleDbCommand();
            comandoBaseDatos.Connection = coneccionBaseDatos;
            comandoBaseDatos.CommandText = "SELECT Categoría FROM Productos";
            lectorDataReader = comandoBaseDatos.ExecuteReader();
            while (lectorDataReader.Read())
            {
                if (!cboListaNombres.Items.Contains(Convert.ToInt32(lectorDataReader[0])))
                {
                    cboListaNombres.Items.Add(lectorDataReader[0]);
                }
            }
        }

        public void buscarProductos(int codigo, TextBox nombre, TextBox descripcion, TextBox precio, TextBox stock, ComboBox categoria)
        {
            try
            {
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = $"SELECT * FROM Productos WHERE Código={codigo}";
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                lectorDataReader.Read();
                nombre.Text = lectorDataReader[1].ToString();
                descripcion.Text = lectorDataReader[2].ToString();
                precio.Text = lectorDataReader[3].ToString();
                stock.Text = lectorDataReader[4].ToString();
                categoria.Text = lectorDataReader[5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró ningún producto con ese código. \n" + ex.ToString());
            }
        }
        public void agregarProductos(int codigo, string nombre, string descripcion, decimal precio, int stock, int categoria)
        {
            coneccionBaseDatos = new OleDbConnection(cadenaConexion);
            coneccionBaseDatos.Open();
            comandoBaseDatos = new OleDbCommand();
            comandoBaseDatos.Connection = coneccionBaseDatos;
            comandoBaseDatos.CommandText = "INSERT INTO Productos (Código, Nombre, Descripción, Precio, Stock, Categoría) " +
        $"VALUES ({codigo}, '{nombre}', '{descripcion}', {precio}, {stock}, {categoria})";
            lectorDataReader = comandoBaseDatos.ExecuteReader();
            MessageBox.Show("Producto agregado con éxito.");
        }

        public void modificarProductos(int codigo, string nombre, 
            string descripcion, decimal precio, int 
            stock, int categoria)
        {
            try
            {
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = 
                    $"UPDATE Productos SET Nombre = '{nombre}', Descripción = '{descripcion}', Precio = {precio}, Stock = {stock}, Categoría = {categoria} WHERE Código = {codigo}";
                comandoBaseDatos.ExecuteNonQuery();
                MessageBox.Show("Producto modificado con éxito.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar modificar el producto.");
            }
        }
        public void eliminarProductos(int codigo)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este producto?"
                    ,"Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                    coneccionBaseDatos.Open();
                    comandoBaseDatos = new OleDbCommand();
                    comandoBaseDatos.Connection = coneccionBaseDatos;
                    comandoBaseDatos.CommandText = $"DELETE FROM Productos WHERE Código = {codigo}";
                    comandoBaseDatos.ExecuteNonQuery();
                    MessageBox.Show("Producto eliminado con éxito.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar eliminar el producto.");
            }
        }

        public void buscarPorCategoria(string categoria, string elemento, DataGridView dgvCategoria)
        {
            try
            {
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                if (categoria != "Nombre")
                {
                    Convert.ToInt32(elemento);
                }
                comandoBaseDatos.CommandText = $"SELECT * FROM Productos WHERE {categoria}=@elemento";
                comandoBaseDatos.Parameters.AddWithValue("@elemento", elemento);
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                while (lectorDataReader.Read())
                {
                    dgvCategoria.Rows.Add(lectorDataReader[0], lectorDataReader[1], lectorDataReader[2], lectorDataReader[3], lectorDataReader[4], lectorDataReader[5]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la categoría o el valor ingresado.");
            }
        }

        public void cargarChart(Chart chtStockProductos)
        {
            try
            {
                chtStockProductos.Series.Add("Inventario");
                chtStockProductos.ChartAreas[0].AxisX.Title = "Productos";
                chtStockProductos.ChartAreas[0].AxisY.Title = "Stock";
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT Nombre, Stock FROM Productos";
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                while (lectorDataReader.Read())
                {
                    string producto = lectorDataReader[0].ToString();
                    Int32 stock = Convert.ToInt32(lectorDataReader[1]);
                    int index = chtStockProductos.Series[0].Points.AddY(stock);
                    chtStockProductos.Series[0].Points[index].AxisLabel = producto;
                    if (stock < 3)
                    {
                        chtStockProductos.Series[0].Points[index].Color = Color.Red;
                    }
                    else if (stock > 10)
                    {
                        chtStockProductos.Series[0].Points[index].Color = Color.Green;
                    }

                    
                }
            }
            catch
            {
                MessageBox.Show("No se puedieron obtener los datos solicitados.");
            }
        }
    }
}
