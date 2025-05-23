namespace InventariosCore.Model
{
    public class API
    {
        public string Clave { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public decimal CostoUnitario { get; set; }
        public int Stock { get; set; }
        public string Impuesto { get; set; } = "N/A";
        public int Estatus { get; set; }

        public string EstatusTexto
        {
            get
            {
                return Estatus == 1 ? "Activo" : "Inactivo";
            }
        }

    }
}
