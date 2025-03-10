namespace demo_pollo
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etiquetasimpresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Db_pollosDataSet = new demo_pollo._Db_pollosDataSet();
            this.etiquetas_impresasTableAdapter = new demo_pollo._Db_pollosDataSetTableAdapters.Etiquetas_impresasTableAdapter();
            this.fechahoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calibreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_etq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasimpresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Db_pollosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechahoraDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.calibreDataGridViewTextBoxColumn,
            this.nom_etq});
            this.dataGridView1.DataSource = this.etiquetasimpresasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(411, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // etiquetasimpresasBindingSource
            // 
            this.etiquetasimpresasBindingSource.DataMember = "Etiquetas_impresas";
            this.etiquetasimpresasBindingSource.DataSource = this._Db_pollosDataSet;
            // 
            // _Db_pollosDataSet
            // 
            this._Db_pollosDataSet.DataSetName = "_Db_pollosDataSet";
            this._Db_pollosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etiquetas_impresasTableAdapter
            // 
            this.etiquetas_impresasTableAdapter.ClearBeforeFill = true;
            // 
            // fechahoraDataGridViewTextBoxColumn
            // 
            this.fechahoraDataGridViewTextBoxColumn.DataPropertyName = "fecha_hora";
            this.fechahoraDataGridViewTextBoxColumn.HeaderText = "FECHA / HORA";
            this.fechahoraDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.fechahoraDataGridViewTextBoxColumn.Name = "fechahoraDataGridViewTextBoxColumn";
            this.fechahoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechahoraDataGridViewTextBoxColumn.Width = 120;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "CÓDIGO";
            this.productoDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoDataGridViewTextBoxColumn.Width = 55;
            // 
            // calibreDataGridViewTextBoxColumn
            // 
            this.calibreDataGridViewTextBoxColumn.DataPropertyName = "calibre";
            this.calibreDataGridViewTextBoxColumn.HeaderText = "CALIBRE";
            this.calibreDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.calibreDataGridViewTextBoxColumn.Name = "calibreDataGridViewTextBoxColumn";
            this.calibreDataGridViewTextBoxColumn.ReadOnly = true;
            this.calibreDataGridViewTextBoxColumn.Width = 70;
            // 
            // nom_etq
            // 
            this.nom_etq.DataPropertyName = "nom_etq";
            this.nom_etq.HeaderText = "ETIQUETA";
            this.nom_etq.Name = "nom_etq";
            this.nom_etq.ReadOnly = true;
            this.nom_etq.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "IMPRIMIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "EXPORTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasimpresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Db_pollosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _Db_pollosDataSet _Db_pollosDataSet;
        private System.Windows.Forms.BindingSource etiquetasimpresasBindingSource;
        private _Db_pollosDataSetTableAdapters.Etiquetas_impresasTableAdapter etiquetas_impresasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calibreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_etq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}