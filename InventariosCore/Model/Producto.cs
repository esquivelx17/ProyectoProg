using System;

namespace InventariosCore.Model
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Costo { get; set; }
        public int? Stock { get; set; }
        public string Ubicacion { get; set; }
        public string Clave { get; set; }
        public int Estatus { get; set; }
        public bool AplicaImpuesto { get; set; }
        public int? IdImpuesto { get; set; }
        public Impuesto Impuesto { get; set; }

        public Producto()
        {
            Nombre = string.Empty;
            Categoria = string.Empty;
            Ubicacion = string.Empty;
            Clave = string.Empty;
            Estatus = 1;
            AplicaImpuesto = false;
            Impuesto = new Impuesto();
        }

        public Producto(string nombre, string clave, decimal costo)
        {
            Nombre = nombre;
            Clave = clave;
            Costo = costo;
            Categoria = string.Empty;
            Ubicacion = string.Empty;
            Estatus = 1;
            AplicaImpuesto = false;
            Impuesto = new Impuesto();
        }

        public Producto(int idProducto, string nombre, string categoria, decimal costo, int? stock,
                        string ubicacion, string clave, int estatus, bool aplicaImpuesto, int? idImpuesto)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Categoria = categoria;
            Costo = costo;
            Stock = stock;
            Ubicacion = ubicacion;
            Clave = clave;
            Estatus = estatus;
            AplicaImpuesto = aplicaImpuesto;
            IdImpuesto = idImpuesto;
            Impuesto = new Impuesto();
        }
    }
}
