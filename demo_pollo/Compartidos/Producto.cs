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

    private Dictionary<int, string> calibres;

    private String pathEtiqueta;


    public Producto(int id, string descripcion, string codigo_producto, int tipo_producto, int conservacion, int grado, string repeticion, int planta, bool habilitado, String pathEtiqueta, Dictionary<int, string> calibres)
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

    override public String ToString()
    {
        return this.codigo_producto + " - " + this.descripcion;
    }

    public int getId() { return id; }
    public string getDescripcion() { return descripcion; }
    public string getCodigoProducto() { return codigo_producto; }
    public int getTipoProducto() { return tipo_producto; }
    public int getConservacion() { return conservacion; }
    public int getGrado() { return grado; }
    public string getRepeticion() { return repeticion; }
    public int getPlanta() { return planta; }
    public bool getHabilitado() { return habilitado; }

    public String getPathEtiqueta() { return pathEtiqueta; }
    public Dictionary<int, string> getCalibres() { return calibres; }


    public void setDescripcion(string descripcion) { this.descripcion = descripcion; }
    public void setCodigoProducto(string codigo_producto) { this.codigo_producto = codigo_producto; }
    public void setTipoProducto(int tipo_producto) { this.tipo_producto = tipo_producto; }
    public void setConservacion(int conservacion) { this.conservacion = conservacion; }
    public void setGrado(int grado) { this.grado = grado; }
    public void setRepeticion(string repeticion) { this.repeticion = repeticion; }
    public void setPlanta(int planta) { this.planta = planta; }
    public void setHabilitado(bool habilitado) { this.habilitado = habilitado; }
    public void setPathEtiqueta(string pathEtiqueta) { this.pathEtiqueta = pathEtiqueta; }
    public void setCalibres(Dictionary<int, string> calibres) { this.calibres = calibres; }

}