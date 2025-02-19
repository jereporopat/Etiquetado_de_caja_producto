namespace demo_pollo
{
    partial class AltaProductoFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPlanta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRepeticion = new System.Windows.Forms.TextBox();
            this.crearProductoBtn = new System.Windows.Forms.Button();
            this.grpConservacion = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.grpGrado = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.grpTipoProducto = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.btnSelEtq = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textPathEtiqueta = new System.Windows.Forms.TextBox();
            this.grpConservacion.SuspendLayout();
            this.grpGrado.SuspendLayout();
            this.grpTipoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCRIPCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO DE PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLANTA";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(23, 73);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(197, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(24, 137);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(77, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtPlanta
            // 
            this.txtPlanta.Location = new System.Drawing.Point(23, 198);
            this.txtPlanta.Name = "txtPlanta";
            this.txtPlanta.Size = new System.Drawing.Size(77, 20);
            this.txtPlanta.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "REPETICION";
            // 
            // txtRepeticion
            // 
            this.txtRepeticion.Location = new System.Drawing.Point(23, 259);
            this.txtRepeticion.Name = "txtRepeticion";
            this.txtRepeticion.Size = new System.Drawing.Size(77, 20);
            this.txtRepeticion.TabIndex = 13;
            // 
            // crearProductoBtn
            // 
            this.crearProductoBtn.Location = new System.Drawing.Point(395, 375);
            this.crearProductoBtn.Name = "crearProductoBtn";
            this.crearProductoBtn.Size = new System.Drawing.Size(71, 35);
            this.crearProductoBtn.TabIndex = 14;
            this.crearProductoBtn.Text = "CREAR";
            this.crearProductoBtn.UseVisualStyleBackColor = true;
            this.crearProductoBtn.Click += new System.EventHandler(this.CrearProductoBtn_Click);
            // 
            // grpConservacion
            // 
            this.grpConservacion.Controls.Add(this.radioButton4);
            this.grpConservacion.Controls.Add(this.radioButton3);
            this.grpConservacion.Location = new System.Drawing.Point(297, 55);
            this.grpConservacion.Name = "grpConservacion";
            this.grpConservacion.Size = new System.Drawing.Size(169, 71);
            this.grpConservacion.TabIndex = 15;
            this.grpConservacion.TabStop = false;
            this.grpConservacion.Text = "CONSERVACION";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(8, 39);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 21;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "2";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 18);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // grpGrado
            // 
            this.grpGrado.Controls.Add(this.radioButton1);
            this.grpGrado.Controls.Add(this.radioButton2);
            this.grpGrado.Location = new System.Drawing.Point(297, 137);
            this.grpGrado.Name = "grpGrado";
            this.grpGrado.Size = new System.Drawing.Size(169, 71);
            this.grpGrado.TabIndex = 16;
            this.grpGrado.TabStop = false;
            this.grpGrado.Text = "GRADO";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 22);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 43);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // grpTipoProducto
            // 
            this.grpTipoProducto.Controls.Add(this.radioButton6);
            this.grpTipoProducto.Controls.Add(this.radioButton5);
            this.grpTipoProducto.Location = new System.Drawing.Point(297, 220);
            this.grpTipoProducto.Name = "grpTipoProducto";
            this.grpTipoProducto.Size = new System.Drawing.Size(169, 71);
            this.grpTipoProducto.TabIndex = 17;
            this.grpTipoProducto.TabStop = false;
            this.grpTipoProducto.Text = "TIPO DE PRODUCTO";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(8, 39);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(31, 17);
            this.radioButton6.TabIndex = 21;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "2";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(8, 18);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 20;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "1";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "INGRESE LOS DATOS DEL PRODUCTO";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.Red;
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarBtn.Location = new System.Drawing.Point(297, 375);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(71, 35);
            this.cancelarBtn.TabIndex = 19;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelEtq
            // 
            this.btnSelEtq.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSelEtq.Location = new System.Drawing.Point(23, 303);
            this.btnSelEtq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelEtq.Name = "btnSelEtq";
            this.btnSelEtq.Size = new System.Drawing.Size(130, 30);
            this.btnSelEtq.TabIndex = 22;
            this.btnSelEtq.Text = "BUSCAR ETIQUETA";
            this.btnSelEtq.UseVisualStyleBackColor = false;
            this.btnSelEtq.Click += new System.EventHandler(this.bunSelEtq_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textPathEtiqueta
            // 
            this.textPathEtiqueta.AllowDrop = true;
            this.textPathEtiqueta.Location = new System.Drawing.Point(23, 340);
            this.textPathEtiqueta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPathEtiqueta.Multiline = true;
            this.textPathEtiqueta.Name = "textPathEtiqueta";
            this.textPathEtiqueta.ReadOnly = true;
            this.textPathEtiqueta.Size = new System.Drawing.Size(197, 70);
            this.textPathEtiqueta.TabIndex = 23;
            // 
            // AltaProductoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 446);
            this.Controls.Add(this.textPathEtiqueta);
            this.Controls.Add(this.btnSelEtq);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpTipoProducto);
            this.Controls.Add(this.grpGrado);
            this.Controls.Add(this.grpConservacion);
            this.Controls.Add(this.crearProductoBtn);
            this.Controls.Add(this.txtRepeticion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPlanta);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaProductoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de productos";
            this.grpConservacion.ResumeLayout(false);
            this.grpConservacion.PerformLayout();
            this.grpGrado.ResumeLayout(false);
            this.grpGrado.PerformLayout();
            this.grpTipoProducto.ResumeLayout(false);
            this.grpTipoProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPlanta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRepeticion;
        private System.Windows.Forms.Button crearProductoBtn;
        private System.Windows.Forms.GroupBox grpConservacion;
        private System.Windows.Forms.GroupBox grpGrado;
        private System.Windows.Forms.GroupBox grpTipoProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button btnSelEtq;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textPathEtiqueta;
    }
}