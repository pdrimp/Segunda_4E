using System.ComponentModel.DataAnnotations;

namespace Segunda_4E.Modelos
{
    public class Producto
    {
        [Range(1, int.MaxValue, ErrorMessage = "El inventario debe ser entero positivo")]
        public int Inventario { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(200, ErrorMessage = "El número máximo de caracteres es 200")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe seleccionar departamento")]
        public string? Departamento { get; set; }
    }
}
