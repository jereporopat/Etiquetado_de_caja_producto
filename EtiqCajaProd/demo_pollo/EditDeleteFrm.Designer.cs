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
            this.components = new System.ComponentModel.Container();
            this.EditDeleteLb = new System.Windows.Forms.ListBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Db_pollosDataSet = new demo_pollo._Db_pollosDataSet();
            this.productoTableAdapter = new demo_pollo._Db_pollosDataSetTableAdapters.ProductoTableAdapter();
            this.datosLb = new System.Windows.Forms.ListBox();
            this.codigoProductoLbl = new System.Windows.Forms.Label();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.codigoDeProductoTb = new System.Windows.Forms.TextBox();
            this.descripcionTb = new System.Windows.Forms.TextBox();
            this.plantaLbl = new System.Windows.Forms.Label();
            this.plantaTb = new System.Windows.Forms.TextBox();
            this.tipoProductoGb = new System.Windows.Forms.GroupBox();
            this.chkTipo2 = new System.Windows.Forms.CheckBox();
            this.chkTipo1 = new System.Windows.Forms.CheckBox();
            this.conservacionGb = new System.Windows.Forms.GroupBox();
            this.chkConservacion2 = new System.Windows.Forms.CheckBox();
            this.chkConservacion1 = new System.Windows.Forms.CheckBox();
            this.gradoGb = new System.Windows.Forms.GroupBox();
            this.chkGrado2 = new System.Windows.Forms.CheckBox();
            this.chkGrado1 = new System.Windows.Forms.CheckBox();
            this.repeticionLbl = new System.Windows.Forms.Label();
            this.repeticionTb = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.btnEtiqueta = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textPathEtiqueta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Db_pollosDataSet)).BeginInit();
            this.tipoProductoGb.SuspendLayout();
            this.conservacionGb.SuspendLayout();
            this.gradoGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditDeleteLb
            // 
            this.EditDeleteLb.FormattingEnabled = true;
            this.EditDeleteLb.Location = new System.Drawing.Point(10, 29);
            this.EditDeleteLb.Name = "EditDeleteLb";
            this.EditDeleteLb.Size = new System.Drawing.Size(732, 381);
            this.EditDeleteLb.TabIndex = 0;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this._Db_pollosDataSet;
            // 
            // _Db_pollosDataSet
            // 
            this._Db_pollosDataSet.DataSetName = "_Db_pollosDataSet";
            this._Db_pollosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // datosLb
            // 
            this.datosLb.FormattingEnabled = true;
            this.datosLb.Location = new System.Drawing.Point(24, 41);
            this.datosLb.Name = "datosLb";
            this.datosLb.Size = new System.Drawing.Size(241, 342);
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
            this.descripcionLbl.Location = new System.Drawing.Point(294, 133);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(80, 13);
            this.descripcionLbl.TabIndex = 3;
            this.descripcionLbl.Text = "DESCRIPCION";
            // 
            // codigoDeProductoTb
            // 
            this.codigoDeProductoTb.Location = new System.Drawing.Point(297, 85);
            this.codigoDeProductoTb.Name = "codigoDeProductoTb";
            this.codigoDeProductoTb.Size = new System.Drawing.Size(100, 20);
            this.codigoDeProductoTb.TabIndex = 4;
            // 
            // descripcionTb
            // 
            this.descripcionTb.Location = new System.Drawing.Point(297, 162);
            this.descripcionTb.Name = "descripcionTb";
            this.descripcionTb.Size = new System.Drawing.Size(100, 20);
            this.descripcionTb.TabIndex = 5;
            // 
            // plantaLbl
            // 
            this.plantaLbl.AutoSize = true;
            this.plantaLbl.Location = new System.Drawing.Point(294, 207);
            this.plantaLbl.Name = "plantaLbl";
            this.plantaLbl.Size = new System.Drawing.Size(49, 13);
            this.plantaLbl.TabIndex = 6;
            this.plantaLbl.Text = "PLANTA";
            // 
            // plantaTb
            // 
            this.plantaTb.Location = new System.Drawing.Point(297, 238);
            this.plantaTb.Name = "plantaTb";
            this.plantaTb.Size = new System.Drawing.Size(100, 20);
            this.plantaTb.TabIndex = 7;
            // 
            // tipoProductoGb
            // 
            this.tipoProductoGb.Controls.Add(this.chkTipo2);
            this.tipoProductoGb.Controls.Add(this.chkTipo1);
            this.tipoProductoGb.Location = new System.Drawing.Point(446, 50);
            this.tipoProductoGb.Name = "tipoProductoGb";
            this.tipoProductoGb.Size = new System.Drawing.Size(137, 67);
            this.tipoProductoGb.TabIndex = 9;
            this.tipoProductoGb.TabStop = false;
            this.tipoProductoGb.Text = "TIPO DE PRODUCTO";
            // 
            // chkTipo2
            // 
            this.chkTipo2.AutoSize = true;
            this.chkTipo2.Location = new System.Drawing.Point(16, 42);
            this.chkTipo2.Name = "chkTipo2";
            this.chkTipo2.Size = new System.Drawing.Size(32, 17);
            this.chkTipo2.TabIndex = 1;
            this.chkTipo2.Text = "2";
            this.chkTipo2.UseVisualStyleBackColor = true;
            // 
            // chkTipo1
            // 
            this.chkTipo1.AutoSize = true;
            this.chkTipo1.Location = new System.Drawing.Point(16, 19);
            this.chkTipo1.Name = "chkTipo1";
            this.chkTipo1.Size = new System.Drawing.Size(32, 17);
            this.chkTipo1.TabIndex = 0;
            this.chkTipo1.Text = "1";
            this.chkTipo1.UseVisualStyleBackColor = true;
            // 
            // conservacionGb
            // 
            this.conservacionGb.Controls.Add(this.chkConservacion2);
            this.conservacionGb.Controls.Add(this.chkConservacion1);
            this.conservacionGb.Location = new System.Drawing.Point(446, 133);
            this.conservacionGb.Name = "conservacionGb";
            this.conservacionGb.Size = new System.Drawing.Size(137, 67);
            this.conservacionGb.TabIndex = 10;
            this.conservacionGb.TabStop = false;
            this.conservacionGb.Text = "CONSERVACION";
            // 
            // chkConservacion2
            // 
            this.chkConservacion2.AutoSize = true;
            this.chkConservacion2.Location = new System.Drawing.Point(16, 42);
            this.chkConservacion2.Name = "chkConservacion2";
            this.chkConservacion2.Size = new System.Drawing.Size(32, 17);
            this.chkConservacion2.TabIndex = 1;
            this.chkConservacion2.Text = "2";
            this.chkConservacion2.UseVisualStyleBackColor = true;
            // 
            // chkConservacion1
            // 
            this.chkConservacion1.AutoSize = true;
            this.chkConservacion1.Location = new System.Drawing.Point(16, 19);
            this.chkConservacion1.Name = "chkConservacion1";
            this.chkConservacion1.Size = new System.Drawing.Size(32, 17);
            this.chkConservacion1.TabIndex = 0;
            this.chkConservacion1.Text = "1";
            this.chkConservacion1.UseVisualStyleBackColor = true;
            // 
            // gradoGb
            // 
            this.gradoGb.Controls.Add(this.chkGrado2);
            this.gradoGb.Controls.Add(this.chkGrado1);
            this.gradoGb.Location = new System.Drawing.Point(446, 220);
            this.gradoGb.Name = "gradoGb";
            this.gradoGb.Size = new System.Drawing.Size(137, 67);
            this.gradoGb.TabIndex = 11;
            this.gradoGb.TabStop = false;
            this.gradoGb.Text = "GRADO";
            // 
            // chkGrado2
            // 
            this.chkGrado2.AutoSize = true;
            this.chkGrado2.Location = new System.Drawing.Point(16, 42);
            this.chkGrado2.Name = "chkGrado2";
            this.chkGrado2.Size = new System.Drawing.Size(32, 17);
            this.chkGrado2.TabIndex = 1;
            this.chkGrado2.Text = "2";
            this.chkGrado2.UseVisualStyleBackColor = true;
            // 
            // chkGrado1
            // 
            this.chkGrado1.AutoSize = true;
            this.chkGrado1.Location = new System.Drawing.Point(16, 19);
            this.chkGrado1.Name = "chkGrado1";
            this.chkGrado1.Size = new System.Drawing.Size(32, 17);
            this.chkGrado1.TabIndex = 0;
            this.chkGrado1.Text = "1";
            this.chkGrado1.UseVisualStyleBackColor = true;
            // 
            // repeticionLbl
            // 
            this.repeticionLbl.AutoSize = true;
            this.repeticionLbl.Location = new System.Drawing.Point(612, 50);
            this.repeticionLbl.Name = "repeticionLbl";
            this.repeticionLbl.Size = new System.Drawing.Size(72, 13);
            this.repeticionLbl.TabIndex = 12;
            this.repeticionLbl.Text = "REPETICION";
            // 
            // repeticionTb
            // 
            this.repeticionTb.Location = new System.Drawing.Point(614, 78);
            this.repeticionTb.Name = "repeticionTb";
            this.repeticionTb.Size = new System.Drawing.Size(100, 20);
            this.repeticionTb.TabIndex = 13;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(296, 338);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(118, 44);
            this.cancelarBtn.TabIndex = 14;
            this.cancelarBtn.Text = "CANCELAR";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(446, 338);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(119, 44);
            this.guardarBtn.TabIndex = 15;
            this.guardarBtn.Text = "GUARDAR";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.Color.Red;
            this.eliminarBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.eliminarBtn.Location = new System.Drawing.Point(611, 338);
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
            this.btnEtiqueta.Location = new System.Drawing.Point(614, 133);
            this.btnEtiqueta.Margin = new System.Windows.Forms.Padding(2);
            this.btnEtiqueta.Name = "btnEtiqueta";
            this.btnEtiqueta.Size = new System.Drawing.Size(69, 30);
            this.btnEtiqueta.TabIndex = 17;
            this.btnEtiqueta.Text = "ETIQUETA";
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
            this.textPathEtiqueta.Location = new System.Drawing.Point(614, 176);
            this.textPathEtiqueta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPathEtiqueta.Multiline = true;
            this.textPathEtiqueta.Name = "textPathEtiqueta";
            this.textPathEtiqueta.ReadOnly = true;
            this.textPathEtiqueta.Size = new System.Drawing.Size(110, 112);
            this.textPathEtiqueta.TabIndex = 19;
            // 
            // EditDeleteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 420);
            this.Controls.Add(this.textPathEtiqueta);
            this.Controls.Add(this.btnEtiqueta);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.repeticionTb);
            this.Controls.Add(this.repeticionLbl);
            this.Controls.Add(this.gradoGb);
            this.Controls.Add(this.conservacionGb);
            this.Controls.Add(this.tipoProductoGb);
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
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Db_pollosDataSet)).EndInit();
            this.tipoProductoGb.ResumeLayout(false);
            this.tipoProductoGb.PerformLayout();
            this.conservacionGb.ResumeLayout(false);
            this.conservacionGb.PerformLayout();
            this.gradoGb.ResumeLayout(false);
            this.gradoGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EditDeleteLb;
        private _Db_pollosDataSet _Db_pollosDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private _Db_pollosDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.ListBox datosLb;
        private System.Windows.Forms.Label codigoProductoLbl;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.TextBox codigoDeProductoTb;
        private System.Windows.Forms.TextBox descripcionTb;
        private System.Windows.Forms.Label plantaLbl;
        private System.Windows.Forms.TextBox plantaTb;
        private System.Windows.Forms.GroupBox tipoProductoGb;
        private System.Windows.Forms.CheckBox chkTipo2;
        private System.Windows.Forms.CheckBox chkTipo1;
        private System.Windows.Forms.GroupBox conservacionGb;
        private System.Windows.Forms.CheckBox chkConservacion2;
        private System.Windows.Forms.CheckBox chkConservacion1;
        private System.Windows.Forms.GroupBox gradoGb;
        private System.Windows.Forms.CheckBox chkGrado2;
        private System.Windows.Forms.CheckBox chkGrado1;
        private System.Windows.Forms.Label repeticionLbl;
        private System.Windows.Forms.TextBox repeticionTb;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button btnEtiqueta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textPathEtiqueta;
    }
}