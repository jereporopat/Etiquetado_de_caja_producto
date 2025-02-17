namespace demo_pollo
{
    partial class Config
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tB_Mask_Z = new System.Windows.Forms.TextBox();
            this.tB_IP_Zebra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_Ruta_ZD = new System.Windows.Forms.TextBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_Terminar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tB_Mask_Z);
            this.groupBox3.Controls.Add(this.tB_IP_Zebra);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(78, 36);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(399, 217);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Puerto Ethernet Impresora ZEBRA";
            // 
            // tB_Mask_Z
            // 
            this.tB_Mask_Z.Location = new System.Drawing.Point(186, 142);
            this.tB_Mask_Z.Margin = new System.Windows.Forms.Padding(6);
            this.tB_Mask_Z.Name = "tB_Mask_Z";
            this.tB_Mask_Z.Size = new System.Drawing.Size(184, 30);
            this.tB_Mask_Z.TabIndex = 13;
            this.tB_Mask_Z.Text = "255.255.255.000";
            this.tB_Mask_Z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB_IP_Zebra
            // 
            this.tB_IP_Zebra.Location = new System.Drawing.Point(186, 70);
            this.tB_IP_Zebra.Margin = new System.Windows.Forms.Padding(6);
            this.tB_IP_Zebra.Name = "tB_IP_Zebra";
            this.tB_IP_Zebra.Size = new System.Drawing.Size(178, 30);
            this.tB_IP_Zebra.TabIndex = 11;
            this.tB_IP_Zebra.Text = "192.168.000.001";
            this.tB_IP_Zebra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mascara";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "IP Zebra 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_Ruta_ZD);
            this.groupBox1.Location = new System.Drawing.Point(78, 288);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(399, 182);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruta Zebra Designer";
            // 
            // tB_Ruta_ZD
            // 
            this.tB_Ruta_ZD.Location = new System.Drawing.Point(42, 55);
            this.tB_Ruta_ZD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tB_Ruta_ZD.Multiline = true;
            this.tB_Ruta_ZD.Name = "tB_Ruta_ZD";
            this.tB_Ruta_ZD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_Ruta_ZD.Size = new System.Drawing.Size(322, 82);
            this.tB_Ruta_ZD.TabIndex = 12;
            this.toolTip1.SetToolTip(this.tB_Ruta_ZD, "Aquí se debe Copiar la Ruta donde se encuentre alojado el diseñador de Etiquetas " +
        "\"ZebraDesigner.exe\" de su Sistema.");
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Location = new System.Drawing.Point(78, 503);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(6);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(150, 84);
            this.bt_cancelar.TabIndex = 13;
            this.bt_cancelar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.bt_cancelar, "Salir sin Grabar los Cambios.");
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_Terminar
            // 
            this.bt_Terminar.BackColor = System.Drawing.Color.GreenYellow;
            this.bt_Terminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Terminar.Location = new System.Drawing.Point(327, 506);
            this.bt_Terminar.Margin = new System.Windows.Forms.Padding(6);
            this.bt_Terminar.Name = "bt_Terminar";
            this.bt_Terminar.Size = new System.Drawing.Size(150, 81);
            this.bt_Terminar.TabIndex = 12;
            this.bt_Terminar.Text = "Terminar";
            this.toolTip1.SetToolTip(this.bt_Terminar, "Grabar y Salir de Configuración.");
            this.bt_Terminar.UseVisualStyleBackColor = false;
            this.bt_Terminar.Click += new System.EventHandler(this.bt_Terminar_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 622);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_Terminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tB_Mask_Z;
        private System.Windows.Forms.TextBox tB_IP_Zebra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tB_Ruta_ZD;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_Terminar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}