using IndumentariaIntima.Data;

namespace IndumentariaIntima.Models
{
    public class CarritoItem
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
