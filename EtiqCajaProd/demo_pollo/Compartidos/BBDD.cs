using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_pollo.Compartidos
{
    internal class BBDD
    {
        private static string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Db.pollos.accdb";


        public static List<Producto> BuscarProductos()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM Producto";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    using (OleDbDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string id_producto = lector["id_producto"].ToString();

                            // Obtener los calibres en una NUEVA conexión
                            List<string> calibres = ObtenerCalibres(id_producto);

                            productos.Add(new Producto(
                                    int.Parse(id_producto),
                                    lector["descripcion"].ToString(),
                                    lector["codigo_producto"].ToString(),
                                    int.Parse(lector["tipo_producto"].ToString()),
                                    int.Parse(lector["conservacion"].ToString()),
                                    int.Parse(lector["grado"].ToString()),
                                    lector["repeticion"].ToString(),
                                    int.Parse(lector["planta"].ToString()),
                                    bool.Parse(lector["habilitado"].ToString()),
                                    lector["pathEtiqueta"].ToString(),
                                    calibres

                                )
                            );
                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos desde la base: " + ex.Message);
            }

            return productos;
        }

        // Método separado para obtener los calibres usando una nueva conexión
        private static List<string> ObtenerCalibres(string id_producto)
        {
            List<string> calibres = new List<string>();

            using (OleDbConnection nuevaConexion = new OleDbConnection(cadena))
            {
                nuevaConexion.Open();
                string consultaCalibres =
                    "SELECT C.calibre " +
                    "FROM Calibre AS C " +
                    "INNER JOIN Producto_x_Calibre AS PC ON C.id_calibre = PC.id_calibre " +
                    "WHERE PC.id_producto = @id_producto";

                using (OleDbCommand comandoCalibres = new OleDbCommand(consultaCalibres, nuevaConexion))
                {
                    comandoCalibres.Parameters.AddWithValue("@id_producto", id_producto);
                    using (OleDbDataReader lectorCalibres = comandoCalibres.ExecuteReader())
                    {
                        while (lectorCalibres.Read())
                        {
                            calibres.Add(lectorCalibres["calibre"].ToString());
                        }
                    }
                }
                nuevaConexion.Close();
            }
            return calibres;
        }


        public static void ActualizarProducto(Producto producto) {

            string query = @"UPDATE Producto 
                SET descripcion = @descripcion, 
                    planta = @planta, 
                    repeticion = @repeticion, 
                    tipo_producto = @tipoProducto, 
                    conservacion = @conservacion, 
                    grado = @grado,
                    codigo_producto = @codigoProducto,
                    pathEtiqueta = @pathEtiqueta
                WHERE id_producto = @id_producto";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    conexion.Open();
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        // Agregar parámetros
                        comando.Parameters.AddWithValue("@descripcion", producto.getDescripcion());
                        comando.Parameters.AddWithValue("@planta", producto.getPlanta());
                        comando.Parameters.AddWithValue("@repeticion", producto.getRepeticion());
                        comando.Parameters.AddWithValue("@tipoProducto", producto.getTipoProducto());
                        comando.Parameters.AddWithValue("@conservacion", producto.getConservacion());
                        comando.Parameters.AddWithValue("@grado", producto.getGrado());
                        comando.Parameters.AddWithValue("@codigoProducto", producto.getCodigoProducto());
                        comando.Parameters.AddWithValue("@pathEtiqueta", producto.getPathEtiqueta());

                        comando.Parameters.AddWithValue("@id_producto", producto.getId());

                        // Ejecutar actualización
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
