using System.Data.OleDb;

namespace Entidades
{
    public class BBDD
    {
        public List<Producto> BuscarProductos()
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
    }
}
