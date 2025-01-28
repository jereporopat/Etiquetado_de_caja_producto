namespace demo_pollo
{
    partial class FormMas
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
            this.customButton4 = new demo_pollo.CustomButton();
            this.customButton3 = new demo_pollo.CustomButton();
            this.EtiNuevaBtn = new demo_pollo.CustomButton();
            this.customButton2 = new demo_pollo.CustomButton();
            this.SuspendLayout();
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(87, 407);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(508, 330);
            this.customButton4.TabIndex = 4;
            this.customButton4.Text = "REPORTES";
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(788, 407);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(508, 330);
            this.customButton3.TabIndex = 3;
            this.customButton3.Text = "CONFIGURACION";
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // EtiNuevaBtn
            // 
            this.EtiNuevaBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.EtiNuevaBtn.FlatAppearance.BorderSize = 0;
            this.EtiNuevaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EtiNuevaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiNuevaBtn.ForeColor = System.Drawing.Color.White;
            this.EtiNuevaBtn.Location = new System.Drawing.Point(87, 12);
            this.EtiNuevaBtn.Name = "EtiNuevaBtn";
            this.EtiNuevaBtn.Size = new System.Drawing.Size(508, 330);
            this.EtiNuevaBtn.TabIndex = 2;
            this.EtiNuevaBtn.Text = "ETIQUETA NUEVA";
            this.EtiNuevaBtn.UseVisualStyleBackColor = false;
            this.EtiNuevaBtn.Click += new System.EventHandler(this.EtiNuevaBtn_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(788, 12);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(508, 330);
            this.customButton2.TabIndex = 1;
            this.customButton2.Text = "ABM PRODUCTOS";
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // FormMas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 668);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.EtiNuevaBtn);
            this.Controls.Add(this.customButton2);
            this.Name = "FormMas";
            this.Text = "FormMas";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton customButton2;
        private CustomButton EtiNuevaBtn;
        private CustomButton customButton3;
        private CustomButton customButton4;
    }
}