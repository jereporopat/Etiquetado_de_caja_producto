using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using demo_pollo.Properties;
using System.Net;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Diagnostics.Eventing.Reader;
using demo_pollo.Compartidos;


namespace demo_pollo
{
    public partial class Main : Form
    {
        private Settings settings = Settings.Default;
        private CustomButton[] botonesCalibre;
        private CustomButton[] botonesProducto;
        private List<Producto> productos;
        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        string ruta_etq;
        // Conexión a la base de datos Access
        readonly string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Db.pollos.accdb";
        private CustomButton ultimoBotonPresionado = null;
        private CustomButton ultimoBotonPresionadoCalibre = null;
        string filePath;


        //Agregar para tener TRIAL
        private bool _Trial;
        
        public Main(bool IsTrial)

        {
            InitializeComponent();
            this.CargarProductosActivos();
            this.CargarBotonesProducto();
            this.CargarBotonesCalibre();
            

            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;

            
            if (IsTrial == false)
            {
                lblTrial.Text = "FULL";
                lblTrial.ForeColor = Color.Blue;

            }
            else
            {
                lblTrial.Text = "DEMO";
                lblTrial.ForeColor = Color.Red;
            }

            _Trial = IsTrial;
            
        }
        


        // No trial
        
        /*
        public Main()
        {
            InitializeComponent();


            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;

        }*/
        

        private void CargarProductosEnBotonesProducto()
        {
            int indice = 0;
            foreach (Producto producto in productos) {
                botonesProducto[indice].SetProducto(producto);
                botonesProducto[indice].Text = producto.getDescripcion();
                botonesProducto[indice].BackColor = Color.CornflowerBlue;
                botonesProducto[indice].Enabled = true;
                indice++;
            }
        }

        private void CargarBotonesProducto()
        {
            botonesProducto = new CustomButton[15];
            botonesProducto[0] = customButton8;
            botonesProducto[1] = customButton9;
            botonesProducto[2] = customButton10;
            botonesProducto[3] = customButton11;
            botonesProducto[4] = customButton12;
            botonesProducto[5] = customButton13;
            botonesProducto[6] = customButton14;
            botonesProducto[7] = customButton15;
            botonesProducto[8] = customButton16;
            botonesProducto[9] = customButton17;
            botonesProducto[10] = customButton18;
            botonesProducto[11] = customButton19;
            botonesProducto[12] = customButton20;
            botonesProducto[13] = customButton21;
            botonesProducto[14] = customButton22;

            foreach(CustomButton boton in botonesProducto) { 
                boton.BackColor = Color.Gray;
                boton.Enabled = false;
            }

            CargarProductosEnBotonesProducto();
        }

        private void CargarBotonesCalibre()
        {
            botonesCalibre = new CustomButton[6];
            botonesCalibre[0] = (customButton1);
            botonesCalibre[1] = (customButton2);
            botonesCalibre[2] = (customButton3);
            botonesCalibre[3] = (customButton4);
            botonesCalibre[4] = (customButton5);
            botonesCalibre[5] = (customButton7);
        }
        private void DesactivarBotonesDeCalibre() {
            foreach (Control boton in botonesCalibre)
            {
              //  boton.Text = "";
                boton.Enabled = false;
                boton.BackColor = Color.Gray;

            }
        }
        private void ActivarBotones(Producto producto)
        {
            DesactivarBotonesDeCalibre();
            List<string> calibres = producto.getCalibres().Values.ToList();
            int indice = 0;
            foreach (string calibre in calibres)
            {
                botonesCalibre[indice].Text = calibre;
                botonesCalibre[indice].Enabled = true;
                botonesCalibre[indice].BackColor = Color.Green;
                indice++;
            }
        }

        private void CargarProductosActivos()
        {
            productos = BBDD.BuscarProductos().FindAll(p => p.getHabilitado());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            CargarProductosActivos();
            CargarBotonesProducto();
            CargarBotonesCalibre();
            CargarProductosEnBotonesProducto();
            DesactivarBotonesDeCalibre();
        }

        //busqueda etq
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                filePath = openFileDialog1.FileName;
            
                settings.Ult_Etq = filePath;
                settings.Save();
             
