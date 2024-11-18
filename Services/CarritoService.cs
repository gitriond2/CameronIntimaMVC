using IndumentariaIntima.Data;
using IndumentariaIntima.Models;
using System.Collections.Generic;
using System.Linq;

namespace IndumentariaIntima.Services
{
    public class CarritoService
    {
        private readonly ApplicationDbContext _context;
        private readonly List<CarritoItem> _items = new();

        public CarritoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CarritoItem> GetItems()
        {
            return _items;
        }

        public void AddItem(int productoId)
        {
            var producto = _context.Productos.Find(productoId);
            if (producto != null)
            {
                var item = _items.FirstOrDefault(i => i.Producto.Id == productoId);
                if (item == null)
                {
                    _items.Add(new CarritoItem { Producto = producto, Cantidad = 1 });
                }
                else
                {
                    item.Cantidad++;
                }
            }
        }

        public void RemoveItem(int productoId)
        {
            var item = _items.FirstOrDefault(i => i.Producto.Id == productoId);
            if (item != null)
            {
                _items.Remove(item);
            }
        }

        public void UpdateItemCantidad(int productoId, int cantidad)
        {
            var item = _items.FirstOrDefault(i => i.Producto.Id == productoId);
            if (item != null)
            {
                item.Cantidad = cantidad;
            }
        }

        // Método para obtener el resumen del carrito
        public (int totalItems, decimal totalCost) GetCarritoResumen()
        {
            var totalItems = _items.Sum(i => i.Cantidad);
            var totalCost = _items.Sum(i => i.Producto.Precio * i.Cantidad);
            return (totalItems, totalCost);
        }
    }
}




