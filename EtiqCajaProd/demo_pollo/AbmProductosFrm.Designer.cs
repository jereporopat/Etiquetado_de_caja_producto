namespace demo_pollo
{
    partial class AbmProductosFrm
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
            this.crearBtn = new demo_pollo.CustomButton();
            this.editDeleteBtn = new demo_pollo.CustomButton();
            this.volverBtn = new demo_pollo.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crearBtn
            // 
            this.crearBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.crearBtn.FlatAppearance.BorderSize = 0;
            this.crearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearBtn.ForeColor = System.Drawing.Color.White;
            this.crearBtn.Location = new System.Drawing.Point(29, 111);
            this.crearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Size = new System.Drawing.Size(248, 151);
            this.crearBtn.TabIndex = 4;
            this.crearBtn.Text = "ALTA DE PRODUCTO";
            this.crearBtn.UseVisualStyleBackColor = false;
            this.crearBtn.Click += new System.EventHandler(this.crearBtn_Click);
            // 
            // editDeleteBtn
            // 
            this.editDeleteBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.editDeleteBtn.FlatAppearance.BorderSize = 0;
            this.editDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.editDeleteBtn.Location = new System.Drawing.Point(296, 111);
            this.editDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editDeleteBtn.Name = "editDeleteBtn";
            this.editDeleteBtn.Size = new System.Drawing.Size(248, 151);
            this.editDeleteBtn.TabIndex = 5;
            this.editDeleteBtn.Text = "EDITAR/BORRAR PRODUCTO";
            this.editDeleteBtn.UseVisualStyleBackColor = false;
            this.editDeleteBtn.Click += new System.EventHandler(this.editDeleteBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.volverBtn.FlatAppearance.BorderSize = 0;
            this.volverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBtn.ForeColor = System.Drawing.Color.White;
            this.volverBtn.Location = new System.Drawing.Point(29, 291);
            this.volverBtn.Margin = new System.Windows.Forms.Padding(4);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(515, 114);
            this.volverBtn.TabIndex = 6;
            this.volverBtn.Text = "VOLVER";
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código SENASA";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(293, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 38);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(371, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 38);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "00000";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(477, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 38);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "000";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AbmProductosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 449);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.editDeleteBtn);
            this.Controls.Add(this.crearBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AbmProductosFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton crearBtn;
        private CustomButton editDeleteBtn;
        private CustomButton volverBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}