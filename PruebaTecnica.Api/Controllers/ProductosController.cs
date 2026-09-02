using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Api.Data;
using PruebaTecnica.Api.Models;

namespace PruebaTecnica.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/productos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
            return await _context.Productos.ToListAsync();
        }

        // GET: api/productos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null) {
                    return NotFound(new { mensaje = "Producto no encontrado" });
            }
            return producto;
        }

        // POST: api/productos
        [HttpPost]
        public async Task<ActionResult<Producto>> PostProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProducto), new { id = producto.Id }, producto);
        }
        //PUT: api/productos/5
        [HttpPut("{id}")]
            public async Task<IActionResult> PutProducto(int id, Producto productoActualizado)
        {
            // Busca el producto en la base
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
            {
                return NotFound(new { mensaje = "Producto no encontrado" });
            }

            // Actualizar propiedades
            producto.Nombre = productoActualizado.Nombre;
            producto.Precio = productoActualizado.Precio;
            producto.Activo = productoActualizado.Activo;
            producto.Stock = productoActualizado.Stock;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al actualizar el producto", detalle = ex.Message });
            }

            return Ok(producto); 
        }

        // DELETE: api/productos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null) {
                return NotFound(new { mensaje = "Producto no encontrado" });
            }

            //Cambiar de activo a false en lugar de eliminar el producto
            producto.Activo = false;
            _context.Productos.Update(producto);
            await _context.SaveChangesAsync();
                return Ok(new { mensaje = "El estado del producto cambio a false" });
        }
    }
}
