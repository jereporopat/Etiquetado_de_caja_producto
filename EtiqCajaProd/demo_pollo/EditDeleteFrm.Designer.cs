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
            this.repeticionLbl = new System.Windows.Forms.Label();
            this.repeticionTb = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Db_pollosDataSet)).BeginInit();
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
            this.datosLb.Size = new System.Drawing.Size(241, 355);
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
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(296, 352);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(118, 44);
            this.cancelarBtn.TabIndex = 14;
            this.cancelarBtn.Text = "CANCELAR";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(446, 352);
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
            this.eliminarBtn.Location = new System.Drawing.Point(723, 352);
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
            this.btnEtiqueta.Location = new System.Drawing.Point(765, 287);
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
            this.textPathEtiqueta.Size = new System.Drawing.Size(315, 57);
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
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(723, 50);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(112, 229);
            this.checkedListBox1.TabIndex = 26;
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
            // EditDeleteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 420);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBox1);
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
            this.Controls.Add(this.cancelarBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Db_pollosDataSet)).EndInit();
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
        private System.Windows.Forms.Label repeticionLbl;
        private System.Windows.Forms.TextBox repeticionTb;
        private System.Windows.Forms.Button cancelarBtn;
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}