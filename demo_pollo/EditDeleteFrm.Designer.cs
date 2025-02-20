namespace demo_pollo
{
    partial class EditDeleteFrm
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
            this.EditDeleteLb = new System.Windows.Forms.ListBox();
            this.datosLb = new System.Windows.Forms.ListBox();
            this.codigoProductoLbl = new System.Windows.Forms.Label();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.codigoDeProductoTb = new System.Windows.Forms.TextBox();
            this.descripcionTb = new System.Windows.Forms.TextBox();
            this.plantaLbl = new System.Windows.Forms.Label();
            this.plantaTb = new System.Windows.Forms.TextBox();
            this.repeticionLbl = new System.Windows.Forms.Label();
            this.repeticionTb = new System.Windows.Forms.TextBox();
            this.salirBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.btnEtiqueta = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textPathEtiqueta = new System.Windows.Forms.TextBox();
            this.tipoProductoCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conservacionCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gradoCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calibresLb = new System.Windows.Forms.ListBox();
            this.removerBtn = new System.Windows.Forms.Button();
            this.agregarCalibreBtn = new System.Windows.Forms.Button();
            this.agregarProductoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditDeleteLb
            // 
            this.EditDeleteLb.FormattingEnabled = true;
            this.EditDeleteLb.Location = new System.Drawing.Point(10, 29);
            this.EditDeleteLb.Name = "EditDeleteLb";
            this.EditDeleteLb.Size = new System.Drawing.Size(853, 381);
            this.EditDeleteLb.TabIndex = 0;
            // 
            // datosLb
            // 
            this.datosLb.FormattingEnabled = true;
            this.datosLb.Location = new System.Drawing.Point(24, 41);
            this.datosLb.Name = "datosLb";
            this.datosLb.Size = new System.Drawing.Size(241, 251);
            this.datosLb.Sorted = true;
            this.datosLb.TabIndex = 1;
            this.datosLb.SelectedIndexChanged += new System.EventHandler(this.DatosLb_SelectedIndexChanged);
            // 
            // codigoProductoLbl
            // 
            this.codigoProductoLbl.AutoSize = true;
            this.codigoProductoLbl.Location = new System.Drawing.Point(294, 50);
            this.codigoProductoLbl.Name = "codigoProductoLbl";
            this.codigoProductoLbl.Size = new System.Drawing.Size(131, 13);
            this.codigoProductoLbl.TabIndex = 2;
            this.codigoProductoLbl.Text = "CODIGO DE PRODUCTO";
            // 
            // descripcionLbl
            // 
            this.descripcionLbl.AutoSize = true;
            this.descripcionLbl.Location = new System.Drawing.Point(294, 85);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(80, 13);
            this.descripcionLbl.TabIndex = 3;
            this.descripcionLbl.Text = "DESCRIPCION";
            // 
            // codigoDeProductoTb
            // 
            this.codigoDeProductoTb.Location = new System.Drawing.Point(444, 50);
            this.codigoDeProductoTb.Name = "codigoDeProductoTb";
            this.codigoDeProductoTb.Size = new System.Drawing.Size(100, 20);
            this.codigoDeProductoTb.TabIndex = 4;
            // 
            // descripcionTb
            // 
            this.descripcionTb.Location = new System.Drawing.Point(444, 85);
            this.descripcionTb.Name = "descripcionTb";
            this.descripcionTb.Size = new System.Drawing.Size(100, 20);
            this.descripcionTb.TabIndex = 5;
            // 
            // plantaLbl
            // 
            this.plantaLbl.AutoSize = true;
            this.plantaLbl.Location = new System.Drawing.Point(293, 151);
            this.plantaLbl.Name = "plantaLbl";
            this.plantaLbl.Size = new System.Drawing.Size(49, 13);
            this.plantaLbl.TabIndex = 6;
            this.plantaLbl.Text = "PLANTA";
            // 
            // plantaTb
            // 
            this.plantaTb.Location = new System.Drawing.Point(444, 151);
            this.plantaTb.Name = "plantaTb";
            this.plantaTb.Size = new System.Drawing.Size(100, 20);
            this.plantaTb.TabIndex = 7;
            // 
            // repeticionLbl
            // 
            this.repeticionLbl.AutoSize = true;
            this.repeticionLbl.Location = new System.Drawing.Point(293, 120);
            this.repeticionLbl.Name = "repeticionLbl";
            this.repeticionLbl.Size = new System.Drawing.Size(72, 13);
            this.repeticionLbl.TabIndex = 12;
            this.repeticionLbl.Text = "REPETICION";
            // 
            // repeticionTb
            // 
            this.repeticionTb.Location = new System.Drawing.Point(444, 120);
            this.repeticionTb.Name = "repeticionTb";
            this.repeticionTb.Size = new System.Drawing.Size(100, 20);
            this.repeticionTb.TabIndex = 13;
            // 
            // salirBtn
            // 
            this.salirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirBtn.Location = new System.Drawing.Point(730, 352);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(118, 44);
            this.salirBtn.TabIndex = 14;
            this.salirBtn.Text = "SALIR";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(598, 352);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(119, 44);
            this.guardarBtn.TabIndex = 15;
            this.guardarBtn.Text = "GUARDAR";
            this.guardarBtn.UseVisualStyleBackColor = false;
            this.guardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.Color.Red;
            this.eliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.eliminarBtn.Location = new System.Drawing.Point(153, 300);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(112, 44);
            this.eliminarBtn.TabIndex = 16;
            this.eliminarBtn.Text = "DESHABILITAR";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            this.eliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // btnEtiqueta
            // 
            this.btnEtiqueta.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEtiqueta.Location = new System.Drawing.Point(778, 287);
            this.btnEtiqueta.Margin = new System.Windows.Forms.Padding(2);
            this.btnEtiqueta.Name = "btnEtiqueta";
            this.btnEtiqueta.Size = new System.Drawing.Size(70, 57);
            this.btnEtiqueta.TabIndex = 17;
            this.btnEtiqueta.Text = "BUSCAR ETIQUETA";
            this.btnEtiqueta.UseVisualStyleBackColor = false;
            this.btnEtiqueta.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textPathEtiqueta
            // 
            this.textPathEtiqueta.AllowDrop = true;
            this.textPathEtiqueta.Location = new System.Drawing.Point(444, 287);
            this.textPathEtiqueta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPathEtiqueta.Multiline = true;
            this.textPathEtiqueta.Name = "textPathEtiqueta";
            this.textPathEtiqueta.ReadOnly = true;
            this.textPathEtiqueta.Size = new System.Drawing.Size(328, 57);
            this.textPathEtiqueta.TabIndex = 19;
            // 
            // tipoProductoCb
            // 
            this.tipoProductoCb.FormattingEnabled = true;
            this.tipoProductoCb.Location = new System.Drawing.Point(444, 177);
            this.tipoProductoCb.Name = "tipoProductoCb";
            this.tipoProductoCb.Size = new System.Drawing.Size(121, 21);
            this.tipoProductoCb.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "TIPO DE PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "CONSERVACION";
            // 
            // conservacionCb
            // 
            this.conservacionCb.FormattingEnabled = true;
            this.conservacionCb.Location = new System.Drawing.Point(444, 211);
            this.conservacionCb.Name = "conservacionCb";
            this.conservacionCb.Size = new System.Drawing.Size(121, 21);
            this.conservacionCb.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "GRADO";
            // 
            // gradoCb
            // 
            this.gradoCb.FormattingEnabled = true;
            this.gradoCb.Location = new System.Drawing.Point(444, 249);
            this.gradoCb.Name = "gradoCb";
            this.gradoCb.Size = new System.Drawing.Size(121, 21);
            this.gradoCb.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "RUTA ETIQUETA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "CALIBRES";
            // 
            // calibresLb
            // 
            this.calibresLb.FormattingEnabled = true;
            this.calibresLb.Location = new System.Drawing.Point(723, 50);
            this.calibresLb.Name = "calibresLb";
            this.calibresLb.Size = new System.Drawing.Size(125, 108);
            this.calibresLb.TabIndex = 29;
            // 
            // removerBtn
            // 
            this.removerBtn.Location = new System.Drawing.Point(723, 164);
            this.removerBtn.Name = "removerBtn";
            this.removerBtn.Size = new System.Drawing.Size(125, 28);
            this.removerBtn.TabIndex = 30;
            this.removerBtn.Text = "REMOVER";
            this.removerBtn.UseVisualStyleBackColor = true;
            this.removerBtn.Click += new System.EventHandler(this.removerCalibreBtn_Click);
            // 
            // agregarCalibreBtn
            // 
            this.agregarCalibreBtn.Location = new System.Drawing.Point(723, 197);
            this.agregarCalibreBtn.Name = "agregarCalibreBtn";
            this.agregarCalibreBtn.Size = new System.Drawing.Size(125, 28);
            this.agregarCalibreBtn.TabIndex = 31;
            this.agregarCalibreBtn.Text = "AGREGAR";
            this.agregarCalibreBtn.UseVisualStyleBackColor = true;
            this.agregarCalibreBtn.Click += new System.EventHandler(this.agregarCalibreBtn_Click);
            // 
            // agregarProductoBtn
            // 
            this.agregarProductoBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.agregarProductoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarProductoBtn.Location = new System.Drawing.Point(24, 300);
            this.agregarProductoBtn.Name = "agregarProductoBtn";
            this.agregarProductoBtn.Size = new System.Drawing.Size(112, 44);
            this.agregarProductoBtn.TabIndex = 32;
            this.agregarProductoBtn.Text = "NUEVO";
            this.agregarProductoBtn.UseVisualStyleBackColor = false;
            this.agregarProductoBtn.Click += new System.EventHandler(this.agregarProductoBtn_Click);
            // 
            // EditDeleteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 420);
            this.Controls.Add(this.agregarProductoBtn);
            this.Controls.Add(this.agregarCalibreBtn);
            this.Controls.Add(this.removerBtn);
            this.Controls.Add(this.calibresLb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gradoCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.conservacionCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoProductoCb);
            this.Controls.Add(this.textPathEtiqueta);
            this.Controls.Add(this.btnEtiqueta);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.repeticionTb);
            this.Controls.Add(this.repeticionLbl);
            this.Controls.Add(this.plantaTb);
            this.Controls.Add(this.plantaLbl);
            this.Controls.Add(this.descripcionTb);
            this.Controls.Add(this.codigoDeProductoTb);
            this.Controls.Add(this.descripcionLbl);
            this.Controls.Add(this.codigoProductoLbl);
            this.Controls.Add(this.datosLb);
            this.Controls.Add(this.EditDeleteLb);
            this.Name = "EditDeleteFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar / Deshabilitar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EditDeleteLb;
        private System.Windows.Forms.ListBox datosLb;
        private System.Windows.Forms.Label codigoProductoLbl;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.TextBox codigoDeProductoTb;
        private System.Windows.Forms.TextBox descripcionTb;
        private System.Windows.Forms.Label plantaLbl;
        private System.Windows.Forms.TextBox plantaTb;
        private System.Windows.Forms.Label repeticionLbl;
        private System.Windows.Forms.TextBox repeticionTb;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button btnEtiqueta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textPathEtiqueta;
        private System.Windows.Forms.ComboBox tipoProductoCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox conservacionCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox gradoCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox calibresLb;
        private System.Windows.Forms.Button removerBtn;
        private System.Windows.Forms.Button agregarCalibreBtn;
        private System.Windows.Forms.Button agregarProductoBtn;
    }
}