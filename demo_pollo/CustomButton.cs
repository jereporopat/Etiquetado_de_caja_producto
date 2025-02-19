using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;




namespace demo_pollo
{
    public class CustomButton : Button
    {
        //Campos
        private int bordeSize = 0;
        private int bordeRadio = 60;
        private NumericUpDown numericUpDown1;
        private Color bordeColor = Color.PaleGreen;
        private Producto producto;

        //Constructor
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(250, 220);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        public Producto GetProducto() {
            return producto;
        }

        public void SetProducto(Producto producto)
        {
            this.producto = producto;
        }

        //Metodo
        private GraphicsPath GetFigurePath(RectangleF rect, float radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
            path.AddArc(rect.Width - radio, rect.Y, radio, radio, 270, 90);
            path.AddArc(rect.Width - radio, rect.Height - radio, radio, radio, 0, 90);
            path.AddArc(rect.X, rect.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs evento)
        {
            base.OnPaint(evento);
            evento.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSup = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF recBorde = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            if (bordeRadio > 2)//boton redondeado
            {
                using (GraphicsPath pathSup = GetFigurePath(rectSup, bordeRadio))
                using (GraphicsPath pathBorde = GetFigurePath(recBorde, bordeRadio - 1F))
                using (Pen penSup = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorde = new Pen(bordeColor, bordeSize))
                {
                    penBorde.Alignment = PenAlignment.Inset;
                    //Sup del  Boton
                    this.Region = new Region(pathSup);
                    //Dibuja el borde en HD
                    evento.Graphics.DrawPath(penSup, pathSup);
                    //Bordes del botón y color
                    if (bordeSize >= 1)
                        evento.Graphics.DrawPath(penBorde, pathBorde);

                }
            }
            else //Normal
            {
                this.Region = new Region(rectSup);
                if (bordeSize >= 1)
                {
                    using (Pen penBorde = new Pen(bordeColor, bordeSize))
                    {
                        penBorde.Alignment = PenAlignment.Inset;
                        evento.Graphics.DrawRectangle(penBorde, 0, 0, this.Width - 1, this.Height - 1);

                    }
                }

            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);

        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            //  throw new NotImplementedException();
            if (this.DesignMode)
                this.Invalidate();
        }

        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

