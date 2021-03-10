using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD_side_Client.Shared.Models
{
    public class Country
    {
        //[Key]
        public int Id { get; set; }
        public string NameCountry { get; set; }
        public List<State> Estados { get; set; }
    }
}
