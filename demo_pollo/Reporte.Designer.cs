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
            this.calibreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.etiquetasimpresasBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(297, 450);
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
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte";
            this.Text = "Reporte";
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
    }
}