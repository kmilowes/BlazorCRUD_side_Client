using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD_side_Client.Shared.Models
{
    public class State
    {
        //[Key]
        public int Id { get; set; }
        public string NameState { get; set; }
        public int IdCountry { get; set; }
        public Country Country { get; set; }
    }
}
