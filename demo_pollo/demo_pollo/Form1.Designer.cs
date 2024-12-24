namespace demo_pollo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtRepeticion = new System.Windows.Forms.TextBox();
            this.txtCalibre = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtConservacion = new System.Windows.Forms.TextBox();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPlanta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbNumpad = new System.Windows.Forms.GroupBox();
            this.btnPadCero = new System.Windows.Forms.Button();
            this.btnPadNueve = new System.Windows.Forms.Button();
            this.btnPadOcho = new System.Windows.Forms.Button();
            this.btnPadSiete = new System.Windows.Forms.Button();
            this.btnPadSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Etiqueta = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnDiez = new System.Windows.Forms.Button();
            this.btnOnce = new System.Windows.Forms.Button();
            this.gbCalibre = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbNumpad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Etiqueta.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCalibre.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigoProducto);
            this.groupBox1.Controls.Add(this.gbNumpad);
            this.groupBox1.Controls.Add(this.listBoxItems);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo de producto";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(137, 31);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(45, 20);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.Click += new System.EventHandler(this.txtCodigoProducto_Click);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(7, 71);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(175, 173);
            this.listBoxItems.TabIndex = 0;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(35, 424);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Mas...";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImprimir.Location = new System.Drawing.Point(773, 478);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(196, 66);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCodigo);
            this.groupBox3.Controls.Add(this.txtRepeticion);
            this.groupBox3.Controls.Add(this.txtCalibre);
            this.groupBox3.Controls.Add(this.txtGrado);
            this.groupBox3.Controls.Add(this.txtConservacion);
            this.groupBox3.Controls.Add(this.txtTipoProducto);
            this.groupBox3.Controls.Add(this.txtProducto);
            this.groupBox3.Controls.Add(this.txtPlanta);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(473, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 396);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(131, 267);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // txtRepeticion
            // 
            this.txtRepeticion.Location = new System.Drawing.Point(131, 234);
            this.txtRepeticion.Name = "txtRepeticion";
            this.txtRepeticion.ReadOnly = true;
            this.txtRepeticion.Size = new System.Drawing.Size(100, 20);
            this.txtRepeticion.TabIndex = 14;
            // 
            // txtCalibre
            // 
            this.txtCalibre.Location = new System.Drawing.Point(131, 202);
            this.txtCalibre.Name = "txtCalibre";
            this.txtCalibre.ReadOnly = true;
            this.txtCalibre.Size = new System.Drawing.Size(100, 20);
            this.txtCalibre.TabIndex = 13;
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(131, 167);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.ReadOnly = true;
            this.txtGrado.Size = new System.Drawing.Size(100, 20);
            this.txtGrado.TabIndex = 12;
            // 
            // txtConservacion
            // 
            this.txtConservacion.Location = new System.Drawing.Point(131, 135);
            this.txtConservacion.Name = "txtConservacion";
            this.txtConservacion.ReadOnly = true;
            this.txtConservacion.Size = new System.Drawing.Size(100, 20);
            this.txtConservacion.TabIndex = 11;
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Location = new System.Drawing.Point(131, 101);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.ReadOnly = true;
            this.txtTipoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtTipoProducto.TabIndex = 10;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(131, 68);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 9;
            // 
            // txtPlanta
            // 
            this.txtPlanta.Location = new System.Drawing.Point(131, 38);
            this.txtPlanta.Name = "txtPlanta";
            this.txtPlanta.ReadOnly = true;
            this.txtPlanta.Size = new System.Drawing.Size(100, 20);
            this.txtPlanta.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "CODIGO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "REPETICION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "CALIBRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "GRADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "CONSERVACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "TIPO DE PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PLANTA";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "ArchivosPRN|*.PRN";
            // 
            // gbNumpad
            // 
            this.gbNumpad.Controls.Add(this.btnPadCero);
            this.gbNumpad.Controls.Add(this.btnPadNueve);
            this.gbNumpad.Controls.Add(this.btnPadOcho);
            this.gbNumpad.Controls.Add(this.btnPadSiete);
            this.gbNumpad.Controls.Add(this.btnPadSeis);
            this.gbNumpad.Controls.Add(this.btnCinco);
            this.gbNumpad.Controls.Add(this.btnCuatro);
            this.gbNumpad.Controls.Add(this.btnTres);
            this.gbNumpad.Controls.Add(this.btnDos);
            this.gbNumpad.Controls.Add(this.btnUno);
            this.gbNumpad.Location = new System.Drawing.Point(188, 54);
            this.gbNumpad.Name = "gbNumpad";
            this.gbNumpad.Size = new System.Drawing.Size(203, 133);
            this.gbNumpad.TabIndex = 7;
            this.gbNumpad.TabStop = false;
            this.gbNumpad.Text = "NumPad";
            this.gbNumpad.Visible = false;
            // 
            // btnPadCero
            // 
            this.btnPadCero.Location = new System.Drawing.Point(73, 104);
            this.btnPadCero.Name = "btnPadCero";
            this.btnPadCero.Size = new System.Drawing.Size(62, 23);
            this.btnPadCero.TabIndex = 9;
            this.btnPadCero.Text = "00";
            this.btnPadCero.UseVisualStyleBackColor = true;
            this.btnPadCero.Click += new System.EventHandler(this.btnNumpad_Click);
            // 
            // btnPadNueve
            // 
            this.btnPadNueve.Location = new System.Drawing.Point(141, 77);
            this.btnPadNueve.Name = "btnPadNueve";
            this.btnPadNueve.Size = new System.Drawing.Size(62, 23);
            this.btnPadNueve.TabIndex = 8;
            this.btnPadNueve.Text = "09";
            this.btnPadNueve.UseVisualStyleBackColor = true;
            this.btnPadNueve.Click += new System.EventHandler(this.btnNumpad_Click);
            // 
            // btnPadOcho
            // 
            this.btnPadOcho.Location = new System.Drawing.Point(73, 77);
            this.btnPadOcho.Name = "btnPadOcho";
            this.btnPadOcho.Size = new System.Drawing.Size(62, 23);
            this.btnPadOcho.TabIndex = 7;
            this.btnPadOcho.Text = "08";
            this.btnPadOcho.UseVisualStyleBackColor = true;
            this.btnPadOcho.Click += new System.EventHandler(this.btnNumpad_Click);
            // 
            // btnPadSiete
            // 
            this.btnPadSiete.Location = new System.Drawing.Point(6, 77);
            this.btnPadSiete.Name = "btnPadSiete";
            this.btnPadSiete.Size = new System.Drawing.Size(62, 23);
            this.btnPadSiete.TabIndex = 6;
            this.btnPadSiete.Text = "07";
            this.btnPadSiete.UseVisualStyleBackColor = true;
            this.btnPadSiete.Click += new System.EventHandler(this.btnNumpad_Click);
            // 
            // btnPadSeis
            // 
            this.btnPadSeis.Location = new System.Drawing.Point(141, 48);
            this.btnPadSeis.Name = "btnPadSeis";
            this.btnPadSeis.Size = new System.Drawing.Size(62, 23);
            this.btnPadSeis.TabIndex = 5;
            this.btnPadSeis.Text = "06";
            this.btnPadSeis.UseVisualStyleBackColor = true;
            this.btnPadSeis.Click += new System.EventHandler(this.btnNumpad_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(74, 48);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(61, 23);
            this.btnCinco.TabIndex = 4;
            this.btnCinco.Text = "05";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnNumpad_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(6, 48);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(62, 23);
            this.btnCuatro.TabIndex = 3;
            this.btnCuatro.Text = "04";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnNumpad_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(141, 19);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(62, 23);
            this.btnTres.TabIndex = 2;
            this.btnTres.Text = "03";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnNumpad_Click);
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(73, 19);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(62, 23);
            this.btnDos.TabIndex = 1;
            this.btnDos.Text = "02";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnNumpad_Click);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(6, 19);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(62, 23);
            this.btnUno.TabIndex = 0;
            this.btnUno.Text = "01";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnNumpad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::demo_pollo.Properties.Resources.LogoSC;
            this.pictureBox1.Image = global::demo_pollo.Properties.Resources.LogoSC;
            this.pictureBox1.InitialImage = global::demo_pollo.Properties.Resources.LogoSC;
            this.pictureBox1.Location = new System.Drawing.Point(5, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Etiqueta
            // 
            this.Etiqueta.Controls.Add(this.lblNombreArchivo);
            this.Etiqueta.Controls.Add(this.btnExaminar);
            this.Etiqueta.Location = new System.Drawing.Point(247, 424);
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Size = new System.Drawing.Size(270, 102);
            this.Etiqueta.TabIndex = 0;
            this.Etiqueta.TabStop = false;
            this.Etiqueta.Text = "Etiqueta";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(187, 75);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 0;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Location = new System.Drawing.Point(51, 38);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(153, 13);
            this.lblNombreArchivo.TabIndex = 1;
            this.lblNombreArchivo.Text = "Antonio-Notebook\\San Andrés";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.50117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.49883F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbCalibre, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(241, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.03694F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 414);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnSeis
            // 
            this.btnSeis.AutoSize = true;
            this.btnSeis.Location = new System.Drawing.Point(32, 28);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(120, 77);
            this.btnSeis.TabIndex = 0;
            this.btnSeis.Text = "06";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnCalibre_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(158, 28);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(120, 77);
            this.btnSiete.TabIndex = 1;
            this.btnSiete.Text = "07";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnCalibre_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Location = new System.Drawing.Point(32, 111);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(120, 77);
            this.btnOcho.TabIndex = 2;
            this.btnOcho.Text = "08";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnCalibre_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(158, 111);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(120, 77);
            this.btnNueve.TabIndex = 3;
            this.btnNueve.Text = "09";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnCalibre_Click);
            // 
            // btnDiez
            // 
            this.btnDiez.Location = new System.Drawing.Point(32, 194);
            this.btnDiez.Name = "btnDiez";
            this.btnDiez.Size = new System.Drawing.Size(120, 77);
            this.btnDiez.TabIndex = 4;
            this.btnDiez.Text = "10";
            this.btnDiez.UseVisualStyleBackColor = true;
            this.btnDiez.Click += new System.EventHandler(this.btnCalibre_Click);
            // 
            // btnOnce
            // 
            this.btnOnce.Location = new System.Drawing.Point(158, 194);
            this.btnOnce.Name = "btnOnce";
            this.btnOnce.Size = new System.Drawing.Size(120, 77);
            this.btnOnce.TabIndex = 5;
            this.btnOnce.Text = "11";
            this.btnOnce.UseVisualStyleBackColor = true;
            this.btnOnce.Click += new System.EventHandler(this.btnCalibre_Click);
            // 
            // gbCalibre
            // 
            this.gbCalibre.Controls.Add(this.btnOnce);
            this.gbCalibre.Controls.Add(this.btnDiez);
            this.gbCalibre.Controls.Add(this.btnNueve);
            this.gbCalibre.Controls.Add(this.btnOcho);
            this.gbCalibre.Controls.Add(this.btnSiete);
            this.gbCalibre.Controls.Add(this.btnSeis);
            this.gbCalibre.Location = new System.Drawing.Point(3, 3);
            this.gbCalibre.Name = "gbCalibre";
            this.gbCalibre.Size = new System.Drawing.Size(407, 317);
            this.gbCalibre.TabIndex = 2;
            this.gbCalibre.TabStop = false;
            this.gbCalibre.Text = "Calibre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(971, 556);
            this.Controls.Add(this.Etiqueta);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Control de etiquetado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btnNumpad_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbNumpad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Etiqueta.ResumeLayout(false);
            this.Etiqueta.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbCalibre.ResumeLayout(false);
            this.gbCalibre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtRepeticion;
        private System.Windows.Forms.TextBox txtCalibre;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtConservacion;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPlanta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.GroupBox gbNumpad;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPadSiete;
        private System.Windows.Forms.Button btnPadSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnPadCero;
        private System.Windows.Forms.Button btnPadNueve;
        private System.Windows.Forms.Button btnPadOcho;
        private System.Windows.Forms.GroupBox Etiqueta;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnDiez;
        private System.Windows.Forms.Button btnOnce;
        private System.Windows.Forms.GroupBox gbCalibre;
    }
}

