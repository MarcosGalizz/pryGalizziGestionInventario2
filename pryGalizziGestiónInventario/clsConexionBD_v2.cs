using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

//para conexion de ACcess
using System.Data.OleDb;

using System.Windows.Forms;

namespace pryGalizziGestionInventario
{
    internal class clsConexionBD
    {
        //cadena de conexion
        //sql - string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../dbGestionInventario1.accdb";
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
            comandoBaseDatos.CommandText = "SELECT marca_nombre FROM Productos";
            lectorDataReader = comandoBaseDatos.ExecuteReader();
            while (lectorDataReader.Read())
            {
                cboListaNombres.Items.Add(lectorDataReader[0]);
            }
        }

        public void agregarProductos(int txtId, string nombre, string descripcion, decimal precio, int stock, string categoria)
        {
            comandoBaseDatos = new OleDbCommand();
            comandoBaseDatos.Connection = coneccionBaseDatos;
            comandoBaseDatos.CommandText = $"INSERT INTO Productos " +
                "VALUES (1, 2, 'Dell', 'pantalla rota')";
            lectorDataReader = comandoBaseDatos.ExecuteReader();
        }
    }
}