                ruta_etq = filePath; // guardo para el momento de impresión
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén el producto seleccionado en el ListBox
            if (listBoxItems.SelectedItem != null)
            {
                // Obtiene el producto seleccionado
                string productoSeleccionado = listBoxItems.SelectedItem.ToString();

                CargarDatosProducto(listBoxItems.SelectedItem.ToString());
            }
        }
        private void GenerarCodigo()
        {
            //Le pido al boton seleccionado el objeto producto
            Producto productoSeleccionado = ultimoBotonPresionado.GetProducto();
            String calibre = ultimoBotonPresionadoCalibre != null ? ultimoBotonPresionadoCalibre.Text : "00";

            // Genera el código
            txtCodigo.Text =
                productoSeleccionado.getPlanta() +
                productoSeleccionado.getCodigoProducto() +
                productoSeleccionado.getTipoProducto() +
                productoSeleccionado.getConservacion() +
                productoSeleccionado.getGrado()+
                calibre +
                productoSeleccionado.getRepeticion();
        }
        private void btnCalibre_Click(object sender, EventArgs e)
        {
            CustomButton btn = sender as CustomButton; // El botón que disparó el evento.

            if(btn != null)
            {
                // Restaurar el color original del último botón presionado
                if (ultimoBotonPresionadoCalibre != null)
                {
                    ultimoBotonPresionadoCalibre.BackColor = Color.Green; // Color predeterminado
                }
                // Cambiar el color del botón actualmente presionado
                btn.BackColor = Color.OrangeRed;

                // Guardar el botón actual como último presionado
                ultimoBotonPresionadoCalibre = btn;
            }

            GenerarCodigo(); // Regenera el código con la nueva información.
        }
        private void btnNumpad_Click(object sender, EventArgs e)
        {
            CustomButton btn = sender as CustomButton; // Obtener el botón presionado
            if (btn != null)
            {
                // Restaurar el color original del último botón presionado
                if (ultimoBotonPresionado != null)
                {
                    ultimoBotonPresionado.BackColor = Color.CornflowerBlue; // Color predeterminado
                }
                // Cambiar el color del botón actualmente presionado
                btn.BackColor = Color.OrangeRed;

                // Guardar el botón actual como último presionado
                ultimoBotonPresionado = btn;

                ultimoBotonPresionadoCalibre = null;

                BuscarProductoPorCodigo();
            }
        }
        private void BuscarProductoPorCodigo()
        {
            // Buscar en la lista de productos ya cargada
            Producto productoSeleccionado = ultimoBotonPresionado.GetProducto();

            if (productoSeleccionado != null)
            {
                // Mostrar el producto encontrado en el ListBox
                listBoxItems.SelectedItem = productoSeleccionado.getDescripcion();

                // Cargar los datos del producto en los TextBox correspondientes
                CargarDatosProducto(productoSeleccionado.getDescripcion());
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ActivarBotones(productoSeleccionado);
        }

        private void LogError(string message)
        {
            string logPath = Path.Combine(Application.StartupPath, "error_log.txt");
            File.AppendAllText(logPath, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }
        private void CargarDatosProducto(string producto)
        {
            // Consulta SQL para obtener los datos del producto
            string query = "SELECT * FROM Producto WHERE descripcion = @descripcion";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    conexion.Open();
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        // Parámetro para evitar SQL Injection
                        comando.Parameters.AddWithValue("@descripcion", producto);

                        using (OleDbDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                if (lector["tipo_producto"].ToString() == "1")
                                    txtTipoProducto.Text = "Entero";
                                else
                                    txtTipoProducto.Text = "Trozado";
                            
                                if (lector["conservacion"].ToString() == "1")
                                    txtConservacion.Text = "Refrigerado";
                                else
                                    txtConservacion.Text = "Congelado";

                                textNomEtiqueta.Text = lector["pathEtiqueta"].ToString();
                                int i = textNomEtiqueta.Text.LastIndexOf("\\");
                                textNomEtiqueta.Text = textNomEtiqueta.Text.Substring(i+1);                               
                                i = textNomEtiqueta.Text.LastIndexOf('.');
                                textNomEtiqueta.Text = textNomEtiqueta.Text.Remove(i, 4);

                                // Generar código después de cargar datos
                                GenerarCodigo();
                            }
                            else
                            {
                                // Limpiar campos si no se encuentra el producto
                                txtTipoProducto.Clear();
                                txtConservacion.Clear();
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close(); // Cierra la aplicación
                return true; // Indica que se procesó la tecla
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnMas_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crear una instancia del formulario que deseas abrir
            MasFrm Mas = new MasFrm();

            Mas.ShowDialog(); // Abre como ventana independiente

            // Mostrar nuevamente el formulario principal después de cerrar el secundario
            this.Show();
        }

        //Imprimir
        private void imprimirBtn_Click(object sender, EventArgs e)
        {
            
           


            if (ultimoBotonPresionado.GetProducto().getCalibres().Count > 0 
                && ultimoBotonPresionadoCalibre == null) 
            {

                MessageBox.Show("SE DEBE SELECCIONAR UNA CALIDAD.", "ERROR DE OPERACIÓN !!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {


                IPEndPoint EndPoint_Z = new IPEndPoint(IPAddress.Parse(settings.IP_Zebra), 9100);
                try
                {
                    if (!sock.Connected)
                    {
                        //para debug sin conexion a imp
                      ////  SET_ETQ();
                      ///  return;

                        // if (settings.sonidos)
                        //    warning.Play();
                        IAsyncResult res = sock.BeginConnect(EndPoint_Z, null, null);
                        res.AsyncWaitHandle.WaitOne(500); // .5 sec timeout
                    }
                    if (sock.Connected)
                    {
                        SET_ETQ();
                        //CargarReporte();
                    }
                    else
                    {
                        MessageBox.Show("La Impresora Zebra no responde a la IP " + settings.IP_Zebra.ToString() + " !!!\nVerifique su correcta alimentación y el cable de comunicación Ethernet.\nVerifique la Direccion IP.\nPara reconectar, reinicie el Sistema.", "Error de Operación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Restart();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("La Impresora Zebra se Desconectó  !!!\nVerifique su correcta alimentación y el cable de comunicación Ethernet.\nVerifique la Direccion IP.\nPara reconectar, reinicie el Sistema.", "Error de Operación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Application.Restart();
                }

            }
        }


        private void SET_ETQ()
        {
            StreamReader Streader;
            byte[] msgbuffer = null;
            try
            {
                listBox1.Items.Clear();//para guardar archivo de etiqueta, no esta visible en pantalla

                String pathEtiqueta = ultimoBotonPresionado.GetProducto().getPathEtiqueta();

               // pathEtiqueta = pathEtiqueta + "\\Etiquetas";
              
                Streader = new StreamReader(pathEtiqueta);
                string line;
                line = Streader.ReadLine();
                char[] anyOf;
                int Index;

                while (Streader.EndOfStream == false)
                {
                    line = Streader.ReadLine();

                    if (line != null)
                    {
                        if (line.Contains("\\^FDCA^FS"))
                        {
                            anyOf = "\\".ToCharArray();//busca CA de Calibre
                            Index = line.IndexOfAny(anyOf, 0);//determina donde está
                            line = line.Remove(Index + 4, 2);

                            String calibre = ultimoBotonPresionadoCalibre != null ? ultimoBotonPresionadoCalibre.Text : "00";

                            line = line.Insert(Index + 4, calibre); //inserta el nuevo  calibre
                        }
                        if (line.Contains("\\^FDDESCRIPCION PRODUCTO^FS"))
                        {
                           
                            anyOf = "\\".ToCharArray();//busca Descrip

                            //ubico ^FB para cambiar el Nro de lineas de 1 a 2
                            Index = line.IndexOfAny(anyOf, 0);

                            //  line = line.Replace("1", "2");
                            line = line.Remove(Index - 8, 1);
                            line = line.Insert(Index - 8, "2");

                            //^FT521,200^A0N,23,26^FB277,1,0,C^FH\^FDDESCRIPCION PRODUCTO^FS

                            Index = line.IndexOfAny(anyOf, 0);//determina donde está

                            line = line.Remove(Index + 4, 20);

                            //   string[] partes = txtDescripcion.Text.Split(new string[] { " CON " }, StringSplitOptions.None);
                            //   string nuevaDescripcion = partes.Length > 1
                            //        ? partes[0] + "\\&" + "CON " + partes[1]  // Usa "\&" para el salto de línea en ZPL
                            //       : txtDescripcion.Text; // Si no hay "CON", usa el texto completo

                            // Reemplazar la línea en el código de impresión

                            //   line = line.Insert(Index + 4, nuevaDescripcion);


                            String calibre = ultimoBotonPresionadoCalibre != null ? ultimoBotonPresionadoCalibre.Text : "00";

                            line = line.Insert(Index + 4, calibre); //inserta el nuevo  calibre


                        }
                        if (line.Contains("\\^FDCONSERVACION^FS"))
                        {
                            anyOf = "\\".ToCharArray();//busca Conservacion
                            Index = line.IndexOfAny(anyOf, 0);//determina donde está
                            line = line.Remove(Index + 4, 12);

                            if (txtConservacion.Text == "1")

                                line = line.Insert(Index + 4, "CONGELADO"); //inserta la conservacion
                            else
                                line = line.Insert(Index + 4, "REFRIGERADO"); //inserta la conservacion
                                                       
                        }
                        if (line.Contains("^FD>:BARRAS"))
                        
                        {
                            anyOf = ">".ToCharArray();//busca codigo de barras
                            Index = line.IndexOfAny(anyOf, 0);//determina donde está
                            line = line.Remove(Index + 2, 6);
                         
                            line = line.Insert(Index + 2, txtCodigo.Text); //inserta codigo de barras
                        }
                        if (line.Contains("\\^FDCODIGO HUMANO^FS"))
                        
                        {
                            anyOf = "\\".ToCharArray();//busca Cod Hum
                            Index = line.IndexOfAny(anyOf, 0);//determina donde está
                            line = line.Remove(Index + 4, 13);
                            line = line.Insert(Index + 4, txtCodigo.Text); //inserta la cod hum
                        }

                        //^FH\^FDSENASA^FS
                        if (line.Contains("\\^FDSENASA^FS"))
                        {
                            anyOf = "\\".ToCharArray();//busca senasa
                            Index = line.IndexOfAny(anyOf, 0);//determina donde está
                            line = line.Remove(Index + 4, 6);

                            string senasa = settings.senasa1 + " " + settings.senasa2 + " " + settings.senasa3;

                            line = line.Insert(Index + 4, senasa); //inserta
                          

                            //
                        }


                        listBox1.Items.Add(line);
                    }
                }//while

                Streader.Close();

                /*
                if (dato1 == false)
                    MessageBox.Show("El Identificador de Dato LOTE es Erroneo en el archivo .PRN", "Error de Diseño");
                if (dato2 == false)
                    MessageBox.Show("El Identificador de Dato OP es Erroneo en el archivo .PRN", "Error de Diseño");
                if (dato3 == false)
                    MessageBox.Show("El Identificador de la Fecha es Erroneo en el archivo .PRN", "Error de Diseño");
                */

                if (sock.Connected)
                {
                    //borrar buffer Z
                    msgbuffer = Encoding.Default.GetBytes("XA/n~JA/n^XZ");
                    sock.Send(msgbuffer, 0, msgbuffer.Length, 0);

                    foreach (string items in listBox1.Items)//envia etq Normal
                    {
                        msgbuffer = Encoding.Default.GetBytes(items);
                        sock.Send(msgbuffer, 0, msgbuffer.Length, 0);
                    }
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("La Impresora Zebra se desconectó\nReiniciar la Aplicación.", "Fallo Anormal", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (respuesta == DialogResult.Cancel)
                        sock.Close();
                    // Application.Restart();
                    //  if (respuesta == DialogResult.OK)
                    //     continue;

                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
              //  MessageBox.Show("La Impresora Zebra se Desconectó  !!!\nVerifique su correcta alimentación y el cable de comunicación Ethernet.\nVerifique la Direccion IP.\nPara reconectar, reinicie el Sistema.", "Error de Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void CargarReporte()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    conexion.Open();

                    string query = @"INSERT INTO Etiquetas_impresas (fecha_hora, id_producto, id_calibre) 
                             VALUES (@fecha_hora, @id_producto, @id_calibre)";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        String calibre = ultimoBotonPresionadoCalibre != null ? ultimoBotonPresionadoCalibre.Text : null;

                        // Asignar valores desde los controles del formulario
                        comando.Parameters.AddWithValue("@fecha_hora", DateTime.Now);
                        comando.Parameters.AddWithValue("@id_producto", txtCodigo.Text);
                        comando.Parameters.AddWithValue("@id_calibre", calibre);
                        comando.Parameters.AddWithValue("@id_pathEtiqueta", textNomEtiqueta.Text);

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la impresión en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMas_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            // Crear una instancia del formulario que deseas abrir
            MasFrm Mas = new MasFrm();

            Mas.ShowDialog(); // Abre como ventana independiente

            InicializarFormulario();
            this.Show();
        }
    }
}
  