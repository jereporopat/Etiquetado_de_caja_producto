namespace demo_pollo
{
    partial class FormSeleccionCalibres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeleccionCalibres));
            this.calibresLb = new System.Windows.Forms.CheckedListBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calibresLb
            // 
            this.calibresLb.FormattingEnabled = true;
            this.calibresLb.Location = new System.Drawing.Point(12, 12);
            this.calibresLb.Name = "calibresLb";
            this.calibresLb.Size = new System.Drawing.Size(125, 229);
            this.calibresLb.TabIndex = 0;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(143, 207);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(125, 34);
            this.aceptar.TabIndex = 1;
            this.aceptar.Text = "ACEPTAR";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // FormSeleccionCalibres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 250);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.calibresLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSeleccionCalibres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de calibres";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox calibresLb;
        private System.Windows.Forms.Button aceptar;
    }
}