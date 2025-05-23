namespace InventariosCore.Model
{
    public class Impuesto
    {
        public int IdImpuesto { get; set; }
        public string TipoImpuesto { get; set; } = string.Empty;
        public decimal CantidadImpuesto { get; set; }

        public Impuesto() { }

        public Impuesto(int id, string tipo, decimal cantidad)
        {
            IdImpuesto = id;
            TipoImpuesto = tipo;
            CantidadImpuesto = cantidad;
        }
    }
}
