using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD_side_Client.Shared.Models
{
    public class Person
    {
        public int Id{ get; set; }
        [Required(ErrorMessage = "El campo {0} no puede ir vacío")]
        public string Name { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Estado")]
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
