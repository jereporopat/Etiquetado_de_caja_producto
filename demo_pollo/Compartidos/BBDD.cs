using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace demo_pollo.Compartidos
{
    internal class BBDD
    {
        private static string cadenaDeConeccion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Db.pollos.accdb";


        public static List<Producto> BuscarProductos()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaDeConeccion))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM Producto";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    using (OleDbDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string id_producto = lector["id"].ToString();

                            // Obtener los calibres en una NUEVA conexión
                            Dictionary<int, string> calibres = ObtenerCalibres(id_producto);

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
                MessageBox.Show("Error al cargar productos desde la base: " + ex);
            }

            return productos;
        }

        // Método separado para obtener los calibres usando una nueva conexión
        private static Dictionary<int, string> ObtenerCalibres(string id_producto)
        {
            Dictionary<int, string> calibres = new Dictionary<int, string>();

            using (OleDbConnection nuevaConexion = new OleDbConnection(cadenaDeConeccion))
            {
                nuevaConexion.Open();
                string consultaCalibres =
                    "SELECT C.id, C.descripcion " +
                    "FROM Calibre AS C " +
                    "INNER JOIN Producto_x_Calibre AS PC ON C.id = PC.id_calibre " +
                    "WHERE PC.id_producto = @id_producto";

                using (OleDbCommand comandoCalibres = new OleDbCommand(consultaCalibres, nuevaConexion))
                {
                    comandoCalibres.Parameters.AddWithValue("@id_producto", id_producto);
                    using (OleDbDataReader lectorCalibres = comandoCalibres.ExecuteReader())
                    {
                        while (lectorCalibres.Read())
                        {
                            calibres.Add(
                                int.Parse(lectorCalibres["id"].ToString()),
                                lectorCalibres["descripcion"].ToString()
                                );
                        }
                    }
                }
                nuevaConexion.Close();
            }
            return calibres;
        }

        public static void GuardarProducto(Producto producto)
        {
            if (producto.getId() != -1)
            {
                ActualizarProducto(producto);
            }
            else
            {
                AgregarProducto(producto);
            }
        }

        private static void ActualizarProducto(Producto producto) {

            string query = @"UPDATE Producto 
                SET descripcion = @descripcion, 
                    planta = @planta, 
                    repeticion = @repeticion, 
                    tipo_producto = @tipoProducto, 
                    conservacion = @conservacion, 
                    grado = @grado,
                    codigo_producto = @codigoProducto,
                    pathEtiqueta = @pathEtiqueta
                WHERE id = @id_producto";

            try
            {
                ActualizarCalibresDeProducto(producto);

                using (OleDbConnection conexion = new OleDbConnection(cadenaDeConeccion))
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




        public static void AgregarProducto(Producto producto)
        {
            string queryInsert = @"INSERT INTO Producto (descripcion, planta, repeticion, tipo_producto, conservacion, grado, pathEtiqueta) 
                           VALUES (@descripcion, @planta, @repeticion, @tipoProducto, @conservacion, @grado, @pathEtiqueta);";

            using (OleDbConnection connection = new OleDbConnection(cadenaDeConeccion))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(queryInsert, connection))
                    {
                        // Agregar parámetros
                        command.Parameters.AddWithValue("@descripcion", producto.getDescripcion());
                        command.Parameters.AddWithValue("@planta", producto.getPlanta());
                        command.Parameters.AddWithValue("@repeticion", producto.getRepeticion());
                        command.Parameters.AddWithValue("@tipoProducto", producto.getTipoProducto());
                        command.Parameters.AddWithValue("@conservacion", producto.getConservacion());
                        command.Parameters.AddWithValue("@grado", producto.getGrado());
                        command.Parameters.AddWithValue("@pathEtiqueta", producto.getPathEtiqueta());

                        // Ejecutar INSERT
                        command.ExecuteNonQuery();

                        // Recuperar el ID generado
                        command.CommandText = "SELECT @@IDENTITY;";
                        int nuevoId = Convert.ToInt32(command.ExecuteScalar());

                        producto.setId(nuevoId);

                        ActualizarCalibresDeProducto(producto);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public static void ActualizarCalibresDeProducto(Producto producto)
        {
            string queryDelete = $"delete from Producto_x_Calibre where id_producto = {producto.getId()};";

            //No recuerdo como hacer una transaccion, asi que me chorie todo este codigo de la documentacion :)
            using (OleDbConnection connection = new OleDbConnection(cadenaDeConeccion))
            {
                OleDbCommand command = new OleDbCommand();
                OleDbTransaction transaction = null;

                // Set the Connection to the new OleDbConnection.
                command.Connection = connection;

                // Open the connection and execute the transaction.
                try
                {
                    connection.Open();

                    // Start a local transaction with ReadCommitted isolation level.
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);

                    // Assign transaction object for a pending local transaction.
                    command.Connection = connection;
                    command.Transaction = transaction;

                    // Execute the commands.
                    command.CommandText = queryDelete;

                    command.ExecuteNonQuery();

                    foreach (var calibre in producto.getCalibres())
                    {
                        string queryInsertCalibres = $"INSERT INTO Producto_x_Calibre (id_producto, id_calibre) VALUES ({producto.getId()}, {calibre.Key});";
                        command.CommandText = queryInsertCalibres;
                        command.ExecuteNonQuery();
                    }

                    // Commit the transaction.
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    try
                    {
                        // Attempt to roll back the transaction.
                        transaction.Rollback();
                        MessageBox.Show("Error al actualizar calibres del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        // Do nothing here; transaction is not active.
                    }
                }
                // The connection is automatically closed when the
                // code exits the using block.
            }
        }

        public static Dictionary<int, String> ObtenerDiccionarioDeOpciones(string tabla)
        {
            Dictionary<int, String> diccionarioDeOpciones = new Dictionary<int, String>();

            using (OleDbConnection nuevaConexion = new OleDbConnection(cadenaDeConeccion))
            {
                nuevaConexion.Open();
                string consultaCalibres =
                    "SELECT T.id, T.descripcion " +
                    $"FROM {tabla} AS T";

                using (OleDbCommand comandoCalibres = new OleDbCommand(consultaCalibres, nuevaConexion))
                {
                    using (OleDbDataReader lectorCalibres = comandoCalibres.ExecuteReader())
                    {
                        while (lectorCalibres.Read())
                        {
                            diccionarioDeOpciones.Add(
                                int.Parse (lectorCalibres["id"].ToString())
                                , lectorCalibres["descripcion"].ToString()
                                );
                        }
                    }
                }
                nuevaConexion.Close();
            }
            return diccionarioDeOpciones;
        }
    }
}
