namespace Proyecto_final_Herramientas.Helpers.Modelos
{
    public class Producto
    {
        public string Id { get; set; }

        public string Nombre { get; set; }

        public decimal Valor { get; set; }

        public decimal Cantidad { get; set; }

        public decimal ValorTotal => Valor * Cantidad;
    }
}
