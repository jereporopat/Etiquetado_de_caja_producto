using System;
using System.Collections.Generic;

public class Producto
    {
        private int id;

        private string descripcion;

        private string codigo_producto;

        private int tipo_producto;

        private int conservacion;

        private int grado;

        private string repeticion;

        private int planta;

        private bool habilitado;

        private List<string> calibres;

        private String pathEtiqueta;


        public Producto(int id, string descripcion, string codigo_producto, int tipo_producto, int conservacion, int grado, string repeticion, int planta, bool habilitado,String pathEtiqueta , List<string> calibres)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.codigo_producto = codigo_producto;
            this.tipo_producto = tipo_producto;
            this.conservacion = conservacion;
            this.grado = grado;
            this.repeticion = repeticion;
            this.planta = planta;
            this.habilitado = habilitado;
            this.pathEtiqueta = pathEtiqueta;
            this.calibres = calibres;
        }

        public int getId() { return id; }
        public string getDescripcion() { return descripcion; }
        public string getCodigoProducto() { return codigo_producto; }
        public int getTipoProducto() {return tipo_producto;}
        public int getConservacion() {return conservacion;}
        public int getGrado() {return grado;}
        public string getRepeticion() {return repeticion;}
        public int getPlanta() {return planta;}
        public bool getHabilitado() { return habilitado;}

        public String getPathEtiqueta () {return pathEtiqueta;}
        public List<string> getCalibres() { return calibres;}
    }
  