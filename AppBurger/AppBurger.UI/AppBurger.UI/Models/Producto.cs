namespace AppBurger.UI.Models
{
    public class Producto
    {
        public int idProductos { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public object imagen { get; set; }
        public int idRestaurante { get; set; }
        public int idCategoria { get; set; }
    }
}
