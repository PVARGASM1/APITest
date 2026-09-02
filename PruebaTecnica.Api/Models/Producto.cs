using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Api.Models
{
    public class Producto
    {
      public int Id { get; set; }
      [Required(ErrorMessage = "El nombre es obligatorio")]
      public string Nombre { get; set; } = string.Empty;
      [Range(1, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
      public decimal Precio { get; set; }
      public bool Activo { get; set; } = true;
      [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
      public int Stock { get; set; }
    }
}

