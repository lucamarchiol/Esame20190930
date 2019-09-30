using System.ComponentModel.DataAnnotations;

namespace AssicurazioneWebApp.Models
{
    public class Proprietario
    {
        [Key]
        public string codicefiscale { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string residenza { get; set; }
    }
}
